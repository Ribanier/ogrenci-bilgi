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
    public partial class kayitsilme : Form
    {
        public kayitsilme()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabanim.accdb");
        void baglan()
        {
            if (con.State == ConnectionState.Closed) { con.Open(); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglan();
            OleDbCommand asd = new OleDbCommand("select OKULNO,ADI,SOYAD,PROJE1,Projenot1,PROJE2,Projenot2,ProjeyiAldığıTarih,ProjeyiVereceğiTarih from proje where OKULNO = @1 and ADI = @2", con);
         asd.Parameters.Add("@1", OleDbType.VarChar).Value=textBox1.Text;
    asd.Parameters.Add("@2", OleDbType.VarChar).Value=textBox2.Text;
          //     asd.Parameters.Add("@1", textBox1.Text);
            //   asd.Parameters.Add("@2", textBox2.Text);
            OleDbDataReader rd = asd.ExecuteReader();
            if (rd.Read())
            {
                OleDbCommand cmd = new OleDbCommand("INSERT INTO arsiv VALUES ('" + rd["OKULNO"] + "','" + rd["ADI"] + "','" + rd["SOYAD"] + "','" + rd["PROJE1"] + "','" + rd["Projenot1"] + "','" + rd["PROJE2"] + "','" + rd["Projenot2"] + "','" + rd["ProjeyiAldığıTarih"] + "','" + rd["ProjeyiVereceğiTarih"] + "')", con);
                cmd.ExecuteNonQuery();
            }


            OleDbCommand cnd = new OleDbCommand("delete * from proje where OKULNO = '" + textBox1.Text + "'and ADI = '" + textBox2.Text + "'", con);
            cnd.ExecuteNonQuery();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ogretmenpaneli hh = new ogretmenpaneli();
            this.Hide();
            hh.Show();
        }
        void silme()
        {
            silinendosyalar sil = new silinendosyalar();
            sil.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            silme();
        }
    }
}
