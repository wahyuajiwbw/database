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


namespace database
{
    public partial class SignUp : Form
    {
        DBAccess objDBAccess = new DBAccess();
        
        public SignUp()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            string userName = txtname.Text;
            string userEmail = txtemail.Text;
            string userPassword = txtpass.Text;
            string userCountry = txtcountry.Text;

            if(userName.Equals(""))
            {
                MessageBox.Show("Please enter your name.");
            }

            else if (userEmail.Equals(""))
            {
                MessageBox.Show("Please enter your email.");
            }

            else if (userPassword.Equals(""))
            {
                MessageBox.Show("Please enter your password.");
            }

            else if (userCountry.Equals(""))
            {
                MessageBox.Show("Please enter your country.");
            }

            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into Users(Name,Email,Password,Country) values(@userName, @userEmail, @userPassword, @userCountry )");

                SqlParameter sqlParameter = insertCommand.Parameters.AddWithValue("@userName", userName);
                insertCommand.Parameters.AddWithValue("@userEmail", userEmail);
                insertCommand.Parameters.AddWithValue("@userPassword", userPassword);
                insertCommand.Parameters.AddWithValue("@userCountry", userCountry);

                int row = objDBAccess.executeQuery(insertCommand);

                if(row==1)
                {
                    MessageBox.Show("Account Created Successful.");

                    this.Hide();
                    HomePage home = new HomePage();
                    home.Show();
                 
                }
                else
                {
                    MessageBox.Show("Error Occured. Try Again.");
                }
            }

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }

        internal class objDBAccess
         {
        internal int executeQuery(SqlCommand insertCommand)
            {
            throw new NotImplementedException();
            }
         }
}
