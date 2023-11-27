using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            DisplayPatient();
        }

        // Initializes the database connection
        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\Hospital MS.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayPatient()
        {
            try
            {
                Con.Open();
                string Query = "select * from Patient";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                patDataGridView.DataSource = ds.Tables[0];
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

        // Creates button to add user input to the database
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(patIdTb.Text) || string.IsNullOrWhiteSpace(patNameTb.Text) ||
                        string.IsNullOrWhiteSpace(patAddressTb.Text) || string.IsNullOrWhiteSpace(patAgeTb.Text) ||
                        string.IsNullOrWhiteSpace(patNumberTb.Text) || string.IsNullOrWhiteSpace(patGenderCB.Text) || string.IsNullOrWhiteSpace(patBTCB.Text))
                {
                    MessageBox.Show("There Is Information Missing");
                }
                else
                {
                    Con.Open();
                    string query = "insert into Patient Values(' " + patIdTb.Text + "', ' " + patNameTb.Text + "'," +
                    "' " + patAddressTb.Text + "',' " + patAgeTb.Text + "',' " + patNumberTb.Text + "', " +
                    "' " + patGenderCB.Text + "',' " + patBTCB.Text + "', ' " + patCITb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Entered Successfully!");
                    DisplayPatient();
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

        private void Patient_Load(object sender, EventArgs e)
        {
            DisplayPatient();
        }

        private void crossBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Creates button to update data in the database
        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(patIdTb.Text) || string.IsNullOrWhiteSpace(patNameTb.Text) ||
                    string.IsNullOrWhiteSpace(patAddressTb.Text) || string.IsNullOrWhiteSpace(patAgeTb.Text) ||
                    string.IsNullOrWhiteSpace(patNumberTb.Text) || string.IsNullOrWhiteSpace(patGenderCB.Text) || string.IsNullOrWhiteSpace(patBTCB.Text))
                {
                    MessageBox.Show("There Is Information Missing");
                }
                else
                {
                    Con.Open();
                    string query = "update Patient Set PName = @PName, PAddress = @PAddress, PAge = @PAge," +
                    " PNumber = @PNumber, PGender = @PGender, BloodType = @BloodType, ChronicIllness = @ChronicIllness where PId = @PId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@PName", patNameTb.Text);
                    cmd.Parameters.AddWithValue("@PAddress", patAddressTb.Text);
                    cmd.Parameters.AddWithValue("@PAge", patAgeTb.Text);
                    cmd.Parameters.AddWithValue("@PNumber", patNumberTb.Text);
                    cmd.Parameters.AddWithValue("@PGender", patGenderCB.Text);
                    cmd.Parameters.AddWithValue("@BloodType", patBTCB.Text);
                    cmd.Parameters.AddWithValue("@ChronicIllness", patCITb.Text);
                    cmd.Parameters.AddWithValue("@PId", patIdTb.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Updated Successfully!");
                    DisplayPatient();
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

        // Creates button to delete selected record from database
        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(patIdTb.Text))
                {
                    MessageBox.Show("Please Enter The Patient's ID");
                }
                else
                {
                    Con.Open();
                    string query = "delete from Patient where PId = '" + patIdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                    DisplayPatient();
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

        // Creates button to clear all user input fields
        private void resetBtn_Click(object sender, EventArgs e)
        {
            patIdTb.Text = "";
            patNameTb.Text = "";
            patAddressTb.Text = "";
            patAgeTb.Text = "";
            patNumberTb.Text = "";            
            patGenderCB.Text = "";
            patBTCB.Text = "";
            patCITb.Text = "";
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        // Allows the patient details to poulate the fields when the record is double clicked in the datagridview
        private void patDataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                patIdTb.Text = patDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                patNameTb.Text = patDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                patAddressTb.Text = patDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                patAgeTb.Text = patDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                patNumberTb.Text = patDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                patGenderCB.Text = patDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                patBTCB.Text = patDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                patCITb.Text = patDataGridView.SelectedRows[0].Cells[7].Value.ToString();
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
    }
}
