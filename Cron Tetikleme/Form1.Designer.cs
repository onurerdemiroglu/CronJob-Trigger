namespace Cron_Tetikleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.domainsayisi = new System.Windows.Forms.Label();
            this.yenile = new System.Windows.Forms.Button();
            this.cronac = new System.Windows.Forms.Button();
            this.Domainliste = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tumcronsonrasizaman = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cronarasizaman = new System.Windows.Forms.DomainUpDown();
            this.cikti = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wordpresscron = new System.Windows.Forms.CheckBox();
            this.pinautomatic = new System.Windows.Forms.CheckBox();
            this.wautomatic = new System.Windows.Forms.CheckBox();
            this.ayaryukle = new System.Windows.Forms.Button();
            this.teksefer = new System.Windows.Forms.CheckBox();
            this.sinirsiz = new System.Windows.Forms.CheckBox();
            this.ayarkaydet = new System.Windows.Forms.Button();
            this.baslat = new System.Windows.Forms.Button();
            this.Devamet = new System.Windows.Forms.Button();
            this.durdur = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.domainsayisi);
            this.groupBox1.Controls.Add(this.yenile);
            this.groupBox1.Controls.Add(this.cronac);
            this.groupBox1.Controls.Add(this.Domainliste);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 508);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cron Listesi";
            // 
            // domainsayisi
            // 
            this.domainsayisi.AutoSize = true;
            this.domainsayisi.Location = new System.Drawing.Point(35, 474);
            this.domainsayisi.Name = "domainsayisi";
            this.domainsayisi.Size = new System.Drawing.Size(65, 20);
            this.domainsayisi.TabIndex = 3;
            this.domainsayisi.Text = "Toplam:";
            // 
            // yenile
            // 
            this.yenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenile.Location = new System.Drawing.Point(352, 406);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(39, 49);
            this.yenile.TabIndex = 2;
            this.yenile.Text = "↺";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // cronac
            // 
            this.cronac.Location = new System.Drawing.Point(20, 420);
            this.cronac.Name = "cronac";
            this.cronac.Size = new System.Drawing.Size(328, 35);
            this.cronac.TabIndex = 1;
            this.cronac.Text = "Cron Liste Düzenle";
            this.cronac.UseVisualStyleBackColor = true;
            this.cronac.Click += new System.EventHandler(this.cronac_Click);
            // 
            // Domainliste
            // 
            this.Domainliste.FormattingEnabled = true;
            this.Domainliste.ItemHeight = 20;
            this.Domainliste.Location = new System.Drawing.Point(20, 36);
            this.Domainliste.Name = "Domainliste";
            this.Domainliste.Size = new System.Drawing.Size(371, 364);
            this.Domainliste.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tumcronsonrasizaman);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cronarasizaman);
            this.groupBox2.Controls.Add(this.cikti);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(446, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 339);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çıktı Ekranı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "dakika bekle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tüm cronlar bitince";
            // 
            // tumcronsonrasizaman
            // 
            this.tumcronsonrasizaman.Location = new System.Drawing.Point(221, 298);
            this.tumcronsonrasizaman.Name = "tumcronsonrasizaman";
            this.tumcronsonrasizaman.Size = new System.Drawing.Size(137, 26);
            this.tumcronsonrasizaman.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "saniye bekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cron komutları arasında";
            // 
            // cronarasizaman
            // 
            this.cronarasizaman.Location = new System.Drawing.Point(221, 254);
            this.cronarasizaman.Name = "cronarasizaman";
            this.cronarasizaman.Size = new System.Drawing.Size(137, 26);
            this.cronarasizaman.TabIndex = 1;
            // 
            // cikti
            // 
            this.cikti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikti.FormattingEnabled = true;
            this.cikti.ItemHeight = 18;
            this.cikti.Location = new System.Drawing.Point(6, 36);
            this.cikti.Name = "cikti";
            this.cikti.Size = new System.Drawing.Size(513, 202);
            this.cikti.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Controls.Add(this.wordpresscron);
            this.groupBox3.Controls.Add(this.pinautomatic);
            this.groupBox3.Controls.Add(this.wautomatic);
            this.groupBox3.Controls.Add(this.ayaryukle);
            this.groupBox3.Controls.Add(this.teksefer);
            this.groupBox3.Controls.Add(this.sinirsiz);
            this.groupBox3.Controls.Add(this.ayarkaydet);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(445, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 163);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Döngü Ayarları";
            // 
            // wordpresscron
            // 
            this.wordpresscron.AutoSize = true;
            this.wordpresscron.Location = new System.Drawing.Point(377, 61);
            this.wordpresscron.Name = "wordpresscron";
            this.wordpresscron.Size = new System.Drawing.Size(143, 24);
            this.wordpresscron.TabIndex = 15;
            this.wordpresscron.Text = "Wordpress Cron";
            this.wordpresscron.UseVisualStyleBackColor = true;
            // 
            // pinautomatic
            // 
            this.pinautomatic.AutoSize = true;
            this.pinautomatic.Location = new System.Drawing.Point(204, 61);
            this.pinautomatic.Name = "pinautomatic";
            this.pinautomatic.Size = new System.Drawing.Size(167, 24);
            this.pinautomatic.TabIndex = 14;
            this.pinautomatic.Text = "Pinterest Automatic";
            this.pinautomatic.UseVisualStyleBackColor = true;
            // 
            // wautomatic
            // 
            this.wautomatic.AutoSize = true;
            this.wautomatic.Location = new System.Drawing.Point(8, 61);
            this.wautomatic.Name = "wautomatic";
            this.wautomatic.Size = new System.Drawing.Size(181, 24);
            this.wautomatic.TabIndex = 13;
            this.wautomatic.Text = "Wordpress Automatic";
            this.wautomatic.UseVisualStyleBackColor = true;
            // 
            // ayaryukle
            // 
            this.ayaryukle.Location = new System.Drawing.Point(289, 119);
            this.ayaryukle.Name = "ayaryukle";
            this.ayaryukle.Size = new System.Drawing.Size(150, 30);
            this.ayaryukle.TabIndex = 12;
            this.ayaryukle.Text = "Ayarları yükle";
            this.ayaryukle.UseVisualStyleBackColor = true;
            this.ayaryukle.Click += new System.EventHandler(this.ayaryukle_Click);
            // 
            // teksefer
            // 
            this.teksefer.AutoSize = true;
            this.teksefer.Location = new System.Drawing.Point(280, 25);
            this.teksefer.Name = "teksefer";
            this.teksefer.Size = new System.Drawing.Size(142, 24);
            this.teksefer.TabIndex = 1;
            this.teksefer.Text = "Tek sefer çalıştır";
            this.teksefer.UseVisualStyleBackColor = true;
            this.teksefer.Click += new System.EventHandler(this.teksefer_Click);
            // 
            // sinirsiz
            // 
            this.sinirsiz.AutoSize = true;
            this.sinirsiz.Location = new System.Drawing.Point(121, 25);
            this.sinirsiz.Name = "sinirsiz";
            this.sinirsiz.Size = new System.Drawing.Size(130, 24);
            this.sinirsiz.TabIndex = 0;
            this.sinirsiz.Text = "Sınırsız Döngü";
            this.sinirsiz.UseVisualStyleBackColor = true;
            this.sinirsiz.Click += new System.EventHandler(this.sinirsiz_Click);
            // 
            // ayarkaydet
            // 
            this.ayarkaydet.Location = new System.Drawing.Point(104, 119);
            this.ayarkaydet.Name = "ayarkaydet";
            this.ayarkaydet.Size = new System.Drawing.Size(147, 30);
            this.ayarkaydet.TabIndex = 11;
            this.ayarkaydet.Text = "Ayarları kaydet";
            this.ayarkaydet.UseVisualStyleBackColor = true;
            this.ayarkaydet.Click += new System.EventHandler(this.ayarkaydet_Click);
            // 
            // baslat
            // 
            this.baslat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.baslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslat.Location = new System.Drawing.Point(225, 539);
            this.baslat.Name = "baslat";
            this.baslat.Size = new System.Drawing.Size(188, 66);
            this.baslat.TabIndex = 8;
            this.baslat.Text = "Programı başlat";
            this.baslat.UseVisualStyleBackColor = false;
            this.baslat.Click += new System.EventHandler(this.baslat_Click);
            // 
            // Devamet
            // 
            this.Devamet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Devamet.Enabled = false;
            this.Devamet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Devamet.Location = new System.Drawing.Point(446, 540);
            this.Devamet.Name = "Devamet";
            this.Devamet.Size = new System.Drawing.Size(188, 66);
            this.Devamet.TabIndex = 9;
            this.Devamet.Text = "Devam Et";
            this.Devamet.UseVisualStyleBackColor = false;
            // 
            // durdur
            // 
            this.durdur.BackColor = System.Drawing.SystemColors.ControlLight;
            this.durdur.Enabled = false;
            this.durdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durdur.Location = new System.Drawing.Point(658, 540);
            this.durdur.Name = "durdur";
            this.durdur.Size = new System.Drawing.Size(188, 66);
            this.durdur.TabIndex = 10;
            this.durdur.Text = "Durdur";
            this.durdur.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 617);
            this.Controls.Add(this.durdur);
            this.Controls.Add(this.Devamet);
            this.Controls.Add(this.baslat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cron Tetikleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Button cronac;
        private System.Windows.Forms.ListBox Domainliste;
        private System.Windows.Forms.Label domainsayisi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown tumcronsonrasizaman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown cronarasizaman;
        private System.Windows.Forms.ListBox cikti;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox teksefer;
        private System.Windows.Forms.CheckBox sinirsiz;
        private System.Windows.Forms.Button baslat;
        private System.Windows.Forms.Button Devamet;
        private System.Windows.Forms.Button durdur;
        private System.Windows.Forms.Button ayaryukle;
        private System.Windows.Forms.Button ayarkaydet;
        private System.Windows.Forms.CheckBox wordpresscron;
        private System.Windows.Forms.CheckBox pinautomatic;
        private System.Windows.Forms.CheckBox wautomatic;
        private System.Windows.Forms.Label label3;
    }
}

