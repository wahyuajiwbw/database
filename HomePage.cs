using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace database
{
    public partial class HomePage : Form
    {

        DBAccess objDbAcces = new DBAccess();
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp login = new SignUp();
            login.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            lblwelcomename.Text = "Welcome : " + Signin.name;
            txtnamehome.Text = Signin.name;
            txtemailhome.Text = Signin.email;
            txtpasshome.Text = Signin.password;
            txtcountryhome.Text = Signin.country;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
            string newUserName = txtnamehome.Text;
            string newUserEmail = txtemailhome.Text;
            string newUserPass = txtpasshome.Text;
            string newUserCountry = txtcountryhome.Text;

            if (newUserName.Equals(""))
            {
                MessageBox.Show("Please Write Your Name.");
            }
            else if (newUserEmail.Equals(""))
            {
                MessageBox.Show("Please Write Your Email.");
            }
            else if (newUserPass.Equals(""))
            {
                MessageBox.Show("Please Write Your Password.");
            }
            else if (newUserCountry.Equals(""))
            {
                MessageBox.Show("Please Write Your Country.");
            }
            else
            {
                string query = "Update Users SET Name = '" + @newUserName +"', Email = '" + @newUserEmail + "', Password = '" + @newUserPass + "', Country = '" + @newUserCountry + "' where ID = '" + Signin.id + "'";

                SqlCommand updateCommand = new SqlCommand(query);

                SqlParameter sqlParameter = updateCommand.Parameters.AddWithValue("@userName", @newUserName);
                updateCommand.Parameters.AddWithValue("@userEmail", @newUserEmail);
                updateCommand.Parameters.AddWithValue("@userPassword", @newUserPass);
                updateCommand.Parameters.AddWithValue("@userCountry", @newUserCountry);

                int row = objDbAcces.executeQuery(updateCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account Informastion Updated Successful.");

                    this.Hide();
                    Signin sign = new Signin();
                    sign.Show();

                }
                else
                {
                    MessageBox.Show("Error Occured. Try Again.");
                }
            }
        }
    }
}
