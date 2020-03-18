namespace HedonistProjeOdev
{
    partial class MailGönder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kim = new System.Windows.Forms.TextBox();
            this.txt_baslik = new System.Windows.Forms.TextBox();
            this.txt_icerik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(92, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "MailGönder";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(61, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(56, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baslık";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mesaj Icerik";
            // 
            // txt_kim
            // 
            this.txt_kim.Location = new System.Drawing.Point(92, 13);
            this.txt_kim.Name = "txt_kim";
            this.txt_kim.Size = new System.Drawing.Size(210, 20);
            this.txt_kim.TabIndex = 4;
            // 
            // txt_baslik
            // 
            this.txt_baslik.Location = new System.Drawing.Point(92, 45);
            this.txt_baslik.Name = "txt_baslik";
            this.txt_baslik.Size = new System.Drawing.Size(210, 20);
            this.txt_baslik.TabIndex = 5;
            // 
            // txt_icerik
            // 
            this.txt_icerik.Location = new System.Drawing.Point(92, 84);
            this.txt_icerik.Multiline = true;
            this.txt_icerik.Name = "txt_icerik";
            this.txt_icerik.Size = new System.Drawing.Size(210, 138);
            this.txt_icerik.TabIndex = 6;
            // 
            // MailGönder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(360, 307);
            this.Controls.Add(this.txt_icerik);
            this.Controls.Add(this.txt_baslik);
            this.Controls.Add(this.txt_kim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "MailGönder";
            this.Text = "MailGönder";
            this.Load += new System.EventHandler(this.MailGönder_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kim;
        private System.Windows.Forms.TextBox txt_baslik;
        private System.Windows.Forms.TextBox txt_icerik;
    }
}