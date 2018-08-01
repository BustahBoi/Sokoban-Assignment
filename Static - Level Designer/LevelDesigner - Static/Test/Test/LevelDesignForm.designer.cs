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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Map = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnSave = new System.Windows.Forms.Button();
            this.Errors = new System.Windows.Forms.ListBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.xSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySize)).BeginInit();
            this.itemSelection.SuspendLayout();
            this.MapContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
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
            this.MapContainer.Controls.Add(this.Map);
            this.MapContainer.Location = new System.Drawing.Point(212, 91);
            this.MapContainer.Name = "MapContainer";
            this.MapContainer.Size = new System.Drawing.Size(663, 660);
            this.MapContainer.TabIndex = 13;
            this.MapContainer.TabStop = false;
            this.MapContainer.Text = "Map";
            this.MapContainer.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Map
            // 
            this.Map.AllowUserToAddRows = false;
            this.Map.AllowUserToDeleteRows = false;
            this.Map.AllowUserToResizeColumns = false;
            this.Map.AllowUserToResizeRows = false;
            this.Map.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.Map.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Map.ColumnHeadersVisible = false;
            this.Map.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25,
            this.Column26,
            this.Column27,
            this.Column28,
            this.Column29,
            this.Column30});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Map.DefaultCellStyle = dataGridViewCellStyle1;
            this.Map.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.Map.Location = new System.Drawing.Point(10, 20);
            this.Map.MultiSelect = false;
            this.Map.Name = "Map";
            this.Map.RowHeadersVisible = false;
            this.Map.RowTemplate.Height = 21;
            this.Map.Size = new System.Drawing.Size(634, 633);
            this.Map.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 10F;
            this.Column1.HeaderText = "1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 21;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 10F;
            this.Column2.HeaderText = "2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 21;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 10F;
            this.Column3.HeaderText = "3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 21;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.FillWeight = 10F;
            this.Column4.HeaderText = "4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 21;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.FillWeight = 10F;
            this.Column5.HeaderText = "5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 21;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.FillWeight = 10F;
            this.Column6.HeaderText = "6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 21;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.FillWeight = 10F;
            this.Column7.HeaderText = "7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Width = 21;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.FillWeight = 10F;
            this.Column8.HeaderText = "8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.Width = 21;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column9.FillWeight = 10F;
            this.Column9.HeaderText = "9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.Width = 21;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column10.FillWeight = 10F;
            this.Column10.HeaderText = "10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.Width = 21;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column11.FillWeight = 10F;
            this.Column11.HeaderText = "11";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column11.Width = 21;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column12.FillWeight = 10F;
            this.Column12.HeaderText = "12";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column12.Width = 21;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column13.FillWeight = 10F;
            this.Column13.HeaderText = "13";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column13.Width = 21;
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column14.FillWeight = 10F;
            this.Column14.HeaderText = "14";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column14.Width = 21;
            // 
            // Column15
            // 
            this.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column15.FillWeight = 10F;
            this.Column15.HeaderText = "15";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column15.Width = 5;
            // 
            // Column16
            // 
            this.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column16.FillWeight = 10F;
            this.Column16.HeaderText = "16";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column16.Width = 21;
            // 
            // Column17
            // 
            this.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column17.FillWeight = 10F;
            this.Column17.HeaderText = "17";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column17.Width = 21;
            // 
            // Column18
            // 
            this.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column18.FillWeight = 10F;
            this.Column18.HeaderText = "18";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column18.Width = 21;
            // 
            // Column19
            // 
            this.Column19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column19.FillWeight = 10F;
            this.Column19.HeaderText = "19";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column19.Width = 21;
            // 
            // Column20
            // 
            this.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column20.FillWeight = 10F;
            this.Column20.HeaderText = "20";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column20.Width = 21;
            // 
            // Column21
            // 
            this.Column21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column21.FillWeight = 10F;
            this.Column21.HeaderText = "21";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column21.Width = 21;
            // 
            // Column22
            // 
            this.Column22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column22.FillWeight = 10F;
            this.Column22.HeaderText = "22";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            this.Column22.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column22.Width = 21;
            // 
            // Column23
            // 
            this.Column23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column23.FillWeight = 10F;
            this.Column23.HeaderText = "23";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            this.Column23.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column23.Width = 21;
            // 
            // Column24
            // 
            this.Column24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column24.FillWeight = 10F;
            this.Column24.HeaderText = "24";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            this.Column24.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column24.Width = 21;
            // 
            // Column25
            // 
            this.Column25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column25.FillWeight = 10F;
            this.Column25.HeaderText = "25";
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            this.Column25.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column25.Width = 21;
            // 
            // Column26
            // 
            this.Column26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column26.FillWeight = 10F;
            this.Column26.HeaderText = "26";
            this.Column26.Name = "Column26";
            this.Column26.ReadOnly = true;
            this.Column26.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column26.Width = 21;
            // 
            // Column27
            // 
            this.Column27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column27.FillWeight = 10F;
            this.Column27.HeaderText = "27";
            this.Column27.Name = "Column27";
            this.Column27.ReadOnly = true;
            this.Column27.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column27.Width = 21;
            // 
            // Column28
            // 
            this.Column28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column28.FillWeight = 10F;
            this.Column28.HeaderText = "28";
            this.Column28.Name = "Column28";
            this.Column28.ReadOnly = true;
            this.Column28.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column28.Width = 21;
            // 
            // Column29
            // 
            this.Column29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column29.FillWeight = 10F;
            this.Column29.HeaderText = "29";
            this.Column29.Name = "Column29";
            this.Column29.ReadOnly = true;
            this.Column29.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column29.Width = 21;
            // 
            // Column30
            // 
            this.Column30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column30.FillWeight = 10F;
            this.Column30.HeaderText = "30";
            this.Column30.Name = "Column30";
            this.Column30.ReadOnly = true;
            this.Column30.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column30.Width = 21;
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
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(655, 35);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(64, 13);
            this.lblFileName.TabIndex = 19;
            this.lblFileName.Text = "Level Name";
            this.lblFileName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(725, 33);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(131, 20);
            this.txtLevel.TabIndex = 20;
            this.txtLevel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LevelDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(887, 756);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.lblFileName);
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
            this.MapContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
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
        private System.Windows.Forms.DataGridView Map;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn Column10;
        private System.Windows.Forms.DataGridViewImageColumn Column11;
        private System.Windows.Forms.DataGridViewImageColumn Column12;
        private System.Windows.Forms.DataGridViewImageColumn Column13;
        private System.Windows.Forms.DataGridViewImageColumn Column14;
        private System.Windows.Forms.DataGridViewImageColumn Column15;
        private System.Windows.Forms.DataGridViewImageColumn Column16;
        private System.Windows.Forms.DataGridViewImageColumn Column17;
        private System.Windows.Forms.DataGridViewImageColumn Column18;
        private System.Windows.Forms.DataGridViewImageColumn Column19;
        private System.Windows.Forms.DataGridViewImageColumn Column20;
        private System.Windows.Forms.DataGridViewImageColumn Column21;
        private System.Windows.Forms.DataGridViewImageColumn Column22;
        private System.Windows.Forms.DataGridViewImageColumn Column23;
        private System.Windows.Forms.DataGridViewImageColumn Column24;
        private System.Windows.Forms.DataGridViewImageColumn Column25;
        private System.Windows.Forms.DataGridViewImageColumn Column26;
        private System.Windows.Forms.DataGridViewImageColumn Column27;
        private System.Windows.Forms.DataGridViewImageColumn Column28;
        private System.Windows.Forms.DataGridViewImageColumn Column29;
        private System.Windows.Forms.DataGridViewImageColumn Column30;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtLevel;
    }
}