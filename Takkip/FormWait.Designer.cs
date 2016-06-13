namespace Takkip
{
    partial class FormWait
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
            this.chkAlwaysTop = new System.Windows.Forms.CheckBox();
            this.bitenler = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.chkBitenler = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIntCode = new System.Windows.Forms.Label();
            this.btnIsBitir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAlwaysTop
            // 
            this.chkAlwaysTop.AutoSize = true;
            this.chkAlwaysTop.Location = new System.Drawing.Point(12, 6);
            this.chkAlwaysTop.Name = "chkAlwaysTop";
            this.chkAlwaysTop.Size = new System.Drawing.Size(116, 17);
            this.chkAlwaysTop.TabIndex = 2;
            this.chkAlwaysTop.Text = "her zaman üstte tut";
            this.chkAlwaysTop.UseVisualStyleBackColor = true;
            this.chkAlwaysTop.CheckedChanged += new System.EventHandler(this.chkAlwaysTop_CheckedChanged);
            // 
            // bitenler
            // 
            this.bitenler.Location = new System.Drawing.Point(196, 12);
            this.bitenler.Name = "bitenler";
            this.bitenler.Size = new System.Drawing.Size(75, 38);
            this.bitenler.TabIndex = 3;
            this.bitenler.Text = "bitenler";
            this.bitenler.UseVisualStyleBackColor = true;
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(13, 381);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 39);
            this.geri.TabIndex = 4;
            this.geri.Text = "geri dön";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(580, 1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Location = new System.Drawing.Point(13, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(767, 201);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
            // 
            // cbxUser
            // 
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(12, 29);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(165, 21);
            this.cbxUser.TabIndex = 7;
            this.cbxUser.SelectedIndexChanged += new System.EventHandler(this.cbxUser_SelectedIndexChanged);
            // 
            // chkBitenler
            // 
            this.chkBitenler.AutoSize = true;
            this.chkBitenler.Location = new System.Drawing.Point(278, 29);
            this.chkBitenler.Name = "chkBitenler";
            this.chkBitenler.Size = new System.Drawing.Size(111, 17);
            this.chkBitenler.TabIndex = 8;
            this.chkBitenler.Text = "Bitenleri Gösterme";
            this.chkBitenler.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIsBitir);
            this.groupBox1.Controls.Add(this.lblIntCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblIntCode
            // 
            this.lblIntCode.AutoSize = true;
            this.lblIntCode.Location = new System.Drawing.Point(6, 16);
            this.lblIntCode.Name = "lblIntCode";
            this.lblIntCode.Size = new System.Drawing.Size(35, 13);
            this.lblIntCode.TabIndex = 0;
            this.lblIntCode.Text = "label1";
            // 
            // btnIsBitir
            // 
            this.btnIsBitir.Location = new System.Drawing.Point(659, 16);
            this.btnIsBitir.Name = "btnIsBitir";
            this.btnIsBitir.Size = new System.Drawing.Size(103, 102);
            this.btnIsBitir.TabIndex = 1;
            this.btnIsBitir.Text = "button1";
            this.btnIsBitir.UseVisualStyleBackColor = true;
            this.btnIsBitir.Click += new System.EventHandler(this.btnIsBitir_Click);
            // 
            // FormWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkBitenler);
            this.Controls.Add(this.cbxUser);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.bitenler);
            this.Controls.Add(this.chkAlwaysTop);
            this.Name = "FormWait";
            this.Text = "FormWait";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAlwaysTop;
        private System.Windows.Forms.Button bitenler;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cbxUser;
        private System.Windows.Forms.CheckBox chkBitenler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIsBitir;
        private System.Windows.Forms.Label lblIntCode;
    }
}