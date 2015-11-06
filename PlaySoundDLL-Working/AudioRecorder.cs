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

namespace PlaySoundDLL_Working
{
    public partial class AudioRecorder : Form
    {
        //[DllImport("Recording.dll", EntryPoint="DllMain")]
        //public static extern bool DllMain(IntPtr hInstance, ulong fdwReason, IntPtr pvReserved);

        [DllImport("RecordingC.dll", EntryPoint = "DlgProc")]
        public static extern bool DlgProc(IntPtr hwnd, uint message, int wParam, int lParam);

        public IntPtr handle;
        public uint message = 0x0111;
        public int wParam;
        public int lParam;

        public AudioRecorder()
        {
            InitializeComponent();
            handle = this.Handle;
            PlayButton.Enabled = false;
            StopRecordButton.Enabled = false;
            StopPlayingButton.Enabled = false;
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            StopRecordButton.Enabled = true;
            PlayButton.Enabled = false;
            wParam = 1000; // Begin Recording
            DlgProc(handle, message, wParam, lParam);
        }

        private void StopRecordButton_Click(object sender, EventArgs e)
        {
            PlayButton.Enabled = true;
            StopRecordButton.Enabled = false;
            wParam = 1001; // End Recording
            DlgProc(handle, message, wParam, lParam);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            RecordButton.Enabled = false;
            StopPlayingButton.Enabled = true;
            wParam = 1002; // Begin Play
            DlgProc(handle, message, wParam, lParam);

        }

        private void StopPlayingButton_Click(object sender, EventArgs e)
        {
            RecordButton.Enabled = true;
            StopPlayingButton.Enabled = true;
            StopPlayingButton.Enabled = false;
            wParam = 1004; // End Play
            DlgProc(handle, message, wParam, lParam);
        }
    }
}
