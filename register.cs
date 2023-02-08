using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace demo
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\db2.mdb";
                conn.Open();
                string s1;
                s1 = "select * from loginTable where uname='"+txtuser.Text+"'";
                OleDbCommand cmd = new OleDbCommand(s1, conn);
                
                if (txtuser.Text==""&&txtpass.Text=="")
                {
                    MessageBox.Show("Please Insert Data");
                }
                else
                {
                    OleDbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        s1 = "Insert into loginTable values('" + txtuser.Text + "','" + txtpass.Text + "'); ";
                        cmd.ExecuteNonQuery();
                        if (txtuser.Text != "" && txtpass.Text != "")
                        {
                            MessageBox.Show("Registration Successfull");
                        }
                        else
                        {
                            MessageBox.Show("Please registered first");
                        }
                        
                    }

                    else
                    {
                        MessageBox.Show("User Already Exixt");
                    }
                   
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnreg_Click(object sender, EventArgs e)
        {
                login l1 = new login();
                l1.Show();
                this.Hide();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
