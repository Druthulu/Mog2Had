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
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void createPatchButton_Click(object sender, EventArgs e)
        {
            //  Create patch file (main work here)

            //  Compare source file against known MD5

            //  SCAN 2 FILES AND GENERATE A PATCH FILE
            
            



            //  Create filename to write patch
            DateTimeOffset Date = DateTime.Now;

            //  NEED TO FIX THIS
            string fileName = /*patchTextBox.Text + */ Date + ".m2h";
            //  Serialize data into patch
            //string SerializedJson = JsonConvert.SerializeObject(/* STORAGE OBJECT CREATED DURING SCANNING*/, Formatting.Indented);

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
                newTextBox.Text = fileDlg.FileName;
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Title = "Select New File";
            fileDlg.DefaultExt = ".bin";
            fileDlg.Filter = "bin files (*.bin)|*.bin";
            DialogResult result = fileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                newTextBox.Text = fileDlg.FileName;
            }
        }

    }
}
