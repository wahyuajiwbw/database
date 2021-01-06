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
    public partial class CommandBuilder : Form
    {
        DBAccess objDbAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public CommandBuilder()
        {
            InitializeComponent();
        }

        private void CommandBuilder_Load(object sender, EventArgs e)
        {
            string query = "Select * from  Users";

            objDbAccess.readDatathroughAdapter(query, dtUsers);

            dataGridView1.DataSource = dtUsers;
            objDbAccess.closeConn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Select * from  Users";

            int changes = objDbAccess.executeDataAdapter(dtUsers, query);

            MessageBox.Show("count = " + changes);
        }

        private void logoutt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin signin = new Signin();
            signin.Show();
        }
    }
}
