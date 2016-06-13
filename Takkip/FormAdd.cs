using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Takkip
{
    public partial class FormAdd : Form
    {
        Bilgiler blg = new Bilgiler();
        DBClass db = new DBClass();

        public FormAdd()
        {
            InitializeComponent();
            Init();
            comboBoxSahip.Visible = true;
            textBoxSahip.Visible = false;
            kapatSahip.Visible = false;

            comboBoxKategori.Visible = true;
            textBoxKategori.Visible = false;
            kapatKategori.Visible = false;



        }
        void Init()
        {
            fillUser();

        }
        public void fillUser()
        {
            // Bind combobox to dictionary
            Dictionary<string, string> test = db.Kullanicilar();
            comboBoxUser.DataSource = new BindingSource(test, null);
            comboBoxUser.DisplayMember = "Value";
            comboBoxUser.ValueMember = "Key";

            for (int x = 0; x < comboBoxUser.Items.Count; ++x)
            {
                //  var i = cbxUser.Items[x];
                string u = ((KeyValuePair<string, string>)comboBoxUser.Items[x]).Key.ToString();
                if (u == blg.getSicil())
                    comboBoxUser.SelectedIndex = x;
                comboBoxUser.Enabled = false;
            }
            string uservalue = ((KeyValuePair<string, string>)comboBoxUser.SelectedItem).Value;

            fillSahip(uservalue);
            fillKat(uservalue);
        }

        public void fillKat(string uservalue)
        {
            comboBoxKategori.Items.Clear();
            List<String> liste = db.Listele(" select distinct kat from Takkip_tbl_add_tmp where usr='" + uservalue + "'");
            comboBoxKategori.Items.Add("Seçiniz");

            foreach (String satir in liste)
            {
                comboBoxKategori.Items.Add(satir);
            }
            comboBoxKategori.Items.Add("Diger");
            comboBoxKategori.SelectedIndex = 0;
        }
        public void fillSahip(string uservalue)
        {
            comboBoxSahip.Items.Clear();
            List<String> liste = db.Listele(" select distinct shp from Takkip_tbl_add_tmp where usr='" + uservalue + "'");
            comboBoxSahip.Items.Add("Seçiniz");

            foreach (String satir in liste)
            {
                comboBoxSahip.Items.Add(satir);
            }
            comboBoxSahip.Items.Add("Diger");
            comboBoxSahip.SelectedIndex = 0;
        }




        private void comboBoxSahip_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selected = (string)comboBoxSahip.SelectedItem;
            // MessageBox.Show(selected);
            if (selected == "Diger")
            {
                comboBoxSahip.Visible = false; textBoxSahip.Visible = true;
                kapatSahip.Visible = true; textBoxSahip.Focus();
            }
            else { textBoxSahip.Visible = false; comboBoxSahip.Visible = true; kapatSahip.Visible = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxSahip.Visible = false; comboBoxSahip.Visible = true; kapatSahip.Visible = false;
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string uservalue = ((KeyValuePair<string, string>)comboBoxUser.SelectedItem).Value;

            string sahip = (string)comboBoxSahip.SelectedItem; ;
            string kat = (string)comboBoxKategori.SelectedItem;
            string tarih = (string)dateTimePickerBaslangic.Value.ToString("yyyy-MM-dd");
            string Aciklama = textBoxAciklama.Text;
            string onem = "";
            if (kat == "Diger")
                kat = textBoxKategori.Text;
            if (sahip == "Diger")
                sahip = textBoxSahip.Text;

            if (radioButtonOnem1.Checked)
            {
                onem = radioButtonOnem1.Text;

            }
            else if (radioButtonOnem2.Checked)
            {

                onem = radioButtonOnem2.Text;
            }
            else if (radioButtonOnem3.Checked)
            {

                onem = radioButtonOnem3.Text;
            }

            string rv = db.GorevEkle(uservalue, sahip.Remove('*'), kat.Remove('*'), tarih, Aciklama.Replace("*","><"), onem);

            MessageBox.Show(rv);


        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selected = (string)comboBoxKategori.SelectedItem;
            // MessageBox.Show(selected);
            if (selected == "Diger")
            {
                comboBoxKategori.Visible = false; textBoxKategori.Visible = true;
                kapatKategori.Visible = true; textBoxKategori.Focus();
            }
            else { textBoxSahip.Visible = false; comboBoxSahip.Visible = true; kapatSahip.Visible = false; }
        }

        private void kapatKategori_Click(object sender, EventArgs e)
        {
            textBoxKategori.Visible = false; comboBoxKategori.Visible = true; kapatKategori.Visible = false;


        }
    }



}
