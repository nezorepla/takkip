namespace Takkip
{
    partial class FormAdd
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
            this.buttonEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.comboBoxSahip = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerBaslangic = new System.Windows.Forms.DateTimePicker();
            this.textBoxSahip = new System.Windows.Forms.TextBox();
            this.radioButtonOnem1 = new System.Windows.Forms.RadioButton();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAciklama = new System.Windows.Forms.TextBox();
            this.Açıklama = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.kapatSahip = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonOnem2 = new System.Windows.Forms.RadioButton();
            this.radioButtonOnem3 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKategori = new System.Windows.Forms.TextBox();
            this.kapatKategori = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(171, 290);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonEkle.TabIndex = 0;
            this.buttonEkle.Text = "ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanici:";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.Location = new System.Drawing.Point(97, 10);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(200, 21);
            this.comboBoxUser.TabIndex = 2;
            // 
            // comboBoxSahip
            // 
            this.comboBoxSahip.FormattingEnabled = true;
            this.comboBoxSahip.Location = new System.Drawing.Point(97, 41);
            this.comboBoxSahip.Name = "comboBoxSahip";
            this.comboBoxSahip.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSahip.TabIndex = 3;
            this.comboBoxSahip.SelectedIndexChanged += new System.EventHandler(this.comboBoxSahip_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Talep Sahibi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Talep Tarihi";
            // 
            // dateTimePickerBaslangic
            // 
            this.dateTimePickerBaslangic.Location = new System.Drawing.Point(97, 79);
            this.dateTimePickerBaslangic.Name = "dateTimePickerBaslangic";
            this.dateTimePickerBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBaslangic.TabIndex = 6;
            // 
            // textBoxSahip
            // 
            this.textBoxSahip.Location = new System.Drawing.Point(97, 42);
            this.textBoxSahip.Name = "textBoxSahip";
            this.textBoxSahip.Size = new System.Drawing.Size(183, 20);
            this.textBoxSahip.TabIndex = 7;
            // 
            // radioButtonOnem1
            // 
            this.radioButtonOnem1.AutoSize = true;
            this.radioButtonOnem1.Location = new System.Drawing.Point(0, 3);
            this.radioButtonOnem1.Name = "radioButtonOnem1";
            this.radioButtonOnem1.Size = new System.Drawing.Size(54, 17);
            this.radioButtonOnem1.TabIndex = 8;
            this.radioButtonOnem1.TabStop = true;
            this.radioButtonOnem1.Text = "düşük";
            this.radioButtonOnem1.UseVisualStyleBackColor = true;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(97, 143);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(200, 21);
            this.comboBoxKategori.TabIndex = 10;
            this.comboBoxKategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategori_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kategori";
            // 
            // textBoxAciklama
            // 
            this.textBoxAciklama.Location = new System.Drawing.Point(97, 190);
            this.textBoxAciklama.Multiline = true;
            this.textBoxAciklama.Name = "textBoxAciklama";
            this.textBoxAciklama.Size = new System.Drawing.Size(252, 71);
            this.textBoxAciklama.TabIndex = 12;
            // 
            // Açıklama
            // 
            this.Açıklama.AutoSize = true;
            this.Açıklama.Location = new System.Drawing.Point(19, 190);
            this.Açıklama.Name = "Açıklama";
            this.Açıklama.Size = new System.Drawing.Size(35, 13);
            this.Açıklama.TabIndex = 13;
            this.Açıklama.Text = "label5";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Geri Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kapatSahip
            // 
            this.kapatSahip.Location = new System.Drawing.Point(278, 40);
            this.kapatSahip.Name = "kapatSahip";
            this.kapatSahip.Size = new System.Drawing.Size(24, 23);
            this.kapatSahip.TabIndex = 15;
            this.kapatSahip.Text = "x";
            this.kapatSahip.UseVisualStyleBackColor = true;
            this.kapatSahip.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonOnem3);
            this.panel1.Controls.Add(this.radioButtonOnem2);
            this.panel1.Controls.Add(this.radioButtonOnem1);
            this.panel1.Location = new System.Drawing.Point(97, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 33);
            this.panel1.TabIndex = 16;
            // 
            // radioButtonOnem2
            // 
            this.radioButtonOnem2.AutoSize = true;
            this.radioButtonOnem2.Location = new System.Drawing.Point(60, 3);
            this.radioButtonOnem2.Name = "radioButtonOnem2";
            this.radioButtonOnem2.Size = new System.Drawing.Size(43, 17);
            this.radioButtonOnem2.TabIndex = 9;
            this.radioButtonOnem2.TabStop = true;
            this.radioButtonOnem2.Text = "orta";
            this.radioButtonOnem2.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnem3
            // 
            this.radioButtonOnem3.AutoSize = true;
            this.radioButtonOnem3.Location = new System.Drawing.Point(110, 4);
            this.radioButtonOnem3.Name = "radioButtonOnem3";
            this.radioButtonOnem3.Size = new System.Drawing.Size(59, 17);
            this.radioButtonOnem3.TabIndex = 10;
            this.radioButtonOnem3.TabStop = true;
            this.radioButtonOnem3.Text = "yüksek";
            this.radioButtonOnem3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Önem";
            // 
            // textBoxKategori
            // 
            this.textBoxKategori.Location = new System.Drawing.Point(97, 144);
            this.textBoxKategori.Name = "textBoxKategori";
            this.textBoxKategori.Size = new System.Drawing.Size(183, 20);
            this.textBoxKategori.TabIndex = 18;
            // 
            // kapatKategori
            // 
            this.kapatKategori.Location = new System.Drawing.Point(278, 144);
            this.kapatKategori.Name = "kapatKategori";
            this.kapatKategori.Size = new System.Drawing.Size(24, 20);
            this.kapatKategori.TabIndex = 19;
            this.kapatKategori.Text = "x";
            this.kapatKategori.UseVisualStyleBackColor = true;
            this.kapatKategori.Click += new System.EventHandler(this.kapatKategori_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 366);
            this.Controls.Add(this.kapatKategori);
            this.Controls.Add(this.textBoxKategori);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kapatSahip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Açıklama);
            this.Controls.Add(this.textBoxAciklama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.textBoxSahip);
            this.Controls.Add(this.dateTimePickerBaslangic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSahip);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEkle);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.ComboBox comboBoxSahip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangic;
        private System.Windows.Forms.TextBox textBoxSahip;
        private System.Windows.Forms.RadioButton radioButtonOnem1;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAciklama;
        private System.Windows.Forms.Label Açıklama;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button kapatSahip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonOnem2;
        private System.Windows.Forms.RadioButton radioButtonOnem3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKategori;
        private System.Windows.Forms.Button kapatKategori;
    }
}