using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiDataPKL
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_DataSiswaPKL_Click(object sender, EventArgs e)
        {
            GantiKonten(new UC_DataSiswa());
        }
        private void GantiKonten(System.Windows.Forms.UserControl uc)
        {
            pnl_KontenUtama.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnl_KontenUtama.Controls.Add(uc);
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            GantiKonten(new UC_DashboardRingkasan());
        }

        private void pnl_KontenUtama_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GantiKonten(new UC_DataPerusahaan());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GantiKonten(new UC_DataPembimbing());
        }
    }
}
