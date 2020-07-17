namespace PharmacyMS
{
    partial class AddItem
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
            this.textCompany = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.TextBox();
            this.textRate = new System.Windows.Forms.TextBox();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.textBatch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textCompany
            // 
            this.textCompany.Location = new System.Drawing.Point(441, 254);
            this.textCompany.Name = "textCompany";
            this.textCompany.Size = new System.Drawing.Size(171, 20);
            this.textCompany.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Company Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Expire Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 32);
            this.button2.TabIndex = 31;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 30;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Drug Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Amount";
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(125, 258);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(174, 20);
            this.textType.TabIndex = 26;
            this.textType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textType_KeyDown);
            // 
            // textRate
            // 
            this.textRate.Location = new System.Drawing.Point(441, 207);
            this.textRate.Name = "textRate";
            this.textRate.Size = new System.Drawing.Size(171, 20);
            this.textRate.TabIndex = 25;
            this.textRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textRate_KeyDown);
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(125, 211);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(174, 20);
            this.textAmount.TabIndex = 24;
            this.textAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textAmount_KeyDown);
            // 
            // textBatch
            // 
            this.textBatch.Location = new System.Drawing.Point(441, 125);
            this.textBatch.Name = "textBatch";
            this.textBatch.Size = new System.Drawing.Size(171, 20);
            this.textBatch.TabIndex = 23;
            this.textBatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBatch_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Batch No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(73, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Don\'t use a name which is already in database";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(125, 122);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(174, 20);
            this.textName.TabIndex = 20;
            this.textName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Drug Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Data Entry";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 358);
            this.Controls.Add(this.textCompany);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.textRate);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.textBatch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddItem";
            this.Text = "Add New Drug";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCompany;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.TextBox textRate;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.TextBox textBatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}