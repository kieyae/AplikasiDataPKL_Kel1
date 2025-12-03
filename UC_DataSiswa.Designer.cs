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
            this.dgvSiswa = new System.Windows.Forms.DataGridView();
            this.ColNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiswa)).BeginInit();
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
            // dgvSiswa
            // 
            this.dgvSiswa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNama,
            this.colKelas,
            this.colJurusan});
            this.dgvSiswa.Location = new System.Drawing.Point(38, 46);
            this.dgvSiswa.Name = "dgvSiswa";
            this.dgvSiswa.Size = new System.Drawing.Size(343, 170);
            this.dgvSiswa.TabIndex = 1;
            // 
            // ColNama
            // 
            this.ColNama.DataPropertyName = "Nama";
            this.ColNama.HeaderText = "Nama";
            this.ColNama.Name = "ColNama";
            // 
            // colKelas
            // 
            this.colKelas.DataPropertyName = "Kelas";
            this.colKelas.HeaderText = "Kelas";
            this.colKelas.Name = "colKelas";
            // 
            // colJurusan
            // 
            this.colJurusan.DataPropertyName = "Jurusan";
            this.colJurusan.HeaderText = "Jurusan";
            this.colJurusan.Name = "colJurusan";
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
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(356, 231);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // UC_DataSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvSiswa);
            this.Controls.Add(this.label1);
            this.Name = "UC_DataSiswa";
            this.Size = new System.Drawing.Size(485, 357);
            this.Load += new System.EventHandler(this.UC_DataSiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSiswa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJurusan;
    }
}
