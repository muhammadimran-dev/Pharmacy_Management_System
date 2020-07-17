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
    public partial class ViewBill : Form
    {
        public ViewBill()
        {
            InitializeComponent();
            this.ActiveControl = textBillNo;
            textBillNo.Focus();
        }

        string sqlConn = "datasource=127.0.0.1;port=3306;username=root;password=;database=CDMS";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = "select * from payment_bill where bill_no='" + textBillNo.Text.ToString() + "'";
                //string query1 = "select * from sale_info where bill_no='" + textBillNo.Text.ToString() + "'";
                MySqlConnection dataConn = new MySqlConnection(sqlConn);
                MySqlCommand cmdDatabase = new MySqlCommand(query1, dataConn);
                dataConn.Open();
                MySqlDataAdapter pmntAdapter = new MySqlDataAdapter(cmdDatabase);


                //conn.Open();
                //OleDbCommand pmntBillcmd = new OleDbCommand("select * from payment_bill where bill_no='" + textBillNo.Text.ToString() + "'", conn);
                //OleDbDataAdapter pmntAdapter = new OleDbDataAdapter(pmntBillcmd.CommandText, conn);
                DataTable pmntDta = new DataTable();
                pmntAdapter.Fill(pmntDta);
                dataConn.Close();

                string query2 = "select drug_name,batch_no,drug_type,company_name,expire_date,quantity,mrp,total_amount from sale_info where bill_no='" + textBillNo.Text.ToString() + "'";
                MySqlConnection dataConn2 = new MySqlConnection(sqlConn);
                MySqlCommand cmdDatabase2 = new MySqlCommand(query2, dataConn2);
                dataConn2.Open();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmdDatabase2);
                //OleDbDataAdapter oda = new OleDbDataAdapter("select drug_name,batch_no,drug_type,company_name,expire_date,quantity,mrp,total_amount from sale_info where bill_no='" + textBillNo.Text.ToString() + "'", conn);
                //conn.Close();
                DataTable dtt = new DataTable();
                msda.Fill(dtt);
                dataGridView1.DataSource = dtt;
                dataConn2.Close();
                int count = pmntDta.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    string getTotal = pmntDta.Rows[i]["amount"].ToString();
                    string getDiscount = pmntDta.Rows[i]["discount"].ToString();
                    string getFinal = pmntDta.Rows[i]["total_amount"].ToString();
                    textAmount.Text = getTotal;
                    textDiscount.Text = getDiscount;
                    textPayAmount.Text = getFinal;
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message);
            }
        }

        private void textBillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBillNo.Text != null)
            {
                button1.PerformClick();
            }
        }

        private void textBillNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
