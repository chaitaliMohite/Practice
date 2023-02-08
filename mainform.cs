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
using System.Text.RegularExpressions;


namespace demo
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter();
        }

        public int EMPID ;
        private object mainformAdapter;
        private static bool rows;
       
        public object phonenumber { get; private set; }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnins_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=e:\main_form.mdb";
                conn.Open();
                string s1;
                s1 = "Insert into mainform Values(" + txtid.Text + ",'" + txtename.Text + "'," + txtage.Text + ",'" + txtsal.Text + "')";
                OleDbCommand cmd = new OleDbCommand(s1, conn);
                cmd.ExecuteNonQuery();
                dataGridView1.Update();
                dataGridView1.Refresh();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            Getmainformrecord();
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=e:\main_form.mdb";
            conn.Open();
            string s1;
            s1 = "select * from mainform";
            OleDbDataAdapter da = new OleDbDataAdapter(s1, conn);
            DataSet ds = new DataSet();
            da.Fill(ds,"dt");
            
        }

        private static void Clear()
        {
            throw new NotImplementedException();
        }

        private void Getmainformrecord()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=e:\main_form.mdb";
            conn.Open();
            string s1;
            s1 = "select * from mainform";
            OleDbCommand cmd = new OleDbCommand(s1, conn);
            DataTable dt = new DataTable();
            OleDbDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=e:\main_form.mdb";
                conn.Open();
                string s1;
                s1 = "update mainform set ID="+txtid.Text+",Ename='" + txtename.Text + "' ,Age='" + txtage.Text + "' ,Salary='" + txtsal.Text + "' where ID="+EMPID+"";
                OleDbCommand cmd = new OleDbCommand(s1, conn);
                cmd.Parameters.AddWithValue("ID", txtid.Text);
                cmd.Parameters.AddWithValue("Name", txtename.Text);
                cmd.Parameters.AddWithValue("Age", txtage.Text);
                cmd.Parameters.AddWithValue("Sal", txtsal.Text);
                cmd.Parameters.AddWithValue("email", txtemail.Text);
                cmd.Parameters.AddWithValue("Mobile", txtmob.Text);
                dataGridView1.Update();
                dataGridView1.Refresh();
                cmd.ExecuteNonQuery();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                }
                Getmainformrecord();
                conn.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=e:\main_form.mdb";
                conn.Open();
                string s1;
                s1 = "delete from mainform where ID = " + EMPID + ";";
                OleDbCommand cmd = new OleDbCommand(s1, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnget_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=e:\main_form.mdb";
                conn.Open();
                string strsql;
                strsql = "Select * from mainform";
                OleDbDataAdapter da = new OleDbDataAdapter(strsql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "dt");
                DataRow dr = ds.Tables["dt"].Rows[dataGridView1.CurrentRow.Index];
                txtid.Text = dr[0].ToString();
                txtename.Text = dr[1].ToString();
                txtage.Text = dr[2].ToString();
                txtsal.Text = dr[3].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            login l1 = new login();
            l1.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=e:\main_form.mdb";
        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login l1 = new login();
            l1.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex expr = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (expr.IsMatch(txtemail.Text))
            {
                //MessageBox.Show("ok");
            }
            else
            {
                //MessageBox.Show("Invalid email");
            }
        }

        private void txtmob_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                //Regex phonenumber = new Regex("(3|4|5|6|7|8|9){1}[0-9]{9}");
                //string match = phonenumber.Match(txtmob.Text).Value.ToString();
                if (txtmob.Text.Length!=10 ) 
                {
                    if(Regex.Match(txtmob.Text, @"^(\+[0-9])$").Success)
                    {
                        txtmob.Text = "";
                    }
                   
                }
                else
                {
                    MessageBox.Show("Not Valid phone number!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtmob_Validated(object sender, EventArgs e)
        {

        }

        private void txtmob_Leave(object sender, EventArgs e)
        {
            
        }

        private void ValidateMobile(string text)
        {
            throw new NotImplementedException();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
