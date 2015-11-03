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
        [DllImport("Recording.dll")]
        public static extern bool DlgProc(IntPtr hwnd, uint message, long wParam, uint lParam);

        public IntPtr handle = new IntPtr();
        public uint message;
        public long wParam;
        public uint lParam;

        public AudioRecorder()
        {
            InitializeComponent();
            PlayButton.Enabled = false;
            StopRecordButton.Enabled = false;
            StopPlayingButton.Enabled = false;
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            StopRecordButton.Enabled = true;
            PlayButton.Enabled = false;
            message = 1000; // Begin Recording
            DlgProc(handle, message, wParam, lParam);
        }

        private void StopRecordButton_Click(object sender, EventArgs e)
        {
            PlayButton.Enabled = true;
            StopRecordButton.Enabled = false;
            message = 1001; // End Recording
            DlgProc(handle, message, wParam, lParam);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            StopPlayingButton.Enabled = true;
            message = 1002; // Begin Play
            DlgProc(handle, message, wParam, lParam);
        }

        private void StopPlayingButton_Click(object sender, EventArgs e)
        {
            StopPlayingButton.Enabled = true;
            StopPlayingButton.Enabled = false;
            message = 1004; // End Play
            DlgProc(handle, message, wParam, lParam);
        }
    }
}
