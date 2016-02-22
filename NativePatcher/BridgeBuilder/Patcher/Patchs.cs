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
        AppendString,
        FollowBy,
        SkipUntil

    }

    class PatchCommand
    {
        public readonly PatchCommandKind comandKind;
        public PatchCommand(PatchCommandKind comandKind, string str)
        {
            this.comandKind = comandKind;
            this.String = str.Trim();
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
        public PatchFile(string filename)
        {
            this.FileName = filename;
        }
        public string FileName
        {
            get;
            set;
        }
        public string RootDir
        {
            get;
            set;
        }
        public PatchTask FindPos(string landMark)
        {
            var srcPos = new PatchTask(this, landMark);
            patchTasks.Add(srcPos);
            return srcPos;
        }
        public void PatchContent()
        {
            //1. check if file is exist
            string fullFileName = this.RootDir + "//" + FileName;
            if (!File.Exists(fullFileName))
            {
                throw new NotSupportedException("file not found!");
            }
            SourceFile input = new SourceFile(fullFileName);
            input.ReadAllLines();

            SourceFile output = new SourceFile(fullFileName + ".output");
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

        }
    }

    class SourceFile
    {
        List<string> lines = new List<string>();
        public SourceFile(string filename)
        {
            this.Filename = filename;
        }
        public string Filename
        {
            get;
            set;
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
    }

    class PatchTask
    {

        PatchFile _sourceFile;
        List<PatchCommand> commands = new List<PatchCommand>();
        public PatchTask(PatchFile sourceFile, string landMark)
        {
            this._sourceFile = sourceFile;
            this.LandMark = landMark.Trim();

        }
        public string LandMark
        {
            get;
            private set;
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
            var cmd = new PatchCommand(PatchCommandKind.AppendString, appendString);
            commands.Add(cmd);
            return this;
        }
        public PatchTask FollowBy(string landMark)
        {
            var cmd = new PatchCommand(PatchCommandKind.FollowBy, landMark);
            commands.Add(cmd);
            return this;
        }
        public PatchTask FindNext(string landMark)
        {
            var cmd = new PatchCommand(PatchCommandKind.FindNextLandMark, landMark);
            commands.Add(cmd);
            return this;
        }
        public PatchTask SkipUntil(string text)
        {
            var cmd = new PatchCommand(PatchCommandKind.SkipUntil, text);
            commands.Add(cmd);
            return this;
        }

        public override string ToString()
        {
            return "find " + LandMark + " then do ..." + commands.Count.ToString();
        }


        bool FindStartPosition(StreamReader reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                if (line.StartsWith(this.LandMark))
                {
                    //found
                    return true;
                }
                line = reader.ReadLine();//next
            }
            return false;
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

                        } break;
                    case PatchCommandKind.AppendString:
                        {

                            var strReader = new StringReader(cmd.String);
                            string appendLine = strReader.ReadLine();
                            while (appendLine != null)
                            {
                                output.AddLine(appendLine);
                                appendLine = strReader.ReadLine();
                            }

                        } break;
                    case PatchCommandKind.FollowBy:
                        {
                            //just 1 line must match
                           
                            string nextLine = input.GetLine(input.CurrentLine);
                            input.CurrentLine++;

                            if (nextLine.TrimStart().StartsWith(cmd.String))
                            {
                                //match
                                output.AddLine(nextLine);
                            }
                            else
                            {
                                throw new NotSupportedException();
                            }
                        } break;
                    case PatchCommandKind.SkipUntil:
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




                        } break;
                    default:
                        throw new NotSupportedException();
                }
            }
        }
    }





}
