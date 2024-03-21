using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch(status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;


            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider1.Icon = Properties.Resources.error;
                errorProvider1.SetError(this.textBox1,"Enter Username");
            }
            else
            {
                errorProvider1.Icon = Properties.Resources.check;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider2.Icon = Properties.Resources.error;
                errorProvider2.SetError(this.textBox2, "Enter Password");
            }
            else
            {
                errorProvider2.Icon = Properties.Resources.check;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text!="" && textBox2.Text!="")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from login_data where username=@user and password = @pass";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.Parameters.AddWithValue("@user",textBox1.Text);
                cmd.Parameters.AddWithValue("@pass",textBox2.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows==true)
                {
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Enter Fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
