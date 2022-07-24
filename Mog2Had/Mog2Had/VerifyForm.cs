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


            //SERIALIZE

            //string json = File.ReadAllText(patchTextBox.Text).ToString();

            //var DeserializedFromJSON = new M2HPatch("test");
            //byte[] data = new byte[] { 0, 1, 2, 3, 4 };
            //DeserializedFromJSON.dataPoints.Add(new ObjectData(12345, 5, "replace", data));
            //string SerializedJson = JsonConvert.SerializeObject(DeserializedFromJSON, Formatting.Indented);
            //File.WriteAllText(patchTextBox.Text, SerializedJson);

            //  DeSerial

            //  READ FILE
            string json = File.ReadAllText(patchTextBox.Text).ToString();
            if (json.Length > 8)    //  Check if long enough for next check
            {
                if (json.Substring(6, 3) == "m2H")  //  Check for valid info
                {
                    //  Deserialize
                    var DeserializedFromJSON = JsonConvert.DeserializeObject<M2HPatch>(json);
                    for (int i = 0; i < DeserializedFromJSON.dataPoints.Count; i++)
                    {

                        //var DeserializedFromJSON = JsonConvert.DeserializeObject<M2HPatch>(json);
                        //  Verify Data
                        bool hash = DeserializedFromJSON.sourceMD5 != null;
                        bool dpsa = DeserializedFromJSON.dataPoints[i].startAddress > -1;
                        bool dpl = DeserializedFromJSON.dataPoints[i].length != 0;
                        bool dpt = DeserializedFromJSON.dataPoints[i].type != null;
                        bool dpd = DeserializedFromJSON.dataPoints[i].data != null;
                        if (hash & dpsa & dpl & dpt & dpd)
                        {
                            //  SHOULD BE VALID JSON FORMAT, DATA, and info

                            //  CONTINUE WORK
                            /*
                            verifyRTF.Text += DeserializedFromJSON.sourceMD5 + "\n" +
                                DeserializedFromJSON.dataPoints[i].startAddress + "\n" +
                                DeserializedFromJSON.dataPoints.Count + "\n" +
                                DeserializedFromJSON.dataPoints[i].type + "\n";
                            for (int j = 0; j < DeserializedFromJSON.dataPoints[i].data.Length; j++)
                            {
                                verifyRTF.Text += DeserializedFromJSON.dataPoints[i].data[j] + ",";
                            }
                            */

                            //  Success, notify

                        }
                        else
                        {
                            //  Message no good
                            verifyRTF.Text = "bunk";
                            break;
                        }

                    }
                }
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
