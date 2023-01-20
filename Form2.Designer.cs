namespace Menu
{
    partial class Form2
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
            this.menu = new System.Windows.Forms.Label();
            this.btnpulsa = new System.Windows.Forms.Button();
            this.btnvoucher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu.Location = new System.Drawing.Point(279, 52);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(73, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "MENU";
            // 
            // btnpulsa
            // 
            this.btnpulsa.BackColor = System.Drawing.Color.White;
            this.btnpulsa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpulsa.Location = new System.Drawing.Point(184, 125);
            this.btnpulsa.Name = "btnpulsa";
            this.btnpulsa.Size = new System.Drawing.Size(90, 83);
            this.btnpulsa.TabIndex = 1;
            this.btnpulsa.Text = "Pulsa";
            this.btnpulsa.UseVisualStyleBackColor = false;
            this.btnpulsa.Click += new System.EventHandler(this.btnpulsa_Click);
            // 
            // btnvoucher
            // 
            this.btnvoucher.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoucher.Location = new System.Drawing.Point(359, 125);
            this.btnvoucher.Name = "btnvoucher";
            this.btnvoucher.Size = new System.Drawing.Size(91, 83);
            this.btnvoucher.TabIndex = 2;
            this.btnvoucher.Text = "Voucher";
            this.btnvoucher.UseVisualStyleBackColor = true;
            this.btnvoucher.Click += new System.EventHandler(this.btnvoucher_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(637, 362);
            this.Controls.Add(this.btnvoucher);
            this.Controls.Add(this.btnpulsa);
            this.Controls.Add(this.menu);
            this.Name = "Form2";
            this.Text = "Form menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Button btnpulsa;
        private System.Windows.Forms.Button btnvoucher;
    }
}

