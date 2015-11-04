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
        //[DllImport("DlgProc", EntryPoint = "DlgProc")]
        //public static extern bool DlgProc(IntPtr hwnd, uint message, int wParam, int lParam);

        [DllImport("RecordingC.dll", EntryPoint="recStart")]
        public static extern void recStart(IntPtr handle);
        [DllImport("RecordingC.dll", EntryPoint = "recStop")]
        public static extern void recStop(IntPtr handle);
        [DllImport("RecordingC.dll", EntryPoint = "playStart")]
        public static extern void playStart(IntPtr handle);
        [DllImport("RecordingC.dll", EntryPoint = "playStop")]
        public static extern void playStop(IntPtr handle);

        private IntPtr handle;

        public RecordingCSharp()
        {
            InitializeComponent();
            handle = this.Handle;
        }

        private void recButton_Click(object sender, EventArgs e)
        {
            recStart(handle);
        }

        private void stopRecButton_Click(object sender, EventArgs e)
        {
            recStop(handle);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            playStart(handle);
        }

        private void stopPlayButton_Click(object sender, EventArgs e)
        {
            playStop(handle);
        }
    }
}
