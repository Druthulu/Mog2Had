using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Mog2Had
{
    public partial class VerifyForm : Form
    {
        public VerifyForm()
        {
            InitializeComponent();
        }

        private void verifyPatchButton_Click(object sender, EventArgs e)
        {
            //  Verify patch object structure

            //  Deserialize data and make sure values are of type, and have data

            //  READ INPUT FILE INTO STRING PASS TO DESERIALIZE

            //  DeSerial
            string json = File.ReadAllText(patchTextBox.Text)?.ToString();
            if (json.Length > 0)
            {
                //string json = File.ReadAllText(patchTextBox.Text)?.ToString();
                try
                {
                    M2HPatch DeserializedFromJSON = JsonConvert.DeserializeObject<M2HPatch>(json);
                    //  Verify Data
                    for (int i = 0; i < DeserializedFromJSON.dataPoints.Count; i++)
                    {
                        bool hash = DeserializedFromJSON.sourceMD5 != "";
                        bool dpsa = DeserializedFromJSON.dataPoints[i].startAddress > -1;
                        bool dpl = DeserializedFromJSON.dataPoints[i].length > -1;
                        bool dpt = DeserializedFromJSON.dataPoints[i].type != "";
                        bool dpd = DeserializedFromJSON.dataPoints[i].data.Length > 0;
                        if (!hash | !dpsa | !dpl | !dpt | !dpd)
                        {
                            break;
                            //  Message no good
                        }
                        else
                        {
                            //  Success, notify
                        }
                    }
                }
                catch (NullReferenceException)
                {

                    //throw;
                }
                //M2HPatch DeserializedFromJSON = JsonConvert.DeserializeObject<M2HPatch>(json);
                //  This should read from the patch file path, and create a class based on the data found.

                
            

            
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
