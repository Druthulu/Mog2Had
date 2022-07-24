namespace Mog2Had
{
    partial class ApplyForm
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
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.sourceButton = new System.Windows.Forms.Button();
            this.patchButton = new System.Windows.Forms.Button();
            this.patchTextBox = new System.Windows.Forms.TextBox();
            this.applyPatchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(93, 21);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(224, 20);
            this.sourceTextBox.TabIndex = 0;
            // 
            // sourceButton
            // 
            this.sourceButton.Location = new System.Drawing.Point(12, 12);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(75, 36);
            this.sourceButton.TabIndex = 1;
            this.sourceButton.Text = "Source File";
            this.sourceButton.UseVisualStyleBackColor = true;
            this.sourceButton.Click += new System.EventHandler(this.sourceButton_Click);
            // 
            // patchButton
            // 
            this.patchButton.Location = new System.Drawing.Point(12, 54);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(75, 39);
            this.patchButton.TabIndex = 5;
            this.patchButton.Text = "Patch File";
            this.patchButton.UseVisualStyleBackColor = true;
            this.patchButton.Click += new System.EventHandler(this.patchButton_Click);
            // 
            // patchTextBox
            // 
            this.patchTextBox.Location = new System.Drawing.Point(93, 64);
            this.patchTextBox.Name = "patchTextBox";
            this.patchTextBox.Size = new System.Drawing.Size(224, 20);
            this.patchTextBox.TabIndex = 4;
            // 
            // applyPatchButton
            // 
            this.applyPatchButton.Location = new System.Drawing.Point(125, 109);
            this.applyPatchButton.Name = "applyPatchButton";
            this.applyPatchButton.Size = new System.Drawing.Size(83, 39);
            this.applyPatchButton.TabIndex = 6;
            this.applyPatchButton.Text = "Apply Patch";
            this.applyPatchButton.UseVisualStyleBackColor = true;
            this.applyPatchButton.Click += new System.EventHandler(this.applyPatchButton_Click);
            // 
            // ApplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 165);
            this.Controls.Add(this.applyPatchButton);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.patchTextBox);
            this.Controls.Add(this.sourceButton);
            this.Controls.Add(this.sourceTextBox);
            this.Name = "ApplyForm";
            this.Text = "Apply M2H";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Button sourceButton;
        private System.Windows.Forms.Button patchButton;
        private System.Windows.Forms.TextBox patchTextBox;
        private System.Windows.Forms.Button applyPatchButton;
    }
}