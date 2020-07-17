namespace PharmacyMS
{
    partial class RegisterUser
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCConfirmPass = new System.Windows.Forms.TextBox();
            this.textCPassword = new System.Windows.Forms.TextBox();
            this.textCUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(228, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(331, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "User Name";
            // 
            // textCConfirmPass
            // 
            this.textCConfirmPass.Location = new System.Drawing.Point(228, 146);
            this.textCConfirmPass.Name = "textCConfirmPass";
            this.textCConfirmPass.Size = new System.Drawing.Size(207, 20);
            this.textCConfirmPass.TabIndex = 10;
            // 
            // textCPassword
            // 
            this.textCPassword.Location = new System.Drawing.Point(228, 104);
            this.textCPassword.Name = "textCPassword";
            this.textCPassword.Size = new System.Drawing.Size(207, 20);
            this.textCPassword.TabIndex = 9;
            this.textCPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCPassword_KeyDown);
            // 
            // textCUserName
            // 
            this.textCUserName.Location = new System.Drawing.Point(228, 61);
            this.textCUserName.Name = "textCUserName";
            this.textCUserName.Size = new System.Drawing.Size(207, 20);
            this.textCUserName.TabIndex = 8;
            this.textCUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCUserName_KeyDown);
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(521, 282);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCConfirmPass);
            this.Controls.Add(this.textCPassword);
            this.Controls.Add(this.textCUserName);
            this.Name = "RegisterUser";
            this.Text = "Create New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCConfirmPass;
        private System.Windows.Forms.TextBox textCPassword;
        private System.Windows.Forms.TextBox textCUserName;
    }
}