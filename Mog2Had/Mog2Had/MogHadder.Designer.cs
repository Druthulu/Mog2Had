namespace Mog2Had
{
    partial class MogHadder
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
            this.label4 = new System.Windows.Forms.Label();
            this.applyPatchButton = new System.Windows.Forms.Button();
            this.createPatchButton = new System.Windows.Forms.Button();
            this.verifyPatchButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Druthulu 2022";
            // 
            // applyPatchButton
            // 
            this.applyPatchButton.Location = new System.Drawing.Point(54, 12);
            this.applyPatchButton.Name = "applyPatchButton";
            this.applyPatchButton.Size = new System.Drawing.Size(121, 36);
            this.applyPatchButton.TabIndex = 4;
            this.applyPatchButton.Text = "Apply Patch File";
            this.applyPatchButton.UseVisualStyleBackColor = true;
            this.applyPatchButton.Click += new System.EventHandler(this.applyPatchButton_Click);
            // 
            // createPatchButton
            // 
            this.createPatchButton.Location = new System.Drawing.Point(54, 54);
            this.createPatchButton.Name = "createPatchButton";
            this.createPatchButton.Size = new System.Drawing.Size(121, 36);
            this.createPatchButton.TabIndex = 5;
            this.createPatchButton.Text = "Create Patch File";
            this.createPatchButton.UseVisualStyleBackColor = true;
            this.createPatchButton.Click += new System.EventHandler(this.createPatchButton_Click);
            // 
            // verifyPatchButton
            // 
            this.verifyPatchButton.Location = new System.Drawing.Point(54, 96);
            this.verifyPatchButton.Name = "verifyPatchButton";
            this.verifyPatchButton.Size = new System.Drawing.Size(121, 36);
            this.verifyPatchButton.TabIndex = 6;
            this.verifyPatchButton.Text = "Verify Patch File";
            this.verifyPatchButton.UseVisualStyleBackColor = true;
            this.verifyPatchButton.Click += new System.EventHandler(this.verifyPatchButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(13, 147);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(45, 23);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 180);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.verifyPatchButton);
            this.Controls.Add(this.createPatchButton);
            this.Controls.Add(this.applyPatchButton);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Mog2Had Patcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button applyPatchButton;
        private System.Windows.Forms.Button createPatchButton;
        private System.Windows.Forms.Button verifyPatchButton;
        private System.Windows.Forms.Button helpButton;
    }
}

