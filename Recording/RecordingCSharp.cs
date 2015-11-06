using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Recording
{
    public partial class RecordingCSharp : Form
    {
        [DllImport("RecordingC.dll", EntryPoint = "sendQuit")]
        public static extern int sendQuit();
        [DllImport("RecordingC.dll", EntryPoint = "sendRec")]
        public static extern int sendRec();
        [DllImport("RecordingC.dll", EntryPoint = "sendStopRec")]
        public static extern int sendStopRec();
        [DllImport("RecordingC.dll", EntryPoint = "sendPlay")]
        public static extern int sendPlay();
        [DllImport("RecordingC.dll", EntryPoint = "sendPlayPause")]
        public static extern int sendPlayPause();
        [DllImport("RecordingC.dll", EntryPoint = "sendPlayStop")]
        public static extern int sendPlayStop();
        [DllImport("RecordingC.dll", EntryPoint = "getByteData")]
        public static extern IntPtr getByteData();
        [DllImport("RecordingC.dll", EntryPoint = "getDataSize")]
        public static extern double getDataSize();
        [DllImport("RecordingC.dll", EntryPoint = "sendVolumeUp")]
        public static extern int sendVolumeUp();
        [DllImport("RecordingC.dll", EntryPoint = "sendVolumeDown")]
        public static extern int sendVolumeDown();

        public RecordingCSharp()
        {
            InitializeComponent();
        }

        private void recButton_Click(object sender, EventArgs e)
        {
            sendRec();
        }

        private void stopRecButton_Click(object sender, EventArgs e)
        {
            sendStopRec();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            sendPlay();
        }

        private void stopPlayButton_Click(object sender, EventArgs e)
        {
            sendPlayStop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendQuit();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //vol up
            // get the byte data pointer, and size
            // times everything by 1.2
            IntPtr bytePos = getByteData();
            double size = getDataSize();

            for(int i = 0; i < size; i++)
            {

            }
            // get
            // update
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //vol down
            // get the byte data pointer, and size
            // times everything by 0.2

            //get
            //update
        }
    }
}
