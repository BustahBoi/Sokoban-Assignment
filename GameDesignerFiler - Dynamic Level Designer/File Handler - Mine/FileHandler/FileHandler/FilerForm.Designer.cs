namespace FileHandlerNS
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.lblSaveItem = new System.Windows.Forms.Label();
            this.lblLoadItem = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lnkRecent = new System.Windows.Forms.LinkLabel();
            this.lblMostRecent = new System.Windows.Forms.Label();
            this.lblRecentPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 50);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lstMessages
            // 
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.Location = new System.Drawing.Point(12, 118);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(239, 69);
            this.lstMessages.TabIndex = 2;
            // 
            // lblSaveItem
            // 
            this.lblSaveItem.AutoSize = true;
            this.lblSaveItem.Location = new System.Drawing.Point(107, 16);
            this.lblSaveItem.Name = "lblSaveItem";
            this.lblSaveItem.Size = new System.Drawing.Size(51, 13);
            this.lblSaveItem.TabIndex = 3;
            this.lblSaveItem.Text = "FileName";
            // 
            // lblLoadItem
            // 
            this.lblLoadItem.AutoSize = true;
            this.lblLoadItem.Location = new System.Drawing.Point(107, 55);
            this.lblLoadItem.Name = "lblLoadItem";
            this.lblLoadItem.Size = new System.Drawing.Size(51, 13);
            this.lblLoadItem.TabIndex = 4;
            this.lblLoadItem.Text = "FileName";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(95, 453);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(12, 209);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(239, 238);
            this.lstFiles.TabIndex = 6;
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(13, 190);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(62, 13);
            this.lblFiles.TabIndex = 7;
            this.lblFiles.Text = "Saved Files";
            // 
            // lnkRecent
            // 
            this.lnkRecent.AutoSize = true;
            this.lnkRecent.Location = new System.Drawing.Point(107, 85);
            this.lnkRecent.Name = "lnkRecent";
            this.lnkRecent.Size = new System.Drawing.Size(70, 13);
            this.lnkRecent.TabIndex = 8;
            this.lnkRecent.TabStop = true;
            this.lnkRecent.Text = "Recent Save";
            this.lnkRecent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRecent_LinkClicked);
            // 
            // lblMostRecent
            // 
            this.lblMostRecent.AutoSize = true;
            this.lblMostRecent.Location = new System.Drawing.Point(29, 85);
            this.lblMostRecent.Name = "lblMostRecent";
            this.lblMostRecent.Size = new System.Drawing.Size(58, 13);
            this.lblMostRecent.TabIndex = 9;
            this.lblMostRecent.Text = "Recent file";
            // 
            // lblRecentPath
            // 
            this.lblRecentPath.AutoSize = true;
            this.lblRecentPath.Location = new System.Drawing.Point(29, 102);
            this.lblRecentPath.Name = "lblRecentPath";
            this.lblRecentPath.Size = new System.Drawing.Size(67, 13);
            this.lblRecentPath.TabIndex = 10;
            this.lblRecentPath.Text = "Recent Path";
            // 
            // FilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 485);
            this.ControlBox = false;
            this.Controls.Add(this.lblRecentPath);
            this.Controls.Add(this.lblMostRecent);
            this.Controls.Add(this.lnkRecent);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblLoadItem);
            this.Controls.Add(this.lblSaveItem);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Name = "FilerForm";
            this.Text = "File Handler";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FilerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.Label lblSaveItem;
        private System.Windows.Forms.Label lblLoadItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.LinkLabel lnkRecent;
        private System.Windows.Forms.Label lblMostRecent;
        private System.Windows.Forms.Label lblRecentPath;
    }
}