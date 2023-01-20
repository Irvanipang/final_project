namespace Pulsa
{
    partial class Form3
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
            this.pulsa = new System.Windows.Forms.Label();
            this.nomor = new System.Windows.Forms.Label();
            this.nominal = new System.Windows.Forms.Label();
            this.txtnomor = new System.Windows.Forms.TextBox();
            this.cmbnominal = new System.Windows.Forms.ComboBox();
            this.btnbeli = new System.Windows.Forms.Button();
            this.btnbatal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pulsa
            // 
            this.pulsa.AutoSize = true;
            this.pulsa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulsa.ForeColor = System.Drawing.Color.White;
            this.pulsa.Location = new System.Drawing.Point(38, 54);
            this.pulsa.Name = "pulsa";
            this.pulsa.Size = new System.Drawing.Size(66, 24);
            this.pulsa.TabIndex = 0;
            this.pulsa.Text = "Pulsa";
            this.pulsa.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomor
            // 
            this.nomor.AutoSize = true;
            this.nomor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomor.ForeColor = System.Drawing.Color.White;
            this.nomor.Location = new System.Drawing.Point(39, 130);
            this.nomor.Name = "nomor";
            this.nomor.Size = new System.Drawing.Size(88, 18);
            this.nomor.TabIndex = 1;
            this.nomor.Text = "Nomor HP";
            // 
            // nominal
            // 
            this.nominal.AutoSize = true;
            this.nominal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nominal.ForeColor = System.Drawing.Color.White;
            this.nominal.Location = new System.Drawing.Point(39, 177);
            this.nominal.Name = "nominal";
            this.nominal.Size = new System.Drawing.Size(72, 18);
            this.nominal.TabIndex = 2;
            this.nominal.Text = "Nominal";
            // 
            // txtnomor
            // 
            this.txtnomor.Location = new System.Drawing.Point(204, 128);
            this.txtnomor.Name = "txtnomor";
            this.txtnomor.Size = new System.Drawing.Size(213, 20);
            this.txtnomor.TabIndex = 3;
            this.txtnomor.TextChanged += new System.EventHandler(this.txtnomor_TextChanged);
            // 
            // cmbnominal
            // 
            this.cmbnominal.FormattingEnabled = true;
            this.cmbnominal.Items.AddRange(new object[] {
            "Rp5.000,00",
            "Rp10.000,00",
            "Rp20.000,00",
            "Rp50.000,00",
            "Rp100.000,00"});
            this.cmbnominal.Location = new System.Drawing.Point(204, 177);
            this.cmbnominal.Name = "cmbnominal";
            this.cmbnominal.Size = new System.Drawing.Size(213, 21);
            this.cmbnominal.TabIndex = 4;
            this.cmbnominal.SelectedIndexChanged += new System.EventHandler(this.cmbnominal_SelectedIndexChanged);
            // 
            // btnbeli
            // 
            this.btnbeli.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbeli.Location = new System.Drawing.Point(204, 293);
            this.btnbeli.Name = "btnbeli";
            this.btnbeli.Size = new System.Drawing.Size(93, 23);
            this.btnbeli.TabIndex = 5;
            this.btnbeli.Text = "Beli";
            this.btnbeli.UseVisualStyleBackColor = true;
            this.btnbeli.Click += new System.EventHandler(this.btnbeli_Click);
            // 
            // btnbatal
            // 
            this.btnbatal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbatal.Location = new System.Drawing.Point(324, 293);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(93, 23);
            this.btnbatal.TabIndex = 6;
            this.btnbatal.Text = "Batal";
            this.btnbatal.UseVisualStyleBackColor = true;
            this.btnbatal.Click += new System.EventHandler(this.btnbatal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.White;
            this.lblemail.Location = new System.Drawing.Point(39, 226);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(55, 18);
            this.lblemail.TabIndex = 8;
            this.lblemail.Text = "E-Mail";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(586, 380);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.btnbeli);
            this.Controls.Add(this.cmbnominal);
            this.Controls.Add(this.txtnomor);
            this.Controls.Add(this.nominal);
            this.Controls.Add(this.nomor);
            this.Controls.Add(this.pulsa);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pulsa;
        private System.Windows.Forms.Label nomor;
        private System.Windows.Forms.Label nominal;
        private System.Windows.Forms.TextBox txtnomor;
        private System.Windows.Forms.ComboBox cmbnominal;
        private System.Windows.Forms.Button btnbeli;
        private System.Windows.Forms.Button btnbatal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblemail;
    }
}

