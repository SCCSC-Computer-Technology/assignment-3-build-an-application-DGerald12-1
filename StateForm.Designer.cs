namespace DGerald_CPT_206_A80S_Lab_3_States_DB
{
    partial class StateForm
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
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateDBDataSet = new DGerald_CPT_206_A80S_Lab_3_States_DB.StateDBDataSet();
            this.stateTableAdapter = new DGerald_CPT_206_A80S_Lab_3_States_DB.StateDBDataSetTableAdapters.StateTableAdapter();
            this.tableAdapterManager = new DGerald_CPT_206_A80S_Lab_3_States_DB.StateDBDataSetTableAdapters.TableAdapterManager();
            this.stateDataGridView = new System.Windows.Forms.DataGridView();
            this.stateIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateFlowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateBirdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateColorsifAnyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threeLargestCitiesPerStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateMedianIncomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerRelatedJobsPerStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.compJobsButton = new System.Windows.Forms.Button();
            this.noOfficialColorsButton = new System.Windows.Forms.Button();
            this.sumPopulationButton = new System.Windows.Forms.Button();
            this.AvgMedianButton = new System.Windows.Forms.Button();
            this.medianAbove_75k_Button = new System.Windows.Forms.Button();
            this.medianAbove_50k_Button = new System.Windows.Forms.Button();
            this.filterBy_1MButton = new System.Windows.Forms.Button();
            this.filterBy_5MButton = new System.Windows.Forms.Button();
            this.filterBy_10MButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.capitalComboBox = new System.Windows.Forms.ComboBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.capitalLabel = new System.Windows.Forms.Label();
            this.switchButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.stateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataMember = "State";
            this.stateBindingSource.DataSource = this.stateDBDataSet;
            // 
            // stateDBDataSet
            // 
            this.stateDBDataSet.DataSetName = "StateDBDataSet";
            this.stateDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stateTableAdapter
            // 
            this.stateTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StateTableAdapter = this.stateTableAdapter;
            this.tableAdapterManager.UpdateOrder = DGerald_CPT_206_A80S_Lab_3_States_DB.StateDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stateDataGridView
            // 
            this.stateDataGridView.AutoGenerateColumns = false;
            this.stateDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.stateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stateIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn,
            this.capitalDataGridViewTextBoxColumn,
            this.stateFlowerDataGridViewTextBoxColumn,
            this.stateBirdDataGridViewTextBoxColumn,
            this.stateColorsifAnyDataGridViewTextBoxColumn,
            this.threeLargestCitiesPerStateDataGridViewTextBoxColumn,
            this.stateMedianIncomeDataGridViewTextBoxColumn,
            this.computerRelatedJobsPerStateDataGridViewTextBoxColumn});
            this.stateDataGridView.DataSource = this.stateBindingSource;
            this.stateDataGridView.Location = new System.Drawing.Point(4, 12);
            this.stateDataGridView.Name = "stateDataGridView";
            this.stateDataGridView.RowHeadersWidth = 51;
            this.stateDataGridView.RowTemplate.Height = 24;
            this.stateDataGridView.Size = new System.Drawing.Size(1305, 378);
            this.stateDataGridView.TabIndex = 5;
            // 
            // stateIdDataGridViewTextBoxColumn
            // 
            this.stateIdDataGridViewTextBoxColumn.DataPropertyName = "StateId";
            this.stateIdDataGridViewTextBoxColumn.HeaderText = "StateId";
            this.stateIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateIdDataGridViewTextBoxColumn.Name = "stateIdDataGridViewTextBoxColumn";
            this.stateIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            this.populationDataGridViewTextBoxColumn.Width = 125;
            // 
            // capitalDataGridViewTextBoxColumn
            // 
            this.capitalDataGridViewTextBoxColumn.DataPropertyName = "Capital";
            this.capitalDataGridViewTextBoxColumn.HeaderText = "Capital";
            this.capitalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capitalDataGridViewTextBoxColumn.Name = "capitalDataGridViewTextBoxColumn";
            this.capitalDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateFlowerDataGridViewTextBoxColumn
            // 
            this.stateFlowerDataGridViewTextBoxColumn.DataPropertyName = "State Flower";
            this.stateFlowerDataGridViewTextBoxColumn.HeaderText = "State Flower";
            this.stateFlowerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateFlowerDataGridViewTextBoxColumn.Name = "stateFlowerDataGridViewTextBoxColumn";
            this.stateFlowerDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateBirdDataGridViewTextBoxColumn
            // 
            this.stateBirdDataGridViewTextBoxColumn.DataPropertyName = "State Bird";
            this.stateBirdDataGridViewTextBoxColumn.HeaderText = "State Bird";
            this.stateBirdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateBirdDataGridViewTextBoxColumn.Name = "stateBirdDataGridViewTextBoxColumn";
            this.stateBirdDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateColorsifAnyDataGridViewTextBoxColumn
            // 
            this.stateColorsifAnyDataGridViewTextBoxColumn.DataPropertyName = "State Colors (if any)";
            this.stateColorsifAnyDataGridViewTextBoxColumn.HeaderText = "State Colors (if any)";
            this.stateColorsifAnyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateColorsifAnyDataGridViewTextBoxColumn.Name = "stateColorsifAnyDataGridViewTextBoxColumn";
            this.stateColorsifAnyDataGridViewTextBoxColumn.Width = 125;
            // 
            // threeLargestCitiesPerStateDataGridViewTextBoxColumn
            // 
            this.threeLargestCitiesPerStateDataGridViewTextBoxColumn.DataPropertyName = "Three Largest Cities Per State";
            this.threeLargestCitiesPerStateDataGridViewTextBoxColumn.HeaderText = "Three Largest Cities Per State";
            this.threeLargestCitiesPerStateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.threeLargestCitiesPerStateDataGridViewTextBoxColumn.Name = "threeLargestCitiesPerStateDataGridViewTextBoxColumn";
            this.threeLargestCitiesPerStateDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateMedianIncomeDataGridViewTextBoxColumn
            // 
            this.stateMedianIncomeDataGridViewTextBoxColumn.DataPropertyName = "State Median Income";
            this.stateMedianIncomeDataGridViewTextBoxColumn.HeaderText = "State Median Income";
            this.stateMedianIncomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateMedianIncomeDataGridViewTextBoxColumn.Name = "stateMedianIncomeDataGridViewTextBoxColumn";
            this.stateMedianIncomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // computerRelatedJobsPerStateDataGridViewTextBoxColumn
            // 
            this.computerRelatedJobsPerStateDataGridViewTextBoxColumn.DataPropertyName = "Computer-Related Jobs Per State (%)";
            this.computerRelatedJobsPerStateDataGridViewTextBoxColumn.HeaderText = "Computer-Related Jobs Per State (%)";
            this.computerRelatedJobsPerStateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.computerRelatedJobsPerStateDataGridViewTextBoxColumn.Name = "computerRelatedJobsPerStateDataGridViewTextBoxColumn";
            this.computerRelatedJobsPerStateDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateBindingSource1
            // 
            this.stateBindingSource1.DataMember = "State";
            this.stateBindingSource1.DataSource = this.stateDBDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Controls.Add(this.exitPictureBox);
            this.panel1.Controls.Add(this.compJobsButton);
            this.panel1.Controls.Add(this.noOfficialColorsButton);
            this.panel1.Controls.Add(this.sumPopulationButton);
            this.panel1.Controls.Add(this.AvgMedianButton);
            this.panel1.Controls.Add(this.medianAbove_75k_Button);
            this.panel1.Controls.Add(this.medianAbove_50k_Button);
            this.panel1.Controls.Add(this.filterBy_1MButton);
            this.panel1.Controls.Add(this.filterBy_5MButton);
            this.panel1.Controls.Add(this.filterBy_10MButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.capitalComboBox);
            this.panel1.Controls.Add(this.stateComboBox);
            this.panel1.Controls.Add(this.capitalLabel);
            this.panel1.Controls.Add(this.switchButton);
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.stateLabel);
            this.panel1.Location = new System.Drawing.Point(4, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 407);
            this.panel1.TabIndex = 10;
            // 
            // exitLabel
            // 
            this.exitLabel.BackColor = System.Drawing.Color.IndianRed;
            this.exitLabel.Font = new System.Drawing.Font("HP Simplified", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitLabel.Location = new System.Drawing.Point(1036, 196);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(189, 84);
            this.exitLabel.TabIndex = 27;
            this.exitLabel.Text = "EXIT";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitPictureBox.Image = global::DGerald_CPT_206_A80S_Lab_3_States_DB.Properties.Resources.Stop_1;
            this.exitPictureBox.Location = new System.Drawing.Point(989, 93);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(280, 279);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitPictureBox.TabIndex = 26;
            this.exitPictureBox.TabStop = false;
            // 
            // compJobsButton
            // 
            this.compJobsButton.Font = new System.Drawing.Font("HP Simplified", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compJobsButton.Location = new System.Drawing.Point(772, 302);
            this.compJobsButton.Name = "compJobsButton";
            this.compJobsButton.Size = new System.Drawing.Size(102, 57);
            this.compJobsButton.TabIndex = 25;
            this.compJobsButton.Text = "Average Tech Jobs";
            this.compJobsButton.UseVisualStyleBackColor = true;
            this.compJobsButton.Click += new System.EventHandler(this.compJobsButton_Click);
            // 
            // noOfficialColorsButton
            // 
            this.noOfficialColorsButton.Font = new System.Drawing.Font("HP Simplified", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfficialColorsButton.Location = new System.Drawing.Point(772, 198);
            this.noOfficialColorsButton.Name = "noOfficialColorsButton";
            this.noOfficialColorsButton.Size = new System.Drawing.Size(102, 57);
            this.noOfficialColorsButton.TabIndex = 24;
            this.noOfficialColorsButton.Text = "No Official Colors";
            this.noOfficialColorsButton.UseVisualStyleBackColor = true;
            this.noOfficialColorsButton.Click += new System.EventHandler(this.noOfficialColorsButton_Click);
            // 
            // sumPopulationButton
            // 
            this.sumPopulationButton.Font = new System.Drawing.Font("HP Simplified", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumPopulationButton.Location = new System.Drawing.Point(772, 93);
            this.sumPopulationButton.Name = "sumPopulationButton";
            this.sumPopulationButton.Size = new System.Drawing.Size(102, 57);
            this.sumPopulationButton.TabIndex = 23;
            this.sumPopulationButton.Text = "Total Population";
            this.sumPopulationButton.UseVisualStyleBackColor = true;
            this.sumPopulationButton.Click += new System.EventHandler(this.sumPopulationButton_Click);
            // 
            // AvgMedianButton
            // 
            this.AvgMedianButton.Font = new System.Drawing.Font("HP Simplified", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgMedianButton.Location = new System.Drawing.Point(644, 302);
            this.AvgMedianButton.Name = "AvgMedianButton";
            this.AvgMedianButton.Size = new System.Drawing.Size(102, 57);
            this.AvgMedianButton.TabIndex = 22;
            this.AvgMedianButton.Text = "Average Median";
            this.AvgMedianButton.UseVisualStyleBackColor = true;
            this.AvgMedianButton.Click += new System.EventHandler(this.AvgMedianButton_Click);
            // 
            // medianAbove_75k_Button
            // 
            this.medianAbove_75k_Button.Font = new System.Drawing.Font("HP Simplified", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medianAbove_75k_Button.Location = new System.Drawing.Point(644, 196);
            this.medianAbove_75k_Button.Name = "medianAbove_75k_Button";
            this.medianAbove_75k_Button.Size = new System.Drawing.Size(102, 59);
            this.medianAbove_75k_Button.TabIndex = 21;
            this.medianAbove_75k_Button.Text = "Median > 75k";
            this.medianAbove_75k_Button.UseVisualStyleBackColor = true;
            this.medianAbove_75k_Button.Click += new System.EventHandler(this.medianAbove_75k_Button_Click);
            // 
            // medianAbove_50k_Button
            // 
            this.medianAbove_50k_Button.Font = new System.Drawing.Font("HP Simplified", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medianAbove_50k_Button.Location = new System.Drawing.Point(644, 93);
            this.medianAbove_50k_Button.Name = "medianAbove_50k_Button";
            this.medianAbove_50k_Button.Size = new System.Drawing.Size(102, 57);
            this.medianAbove_50k_Button.TabIndex = 20;
            this.medianAbove_50k_Button.Text = "Median > 50k";
            this.medianAbove_50k_Button.UseVisualStyleBackColor = true;
            this.medianAbove_50k_Button.Click += new System.EventHandler(this.medianAbove_50k_Button_Click);
            // 
            // filterBy_1MButton
            // 
            this.filterBy_1MButton.Font = new System.Drawing.Font("HP Simplified", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBy_1MButton.Location = new System.Drawing.Point(508, 302);
            this.filterBy_1MButton.Name = "filterBy_1MButton";
            this.filterBy_1MButton.Size = new System.Drawing.Size(102, 57);
            this.filterBy_1MButton.TabIndex = 19;
            this.filterBy_1MButton.Text = "Pop < 1M";
            this.filterBy_1MButton.UseVisualStyleBackColor = true;
            this.filterBy_1MButton.Click += new System.EventHandler(this.filterBy_1MButton_Click);
            // 
            // filterBy_5MButton
            // 
            this.filterBy_5MButton.Font = new System.Drawing.Font("HP Simplified", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBy_5MButton.Location = new System.Drawing.Point(508, 196);
            this.filterBy_5MButton.Name = "filterBy_5MButton";
            this.filterBy_5MButton.Size = new System.Drawing.Size(102, 59);
            this.filterBy_5MButton.TabIndex = 18;
            this.filterBy_5MButton.Text = "Pop > 5M";
            this.filterBy_5MButton.UseVisualStyleBackColor = true;
            this.filterBy_5MButton.Click += new System.EventHandler(this.filterBy_5MButton_Click);
            // 
            // filterBy_10MButton
            // 
            this.filterBy_10MButton.Font = new System.Drawing.Font("HP Simplified", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBy_10MButton.Location = new System.Drawing.Point(508, 93);
            this.filterBy_10MButton.Name = "filterBy_10MButton";
            this.filterBy_10MButton.Size = new System.Drawing.Size(102, 57);
            this.filterBy_10MButton.TabIndex = 17;
            this.filterBy_10MButton.Text = "Pop > 10M";
            this.filterBy_10MButton.UseVisualStyleBackColor = true;
            this.filterBy_10MButton.Click += new System.EventHandler(this.filterBy_10MButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HP Simplified", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(502, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "FILTER:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(470, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 377);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // capitalComboBox
            // 
            this.capitalComboBox.DataSource = this.stateBindingSource;
            this.capitalComboBox.DisplayMember = "Capital";
            this.capitalComboBox.Font = new System.Drawing.Font("HP Simplified", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capitalComboBox.FormattingEnabled = true;
            this.capitalComboBox.Location = new System.Drawing.Point(278, 113);
            this.capitalComboBox.Name = "capitalComboBox";
            this.capitalComboBox.Size = new System.Drawing.Size(167, 34);
            this.capitalComboBox.TabIndex = 13;
            this.capitalComboBox.Visible = false;
            this.capitalComboBox.SelectedIndexChanged += new System.EventHandler(this.capitalComboBox_SelectedIndexChanged);
            // 
            // stateComboBox
            // 
            this.stateComboBox.DataSource = this.stateBindingSource;
            this.stateComboBox.DisplayMember = "Name";
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.Font = new System.Drawing.Font("HP Simplified", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(42, 113);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(167, 34);
            this.stateComboBox.TabIndex = 11;
            this.stateComboBox.ValueMember = "Name";
            this.stateComboBox.Visible = false;
            this.stateComboBox.SelectedIndexChanged += new System.EventHandler(this.stateComboBox_SelectedIndexChanged);
            // 
            // capitalLabel
            // 
            this.capitalLabel.Font = new System.Drawing.Font("HP Simplified", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capitalLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.capitalLabel.Location = new System.Drawing.Point(273, 33);
            this.capitalLabel.Name = "capitalLabel";
            this.capitalLabel.Size = new System.Drawing.Size(183, 54);
            this.capitalLabel.TabIndex = 12;
            this.capitalLabel.Text = "Select by Capital:";
            this.capitalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.capitalLabel.Click += new System.EventHandler(this.capitalLabel_Click);
            // 
            // switchButton
            // 
            this.switchButton.Font = new System.Drawing.Font("HP Simplified", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchButton.Location = new System.Drawing.Point(37, 196);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(411, 84);
            this.switchButton.TabIndex = 9;
            this.switchButton.Text = "Click For More Details   --->";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Gold;
            this.resetButton.Font = new System.Drawing.Font("HP Simplified", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(37, 287);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(411, 84);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // stateLabel
            // 
            this.stateLabel.Font = new System.Drawing.Font("HP Simplified", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.stateLabel.Location = new System.Drawing.Point(37, 33);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(167, 55);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "Select by State:";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stateLabel.Click += new System.EventHandler(this.stateLabel_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(921, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 377);
            this.label4.TabIndex = 28;
            this.label4.Text = "label4";
            // 
            // StateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 815);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stateDataGridView);
            this.Font = new System.Drawing.Font("HP Simplified", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DGerald-CPT-206-Lab-3-State-Database";
            this.Load += new System.EventHandler(this.StateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private StateDBDataSet stateDBDataSet;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private StateDBDataSetTableAdapters.StateTableAdapter stateTableAdapter;
        private StateDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView stateDataGridView;
        private System.Windows.Forms.BindingSource stateBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateFlowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateBirdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateColorsifAnyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn threeLargestCitiesPerStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateMedianIncomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerRelatedJobsPerStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox capitalComboBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Label capitalLabel;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filterBy_5MButton;
        private System.Windows.Forms.Button filterBy_10MButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button compJobsButton;
        private System.Windows.Forms.Button noOfficialColorsButton;
        private System.Windows.Forms.Button sumPopulationButton;
        private System.Windows.Forms.Button AvgMedianButton;
        private System.Windows.Forms.Button medianAbove_75k_Button;
        private System.Windows.Forms.Button medianAbove_50k_Button;
        private System.Windows.Forms.Button filterBy_1MButton;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label label4;
    }
}