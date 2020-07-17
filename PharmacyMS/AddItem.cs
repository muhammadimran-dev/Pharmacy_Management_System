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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
            this.ActiveControl = textName;
            textName.Focus();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }
        string sqlConn = "datasource=127.0.0.1;port=3306;username=root;password=;database=CDMS;";
        int max_id;
        public int GetMedicineId()
        {
            string query1 = "select * from medicine order by drug_id asc";
            MySqlConnection dataConn = new MySqlConnection(sqlConn);
            MySqlCommand cmdDatabase = new MySqlCommand(query1, dataConn);
            dataConn.Open();
            MySqlDataAdapter msda = new MySqlDataAdapter(cmdDatabase);

            //OleDbCommand cmd = new OleDbCommand("select * from medicine order by drug_id asc", conn);
            //OleDbDataAdapter oda = new OleDbDataAdapter(cmd.CommandText, conn);
            DataTable dta = new DataTable();
            msda.Fill(dta);
            dataConn.Close();
            int count = dta.Rows.Count;
            if (count == 0)
            {
                return count + 1;
            }
            else
            {
                string get_max_id = dta.Rows[count - 1]["drug_id"].ToString();
                max_id = Int32.Parse(get_max_id);
                return max_id + 1;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
                {
                    string dname, bnum, quantity, price, dType, company;
                    float getRate, getAmount;
                    int id;
                    dname = textName.Text.ToString();
                    bnum = textBatch.Text.ToString();
                    quantity = textAmount.Text.ToString();
                    price = textRate.Text.ToString();
                    // ed = textType.Text.ToString();
                    dType = textType.Text.ToString();
                    company = textCompany.Text.ToString();



                    if (dname != "" && bnum != "" && quantity != "" && price != "")
                    {
                        getAmount = float.Parse(quantity);
                        getRate = float.Parse(price);
                        id = GetMedicineId();

                        string query2 = "insert into medicine (drug_id,drug_name,batch_no,amount,rate,expire_date,drug_type,company_name) values('" + id + "','" + dname + "','" + bnum + "','" + getAmount + "','" + getRate + "','" + this.dateTimePicker1.Text.ToString() + "','" + dType + "','" + company + "')";
                        MySqlConnection dataConn2 = new MySqlConnection(sqlConn);
                        MySqlCommand insrtcmd = new MySqlCommand(query2, dataConn2);
                        dataConn2.Open();
                        MySqlDataReader MyReader2 = insrtcmd.ExecuteReader();
                        while (MyReader2.Read())
                        {
                        }
                        //OleDbCommand cmd = new OleDbCommand("insert into medicine (drug_id,drug_name,batch_no,amount,rate,expire_date,drug_type,company_name) values('" + id + "','" + dname + "','" + bnum + "','" + getAmount + "','" + getRate + "','" + this.dateTimePicker1.Text.ToString() + "','" + dType + "','" + company + "')", conn);
                        //cmd.ExecuteNonQuery();
                        dataConn2.Close();
                        MessageBox.Show("Data has been inserted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Please fill all the requirement.");
                        //conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //conn.Close();
                }
                textAmount.Clear();
                textBatch.Clear();
                textName.Clear();
                textType.Clear();
                textCompany.Clear();
                textRate.Clear();
        }
        

        private void textName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string query1 = "select * from medicine where drug_name='" + textName.Text.ToString() + "'";
                MySqlConnection dataConn = new MySqlConnection(sqlConn);
                MySqlCommand cmdDatabase = new MySqlCommand(query1, dataConn);
                dataConn.Open();
                int count;
                DataTable dta = new DataTable();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmdDatabase);
                msda.Fill(dta);
                count = dta.Rows.Count;
                if (count != 0)
                {
                    MessageBox.Show("Medicine already exists.");
                    textAmount.Clear();
                    textBatch.Clear();
                    textName.Clear();
                    textType.Clear();
                    textCompany.Clear();
                    textRate.Clear();
                    textName.Focus();
                }
                else
                {
                    textBatch.Focus();
                }
                
            }
        }

        private void textBatch_KeyDown(object sender, KeyEventArgs e)
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
                textAmount.Focus();
            }
        }

        private void textAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textRate.Focus();
            }
        }

        private void textRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textType.Focus();
            }
        }

        private void textType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textCompany.Focus();
            }
        }
    }
}
