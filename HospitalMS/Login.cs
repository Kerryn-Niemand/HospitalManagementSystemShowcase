using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class Login : Form
    {        
        public Login()
        {
            InitializeComponent();
            // Disabling the buttons
            loginBtn.Enabled = false; 
            clearBtn.Enabled = false;
            // Handling the Enter key press to link it to the Login btn
            this.KeyPreview = true;
            this.KeyDown += Form_KeyDown;
        }
        private void UpdateClearButtonState()
        {
            // Enabling the Clear btn only if both textboxes have content
            clearBtn.Enabled = !string.IsNullOrWhiteSpace(adminRTB.Text) || !string.IsNullOrWhiteSpace(passwordRTB.Text);
        }
        
        // Clears the textboxes
        private void clearBtn_Click(object sender, EventArgs e)
        {            
            adminRTB.Text = " ";
            passwordRTB.Text = " ";
        }

        private void crossBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Checking if the textboxes are empty
            if (string.IsNullOrWhiteSpace(adminRTB.Text) || string.IsNullOrWhiteSpace(passwordRTB.Text))
            {
                MessageBox.Show("There Is Missing Information");
            }
            // If the textboxes contain the correct details, the Login btn takes you to the home page
            else if (adminRTB.Text == "Admin" && passwordRTB.Text.Length == 8)
            {
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter The Correct Username And Password");
                
            }
        }

        // Changes the state of the Clear btn depending on if the textbox is poulated or not
        private void adminRTB_TextChanged(object sender, EventArgs e)
        {
            UpdateClearButtonState();
            if (adminRTB.Text == "Admin" && passwordRTB.Text.Length == 8)
            {
                loginBtn.Enabled = true;
            }
        }

        // Changes the state of the Clear btn depending on if the textbox is poulated or not
        private void passwordRTB_TextChanged(object sender, EventArgs e)
        {           
            UpdateClearButtonState();
            if (adminRTB.Text == "Admin" && passwordRTB.Text.Length == 8)
            {
                loginBtn.Enabled = true;
            }
        }

        private void passwordRTB_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (!char.IsControl(e.KeyChar))
            {
                // Replacing the letters of the password to be hidden
                e.KeyChar = '*'; 
            }
        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Triggering the Login btn click event when Enter key is pressed
                loginBtn.PerformClick();
                // Prevents further processing of the Enter key
                e.Handled = true; 
            }
        }
    }

    






}

