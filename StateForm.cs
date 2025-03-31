using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DGerald_CPT_206_A80S_Lab_3_States_DB
{
    public partial class StateForm : Form
    {        
        public StateForm()
        {
            InitializeComponent();

        }


        private void stateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateDBDataSet);
        }
        
       // public static DataGridViewRow gridViewRow {  get; set; }
        private void StateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateDBDataSet.State' table. You can move, or remove it, as needed.
            if (this.stateDBDataSet != null && this.stateDBDataSet.Tables.Contains("State"))
            {
                this.stateTableAdapter.Fill(this.stateDBDataSet.State);
            }

            stateDataGridView.AutoGenerateColumns = false;

            stateDataGridView.Columns.Add(new DataGridViewTextBoxColumn()       // manually name column 'State ID'
            {
                Name = "StateID",
                DataPropertyName = "StateID",
                HeaderText = "State ID"
            });

            stateDataGridView.Columns.Add(new DataGridViewTextBoxColumn()       // manually name column 'Name'
            {
                Name = "Name",
                DataPropertyName = "Name",
                HeaderText = "Name"
            });

            stateDataGridView.Columns.Add(new DataGridViewTextBoxColumn()       // manually name column 'Population'
            {
                Name = "Population",
                DataPropertyName = "Population",
                HeaderText = "Population"
            });

            stateDataGridView.Columns.Add(new DataGridViewTextBoxColumn()       // manually name column 'Capital'
            {
                Name = "Capital",
                DataPropertyName = "Capital",
                HeaderText = "Capital"
            });

            stateDataGridView.Columns.Add(new DataGridViewTextBoxColumn()       // manually name column 'State Flower'
            {
                Name = "State Flower",
                DataPropertyName = "State Flower",
                HeaderText = "State Flower"
            });

            stateDataGridView.Columns.Add(new DataGridViewTextBoxColumn()       // manually name column 'State Bird'
            {
                Name = "State Bird",
                DataPropertyName = "State Bird",
                HeaderText = "State Bird"
            });

            stateDataGridView.Columns.Add(new DataGridViewTextBoxColumn()       // manually name column 'State Colors'
            {
                Name = "State Colors (if any)",
                DataPropertyName = "State Colors (if any)",
                HeaderText = "State Colors (if any)"
            });

            stateDataGridView.Columns.Add(new DataGridViewTextBoxColumn()       // manually name column 'Three Largest Cities Per State'
            {
                Name = "Three Largest Cities Per State",
                DataPropertyName = "Three Largest Cities Per State",
                HeaderText = "Three Largest Cities Per State"
            });

            stateDataGridView.Columns.Add(new DataGridViewTextBoxColumn()       // manually name column 'State Median Income'
            {
                Name = "State Median Income",
                DataPropertyName = "State Median Income",
                HeaderText = "State Median Income"
            });

            stateDataGridView.Columns.Add(new DataGridViewTextBoxColumn()       // manually name column 'Computer-Related Jobs Per State'
            {
                Name = "Computer-Related Jobs Per State (%)",
                DataPropertyName = "Computer-Related Jobs Per State (%)",
                HeaderText = "Computer-Related Jobs Per State (%)"
            });

            stateDataGridView.DataSource = this.stateDBDataSet.State;

            DataView dataView = new DataView(this.stateDBDataSet.Tables["State"]);
            stateComboBox.DataSource = dataView;
            stateComboBox.DisplayMember = "Name";
            // stateDataGridView.DataSource = this.stateDBDataSet.State;

            //exitPictureBox.Image = Image.FromFile(@"D:\DGerald-CPT-206-A80S-Lab-3-States-DB\State-Images\Stop-1.jpg");
            //exitPictureBox.ForeColor = Color.Blue;
            exitLabel.BackColor = ColorTranslator.FromHtml("#cc0001");
        }

        private void stateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stateComboBox.SelectedItem == null) return;

            string stateValue = stateComboBox.Text; // Get selected value from ComboBox

            // Loop through DataGridView to find the matching row
            foreach (DataGridViewRow row in stateDataGridView.Rows)
            {
                if (row.Cells["Name"].Value != null && row.Cells["Name"].Value.ToString() == stateValue)
                {
                    stateDataGridView.ClearSelection(); // Clear previous selection
                    row.Selected = true; // Select the row
                    stateDataGridView.FirstDisplayedScrollingRowIndex = row.Index; // Scrolls to the selected row when clicked
                    break;  // breaks out of foreach loop to button control 
                }
            }
        }

        private void capitalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (capitalComboBox.SelectedItem == null) return;

            string capitalValue = capitalComboBox.Text;

            // Loop through DataGridView to find the matching row
            foreach (DataGridViewRow row in stateDataGridView.Rows)
            {
                if (row.Cells["Capital"].Value != null && row.Cells["Capital"].Value.ToString() == capitalValue)
                {
                    stateDataGridView.ClearSelection();     // Clear previous selection
                    row.Selected = true;    // Sets the row selected to true
                    stateDataGridView.FirstDisplayedScrollingRowIndex = row.Index;  // Scrolls to the selected row when clicked
                    break;  // breaks out of foreach loop to button control 
                }
            }
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            stateDataGridView.DataSource = this.stateDBDataSet.State;
           

            if (stateDataGridView.SelectedRows.Count > 0)
            {
                // all types int, decimal set as objects
                object stateID = stateDataGridView.SelectedRows[0].Cells["StateId"].Value; // Assuming StateID is stored as an int
                string stateName = stateDataGridView.SelectedRows[0].Cells["Name"].Value?.ToString() ?? "N/A";
                object populationValue = stateDataGridView.SelectedRows[0].Cells["Population"].Value;
                int population = int.TryParse(populationValue?.ToString(), out int pop) ? pop : 0;
                string capital = stateDataGridView.SelectedRows[0].Cells["Capital"].Value?.ToString() ?? "N/A";
                string stateFlower = stateDataGridView.SelectedRows[0].Cells["State Flower"].Value?.ToString() ?? "N/A";
                string stateBird = stateDataGridView.SelectedRows[0].Cells["State Bird"].Value?.ToString() ?? "N/A";
                string stateColors = stateDataGridView.SelectedRows[0].Cells["State Colors (if any)"].Value?.ToString() ?? "N/A";
                string largestCities = stateDataGridView.SelectedRows[0].Cells["Three Largest Cities Per State"].Value?.ToString() ?? "N/A";
                object stateMedianValue = stateDataGridView.SelectedRows[0].Cells["State Median Income"].Value;
                decimal stateMedian = decimal.TryParse(stateMedianValue?.ToString(), out decimal median) ? median : 0;
                object computerJobsValue = stateDataGridView.SelectedRows[0].Cells["Computer-Related Jobs Per State (%)"].Value;
                decimal computerJobs = decimal.TryParse(computerJobsValue?.ToString(), out decimal jobs) ? jobs : 0;

                // add local variables above as parameters to StateDetails form
                StateDetails stateDetails = new StateDetails(stateID, stateName, population, capital, stateFlower, stateBird, stateColors, largestCities, stateMedian, computerJobs);
                stateDetails.ShowDialog();

            }

            else
            {
                // display error if row is not selected
                MessageBox.Show("Please select a row from the DataGridView.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }



        // add method ToggleComboxes to determine initial visibility when clicked
        private void stateLabel_Click(object sender, EventArgs e) => ToggleComboBoxes(true);    // lambda (cleaner, more efficient code

        // add method ToggleComboxes to determine initial visibility when clicked
        private void capitalLabel_Click(object sender, EventArgs e)
        {
            ToggleComboBoxes(false);    // same as lambda above
        }


        // method to determine which combobox is visible
        private void ToggleComboBoxes(bool showStateComboBox)
        {
            stateComboBox.Visible = showStateComboBox;
            capitalComboBox.Visible = !showStateComboBox;
        }

        

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();       // closes the program
        }

        private void filterBy_10MButton_Click(object sender, EventArgs e)
        {
            this.stateTableAdapter.FillByPopulation10Million(this.stateDBDataSet.State);
            ComboboxVisibility();
           // ResetDataTabe();
        }

        private void filterBy_5MButton_Click(object sender, EventArgs e)
        {
            this.stateTableAdapter.FillByPop5Million(this.stateDBDataSet.State);
            ComboboxVisibility();
            //ResetDataTabe();
        }

        private void filterBy_1MButton_Click(object sender, EventArgs e)
        {
            this.stateTableAdapter.FillByPopulation1Million(this.stateDBDataSet.State);
            ComboboxVisibility();
           // ResetDataTabe();
        }

        private void medianAbove_50k_Button_Click(object sender, EventArgs e)
        {
            this.stateTableAdapter.FillByIncomeAbove50k(this.stateDBDataSet.State);
            ComboboxVisibility();
            //ResetDataTabe();
        }

        private void medianAbove_75k_Button_Click(object sender, EventArgs e)
        {
            this.stateTableAdapter.FillByIncomeAbove75k(this.stateDBDataSet.State);
            ComboboxVisibility();
            //ResetDataTabe();
        }

        private void AvgMedianButton_Click(object sender, EventArgs e)
        {
            decimal averageMedianIncome;

            averageMedianIncome = (decimal)this.stateTableAdapter.AverageMedian();

            MessageBox.Show("The average state median income is " + averageMedianIncome.ToString("C"));

            ComboboxVisibility();
            //ResetDataTabe();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetDataTabe();
        }

        private void ResetDataTabe()
        {
            try
            {
                this.stateTableAdapter.Fill(this.stateDBDataSet.State);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboboxVisibility()
        {
            stateComboBox.Visible = false;
            capitalComboBox.Visible = false;
        }

        private void sumPopulationButton_Click(object sender, EventArgs e)
        {
            int sumPopulation;

            sumPopulation = (int)this.stateTableAdapter.TotalPopulation();
            MessageBox.Show("Total population for all 50 states is " +  sumPopulation.ToString("N0"));
            ComboboxVisibility();
            //ResetDataTabe();
        }

        private void noOfficialColorsButton_Click(object sender, EventArgs e)
        {
            this.stateTableAdapter.FillByStateColors(this.stateDBDataSet.State);
            ComboboxVisibility();
            //ResetDataTabe();
        }

        private void compJobsButton_Click(object sender, EventArgs e)
        {
            decimal averageTechJobs;

            averageTechJobs = (decimal)this.stateTableAdapter.AverageCompJobs();

            MessageBox.Show("The average percentage of tech jobs is %" +  averageTechJobs.ToString("f2"));
            ComboboxVisibility();
            //ResetDataTabe();
        }
    }
}
