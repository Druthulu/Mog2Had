using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Mog2Had
{
    public partial class ApplyForm : Form
    {
        public ApplyForm()
        {
            InitializeComponent();
        }

        private void applyPatchButton_Click(object sender, EventArgs e)
        {
            //  Apply patch file to source file
            //  MD5 check against known

            //  Duplicate, then APPLY PATCH TO SOURCE FILE  //


            //  DeSerial
            M2HPatch DeserializedFromJSON = JsonConvert.DeserializeObject<M2HPatch>(/*FILE INPUT FROM PATCH PATH*/"");    //changed string to file read

        }

        private void sourceButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Title = "Select Source File";
            fileDlg.DefaultExt = ".bin";
            fileDlg.Filter = "bin files (*.bin)|*.bin";
            DialogResult result = fileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                sourceTextBox.Text = fileDlg.FileName;
            }
        }

        private void patchButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Title = "Select Patch File";
            fileDlg.DefaultExt = ".m2h";
            fileDlg.Filter = "m2h files (*.m2h)|*.m2h";
            DialogResult result = fileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                patchTextBox.Text = fileDlg.FileName;
            }
        }

    }
}
