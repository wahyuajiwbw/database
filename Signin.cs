using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database
{
    public partial class Signin : Form
    {

        public static string id, name, email, password, country;
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        private void btnsignin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtpasslogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpasslogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        public Signin()
        {
            InitializeComponent();
        }

        private void Signin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            string userEmail = txtemaillogin.Text;
            string userPassword = txtpasslogin.Text;

            if (userEmail.Equals(""))
            {
                MessageBox.Show("please enter email...");
            }
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("please enter password....");
            }
            else
            {
                string query = "select * from Users where Email='" + userEmail +"' AND Password = '" + userPassword + "'";

                objDBAccess.readDatathroughAdapter(query, dtUsers);

                if (dtUsers.Rows.Count == 1)
                {
                    id = dtUsers.Rows[0]["ID"].ToString();
                    name = dtUsers.Rows[0]["Name"].ToString();
                    email = dtUsers.Rows[0]["Email"].ToString();
                    password = dtUsers.Rows[0]["Password"].ToString();
                    country = dtUsers.Rows[0]["Country"].ToString();

                    MessageBox.Show("congrulations, you are logged in successfully.");
                    objDBAccess.closeConn();
                    
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

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp login = new SignUp();
            login.Show();
        }
    }
}
