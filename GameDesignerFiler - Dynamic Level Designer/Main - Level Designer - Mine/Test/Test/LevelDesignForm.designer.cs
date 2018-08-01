namespace Test
{
    partial class LevelDesignForm
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
            this.wallButton = new System.Windows.Forms.RadioButton();
            this.emptyButton = new System.Windows.Forms.RadioButton();
            this.playerButton = new System.Windows.Forms.RadioButton();
            this.goalButton = new System.Windows.Forms.RadioButton();
            this.blockButton = new System.Windows.Forms.RadioButton();
            this.blockOnGoalButton = new System.Windows.Forms.RadioButton();
            this.playerOnGoalButton = new System.Windows.Forms.RadioButton();
            this.xSize = new System.Windows.Forms.NumericUpDown();
            this.ySize = new System.Windows.Forms.NumericUpDown();
            this.xSizeText = new System.Windows.Forms.Label();
            this.ySizeText = new System.Windows.Forms.Label();
            this.sizeGenerate = new System.Windows.Forms.Button();
            this.itemSelection = new System.Windows.Forms.GroupBox();
            this.MapContainer = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.Errors = new System.Windows.Forms.ListBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySize)).BeginInit();
            this.itemSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // wallButton
            // 
            this.wallButton.AutoSize = true;
            this.wallButton.Location = new System.Drawing.Point(6, 15);
            this.wallButton.Name = "wallButton";
            this.wallButton.Size = new System.Drawing.Size(46, 17);
            this.wallButton.TabIndex = 0;
            this.wallButton.TabStop = true;
            this.wallButton.Text = "Wall";
            this.wallButton.UseVisualStyleBackColor = true;
            this.wallButton.CheckedChanged += new System.EventHandler(this.wallButton_CheckedChanged);
            // 
            // emptyButton
            // 
            this.emptyButton.AutoSize = true;
            this.emptyButton.Location = new System.Drawing.Point(6, 38);
            this.emptyButton.Name = "emptyButton";
            this.emptyButton.Size = new System.Drawing.Size(54, 17);
            this.emptyButton.TabIndex = 1;
            this.emptyButton.TabStop = true;
            this.emptyButton.Text = "Empty";
            this.emptyButton.UseVisualStyleBackColor = true;
            this.emptyButton.CheckedChanged += new System.EventHandler(this.emptyButton_CheckedChanged);
            // 
            // playerButton
            // 
            this.playerButton.AutoSize = true;
            this.playerButton.Location = new System.Drawing.Point(6, 61);
            this.playerButton.Name = "playerButton";
            this.playerButton.Size = new System.Drawing.Size(54, 17);
            this.playerButton.TabIndex = 2;
            this.playerButton.TabStop = true;
            this.playerButton.Text = "Player";
            this.playerButton.UseVisualStyleBackColor = true;
            this.playerButton.CheckedChanged += new System.EventHandler(this.playerButton_CheckedChanged);
            // 
            // goalButton
            // 
            this.goalButton.AutoSize = true;
            this.goalButton.Location = new System.Drawing.Point(6, 84);
            this.goalButton.Name = "goalButton";
            this.goalButton.Size = new System.Drawing.Size(47, 17);
            this.goalButton.TabIndex = 3;
            this.goalButton.TabStop = true;
            this.goalButton.Text = "Goal";
            this.goalButton.UseVisualStyleBackColor = true;
            this.goalButton.CheckedChanged += new System.EventHandler(this.goalButton_CheckedChanged);
            // 
            // blockButton
            // 
            this.blockButton.AutoSize = true;
            this.blockButton.Location = new System.Drawing.Point(6, 107);
            this.blockButton.Name = "blockButton";
            this.blockButton.Size = new System.Drawing.Size(52, 17);
            this.blockButton.TabIndex = 4;
            this.blockButton.TabStop = true;
            this.blockButton.Text = "Block";
            this.blockButton.UseVisualStyleBackColor = true;
            this.blockButton.CheckedChanged += new System.EventHandler(this.blockButton_CheckedChanged);
            // 
            // blockOnGoalButton
            // 
            this.blockOnGoalButton.AutoSize = true;
            this.blockOnGoalButton.Location = new System.Drawing.Point(6, 130);
            this.blockOnGoalButton.Name = "blockOnGoalButton";
            this.blockOnGoalButton.Size = new System.Drawing.Size(90, 17);
            this.blockOnGoalButton.TabIndex = 5;
            this.blockOnGoalButton.TabStop = true;
            this.blockOnGoalButton.Text = "Block on goal";
            this.blockOnGoalButton.UseVisualStyleBackColor = true;
            this.blockOnGoalButton.CheckedChanged += new System.EventHandler(this.blockOnGoalButton_CheckedChanged);
            // 
            // playerOnGoalButton
            // 
            this.playerOnGoalButton.AutoSize = true;
            this.playerOnGoalButton.Location = new System.Drawing.Point(6, 153);
            this.playerOnGoalButton.Name = "playerOnGoalButton";
            this.playerOnGoalButton.Size = new System.Drawing.Size(92, 17);
            this.playerOnGoalButton.TabIndex = 6;
            this.playerOnGoalButton.TabStop = true;
            this.playerOnGoalButton.Text = "Player on goal";
            this.playerOnGoalButton.UseVisualStyleBackColor = true;
            this.playerOnGoalButton.CheckedChanged += new System.EventHandler(this.playerOnGoalButton_CheckedChanged);
            // 
            // xSize
            // 
            this.xSize.Location = new System.Drawing.Point(86, 33);
            this.xSize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.xSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.xSize.Name = "xSize";
            this.xSize.Size = new System.Drawing.Size(120, 20);
            this.xSize.TabIndex = 7;
            this.xSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ySize
            // 
            this.ySize.Location = new System.Drawing.Point(256, 33);
            this.ySize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ySize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ySize.Name = "ySize";
            this.ySize.Size = new System.Drawing.Size(120, 20);
            this.ySize.TabIndex = 8;
            this.ySize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // xSizeText
            // 
            this.xSizeText.AutoSize = true;
            this.xSizeText.Location = new System.Drawing.Point(46, 35);
            this.xSizeText.Name = "xSizeText";
            this.xSizeText.Size = new System.Drawing.Size(35, 13);
            this.xSizeText.TabIndex = 9;
            this.xSizeText.Text = "Width";
            // 
            // ySizeText
            // 
            this.ySizeText.AutoSize = true;
            this.ySizeText.Location = new System.Drawing.Point(212, 35);
            this.ySizeText.Name = "ySizeText";
            this.ySizeText.Size = new System.Drawing.Size(38, 13);
            this.ySizeText.TabIndex = 10;
            this.ySizeText.Text = "Height";
            // 
            // sizeGenerate
            // 
            this.sizeGenerate.Location = new System.Drawing.Point(382, 33);
            this.sizeGenerate.Name = "sizeGenerate";
            this.sizeGenerate.Size = new System.Drawing.Size(75, 23);
            this.sizeGenerate.TabIndex = 11;
            this.sizeGenerate.Text = "Generate";
            this.sizeGenerate.UseVisualStyleBackColor = true;
            this.sizeGenerate.Click += new System.EventHandler(this.sizeGenerate_Click);
            // 
            // itemSelection
            // 
            this.itemSelection.Controls.Add(this.playerOnGoalButton);
            this.itemSelection.Controls.Add(this.wallButton);
            this.itemSelection.Controls.Add(this.emptyButton);
            this.itemSelection.Controls.Add(this.playerButton);
            this.itemSelection.Controls.Add(this.goalButton);
            this.itemSelection.Controls.Add(this.blockButton);
            this.itemSelection.Controls.Add(this.blockOnGoalButton);
            this.itemSelection.Location = new System.Drawing.Point(46, 91);
            this.itemSelection.Name = "itemSelection";
            this.itemSelection.Size = new System.Drawing.Size(160, 177);
            this.itemSelection.TabIndex = 12;
            this.itemSelection.TabStop = false;
            this.itemSelection.Text = "Items";
            this.itemSelection.Enter += new System.EventHandler(this.itemSelection_Enter);
            // 
            // MapContainer
            // 
            this.MapContainer.Location = new System.Drawing.Point(212, 91);
            this.MapContainer.Name = "MapContainer";
            this.MapContainer.Size = new System.Drawing.Size(680, 680);
            this.MapContainer.TabIndex = 13;
            this.MapContainer.TabStop = false;
            this.MapContainer.Text = "Map";
            this.MapContainer.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(128, 509);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "&Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.save_Click);
            // 
            // Errors
            // 
            this.Errors.FormattingEnabled = true;
            this.Errors.Location = new System.Drawing.Point(46, 291);
            this.Errors.Name = "Errors";
            this.Errors.Size = new System.Drawing.Size(160, 212);
            this.Errors.TabIndex = 15;
            this.Errors.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(46, 509);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 16;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(46, 59);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 17;
            this.Load.Text = "&Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(46, 275);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(34, 13);
            this.lblError.TabIndex = 18;
            this.lblError.Text = "Errors";
            this.lblError.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(877, 802);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTest
            // 
            this.btnTest.Enabled = false;
            this.btnTest.Location = new System.Drawing.Point(127, 59);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 20;
            this.btnTest.Text = "&Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // LevelDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(964, 837);
            this.ControlBox = false;
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.Errors);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.MapContainer);
            this.Controls.Add(this.itemSelection);
            this.Controls.Add(this.sizeGenerate);
            this.Controls.Add(this.ySizeText);
            this.Controls.Add(this.xSizeText);
            this.Controls.Add(this.ySize);
            this.Controls.Add(this.xSize);
            this.Name = "LevelDesignForm";
            this.Text = "Level Designer";
            ((System.ComponentModel.ISupportInitialize)(this.xSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySize)).EndInit();
            this.itemSelection.ResumeLayout(false);
            this.itemSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton wallButton;
        private System.Windows.Forms.RadioButton emptyButton;
        private System.Windows.Forms.RadioButton playerButton;
        private System.Windows.Forms.RadioButton goalButton;
        private System.Windows.Forms.RadioButton blockButton;
        private System.Windows.Forms.RadioButton blockOnGoalButton;
        private System.Windows.Forms.RadioButton playerOnGoalButton;
        private System.Windows.Forms.NumericUpDown xSize;
        private System.Windows.Forms.NumericUpDown ySize;
        private System.Windows.Forms.Label xSizeText;
        private System.Windows.Forms.Label ySizeText;
        private System.Windows.Forms.Button sizeGenerate;
        private System.Windows.Forms.GroupBox itemSelection;
        private System.Windows.Forms.GroupBox MapContainer;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ListBox Errors;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTest;
    }
}