namespace DGerald_CPT_206_A80S_Lab_3_StatesDatabase
{
    partial class DetailsForm
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
            System.Windows.Forms.Label state_FlowerLabel1;
            System.Windows.Forms.Label state_BirdLabel1;
            System.Windows.Forms.Label state_Colors__if_any_Label1;
            System.Windows.Forms.Label three_Largest_Cities_Per_StateLabel1;
            System.Windows.Forms.Label state_Median_IncomeLabel1;
            System.Windows.Forms.Label computer_Related_Jobs_Per_State____Label1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.stateDBDataSet = new DGerald_CPT_206_A80S_Lab_3_StatesDatabase.StateDBDataSet();
            this.stateDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateTableAdapter = new DGerald_CPT_206_A80S_Lab_3_StatesDatabase.StateDBDataSetTableAdapters.StateTableAdapter();
            this.tableAdapterManager = new DGerald_CPT_206_A80S_Lab_3_StatesDatabase.StateDBDataSetTableAdapters.TableAdapterManager();
            this.state_BirdTextBox1 = new System.Windows.Forms.TextBox();
            this.state_Colors__if_any_TextBox1 = new System.Windows.Forms.TextBox();
            this.three_Largest_Cities_Per_StateTextBox1 = new System.Windows.Forms.TextBox();
            this.state_Median_IncomeTextBox1 = new System.Windows.Forms.TextBox();
            this.computer_Related_Jobs_Per_State____TextBox1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            state_FlowerLabel1 = new System.Windows.Forms.Label();
            state_BirdLabel1 = new System.Windows.Forms.Label();
            state_Colors__if_any_Label1 = new System.Windows.Forms.Label();
            three_Largest_Cities_Per_StateLabel1 = new System.Windows.Forms.Label();
            state_Median_IncomeLabel1 = new System.Windows.Forms.Label();
            computer_Related_Jobs_Per_State____Label1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stateDBDataSet
            // 
            this.stateDBDataSet.DataSetName = "StateDBDataSet";
            this.stateDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stateDBDataSetBindingSource
            // 
            this.stateDBDataSetBindingSource.DataSource = this.stateDBDataSet;
            this.stateDBDataSetBindingSource.Position = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(375, 524);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(151, 70);
            this.closeButton.TabIndex = 74;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
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
            // state_FlowerLabel1
            // 
            state_FlowerLabel1.Location = new System.Drawing.Point(233, 229);
            state_FlowerLabel1.Name = "state_FlowerLabel1";
            state_FlowerLabel1.Size = new System.Drawing.Size(231, 16);
            state_FlowerLabel1.TabIndex = 82;
            state_FlowerLabel1.Text = "State Flower:";
            state_FlowerLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // state_BirdLabel1
            // 
            state_BirdLabel1.Location = new System.Drawing.Point(233, 257);
            state_BirdLabel1.Name = "state_BirdLabel1";
            state_BirdLabel1.Size = new System.Drawing.Size(234, 16);
            state_BirdLabel1.TabIndex = 84;
            state_BirdLabel1.Text = "State Bird:";
            state_BirdLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // state_BirdTextBox1
            // 
            this.state_BirdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateBindingSource, "State Bird", true));
            this.state_BirdTextBox1.Location = new System.Drawing.Point(473, 254);
            this.state_BirdTextBox1.Name = "state_BirdTextBox1";
            this.state_BirdTextBox1.Size = new System.Drawing.Size(282, 22);
            this.state_BirdTextBox1.TabIndex = 85;
            // 
            // state_Colors__if_any_Label1
            // 
            state_Colors__if_any_Label1.Location = new System.Drawing.Point(233, 285);
            state_Colors__if_any_Label1.Name = "state_Colors__if_any_Label1";
            state_Colors__if_any_Label1.Size = new System.Drawing.Size(234, 16);
            state_Colors__if_any_Label1.TabIndex = 86;
            state_Colors__if_any_Label1.Text = "State Colors (if any):";
            state_Colors__if_any_Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // state_Colors__if_any_TextBox1
            // 
            this.state_Colors__if_any_TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateBindingSource, "State Colors (if any)", true));
            this.state_Colors__if_any_TextBox1.Location = new System.Drawing.Point(473, 282);
            this.state_Colors__if_any_TextBox1.Name = "state_Colors__if_any_TextBox1";
            this.state_Colors__if_any_TextBox1.Size = new System.Drawing.Size(282, 22);
            this.state_Colors__if_any_TextBox1.TabIndex = 87;
            // 
            // three_Largest_Cities_Per_StateLabel1
            // 
            three_Largest_Cities_Per_StateLabel1.Location = new System.Drawing.Point(233, 313);
            three_Largest_Cities_Per_StateLabel1.Name = "three_Largest_Cities_Per_StateLabel1";
            three_Largest_Cities_Per_StateLabel1.Size = new System.Drawing.Size(234, 16);
            three_Largest_Cities_Per_StateLabel1.TabIndex = 88;
            three_Largest_Cities_Per_StateLabel1.Text = "Three Largest Cities Per State:";
            three_Largest_Cities_Per_StateLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // three_Largest_Cities_Per_StateTextBox1
            // 
            this.three_Largest_Cities_Per_StateTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateBindingSource, "Three Largest Cities Per State", true));
            this.three_Largest_Cities_Per_StateTextBox1.Location = new System.Drawing.Point(473, 310);
            this.three_Largest_Cities_Per_StateTextBox1.Name = "three_Largest_Cities_Per_StateTextBox1";
            this.three_Largest_Cities_Per_StateTextBox1.Size = new System.Drawing.Size(282, 22);
            this.three_Largest_Cities_Per_StateTextBox1.TabIndex = 89;
            // 
            // state_Median_IncomeLabel1
            // 
            state_Median_IncomeLabel1.Location = new System.Drawing.Point(233, 343);
            state_Median_IncomeLabel1.Name = "state_Median_IncomeLabel1";
            state_Median_IncomeLabel1.Size = new System.Drawing.Size(234, 20);
            state_Median_IncomeLabel1.TabIndex = 90;
            state_Median_IncomeLabel1.Text = "State Median Income:";
            state_Median_IncomeLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // state_Median_IncomeTextBox1
            // 
            this.state_Median_IncomeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateBindingSource, "State Median Income", true));
            this.state_Median_IncomeTextBox1.Location = new System.Drawing.Point(473, 338);
            this.state_Median_IncomeTextBox1.Name = "state_Median_IncomeTextBox1";
            this.state_Median_IncomeTextBox1.Size = new System.Drawing.Size(282, 22);
            this.state_Median_IncomeTextBox1.TabIndex = 91;
            // 
            // computer_Related_Jobs_Per_State____Label1
            // 
            computer_Related_Jobs_Per_State____Label1.Location = new System.Drawing.Point(233, 371);
            computer_Related_Jobs_Per_State____Label1.Name = "computer_Related_Jobs_Per_State____Label1";
            computer_Related_Jobs_Per_State____Label1.Size = new System.Drawing.Size(234, 16);
            computer_Related_Jobs_Per_State____Label1.TabIndex = 92;
            computer_Related_Jobs_Per_State____Label1.Text = "Computer-Related Jobs Per State (%):";
            // 
            // computer_Related_Jobs_Per_State____TextBox1
            // 
            this.computer_Related_Jobs_Per_State____TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateBindingSource, "Computer-Related Jobs Per State (%)", true));
            this.computer_Related_Jobs_Per_State____TextBox1.Location = new System.Drawing.Point(473, 366);
            this.computer_Related_Jobs_Per_State____TextBox1.Name = "computer_Related_Jobs_Per_State____TextBox1";
            this.computer_Related_Jobs_Per_State____TextBox1.Size = new System.Drawing.Size(282, 22);
            this.computer_Related_Jobs_Per_State____TextBox1.TabIndex = 93;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(470, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 22);
            this.textBox1.TabIndex = 83;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(470, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(282, 22);
            this.textBox2.TabIndex = 81;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(230, 198);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(234, 16);
            label1.TabIndex = 80;
            label1.Text = "Capital:";
            label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(473, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(282, 22);
            this.textBox3.TabIndex = 79;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(230, 170);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(234, 16);
            label2.TabIndex = 78;
            label2.Text = "Population:";
            label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(470, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(282, 22);
            this.textBox4.TabIndex = 77;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(230, 142);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(234, 16);
            label3.TabIndex = 76;
            label3.Text = "Name:";
            label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(473, 111);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(282, 22);
            this.textBox5.TabIndex = 75;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(230, 114);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(234, 16);
            label4.TabIndex = 74;
            label4.Text = "State Id:";
            label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 659);
            this.Controls.Add(label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(state_FlowerLabel1);
            this.Controls.Add(state_BirdLabel1);
            this.Controls.Add(this.state_BirdTextBox1);
            this.Controls.Add(state_Colors__if_any_Label1);
            this.Controls.Add(this.state_Colors__if_any_TextBox1);
            this.Controls.Add(three_Largest_Cities_Per_StateLabel1);
            this.Controls.Add(this.three_Largest_Cities_Per_StateTextBox1);
            this.Controls.Add(state_Median_IncomeLabel1);
            this.Controls.Add(this.state_Median_IncomeTextBox1);
            this.Controls.Add(computer_Related_Jobs_Per_State____Label1);
            this.Controls.Add(this.computer_Related_Jobs_Per_State____TextBox1);
            this.Controls.Add(this.closeButton);
            this.Name = "DetailsForm";
            this.Text = "StateDetails";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StateDBDataSet stateDBDataSet;
        private System.Windows.Forms.BindingSource stateDBDataSetBindingSource;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private StateDBDataSetTableAdapters.StateTableAdapter stateTableAdapter;
        private StateDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox state_BirdTextBox1;
        private System.Windows.Forms.TextBox state_Colors__if_any_TextBox1;
        private System.Windows.Forms.TextBox three_Largest_Cities_Per_StateTextBox1;
        private System.Windows.Forms.TextBox state_Median_IncomeTextBox1;
        private System.Windows.Forms.TextBox computer_Related_Jobs_Per_State____TextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}