using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textPassword.PasswordChar = '*';
            this.ActiveControl = textSearch;
            textSearch.Focus();
        }

        string query = "Select * From login";
        string sqlConn = "datasource=127.0.0.1;port=3306;username=root;password=;database=CDMS";
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection dataConn = new MySqlConnection(sqlConn);
                MySqlCommand cmdDatabase = new MySqlCommand(query, dataConn);
                dataConn.Open();
                MySqlDataReader sqlReader = cmdDatabase.ExecuteReader();
              
                string inputUser = textUser.Text.ToString();
                string inputPass = textPassword.Text.ToString();
                bool flag = false;
                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        if (sqlReader.GetString(1) == inputUser && sqlReader.GetString(2) == inputPass)
                        {
                            flag = true;                            
                        }
                        
                    }
                    if(flag)
                    {
                        this.Hide();
                        MainForm fm = new MainForm();
                        fm.Show();
                        dataConn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username and password!");
                        dataConn.Close();
                    }

                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query1 = "select * from login where id='" + textSearch.Text.ToString() + "'";
            MySqlConnection dataConn = new MySqlConnection(sqlConn);
            MySqlCommand cmdDatabase = new MySqlCommand(query1, dataConn);
            try
            {
                dataConn.Open();
                int count;
                DataTable dta = new DataTable();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmdDatabase);
                msda.Fill(dta);
                count = dta.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    string getName = dta.Rows[i]["name"].ToString();

                    textUser.Text = getName;
                }
                dataConn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                dataConn.Close();
            }
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textPassword.Focus();
            }
        }
    }
}
