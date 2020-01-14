using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAllInOne
{
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            string gender = "";
            
            if (rdbGenderMale.Checked)
            {
                gender = "Male";
            }
            else if (rdbGenderFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Other";
            }

            MessageBox.Show("My name is " + firstName + " " + lastName);
            MessageBox.Show("My gender is " + gender);
        }
    }
}
