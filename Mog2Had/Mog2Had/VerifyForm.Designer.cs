namespace Mog2Had
{
    partial class VerifyForm
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
            this.patchButton = new System.Windows.Forms.Button();
            this.patchTextBox = new System.Windows.Forms.TextBox();
            this.verifyPatchButton = new System.Windows.Forms.Button();
            this.verifyRTF = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // patchButton
            // 
            this.patchButton.Location = new System.Drawing.Point(12, 12);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(75, 39);
            this.patchButton.TabIndex = 7;
            this.patchButton.Text = "Patch File";
            this.patchButton.UseVisualStyleBackColor = true;
            this.patchButton.Click += new System.EventHandler(this.patchButton_Click);
            // 
            // patchTextBox
            // 
            this.patchTextBox.Location = new System.Drawing.Point(93, 22);
            this.patchTextBox.Name = "patchTextBox";
            this.patchTextBox.Size = new System.Drawing.Size(224, 20);
            this.patchTextBox.TabIndex = 6;
            // 
            // verifyPatchButton
            // 
            this.verifyPatchButton.Location = new System.Drawing.Point(127, 112);
            this.verifyPatchButton.Name = "verifyPatchButton";
            this.verifyPatchButton.Size = new System.Drawing.Size(83, 39);
            this.verifyPatchButton.TabIndex = 8;
            this.verifyPatchButton.Text = "Verify Patch";
            this.verifyPatchButton.UseVisualStyleBackColor = true;
            this.verifyPatchButton.Click += new System.EventHandler(this.verifyPatchButton_Click);
            // 
            // verifyRTF
            // 
            this.verifyRTF.Location = new System.Drawing.Point(13, 58);
            this.verifyRTF.Name = "verifyRTF";
            this.verifyRTF.Size = new System.Drawing.Size(323, 48);
            this.verifyRTF.TabIndex = 9;
            this.verifyRTF.Text = "";
            // 
            // VerifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 163);
            this.Controls.Add(this.verifyRTF);
            this.Controls.Add(this.verifyPatchButton);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.patchTextBox);
            this.Name = "VerifyForm";
            this.Text = "VerifyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button patchButton;
        private System.Windows.Forms.TextBox patchTextBox;
        private System.Windows.Forms.Button verifyPatchButton;
        private System.Windows.Forms.RichTextBox verifyRTF;
    }
}