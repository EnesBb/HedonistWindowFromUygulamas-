namespace HedonistProjeOdev
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
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.Location = new System.Drawing.Point(91, 67);
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.Size = new System.Drawing.Size(100, 20);
            this.txtAdminSifre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // txtAdminKullaniciAdi
            // 
            this.txtAdminKullaniciAdi.Location = new System.Drawing.Point(91, 16);
            this.txtAdminKullaniciAdi.Name = "txtAdminKullaniciAdi";
            this.txtAdminKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdminKullaniciAdi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminGiris.Location = new System.Drawing.Point(91, 109);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(100, 23);
            this.btnAdminGiris.TabIndex = 3;
            this.btnAdminGiris.Text = "GİRİŞ";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 154);
            this.Controls.Add(this.txtAdminSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdminKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdminGiris);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdminSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdminGiris;
    }
}