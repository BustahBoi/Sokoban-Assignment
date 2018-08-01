namespace Sokoban_FileHandler
{
    partial class FilerForm
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
            this.LoadLabel = new System.Windows.Forms.Label();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.LoadedFileLabel = new System.Windows.Forms.Label();
            this.SavedFileLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.LevelComboBox = new System.Windows.Forms.ComboBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadLabel
            // 
            this.LoadLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadLabel.Location = new System.Drawing.Point(132, 46);
            this.LoadLabel.Name = "LoadLabel";
            this.LoadLabel.Size = new System.Drawing.Size(140, 13);
            this.LoadLabel.TabIndex = 2;
            this.LoadLabel.Text = "No File Loaded";
            // 
            // SaveLabel
            // 
            this.SaveLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveLabel.Location = new System.Drawing.Point(132, 133);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(140, 13);
            this.SaveLabel.TabIndex = 3;
            this.SaveLabel.Text = "No File Saved";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveBtn.Location = new System.Drawing.Point(12, 124);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(100, 30);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save Level";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadBtn.Location = new System.Drawing.Point(12, 37);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(100, 30);
            this.LoadBtn.TabIndex = 0;
            this.LoadBtn.Text = "Load Level";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // LoadedFileLabel
            // 
            this.LoadedFileLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadedFileLabel.Location = new System.Drawing.Point(12, 70);
            this.LoadedFileLabel.Name = "LoadedFileLabel";
            this.LoadedFileLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoadedFileLabel.Size = new System.Drawing.Size(250, 25);
            this.LoadedFileLabel.TabIndex = 4;
            this.LoadedFileLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SavedFileLabel
            // 
            this.SavedFileLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SavedFileLabel.Location = new System.Drawing.Point(12, 157);
            this.SavedFileLabel.Name = "SavedFileLabel";
            this.SavedFileLabel.Size = new System.Drawing.Size(250, 25);
            this.SavedFileLabel.TabIndex = 5;
            this.SavedFileLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 188);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(250, 75);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LevelComboBox
            // 
            this.LevelComboBox.FormattingEnabled = true;
            this.LevelComboBox.Location = new System.Drawing.Point(12, 83);
            this.LevelComboBox.Name = "LevelComboBox";
            this.LevelComboBox.Size = new System.Drawing.Size(260, 21);
            this.LevelComboBox.TabIndex = 8;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(95, 269);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(100, 30);
            this.CloseBtn.TabIndex = 9;
            this.CloseBtn.Text = "Cancel";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // FilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.LevelComboBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SavedFileLabel);
            this.Controls.Add(this.LoadedFileLabel);
            this.Controls.Add(this.SaveLabel);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.LoadLabel);
            this.Controls.Add(this.SaveBtn);
            this.Name = "FilerForm";
            this.Text = "Load / Save Level";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LoadLabel;
        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Label LoadedFileLabel;
        private System.Windows.Forms.Label SavedFileLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.ComboBox LevelComboBox;
        private System.Windows.Forms.Button CloseBtn;
    }
}

