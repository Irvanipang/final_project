namespace counter_pulsa
{
    partial class Form1
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
            this.counter = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnmasuk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.ForeColor = System.Drawing.SystemColors.Control;
            this.counter.Location = new System.Drawing.Point(256, 42);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(175, 28);
            this.counter.TabIndex = 0;
            this.counter.Text = "Counter Pulsa";
            this.counter.Click += new System.EventHandler(this.counter_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.Control;
            this.login.Location = new System.Drawing.Point(317, 103);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(52, 18);
            this.login.TabIndex = 1;
            this.login.Text = "Login";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.Control;
            this.username.Location = new System.Drawing.Point(57, 155);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(90, 18);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.Control;
            this.password.Location = new System.Drawing.Point(57, 207);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(87, 18);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.Snow;
            this.txtusername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtusername.Location = new System.Drawing.Point(226, 154);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(239, 20);
            this.txtusername.TabIndex = 4;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Snow;
            this.txtpassword.Location = new System.Drawing.Point(226, 206);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(239, 20);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // btnmasuk
            // 
            this.btnmasuk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmasuk.Location = new System.Drawing.Point(226, 294);
            this.btnmasuk.Name = "btnmasuk";
            this.btnmasuk.Size = new System.Drawing.Size(106, 23);
            this.btnmasuk.TabIndex = 6;
            this.btnmasuk.Text = "MASUK";
            this.btnmasuk.UseVisualStyleBackColor = true;
            this.btnmasuk.Click += new System.EventHandler(this.btnmasuk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(683, 396);
            this.Controls.Add(this.btnmasuk);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.login);
            this.Controls.Add(this.counter);
            this.Name = "Form1";
            this.Text = "Form Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnmasuk;
    }
}

