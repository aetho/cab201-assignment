namespace GUI_Class
{
    partial class SpaceRaceForm
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
			this.components = new System.ComponentModel.Container();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.grbSingleStep = new System.Windows.Forms.GroupBox();
			this.rbtnStepNo = new System.Windows.Forms.RadioButton();
			this.rbtnStepYes = new System.Windows.Forms.RadioButton();
			this.dgvPlayers = new System.Windows.Forms.DataGridView();
			this.playerTokenImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rocketFuelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cmbNumPlayers = new System.Windows.Forms.ComboBox();
			this.btnRoll = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.lblPlayers = new System.Windows.Forms.Label();
			this.lblNumPlayers = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.exitButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.grbSingleStep.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.grbSingleStep);
			this.splitContainer1.Panel2.Controls.Add(this.dgvPlayers);
			this.splitContainer1.Panel2.Controls.Add(this.cmbNumPlayers);
			this.splitContainer1.Panel2.Controls.Add(this.btnRoll);
			this.splitContainer1.Panel2.Controls.Add(this.btnReset);
			this.splitContainer1.Panel2.Controls.Add(this.lblPlayers);
			this.splitContainer1.Panel2.Controls.Add(this.lblNumPlayers);
			this.splitContainer1.Panel2.Controls.Add(this.lblTitle);
			this.splitContainer1.Panel2.Controls.Add(this.exitButton);
			this.splitContainer1.Size = new System.Drawing.Size(884, 661);
			this.splitContainer1.SplitterDistance = 664;
			this.splitContainer1.TabIndex = 0;
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AutoSize = true;
			this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel.ColumnCount = 8;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.95181F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.04819F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 7;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(664, 661);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// grbSingleStep
			// 
			this.grbSingleStep.BackColor = System.Drawing.SystemColors.ControlDark;
			this.grbSingleStep.Controls.Add(this.rbtnStepNo);
			this.grbSingleStep.Controls.Add(this.rbtnStepYes);
			this.grbSingleStep.Location = new System.Drawing.Point(38, 343);
			this.grbSingleStep.Name = "grbSingleStep";
			this.grbSingleStep.Size = new System.Drawing.Size(140, 65);
			this.grbSingleStep.TabIndex = 4;
			this.grbSingleStep.TabStop = false;
			this.grbSingleStep.Text = "Single Step?";
			// 
			// rbtnSingleNo
			// 
			this.rbtnStepNo.AutoSize = true;
			this.rbtnStepNo.Location = new System.Drawing.Point(19, 42);
			this.rbtnStepNo.Name = "rbtnSingleNo";
			this.rbtnStepNo.Size = new System.Drawing.Size(39, 17);
			this.rbtnStepNo.TabIndex = 0;
			this.rbtnStepNo.TabStop = true;
			this.rbtnStepNo.Text = "No";
			this.rbtnStepNo.UseVisualStyleBackColor = true;
			this.rbtnStepNo.CheckedChanged += new System.EventHandler(this.rbtnSingleNo_CheckedChanged);
			// 
			// rbtnStepYes
			// 
			this.rbtnStepYes.AutoSize = true;
			this.rbtnStepYes.Location = new System.Drawing.Point(19, 19);
			this.rbtnStepYes.Name = "rbtnStepYes";
			this.rbtnStepYes.Size = new System.Drawing.Size(43, 17);
			this.rbtnStepYes.TabIndex = 0;
			this.rbtnStepYes.TabStop = true;
			this.rbtnStepYes.Text = "Yes";
			this.rbtnStepYes.UseVisualStyleBackColor = true;
			this.rbtnStepYes.Click += new System.EventHandler(this.rbtnStepYes_Click);
			// 
			// dgvPlayers
			// 
			this.dgvPlayers.AllowUserToAddRows = false;
			this.dgvPlayers.AllowUserToDeleteRows = false;
			this.dgvPlayers.AutoGenerateColumns = false;
			this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerTokenImageDataGridViewImageColumn,
            this.nameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.rocketFuelDataGridViewTextBoxColumn});
			this.dgvPlayers.DataSource = this.playerBindingSource;
			this.dgvPlayers.Location = new System.Drawing.Point(10, 139);
			this.dgvPlayers.Name = "dgvPlayers";
			this.dgvPlayers.RowHeadersVisible = false;
			this.dgvPlayers.Size = new System.Drawing.Size(220, 170);
			this.dgvPlayers.TabIndex = 3;
			// 
			// playerTokenImageDataGridViewImageColumn
			// 
			this.playerTokenImageDataGridViewImageColumn.DataPropertyName = "PlayerTokenImage";
			this.playerTokenImageDataGridViewImageColumn.HeaderText = "";
			this.playerTokenImageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.playerTokenImageDataGridViewImageColumn.Name = "playerTokenImageDataGridViewImageColumn";
			this.playerTokenImageDataGridViewImageColumn.ReadOnly = true;
			this.playerTokenImageDataGridViewImageColumn.Width = 20;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// positionDataGridViewTextBoxColumn
			// 
			this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
			this.positionDataGridViewTextBoxColumn.HeaderText = "Square";
			this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
			this.positionDataGridViewTextBoxColumn.ReadOnly = true;
			this.positionDataGridViewTextBoxColumn.Width = 50;
			// 
			// rocketFuelDataGridViewTextBoxColumn
			// 
			this.rocketFuelDataGridViewTextBoxColumn.DataPropertyName = "RocketFuel";
			this.rocketFuelDataGridViewTextBoxColumn.HeaderText = "Fuel";
			this.rocketFuelDataGridViewTextBoxColumn.Name = "rocketFuelDataGridViewTextBoxColumn";
			this.rocketFuelDataGridViewTextBoxColumn.ReadOnly = true;
			this.rocketFuelDataGridViewTextBoxColumn.Width = 50;
			// 
			// playerBindingSource
			// 
			this.playerBindingSource.DataSource = typeof(Object_Classes.Player);
			// 
			// cmbNumPlayers
			// 
			this.cmbNumPlayers.FormattingEnabled = true;
			this.cmbNumPlayers.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
			this.cmbNumPlayers.Location = new System.Drawing.Point(126, 77);
			this.cmbNumPlayers.Name = "cmbNumPlayers";
			this.cmbNumPlayers.Size = new System.Drawing.Size(35, 21);
			this.cmbNumPlayers.TabIndex = 2;
			this.cmbNumPlayers.Text = "6";
			this.cmbNumPlayers.SelectedIndexChanged += new System.EventHandler(this.cmbNumPlayers_SelectedIndexChanged);
			// 
			// btnRoll
			// 
			this.btnRoll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRoll.Location = new System.Drawing.Point(71, 570);
			this.btnRoll.Name = "btnRoll";
			this.btnRoll.Size = new System.Drawing.Size(75, 23);
			this.btnRoll.TabIndex = 1;
			this.btnRoll.Text = "Roll Dice";
			this.btnRoll.UseVisualStyleBackColor = true;
			this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReset.Location = new System.Drawing.Point(29, 610);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 1;
			this.btnReset.Text = "Game Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// lblPlayers
			// 
			this.lblPlayers.AutoSize = true;
			this.lblPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayers.Location = new System.Drawing.Point(5, 110);
			this.lblPlayers.Name = "lblPlayers";
			this.lblPlayers.Size = new System.Drawing.Size(92, 26);
			this.lblPlayers.TabIndex = 0;
			this.lblPlayers.Text = "Players";
			// 
			// lblNumPlayers
			// 
			this.lblNumPlayers.AutoSize = true;
			this.lblNumPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumPlayers.Location = new System.Drawing.Point(10, 80);
			this.lblNumPlayers.Name = "lblNumPlayers";
			this.lblNumPlayers.Size = new System.Drawing.Size(110, 13);
			this.lblNumPlayers.TabIndex = 0;
			this.lblNumPlayers.Text = "Number of Players";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(5, 10);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(141, 26);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Space Race";
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.Location = new System.Drawing.Point(110, 610);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 0;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// SpaceRaceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 661);
			this.Controls.Add(this.splitContainer1);
			this.Name = "SpaceRaceForm";
			this.Text = "Space Race";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.grbSingleStep.ResumeLayout(false);
			this.grbSingleStep.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label lblPlayers;
		private System.Windows.Forms.Label lblNumPlayers;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.ComboBox cmbNumPlayers;
		private System.Windows.Forms.Button btnRoll;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.DataGridView dgvPlayers;
		private System.Windows.Forms.BindingSource playerBindingSource;
		private System.Windows.Forms.DataGridViewImageColumn playerTokenImageDataGridViewImageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rocketFuelDataGridViewTextBoxColumn;
		private System.Windows.Forms.GroupBox grbSingleStep;
		private System.Windows.Forms.RadioButton rbtnStepNo;
		private System.Windows.Forms.RadioButton rbtnStepYes;
	}
}

