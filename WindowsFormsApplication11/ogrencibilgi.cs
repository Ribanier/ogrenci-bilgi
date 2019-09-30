using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication11
{
    public partial class ogrencibilgi : Form
    {
        public ogrencibilgi()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabanim.accdb");

        void baglan()
        {
            if (con.State == ConnectionState.Closed) { con.Open(); }
        }

        void listele()
        {
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter adb = new OleDbDataAdapter("select OKULNO,PROJE1,Projenot1,PROJE2,Projenot2 from proje where OKULNO = '" + label1.Text + "'", con);
            //tabloyu sectik
            adb.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;
        }
        private void ogrencibilgi_Load(object sender, EventArgs e)
        {
            baglan();
            pictureBox2.ImageLocation = "yukleniyor.gif";
            this.Text = "..:ÖĞRENCİ BİLGİ:..";
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            baglan();
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
            OleDbCommand cmd = new OleDbCommand("select ad,soyad,resim from ogrenci where okulno = '" + label1.Text + "'", con);
            OleDbDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                pictureBox1.ImageLocation = rd["resim"].ToString();
                label2.Text = rd["ad"].ToString() + " " + rd["soyad"].ToString();
            }
            pictureBox2.Visible = false;
            OleDbCommand cnd = new OleDbCommand("select OKULNO,PROJE1,Projenot1,PROJE2,Projenot2 from proje where OKULNO = '" + label1.Text + "'", con);
            cnd.ExecuteNonQuery();
            listele();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
