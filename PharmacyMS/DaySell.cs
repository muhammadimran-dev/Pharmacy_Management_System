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
    public partial class DaySell : Form
    {
        public DaySell()
        {
            InitializeComponent();
            this.ActiveControl = dateTimePicker1;
            dateTimePicker1.Focus();
        }
        string sqlConn = "datasource=127.0.0.1;port=3306;username=root;password=;database=CDMS";
        
        

        //OleDbConnection conn = new OleDbConnection("Provider=MSDAORA;Data Source=orc;User ID=pharmacy;Password=pharmacy;Unicode=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = "select * from payment_bill where sold_date= '" + this.dateTimePicker1.Text.ToString() + "'";
                MySqlConnection dataConn = new MySqlConnection(sqlConn);
                MySqlCommand cmdDatabase = new MySqlCommand(query1, dataConn);
                dataConn.Open();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmdDatabase);
                
                //OleDbDataAdapter oda = new OleDbDataAdapter("select * from payment_bill where sold_date='" + this.dateTimePicker1.Text.ToString() + "'", conn);
                DataTable dt = new DataTable();
                //conn.Close();
                msda.Fill(dt);
                dataGridView1.DataSource = dt;
                int count = dt.Rows.Count;
                float sum = 0;
                for (int i = 0; i < count; i++)
                {
                    string finalAmount = dt.Rows[i]["total_amount"].ToString();
                    sum = sum + float.Parse(finalAmount);
                }
                textBox1.Text = Convert.ToString(sum);
                dataConn.Close();
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message);
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
