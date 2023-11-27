using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace HospitalMS
{
    
    public partial class Diagnosis : Form
    {
        
        public Diagnosis()         
        {
            InitializeComponent();
            // Ensures latest update of the form is visible
            DisplayDiagnosis();          
        }
        
        // Initiating the database connection
        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\Hospital MS.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayDiagnosis()
        {
            try
            {
                Con.Open();
                string Query = "select * from Diagnosis";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                diagDataGridView.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        
        // Calls the patient database to use the patient Id in the diagnosis form
        void DisplayPatientId()
        {
            string sql = "select * from Patient";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                diagPatIdCB.ValueMember = "PId";
                diagPatIdCB.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        // Creates button that sends the user input to the database
        private void addBtn_Click(object sender, EventArgs e)
        {
            // Creates dictionary to connect symptoms to specific tests and medicines
            Dictionary<string, string> symptomToTestMapping = new Dictionary<string, string>();
            Dictionary<string, string> symptomToMedicineMapping = new Dictionary<string, string>();

            // Populates the mappings to connect symptoms to specific tests and medicines
            symptomToTestMapping["Headache"] = "MRI";
            symptomToTestMapping["Cough"] = "Physical Examination";
            symptomToTestMapping["Inflammation"] = "X-Ray";
            symptomToTestMapping["Shortness of Breath"] = "Pulmonary Function Test";
            symptomToTestMapping["Infection(Bacterial)"] = "Blood Test";

            symptomToMedicineMapping["Headache"] = "Pain Killer";
            symptomToMedicineMapping["Cough"] = "Decongestant," + " Antihistamine";
            symptomToMedicineMapping["Inflammation"] = "Anti-Inflammatory";
            symptomToMedicineMapping["Shortness of Breath"] = "Bronchodilator";
            symptomToMedicineMapping["Infection(Bacterial)"] = "Antibiotic";
            try
            {
                // If statement to check if the input fields are empty
                if (string.IsNullOrWhiteSpace(diagIdTb.Text) || string.IsNullOrWhiteSpace(diagPatIdCB.Text) ||
                    string.IsNullOrWhiteSpace(diagPatNameTb.Text) || diagSympCLB.CheckedItems.Count == 0)
                {
                    MessageBox.Show("There Is Diagnosis Information Missing");
                }
                else
                {
                    Con.Open();

                    // Retrieves the selected symptoms from the CheckedListBox
                    var selectedSymptoms = diagSympCLB.CheckedItems.Cast<string>().ToList();

                    // Initializes empty lists for tests and medicines
                    var tests = new List<string>();
                    var medicines = new List<string>();

                    // Looks up the corresponding tests and medicines for each checked symptom
                    foreach (var selectedSymptom in selectedSymptoms)
                    {
                        if (symptomToTestMapping.ContainsKey(selectedSymptom))
                        {
                            tests.Add(symptomToTestMapping[selectedSymptom]);
                        }

                        if (symptomToMedicineMapping.ContainsKey(selectedSymptom))
                        {
                            medicines.Add(symptomToMedicineMapping[selectedSymptom]);
                        }
                    }

                    // Combines the tests and medicines into comma-separated strings
                    string testsStr = string.Join(", ", tests);
                    string medicinesStr = string.Join(", ", medicines);

                    // Populates the textboxes with the selected tests, and medicines
                    diagTestTb.Text = testsStr;
                    diagPMTb.Text = medicinesStr;

                    // Combines the selected symptoms into a comma-separated string
                    string symptoms = string.Join(", ", selectedSymptoms);

                    // Updates the database record
                    string query = "INSERT INTO Diagnosis (DId, PatId, PatName, Symp, DiagTest, PrescMed) " +
                                   "VALUES (@DId, @PatId, @PatName, @Symp, @DiagTest, @PrescMed)";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@DId", diagIdTb.Text);
                    cmd.Parameters.AddWithValue("@PatId", diagPatIdCB.Text);
                    cmd.Parameters.AddWithValue("@PatName", diagPatNameTb.Text);
                    cmd.Parameters.AddWithValue("@Symp", symptoms);
                    cmd.Parameters.AddWithValue("@DiagTest", testsStr);
                    cmd.Parameters.AddWithValue("@PrescMed", medicinesStr);

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Entered Successfully!");
                    DisplayDiagnosis();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        // Helper function to get selected symptom's linked data
        private string GetSelectedSymptomData(string selectedSymptoms, Dictionary<string, string> mapping)
        {
            string[] symptoms = selectedSymptoms.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            List<string> data = new List<string>();

            foreach (var symptom in symptoms)
            {
                if (mapping.ContainsKey(symptom))
                {
                    data.Add(mapping[symptom]);
                }
            }

            return string.Join(", ", data);
        }

        // Creates button that will update the user input in the database
        private void updateBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> symptomToTestMapping = new Dictionary<string, string>();
            Dictionary<string, string> symptomToMedicineMapping = new Dictionary<string, string>();

            // Populate the mappings
            symptomToTestMapping["Headache"] = "MRI";
            symptomToTestMapping["Cough"] = "Physical Examination";
            symptomToTestMapping["Inflammation"] = "X-Ray";
            symptomToTestMapping["Shortness of Breath"] = "Pulmonary Function Test";
            symptomToTestMapping["Infection(Bacterial)"] = "Blood Test";

            symptomToMedicineMapping["Headache"] = "Pain Killer";
            symptomToMedicineMapping["Cough"] = "Decongestant," + " Antihistamine";
            symptomToMedicineMapping["Inflammation"] = "Anti-Inflammatory";
            symptomToMedicineMapping["Shortness of Breath"] = "Bronchodilator";
            symptomToMedicineMapping["Infection(Bacterial)"] = "Antibiotic";
            try
            {
                if (string.IsNullOrWhiteSpace(diagIdTb.Text) || string.IsNullOrWhiteSpace(diagPatIdCB.Text) ||
                    string.IsNullOrWhiteSpace(diagPatNameTb.Text) || diagSympCLB.CheckedItems.Count == 0)
                {
                    MessageBox.Show("There Is Diagnosis Information Missing");
                }
                else
                {
                    Con.Open();

                    // Retrieves the selected symptoms from the CheckedListBox
                    var selectedSymptoms = diagSympCLB.CheckedItems.Cast<string>().ToList();

                    // Initializes empty lists for tests and medicines
                    var tests = new List<string>();
                    var medicines = new List<string>();

                    // Looks up the corresponding tests and medicines for each selected symptom
                    foreach (var selectedSymptom in selectedSymptoms)
                    {
                        if (symptomToTestMapping.ContainsKey(selectedSymptom))
                        {
                            tests.Add(symptomToTestMapping[selectedSymptom]);
                        }

                        if (symptomToMedicineMapping.ContainsKey(selectedSymptom))
                        {
                            medicines.Add(symptomToMedicineMapping[selectedSymptom]);
                        }
                    }

                    // Combines the tests and medicines into comma-separated strings
                    string testsStr = string.Join(", ", tests);
                    string medicinesStr = string.Join(", ", medicines);

                    // Populates the textboxes with the selected tests, and medicines
                    diagTestTb.Text = testsStr;
                    diagPMTb.Text = medicinesStr;

                    // Combines the selected symptoms into a comma-separated string
                    string symptoms = string.Join(", ", selectedSymptoms);

                    // Updates the database record
                    string query = "UPDATE Diagnosis SET PatId = @PatId, PatName = @PatName, Symp = @Symptoms, DiagTest = @DiagTest, PrescMed = @PrescMed WHERE DId = @DId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@DId", diagIdTb.Text);
                    cmd.Parameters.AddWithValue("@PatId", diagPatIdCB.Text);
                    cmd.Parameters.AddWithValue("@PatName", diagPatNameTb.Text);
                    cmd.Parameters.AddWithValue("@Symptoms", symptoms);
                    cmd.Parameters.AddWithValue("@DiagTest", testsStr);
                    cmd.Parameters.AddWithValue("@PrescMed", medicinesStr);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Updated Successfully!");
                    DisplayDiagnosis();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
    
        // Creates a button that deletes the selected record from the database
        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //If statement to check if the ID field is empty
                if (string.IsNullOrWhiteSpace(diagIdTb.Text))
                {
                    MessageBox.Show("Please Enter The Diagnosis ID");
                }
                else
                {
                    Con.Open();
                    string query = "delete from Diagnosis where DId = '" + diagIdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                    DisplayDiagnosis();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        // Creates button to empty all user input fields
        private void resetBtn_Click(object sender, EventArgs e)
        {
            diagIdTb.Text = "";
            diagPatIdCB.Text = "";
            diagPatNameTb.Text = "";
            diagTestTb.Text = "";
            diagPMTb.Text = "";
            
            // Loops through each item in the CheckListBox
            for (int i = 0; i < diagSympCLB.Items.Count; i++)
            {
                // Unchecks the item
                diagSympCLB.SetItemChecked(i, false);
            }            
        }
        
        // Allows the user input to populate the input fields when a record is double clicked in the datagridview
        private void diagDataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                diagIdTb.Text = diagDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                diagPatIdCB.Text = diagDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                diagPatNameTb.Text = diagDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                diagTestTb.Text = diagDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                diagPMTb.Text = diagDataGridView.SelectedRows[0].Cells[5].Value.ToString();

                // Clears existing selections in CheckedListBox
                ClearCheckedItems(diagSympCLB);               

                // Splits the comma-separated values and set the new selections in CheckedListBox
                string symptoms = diagDataGridView.SelectedRows[0].Cells[3].Value.ToString();                

                // Sets new selections in CheckedListBoxes
                SetCheckedItems(diagSympCLB, symptoms);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }

        }

        // Helper function to clear checked items in a CheckedListBox
        private void ClearCheckedItems(CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }

        // Helper function to set checked items in a CheckedListBox based on a comma-separated string
        private void SetCheckedItems(CheckedListBox checkedListBox, string values)
        {
            string[] selectedValues = values.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string selectedValue in selectedValues)
            {
                int index = checkedListBox.Items.IndexOf(selectedValue.Trim());
                if (index >= 0)
                {
                    checkedListBox.SetItemChecked(index, true);
                }
            }
        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            // Shows the patient Id when the page loads
            DisplayPatientId();
        }


        string pname = "";

        // Calls the patient name and linked data from the patient database
        void DisplayPatientName()
        {
            try
            {
                Con.Open();
                string sql2 = "select * from Patient where PId =" + diagPatIdCB.SelectedValue.ToString();

                SqlCommand cmd = new SqlCommand(sql2, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sqlAd = new SqlDataAdapter(cmd);
                sqlAd.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    pname = dr["PName"].ToString();
                    diagPatNameTb.Text = pname;
                }                
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void diagPatIdCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DisplayPatientName();
        }

        private void crossBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void diagSympCLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Dictionary<string, string> symptomToTestMapping = new Dictionary<string, string>();
            Dictionary<string, string> symptomToMedicineMapping = new Dictionary<string, string>();

            
            symptomToTestMapping["Headache"] = "MRI";
            symptomToTestMapping["Cough"] = "Physical Examination";
            symptomToTestMapping["Inflammation"] = "X-Ray";
            symptomToTestMapping["Shortness of Breath"] = "Pulmonary Function Test";
            symptomToTestMapping["Infection(Bacterial)"] = "Blood Test";

            symptomToMedicineMapping["Headache"] = "Pain Killer";
            symptomToMedicineMapping["Cough"] = "Decongestant," + " Antihistamine";
            symptomToMedicineMapping["Inflammation"] = "Anti-Inflammatory";
            symptomToMedicineMapping["Shortness of Breath"] = "Bronchodilator";
            symptomToMedicineMapping["Infection(Bacterial)"] = "Antibiotic";

            string selectedSymptom = diagSympCLB.Items[e.Index].ToString();

            // Checks if the symptom is being checked
            if (e.NewValue == CheckState.Checked)
            {
                // Checks if there's a corresponding test and medicine
                if (symptomToTestMapping.ContainsKey(selectedSymptom))
                {
                    // Sets the test textbox
                    diagTestTb.Text = symptomToTestMapping[selectedSymptom];
                }
                if (symptomToMedicineMapping.ContainsKey(selectedSymptom))
                {
                    // Sets the medicine textbox
                    diagPMTb.Text = symptomToMedicineMapping[selectedSymptom];
                }
            }
            else
            {
                // Handles the case when the symptom is unchecked
                diagTestTb.Clear();
                diagPMTb.Clear();
            }
        }


        //// Activates or deactivates the Add button. (FUTURE IMPLEMENTATION)
        //private void textBox1_TextChanged(object sender, System.EventArgs e)
        //{
        //    if (textBox1.Text == "")
        //    {
        //        button1.Enabled = false;
        //    }
        //    else
        //    {
        //        button1.Enabled = true;
        //    }
        //}
    }
}


