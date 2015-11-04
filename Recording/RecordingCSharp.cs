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
        [DllImport("DlgProc", EntryPoint = "DlgProc")]
        public static extern bool DlgProc(IntPtr hwnd, uint message, int wParam, int lParam);

        public RecordingCSharp()
        {
            InitializeComponent();
        }

        private void recButton_Click(object sender, EventArgs e)
        {
            DlgProc(this.Handle, 0x0111, 1000, 0);
        }

        private void stopRecButton_Click(object sender, EventArgs e)
        {
            DlgProc(this.Handle, 0x0111, 1001, 0);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            DlgProc(this.Handle, 0x0111, 1002, 0);
        }

        private void stopPlayButton_Click(object sender, EventArgs e)
        {
            DlgProc(this.Handle, 0x0111, 1003, 0);
        }
    }
}
