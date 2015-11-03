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
        [DllImport("PlayC++Dll.dll")]
        public static extern bool DlgProc(IntPtr hwnd, uint message, IntPtr wParam, IntPtr lParam);


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
        }

        private void StopRecordButton_Click(object sender, EventArgs e)
        {
            PlayButton.Enabled = true;
            StopRecordButton.Enabled = false;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            StopPlayingButton.Enabled = true;
        }

        private void StopPlayingButton_Click(object sender, EventArgs e)
        {
            StopPlayingButton.Enabled = true;
            StopPlayingButton.Enabled = false;
        }
    }
}
