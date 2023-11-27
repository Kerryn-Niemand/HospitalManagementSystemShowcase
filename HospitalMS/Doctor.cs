using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            DisplayDoctor();
        }
        // Initializes the database connection
        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documents\Hospital MS.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayDoctor()
        {
            try
            {
                Con.Open();
                string Query = "select * from Doctor";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
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
        private void crossBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        // Creates button to add user input to the database
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(docIdTb.Text) || string.IsNullOrWhiteSpace(docNameTb.Text) || 
                        string.IsNullOrWhiteSpace(docGenderCB.Text) || string.IsNullOrWhiteSpace(docSpecTb.Text))
                {
                    MessageBox.Show("There Is Information Missing");
                }
                else
                {
                    Con.Open();
                    string query = "insert into Doctor Values(' " + docIdTb.Text + "', ' " + docNameTb.Text + "', ' " + docGenderCB.Text + "', ' " + docSpecTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Entered Successfully!");
                    DisplayDoctor();
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

        private void Doctor_Load(object sender, EventArgs e)
        {
            DisplayDoctor();
        }

        // Creates button to clear all user input fields
        private void resetBtn_Click(object sender, EventArgs e)
        {
            docIdTb.Text = "";
            docNameTb.Text = "";
            docGenderCB.Text = "";
            docSpecTb.Text = "";
        }

        // Creates button to delete selected record from database
        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(docIdTb.Text))
                {
                    MessageBox.Show("Please Enter The Doctor's ID");
                }
                else
                {
                    Con.Open();
                    string query = "delete from Doctor where DocId = '" + docIdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                    DisplayDoctor();
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

        // Creates button to update data in the database
        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(docIdTb.Text) || string.IsNullOrWhiteSpace(docNameTb.Text) ||
                    string.IsNullOrWhiteSpace(docGenderCB.Text) || string.IsNullOrWhiteSpace(docSpecTb.Text))
                {
                    MessageBox.Show("There Is Information Missing");
                }
                else
                {
                    Con.Open();
                    string query = "update Doctor Set DocName = @DocName, DocGender = @DocGender, Speciality = @Speciality where DocId = @DocId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@DocName", docNameTb.Text);
                    cmd.Parameters.AddWithValue("@DocGender", docGenderCB.Text);
                    cmd.Parameters.AddWithValue("@Speciality", docSpecTb.Text);
                    cmd.Parameters.AddWithValue("@DocID", docIdTb.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Updated Successfully!");
                    DisplayDoctor();
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

        // Allows the doctor details to poulate the fields when the record is double clicked in the datagridview
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                docIdTb.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                docNameTb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                docGenderCB.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                docSpecTb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
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
