using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DGerald_CPT_206_A80S_Lab_3_StatesDatabase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void stateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateDBDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateDBDataSet.State' table. You can move, or remove it, as needed.
            this.stateTableAdapter.Fill(this.stateDBDataSet.State);

        }

     

        private void exit_1Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for checking out my database, have a great day!");
            this.Close();
        }

        private void deatailsButton_Click(object sender, EventArgs e)
        {
            DetailsForm details = new DetailsForm();

            details.ShowDialog();

            this.stateTableAdapter.Fill(this.stateDBDataSet.State);
         
        }
    }
}
