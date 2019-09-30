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
    public partial class projegirisi : Form
    {
        public projegirisi()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabanim.accdb");
        void baglan()
        {
            if(ConnectionState.Closed==con.State)con.Open();
        }
        void listele()
        {
            baglan();
        
            DataTable dt = new DataTable();

            OleDbDataAdapter adb = new OleDbDataAdapter("SELECT * FROM proje", con);
     
            adb.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglan();
            try
            {

                if (!(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == ""))
                {
                    int not1 = int.Parse(textBox5.Text), not2 = int.Parse(textBox4.Text);
                    if (!((not1 > 100 || not1 < 0 )|| (not2 > 100 || not2 < 0)))
                    {
                        OleDbCommand cmd = new OleDbCommand("INSERT INTO proje VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        listele();
                    }
                    else
                    {
                        MessageBox.Show("NOT DEĞERLERİ 100 DEN BÜYÜK 0 DAN KÜÇÜK OLAMAZ !!!");
                    }

                }
                else
                    MessageBox.Show("Boşlukları Doldurunuz.");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }


        private void projegirisi_Load(object sender, EventArgs e)
        {
           label8.Enabled = false;
            label9.Enabled = false;
            button5.Enabled = false;
            textBox6.Enabled= false;
            textBox7.Enabled = false;
           
            this.Text = "..:PROJE GİRİŞİ:..";
            timer1.Enabled = true;
            timer1.Interval = 1000;
            baglan();
            OleDbCommand cmd = new OleDbCommand("select * from siniflar", con);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd["dersler"]);
                comboBox2.Items.Add(rd["dersler"]);
            }
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            ogretmenpaneli dd = new ogretmenpaneli();
            this.Hide();
            dd.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                label9.Text = "Proje1 Not";
                label8.Enabled = true;
                label9.Enabled = true;
                button5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {
                label9.Text = "Proje2 Not";
                label8.Enabled = true;
                label9.Enabled = true;
                button5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglan();
            try
            {
                if (!(textBox6.Text == "" || textBox7.Text == ""))
                {
                    int not=int.Parse(textBox7.Text);
                    if (!(not < 0 || not > 100))
                    {

                        if (radioButton1.Checked)
                        {
                            OleDbCommand cmd = new OleDbCommand("UPDATE proje SET Projenot1 = '" + textBox7.Text + "' Where OKULNO = '" + textBox6.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            listele();
                        }
                        if (radioButton2.Checked)
                        {
                            OleDbCommand cmd = new OleDbCommand("update proje set Projenot2 ='" + textBox7.Text + "' where OKULNO ='" + textBox6.Text + "'", con);
                            cmd.ExecuteNonQuery();
                            listele();
                        }
                    }
                    else
                        MessageBox.Show("NOT DEĞERLERİ 100 DEN BÜYÜK 0 DAN KÜÇÜK OLAMAZ !!!");
                }
                else
                    MessageBox.Show("Boşlukları doldurunuz.");
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
