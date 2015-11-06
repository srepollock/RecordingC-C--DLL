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

/*
	Spencer Pollock
	A00924319
*/

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
            
        }

        private void stopRecButton_Click(object sender, EventArgs e)
        {
            
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            
        }

        private void stopPlayButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //vol down
            // get the byte data pointer, and size
            // times everything by 0.2

            //get
            byte[] ar = Program.getDataArray();
            int sz = Program.getDataSize();
            int d;
            //update
            for (int i = 0; i < sz; i++)
            {
                d = Convert.ToInt32(ar[i]);
                d = d / 2;
                ar[i] = Convert.ToByte(d);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sendQuit();
            Application.Exit();
        }

        private void RecordingCSharp_FormClose(object sender, FormClosedEventArgs e)
        {
            sendQuit();
            Application.Exit();
        }

        private void recButton_Click_1(object sender, EventArgs e)
        {
            sendRec();
        }

        private void stopRecButton_Click_1(object sender, EventArgs e)
        {
            sendStopRec();
        }

        private void playButton_Click_1(object sender, EventArgs e)
        {
            sendPlay();
        }

        private void stopPlayButton_Click_1(object sender, EventArgs e)
        {
            sendPlayStop();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //vol up
            Program.VolumeUp();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //vol up
            Program.VolumeDown();
        }
    }
}
