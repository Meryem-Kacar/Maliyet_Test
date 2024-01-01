namespace Maliyet_Test
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStokAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStokId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtMFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUrunStok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtMaliyet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.v = new System.Windows.Forms.GroupBox();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnMalzemeListesi = new System.Windows.Forms.Button();
            this.btnUrunListesi = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.v.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMalzemeEkle);
            this.groupBox1.Controls.Add(this.btnGetir);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNot);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStok);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStokAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStokId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Girişi";
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.BackColor = System.Drawing.Color.Moccasin;
            this.btnMalzemeEkle.Location = new System.Drawing.Point(123, 246);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(206, 46);
            this.btnMalzemeEkle.TabIndex = 11;
            this.btnMalzemeEkle.Text = "MALZEME EKLE";
            this.btnMalzemeEkle.UseVisualStyleBackColor = false;
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnGetir.Location = new System.Drawing.Point(334, 76);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(102, 31);
            this.btnGetir.TabIndex = 10;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.UseVisualStyleBackColor = false;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(123, 166);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(206, 34);
            this.txtFiyat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "NOTLAR:";
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(123, 206);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(206, 34);
            this.txtNot.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "FİYAT:";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(123, 120);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(206, 34);
            this.txtStok.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "STOK:";
            // 
            // txtStokAd
            // 
            this.txtStokAd.Location = new System.Drawing.Point(123, 76);
            this.txtStokAd.Name = "txtStokAd";
            this.txtStokAd.Size = new System.Drawing.Size(206, 34);
            this.txtStokAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD:";
            // 
            // txtStokId
            // 
            this.txtStokId.Location = new System.Drawing.Point(123, 36);
            this.txtStokId.Name = "txtStokId";
            this.txtStokId.Size = new System.Drawing.Size(206, 34);
            this.txtStokId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUrunEkle);
            this.groupBox2.Controls.Add(this.btnGüncelle);
            this.groupBox2.Controls.Add(this.txtMFiyat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSFiyat);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtUrunStok);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxtUrunAd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtUrunId);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(450, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 366);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Girişi";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.Moccasin;
            this.btnUrunEkle.Location = new System.Drawing.Point(123, 246);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(216, 50);
            this.btnUrunEkle.TabIndex = 11;
            this.btnUrunEkle.Text = "ÜRÜN EKLE";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnGüncelle.Location = new System.Drawing.Point(123, 302);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(216, 46);
            this.btnGüncelle.TabIndex = 10;
            this.btnGüncelle.Text = "GÜNCELLE";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            // 
            // txtMFiyat
            // 
            this.txtMFiyat.Location = new System.Drawing.Point(123, 166);
            this.txtMFiyat.Name = "txtMFiyat";
            this.txtMFiyat.Size = new System.Drawing.Size(206, 34);
            this.txtMFiyat.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "S.FİYAT:";
            // 
            // txtSFiyat
            // 
            this.txtSFiyat.Location = new System.Drawing.Point(123, 206);
            this.txtSFiyat.Name = "txtSFiyat";
            this.txtSFiyat.Size = new System.Drawing.Size(206, 34);
            this.txtSFiyat.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "M.FİYAT:";
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.Location = new System.Drawing.Point(123, 120);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.Size = new System.Drawing.Size(206, 34);
            this.txtUrunStok.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "STOK:";
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(123, 76);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(206, 34);
            this.TxtUrunAd.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 27);
            this.label9.TabIndex = 2;
            this.label9.Text = "AD:";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(123, 36);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(206, 34);
            this.txtUrunId.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 27);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.btnEkle);
            this.groupBox3.Controls.Add(this.txtMaliyet);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtMiktar);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(825, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 366);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Oluştur";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(134, 97);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(206, 35);
            this.comboBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 35);
            this.comboBox1.TabIndex = 12;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Moccasin;
            this.btnEkle.Location = new System.Drawing.Point(134, 257);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(206, 51);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = " EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtMaliyet
            // 
            this.txtMaliyet.Location = new System.Drawing.Point(134, 206);
            this.txtMaliyet.Name = "txtMaliyet";
            this.txtMaliyet.Size = new System.Drawing.Size(206, 34);
            this.txtMaliyet.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 27);
            this.label12.TabIndex = 6;
            this.label12.Text = "MALİYET:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(134, 148);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(206, 34);
            this.txtMiktar.TabIndex = 5;
            this.txtMiktar.TextChanged += new System.EventHandler(this.txtMiktar_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 27);
            this.label13.TabIndex = 4;
            this.label13.Text = "MİKTAR:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 27);
            this.label14.TabIndex = 2;
            this.label14.Text = "MALZEME:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(50, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 27);
            this.label15.TabIndex = 0;
            this.label15.Text = "ÜRÜN:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(2, 384);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1192, 307);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Malzemeler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1186, 274);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Location = new System.Drawing.Point(1200, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(335, 366);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(3, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(329, 333);
            this.listBox1.TabIndex = 0;
            // 
            // v
            // 
            this.v.Controls.Add(this.btnCıkıs);
            this.v.Controls.Add(this.btnKasa);
            this.v.Controls.Add(this.btnMalzemeListesi);
            this.v.Controls.Add(this.btnUrunListesi);
            this.v.Location = new System.Drawing.Point(1203, 384);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(335, 307);
            this.v.TabIndex = 5;
            this.v.TabStop = false;
            this.v.Text = "İşlemler";
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCıkıs.Location = new System.Drawing.Point(6, 235);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(326, 46);
            this.btnCıkıs.TabIndex = 14;
            this.btnCıkıs.Text = "ÇIKIŞ";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // btnKasa
            // 
            this.btnKasa.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnKasa.Location = new System.Drawing.Point(6, 172);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(326, 46);
            this.btnKasa.TabIndex = 13;
            this.btnKasa.Text = "KASA";
            this.btnKasa.UseVisualStyleBackColor = false;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // btnMalzemeListesi
            // 
            this.btnMalzemeListesi.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnMalzemeListesi.Location = new System.Drawing.Point(6, 111);
            this.btnMalzemeListesi.Name = "btnMalzemeListesi";
            this.btnMalzemeListesi.Size = new System.Drawing.Size(323, 46);
            this.btnMalzemeListesi.TabIndex = 12;
            this.btnMalzemeListesi.Text = "MALZEME LİSTESİ";
            this.btnMalzemeListesi.UseVisualStyleBackColor = false;
            this.btnMalzemeListesi.Click += new System.EventHandler(this.btnMalzemeListesi_Click);
            // 
            // btnUrunListesi
            // 
            this.btnUrunListesi.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnUrunListesi.Location = new System.Drawing.Point(6, 45);
            this.btnUrunListesi.Name = "btnUrunListesi";
            this.btnUrunListesi.Size = new System.Drawing.Size(323, 46);
            this.btnUrunListesi.TabIndex = 11;
            this.btnUrunListesi.Text = "ÜRÜN LİSTESİ";
            this.btnUrunListesi.UseVisualStyleBackColor = false;
            this.btnUrunListesi.Click += new System.EventHandler(this.btnUrunListesi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1560, 742);
            this.Controls.Add(this.v);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.v.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStokId;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStokAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMalzemeEkle;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtMFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUrunStok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtMaliyet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox v;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnMalzemeListesi;
        private System.Windows.Forms.Button btnUrunListesi;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

