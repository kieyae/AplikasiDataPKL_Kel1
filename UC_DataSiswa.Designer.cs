namespace AplikasiDataPKL
{
    partial class UC_DataSiswa
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Siswa = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvSiswa = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.Label();
            this.txtKelas = new System.Windows.Forms.Label();
            this.txtPerusahaan = new System.Windows.Forms.Label();
            this.txtJurusan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Siswa)).BeginInit();
            this.dgvSiswa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(143, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA SISWA PKL";
            // 
            // dgv_Siswa
            // 
            this.dgv_Siswa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Siswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Siswa.Location = new System.Drawing.Point(38, 46);
            this.dgv_Siswa.Name = "dgv_Siswa";
            this.dgv_Siswa.Size = new System.Drawing.Size(281, 179);
            this.dgv_Siswa.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(269, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(356, 231);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvSiswa
            // 
            this.dgvSiswa.BackColor = System.Drawing.Color.White;
            this.dgvSiswa.ColumnCount = 5;
            this.dgvSiswa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.48837F));
            this.dgvSiswa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.51163F));
            this.dgvSiswa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.dgvSiswa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.dgvSiswa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.dgvSiswa.Controls.Add(this.lbl_id, 0, 0);
            this.dgvSiswa.Controls.Add(this.txtNama, 1, 0);
            this.dgvSiswa.Controls.Add(this.txtKelas, 2, 0);
            this.dgvSiswa.Controls.Add(this.txtPerusahaan, 3, 0);
            this.dgvSiswa.Controls.Add(this.txtJurusan, 4, 0);
            this.dgvSiswa.Location = new System.Drawing.Point(38, 34);
            this.dgvSiswa.Name = "dgvSiswa";
            this.dgvSiswa.RowCount = 4;
            this.dgvSiswa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23077F));
            this.dgvSiswa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.76923F));
            this.dgvSiswa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.dgvSiswa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.dgvSiswa.Size = new System.Drawing.Size(393, 191);
            this.dgvSiswa.TabIndex = 5;
            this.dgvSiswa.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(3, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNama
            // 
            this.txtNama.AutoSize = true;
            this.txtNama.Location = new System.Drawing.Point(29, 0);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(35, 13);
            this.txtNama.TabIndex = 1;
            this.txtNama.Text = "Nama";
            this.txtNama.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtKelas
            // 
            this.txtKelas.AutoSize = true;
            this.txtKelas.Location = new System.Drawing.Point(200, 0);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.Size = new System.Drawing.Size(33, 13);
            this.txtKelas.TabIndex = 2;
            this.txtKelas.Text = "Kelas";
            // 
            // txtPerusahaan
            // 
            this.txtPerusahaan.AutoSize = true;
            this.txtPerusahaan.Location = new System.Drawing.Point(252, 0);
            this.txtPerusahaan.Name = "txtPerusahaan";
            this.txtPerusahaan.Size = new System.Drawing.Size(64, 13);
            this.txtPerusahaan.TabIndex = 3;
            this.txtPerusahaan.Text = "Perusahaan";
            // 
            // txtJurusan
            // 
            this.txtJurusan.AutoSize = true;
            this.txtJurusan.Location = new System.Drawing.Point(327, 0);
            this.txtJurusan.Name = "txtJurusan";
            this.txtJurusan.Size = new System.Drawing.Size(47, 13);
            this.txtJurusan.TabIndex = 4;
            this.txtJurusan.Text = "Jurusan ";
            // 
            // UC_DataSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.dgvSiswa);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv_Siswa);
            this.Controls.Add(this.label1);
            this.Name = "UC_DataSiswa";
            this.Size = new System.Drawing.Size(485, 357);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Siswa)).EndInit();
            this.dgvSiswa.ResumeLayout(false);
            this.dgvSiswa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Siswa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TableLayoutPanel dgvSiswa;
        private System.Windows.Forms.Label txtNama;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label txtKelas;
        private System.Windows.Forms.Label txtPerusahaan;
        private System.Windows.Forms.Label txtJurusan;
    }
}
