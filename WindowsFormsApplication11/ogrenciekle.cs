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
    public partial class ogrenciekle : Form
    {
        public ogrenciekle()
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
            //veri tabanına bağlandık
            DataTable dt = new DataTable();

            OleDbDataAdapter adb = new OleDbDataAdapter("SELECT * FROM ogrenci", con);
            //tabloyu sectik
            adb.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;

        }
        private void ogrenciekle_Load(object sender, EventArgs e)
        {
            listele();
            textBox4.MaxLength = 11;
            baglan();
            OleDbCommand cmd = new OleDbCommand("select * from siniflar", con);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd["subeler"]);
            }
            this.Text = "..:ÖĞRENCİ EKLE:..";
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            baglan();
            pictureBox1.Image.Save("Resimler/" + textBox3.Text.ToString() + ".jpg");
            OleDbCommand cmd = new OleDbCommand("INSERT INTO ogrenci VALUES ('" + textBox3.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + "Resimler/" + textBox1.Text.ToString() + ".jpg" + "')", con);
            cmd.ExecuteNonQuery();
            listele();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan();
            OleDbCommand cmd = new OleDbCommand("delete * from ogrenci where ad = '" + textBox1.Text + "'and soyad = '" + textBox2.Text + "'", con);
            cmd.ExecuteNonQuery();
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ogretmenpaneli dd = new ogretmenpaneli();
            this.Hide();
            dd.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
