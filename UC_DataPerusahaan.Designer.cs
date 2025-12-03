namespace AplikasiDataPKL
{
    partial class UC_DataPerusahaan
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
            this.lbl_Perusahaan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Perusahaan
            // 
            this.lbl_Perusahaan.AutoSize = true;
            this.lbl_Perusahaan.Location = new System.Drawing.Point(156, 21);
            this.lbl_Perusahaan.Name = "lbl_Perusahaan";
            this.lbl_Perusahaan.Size = new System.Drawing.Size(113, 13);
            this.lbl_Perusahaan.TabIndex = 0;
            this.lbl_Perusahaan.Text = "DATA PERUSAHAAN";
            // 
            // UC_DataPerusahaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Perusahaan);
            this.Name = "UC_DataPerusahaan";
            this.Size = new System.Drawing.Size(466, 283);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Perusahaan;
    }
}
