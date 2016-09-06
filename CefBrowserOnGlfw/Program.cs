using System;
using System.Collections.Generic;
using Pencil.Gaming; 

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
            SimpleWindowProgram.Start(args);
        }
    }
}
