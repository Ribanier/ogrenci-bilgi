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
    public partial class silinendosyalar : Form
    {
        public silinendosyalar()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabanim.accdb");
        void baglan()
        {
            if (ConnectionState.Closed == con.State) con.Open();
        }
        void listele()
        {
            baglan();

            DataTable dt = new DataTable();

            OleDbDataAdapter adb = new OleDbDataAdapter("SELECT * FROM arsiv", con);

            adb.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;

        }
        private void silinendosyalar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogretmenpaneli gg = new ogretmenpaneli();
            this.Hide();
            gg.Show();
        }
    }
}
