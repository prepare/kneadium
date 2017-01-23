//2016, MIT, WinterDev

using System;
using System.Text;
using System.Collections.Generic;
using System.IO;


namespace BridgeBuilder
{
    public enum PatchCommandKind
    {
        Unknown,
        FindNextLandMark,
        AppendStringStart,
        AppendStringStop,
        FollowBy,
        SkipUntilPass,
        SkipUntilAndAccept
    }

    class PatchCommand
    {
        public const string CMD_PREFIX = "//###_";
        public const string START = "//###_START";
        public const string APPPEND_START = "//###_APPEND_START";
        public const string APPPEND_STOP = "//###_APPEND_STOP";
        public const string FIND_NEXT_LANDMARK = "//###_FIND_NEXT_LANDMARK";
        public const string FOLLOW_BY = "//###_FOLLOW_BY";
        public const string SKIP_UNTIL_AND_ACCEPT = "//###_SKIP_UNTIL_AND_ACCEPT";
        public const string SKIP_UNTIL_PASS = "//###_SKIP_UNTIL_PASS";

        public readonly PatchCommandKind comandKind;
        public PatchCommand(int taskId, PatchCommandKind comandKind, string str)
        {
            this.comandKind = comandKind;
            this.String = str.Trim();
            this.TaskId = taskId;
        }
        public int TaskId
        {
            get;
            private set;
        }
        public string String
        {
            get;
            private set;
        }
        public override string ToString()
        {
            return comandKind + " " + this.String;
        }
    }

    class PatchFile
    {

        List<PatchTask> patchTasks = new List<PatchTask>();
        public PatchFile(string originalFilename)
        {
            this.OriginalFileName = originalFilename;
        }
        public string OriginalFileName
        {
            get;
            set;
        }
        public override string ToString()
        {
            return this.OriginalFileName;
        }

        public void AddTask(PatchTask task)
        {

            patchTasks.Add(task);
        }
        public bool CheckIfFileWasPatched(SourceFile input, out string patchCode)
        {
            //check first line
            if (Path.GetFileName(input.Filename) == "CMakeLists.txt")
            {   //this is cmake
                patchCode = "# PATCH ";
                input.IsCMakeFile = true;
            }
            else
            {
                patchCode = _ORIGINAL;
            }
            return input.GetLine(0).StartsWith(patchCode);
        }
        public void PatchContent()
        {
            //1. check if file is exist
            string originalFilename = this.OriginalFileName;
            if (!File.Exists(originalFilename))
            {
                throw new NotSupportedException("file not found!");
            }

            SourceFile input = new SourceFile(originalFilename, false);
            input.ReadAllLines();
            SourceFile output = new SourceFile(originalFilename, true);


            string patchCode;
            if (CheckIfFileWasPatched(input, out patchCode))
            {
                //can't patch
                throw new NotSupportedException("not patch again in this file");
            }
            else
            {
                //can patch ****
                //input patch code with original filename
                output.AddLine(patchCode + " " + originalFilename);
            }

            output.IsCMakeFile = input.IsCMakeFile;
            //-----------------------------------------------------------------
            //can't patch again
            int j = patchTasks.Count;
            for (int i = 0; i < j; ++i)
            {
                patchTasks[i].PatchFile(input, output);
            }

            int linecount = input.LineCount;
            for (int i = input.CurrentLine; i < linecount; ++i)
            {
                output.AddLine(input.GetLine(i));
                input.CurrentLine++;
            }

            output.Save();
        }
        public int Count
        {
            get { return patchTasks.Count; }
        }

        public PatchTask NewTask(string landMark)
        {
            var srcPos = new PatchTask(landMark, patchTasks.Count);
            patchTasks.Add(srcPos);
            return srcPos;
        }


        /// <summary>         
        /// save patch file to disk
        /// </summary>
        /// <param name="filename"></param>
        public void SavePatchFile(string filename)
        {

            //save all patch task
            int j = patchTasks.Count;
            var output = new SourceFile(filename, true);
            //first line of patch file is original file name
            output.AddLine(_ORIGINAL + " " + this.OriginalFileName);

            for (int i = 0; i < j; ++i)
            {
                PatchTask ptask = patchTasks[i];
                List<PatchCommand> cmds = ptask.GetCommands();
                //each task begin with start command
                output.AddLine(PatchCommand.START + " " + ptask.TaskId);
                output.AddLine(ptask.LandMark);

                int cmdCount = cmds.Count;
                for (int n = 0; n < cmdCount; ++n)
                {
                    PatchWriter.WriteCommand(output, cmds[n], true);
                }
            }
            output.Save();
        }
        const string _ORIGINAL = "//###_ORIGINAL";
        static int GetTaskId(string line, int startPos, out string additionalInfo)
        {
            int nextSpace = line.IndexOf(' ', startPos);
            if (nextSpace < 0)
            {
                string id = line.Substring(startPos).Trim();
                additionalInfo = null;
                return int.Parse(id);
            }
            else
            {
                string sub1 = line.Substring(startPos, nextSpace - startPos).Trim();
                additionalInfo = line.Substring(nextSpace).Trim();

                return int.Parse(sub1.Trim());
            }
        }

