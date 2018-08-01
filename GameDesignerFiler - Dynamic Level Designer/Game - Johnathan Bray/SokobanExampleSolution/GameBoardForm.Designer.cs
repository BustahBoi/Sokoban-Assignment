namespace SokobanExampleSolution
{
    partial class GameBoardForm
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
            this.LoadGameButton = new System.Windows.Forms.Button();
            this.gameMap = new System.Windows.Forms.TableLayoutPanel();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.MoveCountNumber = new System.Windows.Forms.Label();
            this.PlayerMoveHistoryLabel = new System.Windows.Forms.Label();
            this.PlayerMoveHistory = new System.Windows.Forms.Label();
            this.undoButton = new System.Windows.Forms.Button();
            this.MoveCountLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.staticGameCheckBox = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadGameButton
            // 
            this.LoadGameButton.Location = new System.Drawing.Point(12, 12);
            this.LoadGameButton.Name = "LoadGameButton";
            this.LoadGameButton.Size = new System.Drawing.Size(75, 23);
            this.LoadGameButton.TabIndex = 0;
            this.LoadGameButton.Text = "Load Game";
            this.LoadGameButton.UseVisualStyleBackColor = true;
            this.LoadGameButton.Click += new System.EventHandler(this.Loadbutton_Click);
            // 
            // gameMap
            // 
            this.gameMap.AutoSize = true;
            this.gameMap.BackColor = System.Drawing.Color.Linen;
            this.gameMap.ColumnCount = 10;
            this.gameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.Location = new System.Drawing.Point(12, 161);
            this.gameMap.Name = "gameMap";
            this.gameMap.Padding = new System.Windows.Forms.Padding(20);
            this.gameMap.RowCount = 10;
            this.gameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameMap.Size = new System.Drawing.Size(131, 132);
            this.gameMap.TabIndex = 1;
            this.gameMap.Visible = false;
            // 
            // StartGameButton
            // 
            this.StartGameButton.Enabled = false;
            this.StartGameButton.Location = new System.Drawing.Point(93, 12);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(75, 23);
            this.StartGameButton.TabIndex = 2;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(281, 12);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MoveCountNumber
            // 
            this.MoveCountNumber.AutoSize = true;
            this.MoveCountNumber.Location = new System.Drawing.Point(123, 116);
            this.MoveCountNumber.Name = "MoveCountNumber";
            this.MoveCountNumber.Size = new System.Drawing.Size(13, 13);
            this.MoveCountNumber.TabIndex = 5;
            this.MoveCountNumber.Text = "0";
            // 
            // PlayerMoveHistoryLabel
            // 
            this.PlayerMoveHistoryLabel.AutoSize = true;
            this.PlayerMoveHistoryLabel.Enabled = false;
            this.PlayerMoveHistoryLabel.Location = new System.Drawing.Point(12, 74);
            this.PlayerMoveHistoryLabel.Name = "PlayerMoveHistoryLabel";
            this.PlayerMoveHistoryLabel.Size = new System.Drawing.Size(104, 13);
            this.PlayerMoveHistoryLabel.TabIndex = 6;
            this.PlayerMoveHistoryLabel.Text = "Player Move History:";
            // 
            // PlayerMoveHistory
            // 
            this.PlayerMoveHistory.AutoSize = true;
            this.PlayerMoveHistory.Enabled = false;
            this.PlayerMoveHistory.Location = new System.Drawing.Point(123, 74);
            this.PlayerMoveHistory.Name = "PlayerMoveHistory";
            this.PlayerMoveHistory.Size = new System.Drawing.Size(33, 13);
            this.PlayerMoveHistory.TabIndex = 7;
            this.PlayerMoveHistory.Text = "None";
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(363, 12);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(75, 23);
            this.undoButton.TabIndex = 8;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // MoveCountLabel
            // 
            this.MoveCountLabel.AutoSize = true;
            this.MoveCountLabel.Location = new System.Drawing.Point(48, 116);
            this.MoveCountLabel.Name = "MoveCountLabel";
            this.MoveCountLabel.Size = new System.Drawing.Size(68, 13);
            this.MoveCountLabel.TabIndex = 4;
            this.MoveCountLabel.Text = "Move Count:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.InitialDirectory = "@\"C:\\\"";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Browse Files";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(174, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // staticGameCheckBox
            // 
            this.staticGameCheckBox.AutoSize = true;
            this.staticGameCheckBox.Location = new System.Drawing.Point(15, 42);
            this.staticGameCheckBox.Name = "staticGameCheckBox";
            this.staticGameCheckBox.Size = new System.Drawing.Size(114, 17);
            this.staticGameCheckBox.TabIndex = 10;
            this.staticGameCheckBox.Text = "Static Game Mode";
            this.staticGameCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(610, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GameBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(697, 608);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.staticGameCheckBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.PlayerMoveHistory);
            this.Controls.Add(this.PlayerMoveHistoryLabel);
            this.Controls.Add(this.MoveCountNumber);
            this.Controls.Add(this.MoveCountLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.gameMap);
            this.Controls.Add(this.LoadGameButton);
            this.KeyPreview = true;
            this.Name = "GameBoardForm";
            this.Text = "GameBoardForm";
            this.Load += new System.EventHandler(this.GameBoardForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameBoardForm_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Control_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadGameButton;
        private System.Windows.Forms.TableLayoutPanel gameMap;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label MoveCountNumber;
        private System.Windows.Forms.Label PlayerMoveHistoryLabel;
        private System.Windows.Forms.Label PlayerMoveHistory;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Label MoveCountLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox staticGameCheckBox;
        private System.Windows.Forms.Button btnClose;
    }
}