using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace Recording
{
    static class Program
    {
        [DllImport("RecordingC.dll")]
        public static extern int startProg(int hInstance);
        [DllImport("RecordingC.dll")]
        public static extern int postQuitMessage();

        /*
            We start a new thread because if we don't one of the 
            programs will freeze while the other runs.
        */

        static void startThread()
        {
            System.Windows.Forms.Application.Run(new RecordingCSharp());
        }

        static void Main(string[] args)
        {
            Process p = Process.GetCurrentProcess();
            string[] cml = Environment.GetCommandLineArgs();
            var newThread = new Thread(new ThreadStart(startThread));
            newThread.Start();
            startProg(p.Id);
        }
    }
}
