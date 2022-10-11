namespace WinFormWebService
{
    partial class frm_vatandasSorgu
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
            this.lbl_TcNo = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.lbl_soyIsim = new System.Windows.Forms.Label();
            this.lbl_dogumYili = new System.Windows.Forms.Label();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.txt_dogumYili = new System.Windows.Forms.TextBox();
            this.btn_sorgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_TcNo
            // 
            this.lbl_TcNo.AutoSize = true;
            this.lbl_TcNo.Location = new System.Drawing.Point(70, 43);
            this.lbl_TcNo.Name = "lbl_TcNo";
            this.lbl_TcNo.Size = new System.Drawing.Size(27, 13);
            this.lbl_TcNo.TabIndex = 0;
            this.lbl_TcNo.Text = "TC :";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(70, 86);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(35, 13);
            this.lbl_isim.TabIndex = 1;
            this.lbl_isim.Text = "İSİM :";
            // 
            // lbl_soyIsim
            // 
            this.lbl_soyIsim.AutoSize = true;
            this.lbl_soyIsim.Location = new System.Drawing.Point(70, 130);
            this.lbl_soyIsim.Name = "lbl_soyIsim";
            this.lbl_soyIsim.Size = new System.Drawing.Size(57, 13);
            this.lbl_soyIsim.TabIndex = 2;
            this.lbl_soyIsim.Text = "SOYİSİM :";
            // 
            // lbl_dogumYili
            // 
            this.lbl_dogumYili.AutoSize = true;
            this.lbl_dogumYili.Location = new System.Drawing.Point(70, 180);
            this.lbl_dogumYili.Name = "lbl_dogumYili";
            this.lbl_dogumYili.Size = new System.Drawing.Size(76, 13);
            this.lbl_dogumYili.TabIndex = 3;
            this.lbl_dogumYili.Text = "DOĞUM YILI :";
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.Location = new System.Drawing.Point(162, 40);
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(278, 20);
            this.txt_tcNo.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(162, 127);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(278, 20);
            this.txt_soyisim.TabIndex = 6;
            // 
            // txt_dogumYili
            // 
            this.txt_dogumYili.Location = new System.Drawing.Point(162, 177);
            this.txt_dogumYili.Name = "txt_dogumYili";
            this.txt_dogumYili.Size = new System.Drawing.Size(278, 20);
            this.txt_dogumYili.TabIndex = 7;
            // 
            // btn_sorgula
            // 
            this.btn_sorgula.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_sorgula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sorgula.Location = new System.Drawing.Point(162, 225);
            this.btn_sorgula.Name = "btn_sorgula";
            this.btn_sorgula.Size = new System.Drawing.Size(278, 39);
            this.btn_sorgula.TabIndex = 8;
            this.btn_sorgula.Text = "SORGULA";
            this.btn_sorgula.UseVisualStyleBackColor = false;
            this.btn_sorgula.Click += new System.EventHandler(this.btn_sorgula_Click);
            // 
            // frm_vatandasSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(528, 302);
            this.Controls.Add(this.btn_sorgula);
            this.Controls.Add(this.txt_dogumYili);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_tcNo);
            this.Controls.Add(this.lbl_dogumYili);
            this.Controls.Add(this.lbl_soyIsim);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.lbl_TcNo);
            this.Name = "frm_vatandasSorgu";
            this.Text = "Vatandaş Sorgulama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TcNo;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_soyIsim;
        private System.Windows.Forms.Label lbl_dogumYili;
        private System.Windows.Forms.TextBox txt_tcNo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.TextBox txt_dogumYili;
        private System.Windows.Forms.Button btn_sorgula;
    }
}

