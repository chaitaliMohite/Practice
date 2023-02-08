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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            register l1 = new register();
            l1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\db2.mdb";
                conn.Open();
                string strsql;
                if(txtuser.Text==""&&txtpass.Text=="")
                {
                    MessageBox.Show("Please entered Username and password");
                }
                else
                {
                    strsql = "Select * from loginTable where username=" + txtuser.Text + " and password=" + txtpass.Text + ";";
                    OleDbCommand cmd = new OleDbCommand(strsql, conn);
                    mainform login = new mainform();
                    login.Show();
                    this.Hide();
                }
                conn.Close();
                

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
