namespace HedonistProjeOdev
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Urun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Kategori = new System.Windows.Forms.ComboBox();
            this.cmb_Marka = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lst_Urunler = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_artan = new System.Windows.Forms.Button();
            this.btn_varsayılan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı :";
            // 
            // txt_Urun
            // 
            this.txt_Urun.Location = new System.Drawing.Point(99, 237);
            this.txt_Urun.Name = "txt_Urun";
            this.txt_Urun.Size = new System.Drawing.Size(219, 20);
            this.txt_Urun.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori :";
            // 
            // cmb_Kategori
            // 
            this.cmb_Kategori.FormattingEnabled = true;
            this.cmb_Kategori.Location = new System.Drawing.Point(99, 276);
            this.cmb_Kategori.Name = "cmb_Kategori";
            this.cmb_Kategori.Size = new System.Drawing.Size(219, 21);
            this.cmb_Kategori.TabIndex = 3;
            // 
            // cmb_Marka
            // 
            this.cmb_Marka.FormattingEnabled = true;
            this.cmb_Marka.Location = new System.Drawing.Point(99, 324);
            this.cmb_Marka.Name = "cmb_Marka";
            this.cmb_Marka.Size = new System.Drawing.Size(219, 21);
            this.cmb_Marka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marka :";
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Location = new System.Drawing.Point(99, 362);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(219, 20);
            this.txt_Fiyat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fiyat :";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(99, 404);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(59, 23);
            this.btn_Ekle.TabIndex = 9;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(164, 404);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(73, 23);
            this.btn_Sil.TabIndex = 10;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(243, 404);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_Guncelle.TabIndex = 11;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ürünlerim";
            // 
            // lst_Urunler
            // 
            this.lst_Urunler.FormattingEnabled = true;
            this.lst_Urunler.HorizontalScrollbar = true;
            this.lst_Urunler.Location = new System.Drawing.Point(31, 48);
            this.lst_Urunler.Name = "lst_Urunler";
            this.lst_Urunler.Size = new System.Drawing.Size(362, 160);
            this.lst_Urunler.TabIndex = 13;
            this.lst_Urunler.Click += new System.EventHandler(this.lst_Urunler_Click);
            this.lst_Urunler.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lst_Urunler_Format);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(427, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 334);
            this.dataGridView1.TabIndex = 14;
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(424, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Siparis Listesi";
            // 
            // btn_artan
            // 
            this.btn_artan.Location = new System.Drawing.Point(427, 388);
            this.btn_artan.Name = "btn_artan";
            this.btn_artan.Size = new System.Drawing.Size(113, 23);
            this.btn_artan.TabIndex = 16;
            this.btn_artan.Text = "FiyataGöreAzalan";
            this.btn_artan.UseVisualStyleBackColor = true;
            this.btn_artan.Click += new System.EventHandler(this.btn_azalan_Click);
            // 
            // btn_varsayılan
            // 
            this.btn_varsayılan.Location = new System.Drawing.Point(564, 388);
            this.btn_varsayılan.Name = "btn_varsayılan";
            this.btn_varsayılan.Size = new System.Drawing.Size(107, 23);
            this.btn_varsayılan.TabIndex = 17;
            this.btn_varsayılan.Text = "VarsayılanSıralama";
            this.btn_varsayılan.UseVisualStyleBackColor = true;
            this.btn_varsayılan.Click += new System.EventHandler(this.btn_varsayılan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(692, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ürüne Göre Arama";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(793, 390);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(905, 442);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_varsayılan);
            this.Controls.Add(this.btn_artan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lst_Urunler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_Fiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Marka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Kategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Urun);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ürün Ekleme Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Urun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Kategori;
        private System.Windows.Forms.ComboBox cmb_Marka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lst_Urunler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_artan;
        private System.Windows.Forms.Button btn_varsayılan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}

