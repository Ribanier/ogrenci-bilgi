using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class ogretmenpaneli : Form
    {
        public ogretmenpaneli()
        {
            InitializeComponent();
        }

        private void öğrenciProjeGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projegirisi prj= new projegirisi();
           this.Hide();
           prj.Show();
        }

        private void öğrenciİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrenciekle asd = new ogrenciekle();
            this.Hide();
            asd.Show();
        }

        private void ogretmenpaneli_Load(object sender, EventArgs e)
        {
            this.Text = "..:ÖĞRETMEN PANELİ:..";
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz!!!", "bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void silinenDosyalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            silinendosyalar b = new silinendosyalar();
            this.Hide();
            b.Show();
        }

        private void kayıtSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayitsilme c = new kayitsilme();
            this.Hide();
            c.Show();
        }
    }
}
