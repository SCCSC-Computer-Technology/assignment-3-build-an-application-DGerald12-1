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
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateDBDataSet.State' table. You can move, or remove it, as needed.
            this.stateTableAdapter.Fill(this.stateDBDataSet.State);

        }
    }
}
