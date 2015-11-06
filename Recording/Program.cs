using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

/*
	Spencer Pollock
	A00924319
*/

namespace Recording
{
    static class Program
    {
        [DllImport("RecordingC.dll")]
        public static extern int startProg(int hInstance);
        [DllImport("RecordingC.dll")]
        public static extern int postQuitMessage();
        [DllImport("RecordingC.dll")]
        public static extern int getDataSize();
        [DllImport("RecordingC.dll")]
        public static extern void getByteData(IntPtr p);
        [DllImport("RecordingC.dll")]
        public static extern void setByteData(IntPtr p);

        private static IntPtr p;
        private static int dataSize;
        private static byte[] recData;

        /*
            We start a new thread because if we don't one of the 
            programs will freeze while the other runs.
        */

        public static int getCDataSize()
        {
            return getDataSize(); // how big data is in C++
        }

        public static void setPointer(int i)
        {
            p = Marshal.AllocHGlobal(i); // avoid errors by doing i * 2
            getByteData(p);
            dataSize = i / 2;
            recData = new byte[dataSize];
            Marshal.Copy(p, recData, 0, dataSize);
        }

        public static void setCByteData(IntPtr p)
        {
            //setByteData(p); // cannot write to memory
        }

        public static byte[] getDataArray()
        {
            return recData;
        }

        public static void VolumeUp()
        {
            int d;
            // update
            for (int i = 0; i < dataSize; i++)
            {
                d = Convert.ToInt32(recData[i]);
                d = d * 2;
                if (d >= 255)
                    d = d - 255;
                recData[i] = Convert.ToByte(d);
                Marshal.WriteByte(p, i, recData[i]);
            }
            setCByteData(p);
        }

        public static void VolumeDown()
        {
            int d;
            // update
            for (int i = 0; i < dataSize; i++)
            {
                d = Convert.ToInt32(recData[i]);
                d = d / 2;
                recData[i] = Convert.ToByte(d);
                Marshal.WriteByte(p, i, recData[i]);
            }
            setCByteData(p);
        }

        static void startThread()
        {
            System.Windows.Forms.Application.Run(new RecordingCSharp());
        }

        static void Main(string[] args)
        {
            Process p = Process.GetCurrentProcess();
            var newThread = new Thread(new ThreadStart(startThread));

            newThread.Start();
            startProg(p.Id); // DLLImport start program
                             // id is the current process of the c# window
                             // 2 things with process id
        }
    }
}
