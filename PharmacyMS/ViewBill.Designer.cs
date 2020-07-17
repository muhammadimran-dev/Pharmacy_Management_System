namespace PharmacyMS
{
    partial class ViewBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBillNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPayAmount = new System.Windows.Forms.TextBox();
            this.textDiscount = new System.Windows.Forms.TextBox();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(816, 252);
            this.dataGridView1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(240, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBillNo
            // 
            this.textBillNo.Location = new System.Drawing.Point(133, 101);
            this.textBillNo.Name = "textBillNo";
            this.textBillNo.Size = new System.Drawing.Size(86, 20);
            this.textBillNo.TabIndex = 19;
            this.textBillNo.TextChanged += new System.EventHandler(this.textBillNo_TextChanged);
            this.textBillNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBillNo_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Enter Bill No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "View Previous Bill / Invoice";
            // 
            // textPayAmount
            // 
            this.textPayAmount.Enabled = false;
            this.textPayAmount.Location = new System.Drawing.Point(737, 101);
            this.textPayAmount.Name = "textPayAmount";
            this.textPayAmount.Size = new System.Drawing.Size(100, 20);
            this.textPayAmount.TabIndex = 16;
            // 
            // textDiscount
            // 
            this.textDiscount.Enabled = false;
            this.textDiscount.Location = new System.Drawing.Point(737, 58);
            this.textDiscount.Name = "textDiscount";
            this.textDiscount.Size = new System.Drawing.Size(100, 20);
            this.textDiscount.TabIndex = 15;
            // 
            // textAmount
            // 
            this.textAmount.Enabled = false;
            this.textAmount.Location = new System.Drawing.Point(737, 19);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(100, 20);
            this.textAmount.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(595, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total Payable Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Discount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Amount";
            // 
            // ViewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(854, 414);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBillNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPayAmount);
            this.Controls.Add(this.textDiscount);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewBill";
            this.Text = "Customer Previous Bill/Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBillNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPayAmount;
        private System.Windows.Forms.TextBox textDiscount;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}