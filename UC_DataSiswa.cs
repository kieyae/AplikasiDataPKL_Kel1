using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiDataPKL
{
    public partial class UC_DataSiswa : UserControl
    {
        List<Siswa> dataSiswa = new List<Siswa>();

        public UC_DataSiswa()
        {
            InitializeComponent();
        }

        private void UC_DataSiswa_Load(object sender, EventArgs e)
        {
            LoadTable();   
        }

        private void LoadTable()
        {
            dgvSiswa.DataSource = null;
            dgvSiswa.DataSource = dataSiswa;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddSiswa f = new FormAddSiswa();

            if (f.ShowDialog() == DialogResult.OK)
            {
                dataSiswa.Add(f.DataBaru);
                LoadTable();
            }
        }

    }

    public class Siswa
    {
        public string Nama { get; set; }
        public string Kelas { get; set; }
        public string Perusahaan { get; set; }
        public string Jurusan { get; set; }
    }
}
