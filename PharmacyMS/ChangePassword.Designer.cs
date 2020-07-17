namespace PharmacyMS
{
    partial class ChangePassword
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNConfirmPass = new System.Windows.Forms.TextBox();
            this.textNPass = new System.Windows.Forms.TextBox();
            this.textOPass = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "New Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Old Password:";
            // 
            // textNConfirmPass
            // 
            this.textNConfirmPass.Location = new System.Drawing.Point(260, 192);
            this.textNConfirmPass.Name = "textNConfirmPass";
            this.textNConfirmPass.Size = new System.Drawing.Size(207, 20);
            this.textNConfirmPass.TabIndex = 18;
            // 
            // textNPass
            // 
            this.textNPass.Location = new System.Drawing.Point(260, 150);
            this.textNPass.Name = "textNPass";
            this.textNPass.Size = new System.Drawing.Size(207, 20);
            this.textNPass.TabIndex = 17;
            this.textNPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textNPass_KeyDown);
            // 
            // textOPass
            // 
            this.textOPass.Location = new System.Drawing.Point(260, 107);
            this.textOPass.Name = "textOPass";
            this.textOPass.Size = new System.Drawing.Size(207, 20);
            this.textOPass.TabIndex = 16;
            this.textOPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textOPass_KeyDown);
            // 
            // textUser
            // 
            this.textUser.Enabled = false;
            this.textUser.Location = new System.Drawing.Point(260, 68);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(207, 20);
            this.textUser.TabIndex = 24;
            this.textUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textUser_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Username:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(260, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 32);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(260, 31);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(207, 20);
            this.textSearch.TabIndex = 26;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "ID:";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(589, 296);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNConfirmPass);
            this.Controls.Add(this.textNPass);
            this.Controls.Add(this.textOPass);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNConfirmPass;
        private System.Windows.Forms.TextBox textNPass;
        private System.Windows.Forms.TextBox textOPass;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label5;
    }
}