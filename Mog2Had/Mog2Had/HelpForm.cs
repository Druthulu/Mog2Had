using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mog2Had
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            fillText();
        }

        private void helpTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        void fillText()
        {
            helpTextBox.Text = "Built by Druthulu 2022. \n Patching to save search work";
        }
    }
}
