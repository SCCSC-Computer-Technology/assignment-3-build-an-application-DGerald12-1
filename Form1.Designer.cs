namespace DGerald_CPT_206_A80S_Lab_3_StatesDatabase
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.stateDBDataSet = new DGerald_CPT_206_A80S_Lab_3_StatesDatabase.StateDBDataSet();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateTableAdapter = new DGerald_CPT_206_A80S_Lab_3_StatesDatabase.StateDBDataSetTableAdapters.StateTableAdapter();
            this.tableAdapterManager = new DGerald_CPT_206_A80S_Lab_3_StatesDatabase.StateDBDataSetTableAdapters.TableAdapterManager();
            this.stateBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stateBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stateDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stateBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.stateNameListBox = new System.Windows.Forms.ListBox();
            this.stateBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.exit_1Button = new System.Windows.Forms.Button();
            this.deatailsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingNavigator)).BeginInit();
            this.stateBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // stateDBDataSet
            // 
            this.stateDBDataSet.DataSetName = "StateDBDataSet";
            this.stateDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataMember = "State";
            this.stateBindingSource.DataSource = this.stateDBDataSet;
            // 
            // stateTableAdapter
            // 
            this.stateTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StateTableAdapter = this.stateTableAdapter;
            this.tableAdapterManager.UpdateOrder = DGerald_CPT_206_A80S_Lab_3_StatesDatabase.StateDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stateBindingNavigator
            // 
            this.stateBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stateBindingNavigator.BindingSource = this.stateBindingSource;
            this.stateBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stateBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stateBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stateBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.stateBindingNavigatorSaveItem});
            this.stateBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stateBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stateBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stateBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stateBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stateBindingNavigator.Name = "stateBindingNavigator";
            this.stateBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stateBindingNavigator.Size = new System.Drawing.Size(1690, 34);
            this.stateBindingNavigator.TabIndex = 0;
            this.stateBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 31);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 31);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 31);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 31);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 31);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 34);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(106, 34);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 31);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 31);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // stateBindingNavigatorSaveItem
            // 
            this.stateBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stateBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stateBindingNavigatorSaveItem.Image")));
            this.stateBindingNavigatorSaveItem.Name = "stateBindingNavigatorSaveItem";
            this.stateBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 31);
            this.stateBindingNavigatorSaveItem.Text = "Save Data";
            this.stateBindingNavigatorSaveItem.Click += new System.EventHandler(this.stateBindingNavigatorSaveItem_Click);
            // 
            // stateBindingSource1
            // 
            this.stateBindingSource1.DataMember = "State";
            this.stateBindingSource1.DataSource = this.stateDBDataSet;
            // 
            // stateDBDataSetBindingSource
            // 
            this.stateDBDataSetBindingSource.DataSource = this.stateDBDataSet;
            this.stateDBDataSetBindingSource.Position = 0;
            // 
            // stateBindingSource2
            // 
            this.stateBindingSource2.DataMember = "State";
            this.stateBindingSource2.DataSource = this.stateDBDataSetBindingSource;
            // 
            // stateBindingSource3
            // 
            this.stateBindingSource3.DataMember = "State";
            this.stateBindingSource3.DataSource = this.stateDBDataSet;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 91);
            this.label2.TabIndex = 22;
            this.label2.Text = "Select one of the following states";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateNameListBox
            // 
            this.stateNameListBox.DataSource = this.stateBindingSource;
            this.stateNameListBox.DisplayMember = "Name";
            this.stateNameListBox.FormattingEnabled = true;
            this.stateNameListBox.ItemHeight = 20;
            this.stateNameListBox.Location = new System.Drawing.Point(38, 208);
            this.stateNameListBox.Name = "stateNameListBox";
            this.stateNameListBox.Size = new System.Drawing.Size(510, 344);
            this.stateNameListBox.TabIndex = 23;
            // 
            // stateBindingSource4
            // 
            this.stateBindingSource4.DataMember = "State";
            this.stateBindingSource4.DataSource = this.stateDBDataSet;
            // 
            // exit_1Button
            // 
            this.exit_1Button.BackColor = System.Drawing.Color.Red;
            this.exit_1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_1Button.Location = new System.Drawing.Point(38, 558);
            this.exit_1Button.Name = "exit_1Button";
            this.exit_1Button.Size = new System.Drawing.Size(510, 163);
            this.exit_1Button.TabIndex = 34;
            this.exit_1Button.Text = "EXIT";
            this.exit_1Button.UseVisualStyleBackColor = false;
            this.exit_1Button.Click += new System.EventHandler(this.exit_1Button_Click);
            // 
            // deatailsButton
            // 
            this.deatailsButton.Location = new System.Drawing.Point(596, 240);
            this.deatailsButton.Name = "deatailsButton";
            this.deatailsButton.Size = new System.Drawing.Size(130, 61);
            this.deatailsButton.TabIndex = 35;
            this.deatailsButton.Text = "Show Details";
            this.deatailsButton.UseVisualStyleBackColor = true;
            this.deatailsButton.Click += new System.EventHandler(this.deatailsButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 65);
            this.button1.TabIndex = 36;
            this.button1.Text = "Show All States";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 58);
            this.button2.TabIndex = 37;
            this.button2.Text = "States Descend";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 741);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deatailsButton);
            this.Controls.Add(this.exit_1Button);
            this.Controls.Add(this.stateNameListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stateBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "DGerald-Lab-3-StatesDatabase";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingNavigator)).EndInit();
            this.stateBindingNavigator.ResumeLayout(false);
            this.stateBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StateDBDataSet stateDBDataSet;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private StateDBDataSetTableAdapters.StateTableAdapter stateTableAdapter;
        private StateDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stateBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton stateBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource stateBindingSource1;
        private System.Windows.Forms.BindingSource stateDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource stateBindingSource2;
        private System.Windows.Forms.BindingSource stateBindingSource3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox stateNameListBox;
        private System.Windows.Forms.BindingSource stateBindingSource4;
        private System.Windows.Forms.Button exit_1Button;
        private System.Windows.Forms.Button deatailsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

