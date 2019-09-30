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
using System.Net.Mail;
namespace WindowsFormsApplication11
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabanim.accdb");
      void baglan()
        {
            if (con.State == ConnectionState.Closed) { con.Open(); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == sayi.ToString())
            {

                baglan();
                OleDbCommand cmd = new OleDbCommand("select * from ogretmen where adi = '" + textBox3.Text + "' and sifre = '" + textBox4.Text + "'and eposta ='" + textBox5.Text + "'", con);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ogretmenpaneli rsm = new ogretmenpaneli();
                    rsm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("giriş başarısız");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            baglan();
            OleDbCommand cmd = new OleDbCommand("select * from ogrenci where tcno = '" + textBox1.Text + "' and okulno = '" + textBox2.Text + "'", con);
            OleDbDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                ogrencibilgi rsm = new ogrencibilgi();       
                rsm.Show();
                this.Hide();
                rsm.label1.Text = textBox2.Text;
                
            }
            else
                MessageBox.Show("giriş başarısız");
        }

        private void giris_Load(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
            this.Text = "..:GİRİŞ:..";
            timer1.Enabled = true;
            timer1.Interval = 1000;
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }
        int sayi;
        Random rnd=new Random();
        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
             try
            {
                sayi = rnd.Next(100000, 900000);
                MailMessage msj = new MailMessage();
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("onaylandiniz@gmail.com", "onaylandiniz123");
                client.Port=587;
                client.Host="smtp.gmail.com";
                client.EnableSsl=true;
                msj.To.Add(textBox5.Text);
                msj.From = new MailAddress("onaylandiniz@gmail.com", "onaylandiniz123");
                msj.Subject="GÜVENLİK KODU";
                msj.Body=sayi.ToString();
                client.Send(msj);
                MessageBox.Show("GMAİL GÜVENLİ BİR ŞEKİLDE GÖNDERİLDİ");
                button2.Enabled = true;

            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
               textBox4.PasswordChar='\0';
            else
            textBox4.PasswordChar = '*';
        }
    }
}
