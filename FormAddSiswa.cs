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
    public partial class FormAddSiswa : Form
    {
        public Siswa DataBaru { get; private set; }

        public FormAddSiswa()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAddSiswa_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataBaru = new Siswa
            {
                Nama = txtNama.Text,
                Kelas = txtKelas.Text,
                Perusahaan = txtPerusahaan.Text,
                Jurusan = txtJurusan.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
