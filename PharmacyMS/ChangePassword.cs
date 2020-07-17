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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            textOPass.PasswordChar = '*';
            textNPass.PasswordChar = '*';
            textNConfirmPass.PasswordChar = '*';
            this.ActiveControl = textSearch;
            textSearch.Focus();
        }

        string query = "Select * From login";
        string sqlConn = "datasource=127.0.0.1;port=3306;username=root;password=;database=CDMS";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection dataConn = new MySqlConnection(sqlConn);
                MySqlCommand cmdDatabase = new MySqlCommand(query, dataConn);
                dataConn.Open();
                MySqlDataReader sqlReader = cmdDatabase.ExecuteReader();

                string inputId = textSearch.Text.ToString();
                string inputUser = textUser.Text.ToString();
                string inputPass = textOPass.Text.ToString();
                string newPass = textNPass.Text.ToString();
                string ConfirmNPass = textNConfirmPass.Text.ToString();
                bool flag = false;
                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        if (sqlReader.GetString(0) == inputId && sqlReader.GetString(2) == inputPass && newPass==ConfirmNPass)
                        {
                            flag = true;
                        }

                    }
                    if (flag)
                    {
                        string query2 = "Update login Set password='" + newPass + "' Where name='" + inputUser + "'";
                        MySqlConnection dataConn2 = new MySqlConnection(sqlConn);
                        MySqlCommand updatecmd = new MySqlCommand(query2, dataConn2);
                        dataConn2.Open();
                        MySqlDataReader MyReader2 = updatecmd.ExecuteReader();
                        while (MyReader2.Read())
                        {
                        }
                        this.Hide();
                        MessageBox.Show("Successfully password changed!");
                        dataConn2.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username and password!");
                        dataConn.Close();
                        textSearch.Clear();
                        textUser.Clear();
                        textOPass.Clear();
                        textNPass.Clear();
                        textNConfirmPass.Clear();
                    }
                    
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textUser_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textOPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textNPass.Focus();
            }
        }

        private void textNPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textNConfirmPass.Focus();
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textOPass.Focus();
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
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
    }
}
