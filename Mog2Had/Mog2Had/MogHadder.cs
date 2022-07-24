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
    public partial class MogHadder : Form
    {
        public MogHadder()
        {
            InitializeComponent();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            form.Show();
        }

        private void applyPatchButton_Click(object sender, EventArgs e)
        {
            ApplyForm form = new ApplyForm();
            form.Show();
        }

        private void createPatchButton_Click(object sender, EventArgs e)
        {
            CreateForm form = new CreateForm();
            form.Show();
        }

        private void verifyPatchButton_Click(object sender, EventArgs e)
        {
            VerifyForm form = new VerifyForm();
            form.Show();
        }
    }
}
