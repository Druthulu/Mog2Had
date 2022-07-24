namespace Mog2Had
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // helpTextBox
            // 
            this.helpTextBox.Location = new System.Drawing.Point(12, 12);
            this.helpTextBox.Name = "helpTextBox";
            this.helpTextBox.Size = new System.Drawing.Size(205, 152);
            this.helpTextBox.TabIndex = 0;
            this.helpTextBox.Text = "";
            this.helpTextBox.TextChanged += new System.EventHandler(this.helpTextBox_TextChanged);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 176);
            this.Controls.Add(this.helpTextBox);
            this.Name = "HelpForm";
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox helpTextBox;
    }
}