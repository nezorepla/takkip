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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YeniGiris_Click(object sender, EventArgs e)
        {
            label1.Text = "devam";
            FormAdd form2 = new FormAdd();
            this.Hide();
            form2.ShowDialog();
            this.Dispose();
        }

        private void btnBekleyenler_Click(object sender, EventArgs e)
        {
            label1.Text = "devam";
            FormWait form2 = new FormWait();
            this.Hide();
               form2.ShowDialog();
            this.Dispose();
        }

 
    }
}
