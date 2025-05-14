namespace WindowsFormsApp3
{
    partial class RegistrationWindow
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
            this.Welcome = new System.Windows.Forms.Label();
            this.PasswordReg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Registr = new System.Windows.Forms.Button();
            this.Pokazat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Welcome.Location = new System.Drawing.Point(310, 59);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(185, 31);
            this.Welcome.TabIndex = 1;
            this.Welcome.Text = "Регистрация";
            // 
            // PasswordReg
            // 
            this.PasswordReg.Location = new System.Drawing.Point(284, 211);
            this.PasswordReg.Name = "PasswordReg";
            this.PasswordReg.Size = new System.Drawing.Size(237, 20);
            this.PasswordReg.TabIndex = 12;
            this.PasswordReg.UseSystemPasswordChar = true;
            this.PasswordReg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(183, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Пароль";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(284, 166);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(237, 20);
            this.Username.TabIndex = 10;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(183, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Логин";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(284, 122);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(237, 20);
            this.Email.TabIndex = 14;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(183, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Почта";
            // 
            // Registr
            // 
            this.Registr.BackColor = System.Drawing.SystemColors.Menu;
            this.Registr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Registr.Location = new System.Drawing.Point(304, 262);
            this.Registr.Name = "Registr";
            this.Registr.Size = new System.Drawing.Size(199, 46);
            this.Registr.TabIndex = 17;
            this.Registr.Text = "Зарегистрироваться";
            this.Registr.UseVisualStyleBackColor = false;
            this.Registr.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pokazat
            // 
            this.Pokazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pokazat.Location = new System.Drawing.Point(527, 211);
            this.Pokazat.Name = "Pokazat";
            this.Pokazat.Size = new System.Drawing.Size(66, 20);
            this.Pokazat.TabIndex = 18;
            this.Pokazat.Text = "Показать";
            this.Pokazat.UseVisualStyleBackColor = true;
            this.Pokazat.Click += new System.EventHandler(this.Pokazat_Click);
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pokazat);
            this.Controls.Add(this.Registr);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Welcome);
            this.Name = "RegistrationWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.TextBox PasswordReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Registr;
        private System.Windows.Forms.Button Pokazat;
    }
}