        static bool GetOriginalFilename(string line, out string originalFilename)
        {
            if (!line.StartsWith(_ORIGINAL))
            {
                originalFilename = null;
                return false;
            }
            //----------------
            originalFilename = line.Substring(_ORIGINAL.Length).Trim();
            return true;
        }
        /// <summary>
        /// create patch file from a patch file in disk
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static PatchFile BuildPatchFile(string filename)
        {
            //if (filename == "d:\\projects\\CefBridge\\cef3\\cefclient\\browser\\client_handler.cc")
            //{

            //}
            //create patch command for specific filename
            PatchFile patchFile = new PatchFile(filename);
            SourceFile sourceFile = new SourceFile(filename, false);
            sourceFile.ReadAllLines();
            int j = sourceFile.LineCount;
            PatchTask ptask = null;

            int i = 0;
            string line = sourceFile.GetLine(0);
            //first line is original filename
            string originalFilename;
            if (GetOriginalFilename(line, out originalFilename))
            {
                //change origial file name for patch file
                patchFile.OriginalFileName = originalFilename;
                i++; //next line
            }

            for (; i < j; ++i)
            {

                line = sourceFile.GetLine(i).TrimStart();

                if (line.StartsWith("//###_"))
                {

                    //what is the comamnd
                    int pos0 = line.IndexOf(' '); //first (must have

                    if (pos0 < 0)
                    {
                        throw new NotSupportedException("pos 0");
                    }
                    else
                    {
                        string additionalInfo;
                        int taskId = GetTaskId(line, pos0 + 1, out additionalInfo);


                        string cmdline = line.Substring(0, pos0);
                        switch (cmdline)
                        {
                            case PatchCommand.START:
                                //start new patch task
                                //read next line for info 
                                {
                                    i++;
                                    string cmd_value = sourceFile.GetLine(i);

                                    //create new task
                                    ptask = new PatchTask(cmd_value, taskId);
                                    patchFile.AddTask(ptask);
                                }
                                break;
                            case PatchCommand.APPPEND_START:
                                //start collect append string 
                                //until find append_stop
                                {

                                    var collectAppendStBuilder = new StringBuilder();
                                    i++;
                                    string cmd_value = sourceFile.GetLine(i);

                                    line = cmd_value.TrimStart();
                                    //eval
                                    do
                                    {
                                        if (line.StartsWith(PatchCommand.APPPEND_STOP))
                                        {
                                            //stop here
                                            break;
                                        }
                                        else
                                        {
                                            if (line.StartsWith("//###_"))
                                            {
                                                //other command
                                                throw new NotSupportedException();
                                            }
                                            else
                                            {
                                                //collect this line
                                                collectAppendStBuilder.AppendLine(line);
                                                //read next line
                                                i++;
                                                line = sourceFile.GetLine(i).TrimStart();
                                            }
                                        }
                                    } while (true);
                                    //finish command
                                    ptask.Append(collectAppendStBuilder.ToString());

                                }
                                break;
                            case PatchCommand.APPPEND_STOP:

                                throw new NotSupportedException();
                            case PatchCommand.FIND_NEXT_LANDMARK:
                                {
                                    i++;
                                    string cmd_value = sourceFile.GetLine(i);

                                    if (taskId != ptask.TaskId)
                                    {
                                        throw new NotSupportedException();
                                    }
                                    ptask.FindNext(cmd_value);
                                }
                                break;
                            case PatchCommand.FOLLOW_BY:
                                {
                                    i++;
                                    string cmd_value = sourceFile.GetLine(i);


                                    if (taskId != ptask.TaskId)
                                    {
                                        throw new NotSupportedException();
                                    }
                                    ptask.FollowBy(cmd_value);

                                }
                                break;
                            case PatchCommand.SKIP_UNTIL_AND_ACCEPT:
                                {
                                    i++;
                                    string cmd_value = sourceFile.GetLine(i);


                                    if (taskId != ptask.TaskId)
                                    {
                                        throw new NotSupportedException();
                                    }
                                    ptask.SkipUntilAndAccept(cmd_value);
                                }
                                break;
                            case PatchCommand.SKIP_UNTIL_PASS:
                                {
                                    //has 2 parameters
                                    if (additionalInfo == null)
                                    {
                                        throw new NotSupportedException();
                                    }
                                    //
                                    ptask.SkipUntilPass(additionalInfo);
                                }
                                break;
                            default:
                                throw new NotSupportedException();
                        }
                    }

                }
            }

            return (ptask != null && ptask.CommandCount > 0) ? patchFile : null;

        }
    }


