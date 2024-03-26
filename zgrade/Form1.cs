using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zgrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Neboder neboder = new Neboder();
                neboder.BrojKatova = Convert.ToInt32(txtBrojKatova.Text);
                txtVisinaZgrade.Text = neboder.Izracunajvisinu(neboder.BrojKatova).ToString();
            }
            catch
            {
                MessageBox.Show("Upisali ste pogrešan format!", "Greška unosa!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
