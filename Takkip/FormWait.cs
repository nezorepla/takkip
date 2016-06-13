using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Takkip
{
    public partial class FormWait : Form
    {
        //private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        //private const UInt32 SWP_NOSIZE = 0x0001;
        //private const UInt32 SWP_NOMOVE = 0x0002;
        //private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        //[DllImport("user32.dll")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public FormWait()
        {
            InitializeComponent(); fillUser(); clear();
        }

     void clear(){
         lblIntCode.Text = null;
    }

        Bilgiler blg = new Bilgiler();
        DBClass db = new DBClass();

        public void fillUser()
        {

            // Bind combobox to dictionary
            Dictionary<string, string> test = db.Kullanicilar();
            cbxUser.DataSource = new BindingSource(test, null);
            cbxUser.DisplayMember = "Value";
            cbxUser.ValueMember = "Key";

            for (int x = 0; x < cbxUser.Items.Count; ++x)
            {
                //  var i = cbxUser.Items[x];
                string u = ((KeyValuePair<string, string>)cbxUser.Items[x]).Key.ToString();
                if (u == blg.getSicil())
                    cbxUser.SelectedIndex = x;
                cbxUser.Enabled = false;
            }

        }
        private void cbxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)cbxUser.SelectedItem).Value;

            //    MessageBox.Show(value);
            listViewFill(value);
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked == true)
            {
                //veritabanı güncelleme işlemi. referans e.item

            }
        }


        private void listViewFill(string usr)
        {
            //   CreateMyListView();


            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("No", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Kategori", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Önem", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Kimden", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Açıklama", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Düşüncelerim", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Başlangıc Tarihi", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Bitiş Tarihi", 50, HorizontalAlignment.Center);

            List<String> liste = db.Listele("Takkip_sp_wait '" + usr + "','bekleyn','tarih'");
            foreach (String satir in liste)
            {


                int i = listView1.Items.Count;

                listView1.Items.Add(satir.Split('*')[0].Trim());
                listView1.Items[i].SubItems.Add(satir.Split('*')[1].Trim());
                listView1.Items[i].SubItems.Add(satir.Split('*')[2].Trim());
                listView1.Items[i].SubItems.Add(satir.Split('*')[3].Trim());
                listView1.Items[i].SubItems.Add(satir.Split('*')[4].Trim());
                listView1.Items[i].SubItems.Add(satir.Split('*')[5].Trim());


                //ImageList imageListLarge = new ImageList();
                //imageListLarge.Images.Add(Bitmap.FromFile(@"C:\Users\Alper\Documents\GitHub\Takkip\Takkip\bin\b_check1.gif"));
                //imageListLarge.Images.Add(Bitmap.FromFile(@"C:\Users\Alper\Documents\GitHub\Takkip\Takkip\bin\b_check1.gif"));
                ////Assign the ImageList objects to the ListView.
                //listView1.LargeImageList = imageListLarge;
                //this.Controls.Add(listView1);    

            }

            //   listView1.CheckBoxes = true;
            recolorListItems(listView1);

        }


        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            listView1.ItemCheck -= (System.Windows.Forms.ItemCheckEventHandler)listView1_ItemCheck;

            recolorListItems(listView1);
            if (e.CurrentValue == CheckState.Unchecked)
            {

                foreach (ListViewItem item in listView1.Items)
                    item.Checked = false;
                listView1.Items[e.Index].Checked = true;
                listView1.Items[e.Index].SubItems[0].BackColor = Color.DimGray;
                //item.SubItems[0].BackColor = Color.Red;
                //     MessageBox.Show(listView1.Items[e.Index].SubItems[0].ToString());
            }



            listView1.ItemCheck += (System.Windows.Forms.ItemCheckEventHandler)listView1_ItemCheck;
        }

        private void chkAlwaysTop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlwaysTop.Checked == true)
            {
                FormWait.ActiveForm.TopMost = true;
                //SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            }
            else
            {
                FormWait.ActiveForm.TopMost = false;
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Dispose();
        }
        private static void recolorListItems(ListView lv)
        {

            for (int ix = 0; ix < lv.Items.Count; ++ix)
            {
                var item = lv.Items[ix];
                item.BackColor = (ix % 2 == 0) ? Color.Beige : Color.White;
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //recolorListItems(listView1);

            //if (listView1.SelectedItems.Count > 0)
            //{
            //    ListViewItem itiem = listView1.SelectedItems[listView1.SelectedItems.Count - 1];

            //    if (itiem != null)
            //    {
            //        itiem.SubItems[0].BackColor = Color.Red;
            //        MessageBox.Show(itiem.ToString());
            //    }
            //}
        }

        private void btnIsBitir_Click(object sender, EventArgs e)
        {

        }





    }
}
