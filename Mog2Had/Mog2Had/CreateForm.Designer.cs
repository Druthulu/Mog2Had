namespace Mog2Had
{
    partial class CreateForm
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
            this.createPatchButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.newTextBox = new System.Windows.Forms.TextBox();
            this.sourceButton = new System.Windows.Forms.Button();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createPatchButton
            // 
            this.createPatchButton.Location = new System.Drawing.Point(125, 109);
            this.createPatchButton.Name = "createPatchButton";
            this.createPatchButton.Size = new System.Drawing.Size(85, 39);
            this.createPatchButton.TabIndex = 11;
            this.createPatchButton.Text = "Create Patch";
            this.createPatchButton.UseVisualStyleBackColor = true;
            this.createPatchButton.Click += new System.EventHandler(this.createPatchButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(12, 54);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 39);
            this.newButton.TabIndex = 10;
            this.newButton.Text = "New File";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // newTextBox
            // 
            this.newTextBox.Location = new System.Drawing.Point(93, 64);
            this.newTextBox.Name = "newTextBox";
            this.newTextBox.Size = new System.Drawing.Size(224, 20);
            this.newTextBox.TabIndex = 9;
            // 
            // sourceButton
            // 
            this.sourceButton.Location = new System.Drawing.Point(12, 12);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(75, 36);
            this.sourceButton.TabIndex = 8;
            this.sourceButton.Text = "Source File";
            this.sourceButton.UseVisualStyleBackColor = true;
            this.sourceButton.Click += new System.EventHandler(this.sourceButton_Click);
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(93, 21);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(224, 20);
            this.sourceTextBox.TabIndex = 7;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 164);
            this.Controls.Add(this.createPatchButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.newTextBox);
            this.Controls.Add(this.sourceButton);
            this.Controls.Add(this.sourceTextBox);
            this.Name = "CreateForm";
            this.Text = "Create M2H";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createPatchButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.TextBox newTextBox;
        private System.Windows.Forms.Button sourceButton;
        private System.Windows.Forms.TextBox sourceTextBox;
    }
}