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
    public partial class UC_DashboardRingkasan : UserControl
    {
        public UC_DashboardRingkasan()
        {
            InitializeComponent();
        }

        private void UC_DashboardRingkasan_Load(object sender, EventArgs e)
        {
            TampilkanDataSiswaPerJurusan();
            TampilkanDataJenisKelamin();
        }

        private void TampilkanDataSiswaPerJurusan()
        {
            chart_SiswaJurusan.Series.Clear();
            chart_SiswaJurusan.Titles.Clear();

            chart_SiswaJurusan.Titles.Add("Siswa Per Jurusan");
           
            chart_SiswaJurusan.Series.Add("Jumlah");
           
            chart_SiswaJurusan.Series["Jumlah"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

          
            chart_SiswaJurusan.Series["Jumlah"].Points.AddXY("RPL", 102);
            chart_SiswaJurusan.Series["Jumlah"].Points.AddXY("TJAT", 35);
            chart_SiswaJurusan.Series["Jumlah"].Points.AddXY("TKJ", 77);
            chart_SiswaJurusan.Series["Jumlah"].Points.AddXY("PG", 56);
            //tambahin di sini

            int totalSiswa = 0;

            foreach (var point in chart_SiswaJurusan.Series["Jumlah"].Points)
            {
                totalSiswa += (int)point.YValues[0];
            }

            lbl_TotalSiswa.Text = totalSiswa.ToString();

            int totalJurusan = chart_SiswaJurusan.Series["Jumlah"].Points.Count;

            lbl_TotalJurusan.Text = totalJurusan.ToString();

            const int SISWA_PER_KELAS = 32;

            double hasilBagi = (double)totalSiswa / SISWA_PER_KELAS;

            int totalKelas = (int)Math.Ceiling(hasilBagi);

            lbl_TotalKelas.Text = totalKelas.ToString();
        }

        private void TampilkanDataJenisKelamin()
        {
            

            chart_JenisKelamin.Series.Clear();
            chart_JenisKelamin.Titles.Clear();

            chart_JenisKelamin.Titles.Add("Persentase Jenis Kelamin");

            chart_JenisKelamin.Series.Add("Gender");

            chart_JenisKelamin.Series["Gender"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            chart_JenisKelamin.Series["Gender"].Points.AddXY("Laki-laki", 56.25);
            chart_JenisKelamin.Series["Gender"].Points.AddXY("Perempuan", 43.75);


            chart_JenisKelamin.Series["Gender"].Label = "#PERCENT";

            chart_JenisKelamin.Series["Gender"].LegendText = "#VALX";
        }

        private void chart_JenisKelamin_Click(object sender, EventArgs e)
        {

        }
    }
}
