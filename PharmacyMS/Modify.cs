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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
            FillCombo();
            textMaddQuantity.Text = "0";
        }
        //OleDbConnection conn = new OleDbConnection("Provider=MSDAORA;Data Source=orc;User ID=pharmacy;Password=pharmacy;Unicode=True");
        string sqlConn = "datasource=127.0.0.1;port=3306;username=root;password=;database=CDMS;";
        void FillCombo()
        {
            textMmedicine.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textMmedicine.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string query1 = "select drug_name from medicine";
            MySqlConnection dataConn = new MySqlConnection(sqlConn);
            MySqlCommand cmdDatabase = new MySqlCommand(query1, dataConn);

            try
            {
                dataConn.Open();
                int count;

                DataTable dt = new DataTable();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmdDatabase);

                msda.Fill(dt);
                count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    string getName = dt.Rows[i]["drug_name"].ToString();
                    coll.Add(getName);
                }
                dataConn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                dataConn.Close();
            }

            textMmedicine.AutoCompleteCustomSource = coll; ;
        }

        private void textMmedicine_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query1 = "select * from medicine where drug_name='" + textMmedicine.Text.ToString() + "'";
                MySqlConnection dataConn = new MySqlConnection(sqlConn);
                MySqlCommand cmdDatabase = new MySqlCommand(query1, dataConn);
                dataConn.Open();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmdDatabase);
                //conn.Open();
                //OleDbCommand cmda = new OleDbCommand("select * from medicine where drug_name='" + textMmedicine.Text.ToString() + "'", conn);
                DataTable dta = new DataTable();
                //OleDbDataAdapter odat = new OleDbDataAdapter(cmda.CommandText, conn);
                //conn.Close();
                msda.Fill(dta);
                int count = dta.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    string getBatch = dta.Rows[i]["batch_no"].ToString();
                    string getAmount = dta.Rows[i]["amount"].ToString();
                    string getRate = dta.Rows[i]["rate"].ToString();
                    string getExDate = dta.Rows[i]["expire_date"].ToString();
                    string drgType = dta.Rows[i]["drug_type"].ToString();
                    string company = dta.Rows[i]["company_name"].ToString();

                    textMavailable.Text = getAmount;
                    textMexpire.Text = getExDate;
                    textMbatch.Text = getBatch;
                    textMmrp.Text = getRate;
                    textMdrugType.Text = drgType;
                    textMcompany.Text = company;

                }
               dataConn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                //conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conn.Open();
            int updateQuantity;
            string existingQuantity = textMavailable.Text.ToString();
            string addQuantity = textMaddQuantity.Text.ToString();
            updateQuantity = int.Parse(existingQuantity) + int.Parse(addQuantity);
            float setMRP = float.Parse(textMmrp.Text.ToString());
            try
            {
                string query2 = "update medicine set amount='" + updateQuantity + "',drug_type='" + textMdrugType.Text.ToString() + "',expire_date='" + this.dateTimePicker1.Text.ToString() + "',batch_no='" + textMbatch.Text.ToString() + "',company_name='" + textMcompany.Text.ToString() + "',rate='" + setMRP + "' where drug_name='" + textMmedicine.Text.ToString() + "'";
                MySqlConnection dataConn2 = new MySqlConnection(sqlConn);
                MySqlCommand updatecmd = new MySqlCommand(query2, dataConn2);
                dataConn2.Open();
                MySqlDataReader MyReader2 = updatecmd.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                dataConn2.Close();
                //OleDbCommand updateCommand = new OleDbCommand("update medicine set amount='" + updateQuantity + "',drug_type='" + textMdrugType.Text.ToString() + "',expire_date='" + this.dateTimePicker1.Text.ToString() + "',batch_no='" + textMbatch.Text.ToString() + "',company_name='" + textMcompany.Text.ToString() + "',rate='" + setMRP + "' where drug_name='" + textMmedicine.Text.ToString() + "' ", conn);
                //updateCommand.ExecuteNonQuery();
                //conn.Close();
                MessageBox.Show("Data has been updated successfully.");
                textMmedicine.Clear();
                textMaddQuantity.Clear();
                textMavailable.Clear();
                textMbatch.Clear();
                textMcompany.Clear();
                textMdrugType.Clear();
                textMexpire.Clear();
                textMmrp.Clear();
               
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                //conn.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textMmedicine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textMaddQuantity.Focus();
            }
        }

        private void textMaddQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker1.Focus();
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textMbatch.Focus();
            }
        }

        private void textMbatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textMdrugType.Focus();
            }
        }

        private void textMdrugType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textMmrp.Focus();
            }
        }

        private void textMmrp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textMcompany.Focus();
            }
        }
    }
}
