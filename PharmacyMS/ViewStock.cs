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
    public partial class ViewStock : Form
    {
        public ViewStock()
        {
            InitializeComponent();
            this.ActiveControl = button2;
            button2.Focus();
        }

        private void ViewStock_Load(object sender, EventArgs e)
        {

        }
        string sqlConn = "datasource=127.0.0.1;port=3306;username=root;password=;database=CDMS";
        DataTable dt;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = "select * from medicine where amount<'" + textQty.Text.ToString() + "'";
                MySqlConnection dataConn = new MySqlConnection(sqlConn);
                MySqlCommand cmdDatabase = new MySqlCommand(query1, dataConn);
                dataConn.Open();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmdDatabase);
                //conn.Open();
                //OleDbDataAdapter oda = new OleDbDataAdapter("select * from medicine where amount<'" + textQty.Text.ToString() + "'", conn);
                DataTable dta = new DataTable();
                msda.Fill(dta);
                dataGridView1.DataSource = dta;
                dataConn.Close();
                textBox1.Focus();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = "select * from medicine";
                MySqlConnection dataConn = new MySqlConnection(sqlConn);
                MySqlCommand cmdDatabase = new MySqlCommand(query1, dataConn);
                dataConn.Open();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmdDatabase);
                //conn.Open();
                //OleDbDataAdapter oda = new OleDbDataAdapter("select * from medicine", conn);
                dt = new DataTable();
                msda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataConn.Close();
                textBox1.Clear();
                textQty.Clear();
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //button2_Click(null, null);
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("drug_name like '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = dv;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textQty.Focus();
            }
        }

        private void textQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
