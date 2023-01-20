namespace Voucher
{
    partial class Form4
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
            this.Voucher = new System.Windows.Forms.Label();
            this.nomorhp = new System.Windows.Forms.Label();
            this.paket = new System.Windows.Forms.Label();
            this.txthp = new System.Windows.Forms.TextBox();
            this.cmbpaket = new System.Windows.Forms.ComboBox();
            this.btnbeli = new System.Windows.Forms.Button();
            this.btnbatal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Voucher
            // 
            this.Voucher.AutoSize = true;
            this.Voucher.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voucher.ForeColor = System.Drawing.Color.White;
            this.Voucher.Location = new System.Drawing.Point(75, 49);
            this.Voucher.Name = "Voucher";
            this.Voucher.Size = new System.Drawing.Size(96, 24);
            this.Voucher.TabIndex = 0;
            this.Voucher.Text = "Voucher";
            // 
            // nomorhp
            // 
            this.nomorhp.AutoSize = true;
            this.nomorhp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomorhp.ForeColor = System.Drawing.Color.White;
            this.nomorhp.Location = new System.Drawing.Point(76, 126);
            this.nomorhp.Name = "nomorhp";
            this.nomorhp.Size = new System.Drawing.Size(88, 18);
            this.nomorhp.TabIndex = 1;
            this.nomorhp.Text = "Nomor HP";
            // 
            // paket
            // 
            this.paket.AutoSize = true;
            this.paket.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paket.ForeColor = System.Drawing.Color.White;
            this.paket.Location = new System.Drawing.Point(76, 183);
            this.paket.Name = "paket";
            this.paket.Size = new System.Drawing.Size(191, 18);
            this.paket.TabIndex = 2;
            this.paket.Text = "Paket Spesial Untukmu";
            this.paket.Click += new System.EventHandler(this.label3_Click);
            // 
            // txthp
            // 
            this.txthp.Location = new System.Drawing.Point(305, 125);
            this.txthp.Name = "txthp";
            this.txthp.Size = new System.Drawing.Size(178, 20);
            this.txthp.TabIndex = 3;
            // 
            // cmbpaket
            // 
            this.cmbpaket.FormattingEnabled = true;
            this.cmbpaket.Items.AddRange(new object[] {
            "13GB/Rp.20.000,00",
            "17GB/Rp.25.000,00",
            "20GB/Rp.30.000,00"});
            this.cmbpaket.Location = new System.Drawing.Point(305, 183);
            this.cmbpaket.Name = "cmbpaket";
            this.cmbpaket.Size = new System.Drawing.Size(180, 21);
            this.cmbpaket.TabIndex = 4;
            // 
            // btnbeli
            // 
            this.btnbeli.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbeli.Location = new System.Drawing.Point(305, 285);
            this.btnbeli.Name = "btnbeli";
            this.btnbeli.Size = new System.Drawing.Size(73, 23);
            this.btnbeli.TabIndex = 5;
            this.btnbeli.Text = "Beli";
            this.btnbeli.UseVisualStyleBackColor = true;
            this.btnbeli.Click += new System.EventHandler(this.btnbeli_Click);
            // 
            // btnbatal
            // 
            this.btnbatal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbatal.Location = new System.Drawing.Point(407, 285);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(76, 23);
            this.btnbatal.TabIndex = 6;
            this.btnbatal.Text = "Batal";
            this.btnbatal.UseVisualStyleBackColor = true;
            this.btnbatal.Click += new System.EventHandler(this.btnbatal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.White;
            this.lblemail.Location = new System.Drawing.Point(76, 242);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(55, 18);
            this.lblemail.TabIndex = 8;
            this.lblemail.Text = "E-Mail";
            this.lblemail.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(583, 374);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.btnbeli);
            this.Controls.Add(this.cmbpaket);
            this.Controls.Add(this.txthp);
            this.Controls.Add(this.paket);
            this.Controls.Add(this.nomorhp);
            this.Controls.Add(this.Voucher);
            this.Name = "Form4";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Voucher;
        private System.Windows.Forms.Label nomorhp;
        private System.Windows.Forms.Label paket;
        private System.Windows.Forms.TextBox txthp;
        private System.Windows.Forms.ComboBox cmbpaket;
        private System.Windows.Forms.Button btnbeli;
        private System.Windows.Forms.Button btnbatal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblemail;
    }
}

