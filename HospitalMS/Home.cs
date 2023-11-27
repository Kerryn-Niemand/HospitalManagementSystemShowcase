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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        // Takes you back to the Login form
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void crossBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Takes you to the doctor form
        private void docBtn_Click(object sender, EventArgs e)
        {
            Doctor obj = new Doctor();
            obj.Show();
            this.Hide();
        }

        // Takes you to the patient form
        private void patientBtn_Click(object sender, EventArgs e)
        {
            Patient obj = new Patient();
            obj.Show();
            this.Hide();
        }

        // Takes you to the diagnosis form
        private void diagBtn_Click(object sender, EventArgs e)
        {
            Diagnosis obj = new Diagnosis();
            obj.Show();
            this.Hide();
        }
    }
}
