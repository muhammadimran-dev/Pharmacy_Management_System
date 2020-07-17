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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
            textCPassword.PasswordChar = '*';
            textCConfirmPass.PasswordChar = '*';
            this.ActiveControl = textCUserName;
            textCUserName.Focus();
        }
        string sqlConn = "datasource=127.0.0.1;port=3306;username=root;password=;database=CDMS";


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string uname, pass, conpass;
                uname = textCUserName.Text.ToString();
                pass = textCPassword.Text.ToString();
                conpass = textCConfirmPass.Text.ToString();
                if (pass == conpass)
                {
                    string query2 = "insert into login(name,password) values('" + textCUserName.Text + "','" + textCPassword.Text + "')";
                    MySqlConnection dataConn2 = new MySqlConnection(sqlConn);
                    MySqlCommand insrtcmd = new MySqlCommand(query2, dataConn2);
                    dataConn2.Open();
                    MySqlDataReader MyReader2 = insrtcmd.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    dataConn2.Close();
                    /*
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert_login";
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter param1 = cmd.Parameters.Add("v_user_name", OracleType.VarChar);
                    param1.Direction = ParameterDirection.Input;
                    param1.Value = textCUserName.Text.ToString();

                    OracleParameter param2 = cmd.Parameters.Add("v_pass", OracleType.VarChar);
                    param2.Direction = ParameterDirection.Input;
                    param2.Value = pass;

                    // OracleParameter f_param = cmd.Parameters.Add("v_user_id",OracleType.Number);
                    //f_param.Direction = ParameterDirection.ReturnValue;

                    cmd.ExecuteNonQuery();
                    conn.Close();

                     OleDbCommand cmd = new OleDbCommand("execute insert_login('"+uname+"','"+pass+"')", conn);
                     cmd.CommandText = "insert_login";
                     cmd.CommandType = CommandType.StoredProcedure;
                     cmd.ExecuteNonQuery();
                     conn.Close();*/

                    MessageBox.Show("Data inserted successfully.");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your password does not match!! Try again.");
                    textCUserName.Clear();
                    textCPassword.Clear();
                    textCConfirmPass.Clear();
                    //conn.Close();
                }
            }
            catch (Exception eeception)
            {
                MessageBox.Show(eeception.Message);
                ///conn.Close();
            }
        }

        private void textCUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textCPassword.Focus();
            }
        }

        private void textCPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textCConfirmPass.Focus();
            }
        }
    }
}
