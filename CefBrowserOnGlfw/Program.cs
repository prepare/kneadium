using System;
namespace TestGlfw
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool is64BitsApp = System.Runtime.InteropServices.Marshal.SizeOf(typeof(IntPtr)) == 8;
            //SimpleWindowProgram.Start(args);
        }
    }
}
