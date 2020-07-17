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

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PharmacyMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.ActiveControl = textSearch;
            textSearch.Focus();
            SetBillNo();
            FillCombo();
            //FillComboDel();
            textDiscount.Text = "0";
            
        }
  
        string sqlConn = "datasource=127.0.0.1;port=3306;username=root;password=;database=CDMS;";


        int bill;
        void SetBillNo()
        {

            string query1 = "select * from sale_info order by bill_no asc";
            MySqlConnection dataConn = new MySqlConnection(sqlConn);
            MySqlCommand cmdDatabase = new MySqlCommand(query1, dataConn);
            dataConn.Open();
            MySqlDataAdapter BDTA = new MySqlDataAdapter(cmdDatabase);

            DataTable BDT = new DataTable();
            BDTA.Fill(BDT);
            int BillCount = BDT.Rows.Count;
            if (BillCount == 0)
            {
                string setBill = "1";
                textBillNum.Text = setBill;
                bill = Convert.ToInt32(setBill);
            }
            else
            {
                string getBill = BDT.Rows[BillCount - 1]["bill_no"].ToString();
                bill = int.Parse(getBill);
                bill = bill + 1;
                string setBill = Convert.ToString(bill);
                textBillNum.Text = setBill;
            }
            dataConn.Close();
            /*MySqlConnection dataConn = new MySqlConnection(sqlConn);
            MySqlCommand cmdDatabase = new MySqlCommand(query, dataConn);
            dataConn.Open();
            MySqlDataReader sqlReader = cmdDatabase.ExecuteReader();
            int BillCount = 0;
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    BillCount++;
                }
            }
            if (BillCount == 0)
            {
                string setBill = "1";
                textBillNum.Text = setBill;
                bill = Convert.ToInt32(setBill);
            }
            else
            {
                BillCount--;
                string query1 = "select * from sale_info order by bill_no where id = '" + BillCount + "'";
                MySqlCommand cmdDatabase1 = new MySqlCommand(query1, dataConn);
                MySqlDataReader sqlReader1 = cmdDatabase1.ExecuteReader();
                if (sqlReader1.Read())
                {
                    string getBill = sqlReader1["bill_no"].ToString();
                    bill = int.Parse(getBill);
                    bill = bill + 1;
                    string setBill = Convert.ToString(bill);
                    textBillNum.Text = setBill;
                }
            }*/

        }

        void FillCombo()
        {
            textSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

            textSearch.AutoCompleteCustomSource = coll;
        }
        void FillTable()
        {
            try
            {
                string query1 = "select drug_name,batch_no,drug_type,company_name,expire_date,quantity,mrp,total_amount from sale_info where bill_no = '" + textBillNum.Text.ToString() + "'";
                MySqlConnection dataConn = new MySqlConnection(sqlConn);
                MySqlCommand cmdDatabase = new MySqlCommand(query1, dataConn);
                dataConn.Open();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmdDatabase);
                
                DataTable dtt = new DataTable();
                msda.Fill(dtt);
                dataGridViewSale.DataSource = dtt;
                int count = dtt.Rows.Count;
                float total_taka, sum = 0;
                for (int i = 0; i < count; i++)
                {
                    string totalAmount = dtt.Rows[i]["total_amount"].ToString();
                    total_taka = float.Parse(totalAmount);
                    sum = sum + total_taka;
                }
                textTotalAmount.Text = Convert.ToString(sum);
                textFinalAmount.Text = Convert.ToString(sum);
                dataConn.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void createUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RegisterUser fm1 = new RegisterUser();
            fm1.Show();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddItem adf = new AddItem();
            adf.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ViewStock dsf = new ViewStock();
            dsf.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textSearch_TextChanged_1(object sender, EventArgs e)
        {
            string query1 = "select * from medicine where drug_name='" + textSearch.Text.ToString() + "'";
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
                    string getBatch = dta.Rows[i]["batch_no"].ToString();
                    string getAmount = dta.Rows[i]["amount"].ToString();
                    string getRate = dta.Rows[i]["rate"].ToString();
                    string getExDate = dta.Rows[i]["expire_date"].ToString();
                    string drgType = dta.Rows[i]["drug_type"].ToString();
                    string company = dta.Rows[i]["company_name"].ToString();

                    textAvailable.Text = getAmount;
                    textExDate.Text = getExDate;
                    textBatch.Text = getBatch;
                    textMrp.Text = getRate;
                    textDrugType .Text = drgType;
                    textCompanyName.Text = company;
                }
                dataConn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                dataConn.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for (int j = 0; j < dataGridViewSale.Rows.Count-1; j++)
            {
                //MessageBox.Show(dataGridViewSale[0, j].Value.ToString());
                if (dataGridViewSale[0, j].Value.ToString().ToLower() == textSearch.Text.ToLower())
                {
                    flag = true;
                }
            }
            if (flag)
            {
                MessageBox.Show("Medicine already exists.");

            }
            else
            {
                textSearch.Focus();
                string query1 = "select * from medicine where drug_name='" + textSearch.Text.ToString() + "'";
                MySqlConnection dataConn = new MySqlConnection(sqlConn);
                MySqlCommand cmdDatabase = new MySqlCommand(query1, dataConn);
                try
                {
                    dataConn.Open();
                    float getRate, getTotal, getAmount, available, updateAmount;
                    int getBill = int.Parse(textBillNum.Text);
                    available = int.Parse(textAvailable.Text);
                    getRate = float.Parse(textMrp.Text);
                    getAmount = float.Parse(textQty.Text);
                    updateAmount = available - getAmount;
                    getTotal = getRate * getAmount;
                    textTotal.Text = Convert.ToString(getTotal);

                    // Checking whether the medicine is Available or not...................
                    string Qty;
                    int getqty = 0;
                    //OleDbDataAdapter chkAdtr = new OleDbDataAdapter("select * from medicine where drug_name='" + textSearch.Text.ToString() + "'", conn);
                    MySqlDataAdapter chkAdtr = new MySqlDataAdapter(cmdDatabase);
                    DataTable chkTbl = new DataTable();
                    chkAdtr.Fill(chkTbl);
                    int chkCount = chkTbl.Rows.Count;
                    for (int i = 0; i < chkCount; i++)
                    {
                        Qty = chkTbl.Rows[i]["amount"].ToString();
                        getqty = int.Parse(Qty);
                    }
                    dataConn.Close();
                    if (getqty >= int.Parse(textQty.Text.ToString()))
                    {
                        string query2 = "insert into sale_info values('" + bill + "','" + textSearch.Text.ToString() + "','" + textBatch.Text.ToString() + "','" + textDrugType.Text.ToString() + "','" + textCompanyName.Text.ToString() + "','" + textExDate.Text.ToString() + "','" + getAmount + "','" + getRate + "','" + getTotal + "','" + this.dateTimePicker1.Text.ToString() + "')";
                        MySqlConnection dataConn2 = new MySqlConnection(sqlConn);
                        MySqlCommand insrtcmd = new MySqlCommand(query2, dataConn2);
                        dataConn2.Open();
                        MySqlDataReader MyReader2 = insrtcmd.ExecuteReader();
                        while (MyReader2.Read())
                        {
                        }
                        //MyReader2.Close();
                        dataConn2.Close();
                        //OleDbCommand insrtcmd = new OleDbCommand("insert into sale_info values('" + bill + "','" + textSearch.Text.ToString() + "','" + textBatch.Text.ToString() + "','" + textDrugType.Text.ToString() + "','" + textCompanyName.Text.ToString() + "','" + textExDate.Text.ToString() + "','" + getAmount + "','" + getRate + "','" + getTotal + "','" + this.dateTimePicker1.Text.ToString() + "')", conn);
                        //insrtcmd.ExecuteNonQuery();

                        string query3 = "update medicine set amount='" + updateAmount + "' where drug_name='" + textSearch.Text.ToString() + "'";
                        MySqlConnection dataConn3 = new MySqlConnection(sqlConn);
                        MySqlCommand updatecmd = new MySqlCommand(query3, dataConn3);
                        dataConn3.Open();
                        MySqlDataReader MyReader3 = updatecmd.ExecuteReader();
                        while (MyReader3.Read())
                        {
                        }
                        dataConn3.Close();
                        //OleDbCommand updatecmd = new OleDbCommand("update medicine set amount='" + updateAmount + "' where drug_name='" + textSearch.Text.ToString() + "'", conn);
                        ///updatecmd.ExecuteNonQuery();

                        textAvailable.Text = Convert.ToString(updateAmount);
                        string query4 = "select drug_name,batch_no,drug_type,company_name,expire_date,quantity,mrp,total_amount from sale_info where bill_no='" + getBill + "'";
                        MySqlConnection dataConn4 = new MySqlConnection(sqlConn);
                        MySqlCommand cmdDatabase4 = new MySqlCommand(query4, dataConn);
                        dataConn4.Open();
                        MySqlDataAdapter msda = new MySqlDataAdapter(cmdDatabase4);

                        // OleDbDataAdapter oda = new OleDbDataAdapter("select * from sale_info where bill_no='"+getBill+"'",conn);
                        //OleDbDataAdapter oda = new OleDbDataAdapter("select drug_name,batch_no,drug_type,company_name,expire_date,quantity,mrp,total_amount from sale_info where bill_no='" + getBill + "'", conn);
                        //conn.Close();
                        DataTable dtt = new DataTable();
                        msda.Fill(dtt);
                        dataGridViewSale.DataSource = dtt;
                        dataConn4.Close();
                        // Calculating total Bill..........
                        int count = dtt.Rows.Count;
                        float total_taka, sum = 0;
                        for (int i = 0; i < count; i++)
                        {
                            string totalAmount = dtt.Rows[i]["total_amount"].ToString();
                            total_taka = float.Parse(totalAmount);
                            sum = sum + total_taka;
                        }
                        textTotalAmount.Text = Convert.ToString(sum);
                        textFinalAmount.Text = Convert.ToString(sum);

                        string med1 = textSearch.Text;
                        comboBox1.Items.Add(med1);
                    }
                    else
                    {
                        MessageBox.Show("Sorry! This medicine is not available.");

                    }
                    textAvailable.Clear();
                    textQty.Clear();
                    textBatch.Clear();
                    textDrugType.Clear();
                    textExDate.Clear();
                    textCompanyName.Clear();
                    textMrp.Clear();
                    //textTotal.Clear();
                    textSearch.Clear();
                    
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewBill vb = new ViewBill();
            vb.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float calDiscount, finalResult;
            float diccount;
            string getDiscount = textDiscount.Text.ToString();
            string getSum = textTotalAmount.Text.ToString();
            float sum = float.Parse(getSum);
            diccount = float.Parse(getDiscount);
            calDiscount = (diccount * sum) / 100;
            finalResult = sum - calDiscount;
            textFinalAmount.Text = Convert.ToString(finalResult);
        }

        void FillTableA()
        {
            try
            {
                string query1 = "select drug_name,batch_no,drug_type,company_name,expire_date,quantity,mrp,total_amount from sale_info where bill_no='" + textBillNum.Text.ToString() + "'";
                MySqlConnection dataConn = new MySqlConnection(sqlConn);
                MySqlCommand cmdDatabase = new MySqlCommand(query1, dataConn);
                dataConn.Open();
                MySqlDataAdapter msda = new MySqlDataAdapter(cmdDatabase);
                //conn.Open();
                // OleDbDataAdapter oda = new OleDbDataAdapter("select * from sale_info where bill_no='" + textBillNum.Text.ToString() + "'", conn);
                //OleDbDataAdapter oda = new OleDbDataAdapter("select drug_name,batch_no,drug_type,company_name,expire_date,quantity,mrp,total_amount from sale_info where bill_no='" + textBillNum.Text.ToString() + "'", conn);
                
                DataTable dtt = new DataTable();
                msda.Fill(dtt);
                dataGridViewSale.DataSource = dtt;
                int count = dtt.Rows.Count;
                float total_taka, sum = 0;
                for (int i = 0; i < count; i++)
                {
                    string totalAmount = dtt.Rows[i]["total_amount"].ToString();
                    total_taka = float.Parse(totalAmount);
                    sum = sum + total_taka;
                }
                dataConn.Close();
                textTotalAmount.Text = Convert.ToString(sum);
                textFinalAmount.Text = Convert.ToString(sum);
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                string medicine_name = comboBox1.Text.ToString();

                string query1 = "select quantity from sale_info where drug_name='" + comboBox1.Text.ToString() + "' and bill_no='" + textBillNum.Text.ToString() + "'";
                MySqlConnection dataConn = new MySqlConnection(sqlConn);
                MySqlCommand cmdDatabase = new MySqlCommand(query1, dataConn);
                dataConn.Open();
                MySqlDataReader sqlReader = cmdDatabase.ExecuteReader();
                sqlReader.Read();
                string qty = sqlReader.GetString(0);
                sqlReader.Close();
                dataConn.Close();

                string query2 = "select amount from medicine where drug_name='" + medicine_name + "'";
                MySqlConnection dataConn2 = new MySqlConnection(sqlConn);
                MySqlCommand cmdDatabase2 = new MySqlCommand(query2, dataConn2);
                dataConn2.Open();
                MySqlDataReader sqlReader2 = cmdDatabase2.ExecuteReader();
                sqlReader2.Read();
                string totalqty = sqlReader2.GetString(0);
                
                sqlReader2.Close();
                dataConn2.Close();
                int amt = int.Parse(totalqty)+int.Parse(qty);
                string query3 = "update medicine set amount='" + amt + "' where drug_name='" + medicine_name + "'";
                MySqlConnection dataConn3 = new MySqlConnection(sqlConn);
                MySqlCommand updatecmd = new MySqlCommand(query3, dataConn3);
                dataConn3.Open();
                MySqlDataReader MyReader3 = updatecmd.ExecuteReader();
                while (MyReader3.Read())
                {
                }
                MyReader3.Close();
                dataConn3.Close();

                string query4 = "delete from sale_info where drug_name='" + comboBox1.Text.ToString() + "' and bill_no='" + textBillNum.Text.ToString() + "'";
                MySqlConnection dataConn5 = new MySqlConnection(sqlConn);
                MySqlCommand dltcmd = new MySqlCommand(query4, dataConn5);
                dataConn5.Open();
                MySqlDataReader MyReader4 = dltcmd.ExecuteReader();
                while (MyReader4.Read())
                {
                }
                MyReader4.Close();
                dataConn5.Close();

                
                textAvailable.Clear();
                textQty.Clear();
                textBatch.Clear();
                textDrugType.Clear();
                textExDate.Clear();
                textCompanyName.Clear();
                textMrp.Clear();
                textTotal.Clear();
                textSearch.Clear();
                //conn.Open();
                //OleDbCommand dltcmd = new OleDbCommand("delete from sale_info where drug_name='" + textDelete.Text.ToString() + "' and bill_no='" + textBillNum.Text.ToString() + "'", conn);
                //dltcmd.ExecuteNonQuery();
                //conn.Close();

                FillTableA();
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DaySell dfm = new DaySell();
            dfm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Modify mfm = new Modify();
            mfm.Show();
        }

        private void dataGridViewSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewSale.Rows[e.RowIndex];
                comboBox1.Text = row.Cells["drug_name"].Value.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string query2 = "insert into payment_bill values('" + textBillNum.Text.ToString() + "','" + textTotalAmount.Text.ToString() + "','" + textDiscount.Text.ToString() + "','" + textFinalAmount.Text.ToString() + "','" + this.dateTimePicker1.Text.ToString() + "')";
                MySqlConnection dataConn2 = new MySqlConnection(sqlConn);
                MySqlCommand insrtcmd = new MySqlCommand(query2, dataConn2);
                dataConn2.Open();
                MySqlDataReader MyReader2 = insrtcmd.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                MyReader2.Close();
                dataConn2.Close();

                //conn.Open();
                //OleDbCommand insrtpayment = new OleDbCommand("insert into payment_bill values('" + textBillNum.Text.ToString() + "','" + textTotalAmount.Text.ToString() + "','" + textDiscount.Text.ToString() + "','" + textFinalAmount.Text.ToString() + "','" + this.dateTimePicker1.Text.ToString() + "')", conn);
                //insrtpayment.ExecuteNonQuery();
                //MessageBox.Show("Inserted");
                //conn.Close();
               

                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter pwri = PdfWriter.GetInstance(doc, new FileStream(textBillNum.Text.ToString() + ".pdf", FileMode.Create));
                doc.Open();
                
                Paragraph para = new Paragraph("                                           Welcome to Pharmacy\n"
                    + "                                           Lahore, Pakistan\n                                           Receipt of the Customer"
                    + "\nBill No." + textBillNum.Text.ToString()
                    + "\nTotal Amount: " + textTotalAmount.Text.ToString() + "\nDiscount: " + textDiscount.Text.ToString() + " %"
                    + "\nPayable Amount: " + textFinalAmount.Text.ToString() + "\nDate of Sale: " + this.dateTimePicker1.Text.ToString() + "\n\n");
                doc.Add(para);

               //Adding dataGridView to the PDF

               PdfPTable pdfTable = new PdfPTable(dataGridViewSale.Columns.Count);
                for (int i = 0; i < dataGridViewSale.Columns.Count; i++)
                {
                    pdfTable.AddCell(new Phrase(dataGridViewSale.Columns[i].HeaderText));
                }
                pdfTable.HeaderRows = 1;
                for (int j = 0; j < dataGridViewSale.Rows.Count; j++)
                {
                    for (int k = 0; k < dataGridViewSale.Columns.Count; k++)
                    {
                        if (dataGridViewSale[k, j].Value != null)
                        {
                            pdfTable.AddCell(new Phrase(dataGridViewSale[k, j].Value.ToString()));
                        }
                    }
                }
               
                
                doc.Add(pdfTable);
                doc.Close();


                
                string foo = textBillNum.Text.ToString();
                StringBuilder path = new StringBuilder();
                foreach (char c in foo)
                {
                    path.Append(c);
                }
                path.Append(".pdf");
                //System.Diagnostics.Process.Start(path.ToString());
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(path.ToString()) { UseShellExecute = true });


                /*
                PrintDialog Dialog = new PrintDialog();
                Dialog.ShowDialog();
                ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                {
                    Verb = "print",
                    CreateNoWindow = true,
                    FileName = Filepath,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process printProcess = new Process();
                printProcess.StartInfo = printProcessInfo;
                printProcess.Start();

                printProcess.WaitForInputIdle();

                Thread.Sleep(3000);

                if (false == printProcess.CloseMainWindow())
                {
                    printProcess.Kill();
                }

                PdfDocument doc1 = new PdfDocument("13.pdf,open");

                doc1.OpenDocument();

 

            //Use the default printer to print all the pages

            //doc.PrintDocument.Print();

 

            //Set the printer and select the pages you want to print

 

                PrintDialog dialogPrint = new PrintDialog();

                dialogPrint.AllowPrintToFile = true;

                dialogPrint.AllowSomePages = true;

                dialogPrint.PrinterSettings.MinimumPage = 1;

                dialogPrint.PrinterSettings.MaximumPage = doc.Pages.Count;

                dialogPrint.PrinterSettings.FromPage = 1;

                dialogPrint.PrinterSettings.ToPage = doc.Pages.Count;

           

                if (dialogPrint.ShowDialog() == DialogResult.OK)

                {

                    doc.PrintFromPage = dialogPrint.PrinterSettings.FromPage;

                    doc.PrintToPage = dialogPrint.PrinterSettings.ToPage;

                    doc.PrinterName = dialogPrint.PrinterSettings.PrinterName;

 

                    PrintDocument printDoc = doc.PrintDocument;

                    printDoc.Print();
                }
                
                */




                this.Hide();
                MainForm mf = new MainForm();
                mf.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword mf = new ChangePassword();
            mf.Show();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem adf = new AddItem();
            adf.Show();
        }

        private void modifyStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modify mfm = new Modify();
            mfm.Show();
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStock dsf = new ViewStock();
            dsf.Show();
        }

        private void viewSellPerDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DaySell dfm = new DaySell();
            dfm.Show();
        }

        private void viewBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBill vb = new ViewBill();
            vb.Show();
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textSearch.Text!=null)
            {
                textQty.Focus();
            }

            if (e.Control && e.KeyCode == Keys.N)
            {
                MainForm mf2 = new MainForm();
                mf2.Show();
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                comboBox1.Focus();
            }
        }

        private void textQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textQty.Text != null)
            {
                button3.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.N)
            {
                MainForm mf2 = new MainForm();
                mf2.Show();
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                comboBox1.Focus();
            }
        }

        /*private void textDelete_TextChanged(object sender, EventArgs e)
        {
            textDelete.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textDelete.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            for (int j = 0; j < dataGridViewSale.Rows.Count-1; j++)
            {
                string getName = dataGridViewSale[0, j].Value.ToString();
                //MessageBox.Show(dataGridViewSale[0, j].Value.ToString());
                coll.Add(getName);
            }
            textDelete.AutoCompleteCustomSource = coll;


            /*
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
            

        }
        void FillComboDel()
        {
            textDelete.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textDelete.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string query1 = "select drug_name from sale_info where bill_no='" + textBillNum.Text.ToString() + "'";
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
            textDelete.AutoCompleteCustomSource = coll;
        }
        private void textDelete_TextChanged_1(object sender, EventArgs e)
        {
            FillComboDel();
        }
        */
        private void viewSellPerMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthSell dfm = new MonthSell();
            dfm.Show();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.N)
            {
                MainForm mf2 = new MainForm();
                mf2.Show();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void textDelete_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox1.Text != null)
            {
                button6.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                MainForm mf2 = new MainForm();
                mf2.Show();
            }

            if (e.Control && e.KeyCode == Keys.D)
            {
                comboBox1.Focus();
            }
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textSearch.Focus();
            }
        }
    }
}
