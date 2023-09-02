
namespace EntityFrameworkLearn
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOgrenciList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfotograf = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtogrencıId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayfet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnDersList = new System.Windows.Forms.Button();
            this.BtnNotlist = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSınavGuncelle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtSınav3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSınav2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSınav1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDersId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BTNPROCESRUE = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnLinqEntity = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(962, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnOgrenciList
            // 
            this.btnOgrenciList.Location = new System.Drawing.Point(3, 211);
            this.btnOgrenciList.Name = "btnOgrenciList";
            this.btnOgrenciList.Size = new System.Drawing.Size(199, 37);
            this.btnOgrenciList.TabIndex = 1;
            this.btnOgrenciList.Text = "Öğrenci Listesi";
            this.btnOgrenciList.UseVisualStyleBackColor = true;
            this.btnOgrenciList.Click += new System.EventHandler(this.btnOgrenciList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtfotograf);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtogrencıId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(208, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 205);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            // 
            // txtfotograf
            // 
            this.txtfotograf.Location = new System.Drawing.Point(185, 131);
            this.txtfotograf.Name = "txtfotograf";
            this.txtfotograf.Size = new System.Drawing.Size(183, 30);
            this.txtfotograf.TabIndex = 10;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(185, 95);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(183, 30);
            this.txtsoyad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "FOTOĞRAF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "SOYAD:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(185, 59);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(183, 30);
            this.txtad.TabIndex = 5;
            this.txtad.TextChanged += new System.EventHandler(this.txtad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD:";
            // 
            // txtogrencıId
            // 
            this.txtogrencıId.Location = new System.Drawing.Point(185, 23);
            this.txtogrencıId.Name = "txtogrencıId";
            this.txtogrencıId.Size = new System.Drawing.Size(183, 30);
            this.txtogrencıId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // btnKayfet
            // 
            this.btnKayfet.Location = new System.Drawing.Point(3, 257);
            this.btnKayfet.Name = "btnKayfet";
            this.btnKayfet.Size = new System.Drawing.Size(199, 37);
            this.btnKayfet.TabIndex = 3;
            this.btnKayfet.Text = "Kaydet";
            this.btnKayfet.UseVisualStyleBackColor = true;
            this.btnKayfet.Click += new System.EventHandler(this.btnKayfet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(3, 303);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(199, 37);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(3, 349);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(199, 37);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(3, 395);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(199, 37);
            this.btnBul.TabIndex = 6;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnDersList
            // 
            this.btnDersList.Location = new System.Drawing.Point(3, 441);
            this.btnDersList.Name = "btnDersList";
            this.btnDersList.Size = new System.Drawing.Size(199, 37);
            this.btnDersList.TabIndex = 7;
            this.btnDersList.Text = "Ders Listesi";
            this.btnDersList.UseVisualStyleBackColor = true;
            this.btnDersList.Click += new System.EventHandler(this.btnDersList_Click);
            // 
            // BtnNotlist
            // 
            this.BtnNotlist.Location = new System.Drawing.Point(3, 487);
            this.BtnNotlist.Name = "BtnNotlist";
            this.BtnNotlist.Size = new System.Drawing.Size(199, 37);
            this.BtnNotlist.TabIndex = 8;
            this.BtnNotlist.Text = "Not Listesi";
            this.BtnNotlist.UseVisualStyleBackColor = true;
            this.BtnNotlist.Click += new System.EventHandler(this.BtnNotlist_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSınavGuncelle);
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.txtDurum);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtOrtalama);
            this.groupBox2.Controls.Add(this.txtSınav3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSınav2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSınav1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(612, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 313);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notlar";
            // 
            // btnSınavGuncelle
            // 
            this.btnSınavGuncelle.Location = new System.Drawing.Point(86, 257);
            this.btnSınavGuncelle.Name = "btnSınavGuncelle";
            this.btnSınavGuncelle.Size = new System.Drawing.Size(247, 37);
            this.btnSınavGuncelle.TabIndex = 14;
            this.btnSınavGuncelle.Text = "Join ile Getir";
            this.btnSınavGuncelle.UseVisualStyleBackColor = true;
            this.btnSınavGuncelle.Click += new System.EventHandler(this.btnSınavGuncelle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(86, 211);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(247, 37);
            this.btnHesapla.TabIndex = 13;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(150, 162);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(183, 30);
            this.txtDurum.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "DURUM:";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(150, 127);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(183, 30);
            this.txtOrtalama.TabIndex = 10;
            // 
            // txtSınav3
            // 
            this.txtSınav3.Location = new System.Drawing.Point(150, 91);
            this.txtSınav3.Name = "txtSınav3";
            this.txtSınav3.Size = new System.Drawing.Size(183, 30);
            this.txtSınav3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "ORTALAMA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "SINAV3:";
            // 
            // txtSınav2
            // 
            this.txtSınav2.Location = new System.Drawing.Point(150, 55);
            this.txtSınav2.Name = "txtSınav2";
            this.txtSınav2.Size = new System.Drawing.Size(183, 30);
            this.txtSınav2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "SINAV2:";
            // 
            // txtSınav1
            // 
            this.txtSınav1.Location = new System.Drawing.Point(150, 19);
            this.txtSınav1.Name = "txtSınav1";
            this.txtSınav1.Size = new System.Drawing.Size(183, 30);
            this.txtSınav1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "SINAV1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtDersAd);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtDersId);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(208, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 118);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dersler";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ders Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(141, 42);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(183, 30);
            this.txtDersAd.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "AD:";
            // 
            // txtDersId
            // 
            this.txtDersId.Location = new System.Drawing.Point(141, 6);
            this.txtDersId.Name = "txtDersId";
            this.txtDersId.Size = new System.Drawing.Size(183, 30);
            this.txtDersId.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(95, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "ID:";
            // 
            // BTNPROCESRUE
            // 
            this.BTNPROCESRUE.Location = new System.Drawing.Point(3, 539);
            this.BTNPROCESRUE.Name = "BTNPROCESRUE";
            this.BTNPROCESRUE.Size = new System.Drawing.Size(199, 37);
            this.BTNPROCESRUE.TabIndex = 11;
            this.BTNPROCESRUE.Text = "PROCEDURE";
            this.BTNPROCESRUE.UseVisualStyleBackColor = true;
            this.BTNPROCESRUE.Click += new System.EventHandler(this.BTNPROCESRUE_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(971, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(252, 29);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ada Göre Sırala(A->Z)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnLinqEntity
            // 
            this.btnLinqEntity.Location = new System.Drawing.Point(985, 570);
            this.btnLinqEntity.Name = "btnLinqEntity";
            this.btnLinqEntity.Size = new System.Drawing.Size(238, 41);
            this.btnLinqEntity.TabIndex = 15;
            this.btnLinqEntity.Text = "Linq Entity";
            this.btnLinqEntity.UseVisualStyleBackColor = true;
            this.btnLinqEntity.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(971, 61);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(252, 29);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ada Göre Sırala(Z->A)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(971, 110);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(154, 29);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "İLK 3 KAYIT";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(971, 159);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(232, 29);
            this.radioButton4.TabIndex = 18;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ID\'ye Göre Veri Getir";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(971, 208);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(233, 29);
            this.radioButton5.TabIndex = 19;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Adı A ile Başlayanlar";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(969, 257);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(193, 29);
            this.radioButton6.TabIndex = 20;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Adı A ile Bitenler";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(971, 306);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(167, 29);
            this.radioButton7.TabIndex = 21;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Deger var mı?";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(969, 355);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(235, 29);
            this.radioButton8.TabIndex = 22;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "toplam ogrenci sayısı";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(968, 404);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(232, 29);
            this.radioButton9.TabIndex = 23;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Sınav1 Toplam puan";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(968, 453);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(243, 29);
            this.radioButton10.TabIndex = 24;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Sınav1 ortalama puan";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(971, 502);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(202, 29);
            this.radioButton11.TabIndex = 25;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "En yüksek sınav1";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(971, 535);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(318, 29);
            this.radioButton12.TabIndex = 26;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "1.sınavı ortalamand yüksekler";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 610);
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.radioButton11);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.btnLinqEntity);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BTNPROCESRUE);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnNotlist);
            this.Controls.Add(this.btnDersList);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKayfet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOgrenciList);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOgrenciList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtfotograf;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtogrencıId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKayfet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnDersList;
        private System.Windows.Forms.Button BtnNotlist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSınavGuncelle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtSınav3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSınav2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSınav1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDersId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTNPROCESRUE;
        private System.Windows.Forms.Button btnLinqEntity;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
    }
}