    class SourceFile
    {
        List<string> lines = new List<string>();
        public SourceFile(string filename, bool isOutput)
        {
            this.Filename = filename;
            this.IsOutput = isOutput;
        }
        public bool IsCMakeFile
        {
            get;
            set;
        }
        public string Filename
        {
            get;
            private set;
        }
        public bool IsOutput
        {
            get;
            private set;
        }
        public void ReadAllLines()
        {
            lines.AddRange(File.ReadAllLines(this.Filename));
        }
        public int CurrentLine
        {
            get;
            set;
        }
        public void AddLine(string str)
        {
            lines.Add(str);
        }

        public string GetLine(int index)
        {
            return lines[index];
        }
        public int LineCount
        {
            get { return lines.Count; }
        }
        public void Save(string filename = null)
        {
            if (string.IsNullOrEmpty(filename))
            {
                filename = this.Filename;
            }
            //save ot original filename
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                StreamWriter writer = new StreamWriter(fs);
                int j = lines.Count;
                for (int i = 0; i < j; ++i)
                {
                    writer.WriteLine(lines[i]);
                }
                writer.Flush();
                writer.Close();
                fs.Close();
            }

        }

    }

    class PatchTask
    {


        List<PatchCommand> commands = new List<PatchCommand>();
        public PatchTask(string landMark, int taskId)
        {
            this.LandMark = landMark.Trim();
            this.TaskId = taskId;
        }
        public int CommandCount
        {
            get { return commands.Count; }
        }
        public int TaskId
        {
            get;
            private set;
        }
        public string LandMark
        {
            get;
            private set;
        }
        public List<PatchCommand> GetCommands()
        {
            return commands;
        }
        public int HintMinLine
        {
            get;
            set;
        }
        public int HintMaxLineNumber
        {
            get;
            set;
        }
        public PatchTask Append(string appendString)
        {
            var cmd = new PatchCommand(this.TaskId, PatchCommandKind.AppendStringStart, appendString);
            commands.Add(cmd);
            return this;
        }
        public PatchTask FollowBy(string landMark)
        {
            var cmd = new PatchCommand(this.TaskId, PatchCommandKind.FollowBy, landMark);
            commands.Add(cmd);
            return this;
        }
        public PatchTask FindNext(string landMark)
        {
            var cmd = new PatchCommand(this.TaskId, PatchCommandKind.FindNextLandMark, landMark);
            commands.Add(cmd);
            return this;
        }
        /// <summary>
        /// not include pass line
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public PatchTask SkipUntilPass(string text)
        {
            var cmd = new PatchCommand(this.TaskId, PatchCommandKind.SkipUntilPass, text);
            commands.Add(cmd);
            return this;
        }
        /// <summary>
        /// include met line
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public PatchTask SkipUntilAndAccept(string text)
        {
            var cmd = new PatchCommand(this.TaskId, PatchCommandKind.SkipUntilAndAccept, text);
            commands.Add(cmd);
            return this;
        }
        public override string ToString()
        {
            return "find " + LandMark + " then do ..." + commands.Count.ToString();
        }


        void AddControlLine(SourceFile outputFile, PatchCommand cmd)
        {

            PatchWriter.WriteCommand(outputFile, cmd, false);
        }

        public void PatchFile(SourceFile input, SourceFile output)
        {
            //find start position of this task
            int curLine = input.CurrentLine;
            int lineCount = input.LineCount;
            bool foundLandMark = false;
            for (int i = curLine; i < lineCount; ++i)
            {
                string line = input.GetLine(i);
                input.CurrentLine++;

                if (line.TrimStart().StartsWith(this.LandMark))
                {
                    //found land mark
                    foundLandMark = true;

                    if (!output.IsCMakeFile)
                    {
                        output.AddLine(PatchCommand.START + " " + this.TaskId);
                    }

                    output.AddLine(line);
                    break;
                }
                else
                {
                    //just add to output
                    output.AddLine(line);
                }
            }

            if (!foundLandMark)
            {
                return;
                throw new NotSupportedException();
            }
            //------------------------------------------------------------
            //do actions...
            int j = commands.Count;

            for (int c = 0; c < j; ++c)
            {
                PatchCommand cmd = commands[c];
                //find start position 
                switch (cmd.comandKind)
                {
                    case PatchCommandKind.FindNextLandMark:
                        {
                            //from current position find next until found 
                            curLine = input.CurrentLine;
                            bool foundNextLandMark = false;
                            for (int i = curLine; i < lineCount; ++i)
                            {
                                string line = input.GetLine(i);
                                input.CurrentLine++;

                                if (line.TrimStart().StartsWith(cmd.String))
                                {
                                    //found land mark
                                    foundNextLandMark = true;
                                    AddControlLine(output, cmd); //***
                                    output.AddLine(line);
                                    break;
                                }
                                else
                                {
                                    //just add to output
                                    output.AddLine(line);
                                }
                            }

                            if (!foundNextLandMark)
                            {
                                throw new NotSupportedException("next land mark not found");
                            }

                        }
                        break;
                    case PatchCommandKind.AppendStringStart:
                        {
                            AddControlLine(output, cmd); //***


                        }
                        break;
                    case PatchCommandKind.FollowBy:
                        {
                            //just 1 line must match

                            string nextLine = input.GetLine(input.CurrentLine);
                            input.CurrentLine++;

                            if (nextLine.TrimStart().StartsWith(cmd.String))
                            {
                                //match
                                AddControlLine(output, cmd); //***
                                output.AddLine(nextLine);
                            }
                            else
                            {
                                throw new NotSupportedException();
                            }
                        }
                        break;
                    case PatchCommandKind.SkipUntilPass:
                        {
                            curLine = input.CurrentLine;
                            bool foundNextLandMark = false;
                            for (int i = curLine; i < lineCount; ++i)
                            {
                                string line = input.GetLine(i);
                                input.CurrentLine++;

                                if (line.TrimStart().StartsWith(cmd.String))
                                {
                                    AddControlLine(output, cmd); //***
                                    //found land mark
                                    foundNextLandMark = true;
                                    //not add this
                                    //just skip
                                    break;
                                }
                                else
                                {
                                    //skip
                                }
                            }

                            if (!foundNextLandMark)
                            {
                                throw new NotSupportedException("next land mark not found");
                            }
                        }
                        break;
                    case PatchCommandKind.SkipUntilAndAccept:
                        {
                            curLine = input.CurrentLine;
                            bool foundNextLandMark = false;
                            for (int i = curLine; i < lineCount; ++i)
                            {
                                string line = input.GetLine(i);
                                input.CurrentLine++;

                                if (line.TrimStart().StartsWith(cmd.String))
                                {
                                    //found land mark
                                    foundNextLandMark = true;
                                    //accept this line
                                    AddControlLine(output, cmd); //***
                                    output.AddLine(line);
                                    break;
                                }
                                else
                                {
                                    //skip
                                }
                            }

                            if (!foundNextLandMark)
                            {
                                throw new NotSupportedException("next land mark not found");
                            }
                        }
                        break;
                    default:
                        throw new NotSupportedException();
                }
            }
        }
    }

    static class PatchWriter
    {
        public static void WriteCommand(SourceFile outputFile, PatchCommand cmd, bool withValue)
        {
            string perfix_comment = outputFile.IsCMakeFile ? "# " : "";
            switch (cmd.comandKind)
            {

                case PatchCommandKind.AppendStringStart:
                    {
                        outputFile.AddLine(perfix_comment + PatchCommand.APPPEND_START + " " + cmd.TaskId);
                        var strReader = new StringReader(cmd.String);
                        string appendLine = strReader.ReadLine();
                        while (appendLine != null)
                        {
                            outputFile.AddLine(appendLine);
                            appendLine = strReader.ReadLine();
                        }
                        outputFile.AddLine(perfix_comment + PatchCommand.APPPEND_STOP);
                    }
                    break;
                case PatchCommandKind.AppendStringStop:
                    outputFile.AddLine(perfix_comment + PatchCommand.APPPEND_STOP + " " + cmd.TaskId);
                    if (withValue)
                    {
                        outputFile.AddLine(cmd.String);
                    }
                    break;
                case PatchCommandKind.FindNextLandMark:
                    outputFile.AddLine(perfix_comment + PatchCommand.FIND_NEXT_LANDMARK + " " + cmd.TaskId);
                    if (withValue)
                    {
                        outputFile.AddLine(cmd.String);
                    }
                    break;
                case PatchCommandKind.FollowBy:
                    outputFile.AddLine(perfix_comment + PatchCommand.FOLLOW_BY + " " + cmd.TaskId);
                    if (withValue)
                    {
                        outputFile.AddLine(cmd.String);
                    }
                    break;
                case PatchCommandKind.SkipUntilAndAccept:
                    outputFile.AddLine(perfix_comment + PatchCommand.SKIP_UNTIL_AND_ACCEPT + " " + cmd.TaskId);
                    if (withValue)
                    {
                        outputFile.AddLine(cmd.String);
                    }
                    break;
                case PatchCommandKind.SkipUntilPass:
                    outputFile.AddLine(perfix_comment + PatchCommand.SKIP_UNTIL_PASS + " " + cmd.TaskId + " " + cmd.String);
                    //value is add in the same line ***
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

    }




}
