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
        public UC_DataSiswa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_DataSiswa_Load(object sender, EventArgs e)
        {

        }
        public class Siswa
        {
            public int ID { get; set; }
            public string Nama { get; set; }
            public string Kelas { get; set; }
            public string Perusahaan { get; set; }
            public string Jurusan { get; set; }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadSiswaData()
        {
            try
            {
                // Ganti dgvSiswa dengan nama DataGridView Anda
                dgvSiswa.DataSource = dal.GetAllSiswa();

                // Opsional: Sembunyikan kolom ID di tampilan
                if (dgvSiswa.Columns.Contains("ID"))
                {
                    dgvSiswa.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data siswa: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Panggil LoadSiswaData saat UserControl dimuat
        private void UC_DataSiswa_Load(object sender, EventArgs e)
        {
            LoadSiswaData();
            // Sambungkan event CellClick agar data terpilih masuk ke TextBox
            dgvSiswa.CellClick += dgvSiswa_CellClick;
        }

        // 4. Clear Input Fields
        private void ClearInputFields()
        {
            // Ganti txt... dengan nama TextBox Anda
            txtNama.Clear();
            txtKelas.Clear();
            txtPerusahaan.Clear();
            txtJurusan.Clear();

            // Hapus ID yang tersimpan di Tag tombol Update
            btnUpdate.Tag = null;
        }

        // --- CREATE (Tombol ADD) ---
        private void btnAdd_Click(object sender, EventArgs e) // Pastikan ini terhubung ke tombol 'add'
        {
            // Validasi input sederhana
            if (string.IsNullOrWhiteSpace(txtNama.Text) || string.IsNullOrWhiteSpace(txtKelas.Text))
            {
                MessageBox.Show("Nama dan Kelas wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Siswa newSiswa = new Siswa
                {
                    Nama = txtNama.Text,
                    Kelas = txtKelas.Text,
                    Perusahaan = txtPerusahaan.Text,
                    Jurusan = txtJurusan.Text
                };

                dal.AddSiswa(newSiswa);
                MessageBox.Show("Data siswa berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadSiswaData();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- UPDATE (Ambil data dari DataGrid ke TextBox) ---
        private void dgvSiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSiswa.Rows[e.RowIndex];

                // Simpan ID yang dipilih ke Tag tombol Update untuk proses Update nanti
                if (row.Cells["ID"].Value != DBNull.Value)
                {
                    btnUpdate.Tag = row.Cells["ID"].Value;
                }

                // Isi TextBox dengan data dari baris yang dipilih
                txtNama.Text = row.Cells["Nama"].Value?.ToString() ?? string.Empty;
                txtKelas.Text = row.Cells["Kelas"].Value?.ToString() ?? string.Empty;
                txtPerusahaan.Text = row.Cells["Perusahaan"].Value?.ToString() ?? string.Empty;
                txtJurusan.Text = row.Cells["Jurusan"].Value?.ToString() ?? string.Empty;
            }
        }

        // --- UPDATE (Tombol UPDATE) ---
        private void btnUpdate_Click(object sender, EventArgs e) // Pastikan ini terhubung ke tombol 'update'
        {
            if (btnUpdate.Tag == null)
            {
                MessageBox.Show("Pilih data yang ingin diubah terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Siswa updatedSiswa = new Siswa
                {
                    ID = Convert.ToInt32(btnUpdate.Tag),
                    Nama = txtNama.Text,
                    Kelas = txtKelas.Text,
                    Perusahaan = txtPerusahaan.Text,
                    Jurusan = txtJurusan.Text
                };

                dal.UpdateSiswa(updatedSiswa);
                MessageBox.Show("Data siswa berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadSiswaData();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- DELETE (Tombol DELETE) ---
        private void btnDelete_Click(object sender, EventArgs e) // Pastikan ini terhubung ke tombol 'delete'
        {
            if (dgvSiswa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris data yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pastikan baris yang dipilih tidak null dan memiliki nilai ID
            if (dgvSiswa.SelectedRows[0].Cells["ID"].Value == null || dgvSiswa.SelectedRows[0].Cells["ID"].Value == DBNull.Value)
            {
                MessageBox.Show("Baris yang dipilih tidak memiliki ID yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int siswaID = Convert.ToInt32(dgvSiswa.SelectedRows[0].Cells["ID"].Value);

            DialogResult result = MessageBox.Show($"Yakin ingin menghapus data siswa ID: {siswaID}?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    dal.DeleteSiswa(siswaID);
                    MessageBox.Show("Data siswa berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadSiswaData();
                    ClearInputFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public class SiswaDAL
        {
            // GANTI INI dengan string koneksi Anda yang sesungguhnya. 
            // Contoh untuk LocalDB:
            private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\NamaDatabaseAnda.mdf;Integrated Security=True;Connect Timeout=30";

            // Asumsi model Siswa berada dalam namespace yang sama.
            // Method READ: Mengambil semua data Siswa
            public DataTable GetAllSiswa()
            {
                DataTable dt = new DataTable();
                string query = "SELECT ID, Nama, Kelas, Perusahaan, Jurusan FROM SiswaPKL";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            adapter.Fill(dt);
                        }
                        catch (Exception ex)
                        {
                            // Anda bisa log error di sini, atau lemparkan kembali
                            throw new Exception("Error saat mengambil data siswa: " + ex.Message);
                        }
                    }
                }
                return dt;
            }

            // Method CREATE: Menambahkan Siswa
            public void AddSiswa(UC_DataSiswa.Siswa siswa)
            {
                string query = "INSERT INTO SiswaPKL (Nama, Kelas, Perusahaan, Jurusan) VALUES (@Nama, @Kelas, @Perusahaan, @Jurusan)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nama", siswa.Nama);
                        command.Parameters.AddWithValue("@Kelas", siswa.Kelas);
                        command.Parameters.AddWithValue("@Perusahaan", siswa.Perusahaan);
                        command.Parameters.AddWithValue("@Jurusan", siswa.Jurusan);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error saat menambahkan data siswa: " + ex.Message);
                        }
                    }
                }
            }

            // Method UPDATE: Mengubah Siswa
            public void UpdateSiswa(UC_DataSiswa.Siswa siswa)
            {
                string query = "UPDATE SiswaPKL SET Nama = @Nama, Kelas = @Kelas, Perusahaan = @Perusahaan, Jurusan = @Jurusan WHERE ID = @ID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", siswa.ID);
                        command.Parameters.AddWithValue("@Nama", siswa.Nama);
                        command.Parameters.AddWithValue("@Kelas", siswa.Kelas);
                        command.Parameters.AddWithValue("@Perusahaan", siswa.Perusahaan);
                        command.Parameters.AddWithValue("@Jurusan", siswa.Jurusan);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error saat memperbarui data siswa: " + ex.Message);
                        }
                    }
                }
            }

            // Method DELETE: Menghapus Siswa
            public void DeleteSiswa(int id)
            {
                string query = "DELETE FROM SiswaPKL WHERE ID = @ID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error saat menghapus data siswa: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
