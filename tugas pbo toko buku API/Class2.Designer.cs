namespace tugas_pbo_toko_buku_API
{
    partial class Class2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_upload = new System.Windows.Forms.Button();
            this.tb_jumlah = new System.Windows.Forms.TextBox();
            this.tb_IDLaptop = new System.Windows.Forms.TextBox();
            this.tb_idtransaksi = new System.Windows.Forms.TextBox();
            this.lab_jumlah = new System.Windows.Forms.Label();
            this.lab_idlap = new System.Windows.Forms.Label();
            this.lab_idtransaksi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(109, 262);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 22;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // tb_jumlah
            // 
            this.tb_jumlah.Location = new System.Drawing.Point(180, 144);
            this.tb_jumlah.Name = "tb_jumlah";
            this.tb_jumlah.Size = new System.Drawing.Size(149, 22);
            this.tb_jumlah.TabIndex = 21;
            // 
            // tb_IDLaptop
            // 
            this.tb_IDLaptop.Location = new System.Drawing.Point(180, 96);
            this.tb_IDLaptop.Name = "tb_IDLaptop";
            this.tb_IDLaptop.Size = new System.Drawing.Size(149, 22);
            this.tb_IDLaptop.TabIndex = 19;
            // 
            // tb_idtransaksi
            // 
            this.tb_idtransaksi.Location = new System.Drawing.Point(180, 47);
            this.tb_idtransaksi.Name = "tb_idtransaksi";
            this.tb_idtransaksi.Size = new System.Drawing.Size(149, 22);
            this.tb_idtransaksi.TabIndex = 17;
            // 
            // lab_jumlah
            // 
            this.lab_jumlah.AutoSize = true;
            this.lab_jumlah.Location = new System.Drawing.Point(59, 150);
            this.lab_jumlah.Name = "lab_jumlah";
            this.lab_jumlah.Size = new System.Drawing.Size(50, 16);
            this.lab_jumlah.TabIndex = 16;
            this.lab_jumlah.Text = "Jumlah";
            // 
            // lab_idlap
            // 
            this.lab_idlap.AutoSize = true;
            this.lab_idlap.Location = new System.Drawing.Point(59, 102);
            this.lab_idlap.Name = "lab_idlap";
            this.lab_idlap.Size = new System.Drawing.Size(65, 16);
            this.lab_idlap.TabIndex = 15;
            this.lab_idlap.Text = "ID Laptop";
            // 
            // lab_idtransaksi
            // 
            this.lab_idtransaksi.AutoSize = true;
            this.lab_idtransaksi.Location = new System.Drawing.Point(59, 54);
            this.lab_idtransaksi.Name = "lab_idtransaksi";
            this.lab_idtransaksi.Size = new System.Drawing.Size(83, 16);
            this.lab_idtransaksi.TabIndex = 12;
            this.lab_idtransaksi.Text = "ID Transaksi";
            // 
            // Class2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 351);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.tb_jumlah);
            this.Controls.Add(this.tb_IDLaptop);
            this.Controls.Add(this.tb_idtransaksi);
            this.Controls.Add(this.lab_jumlah);
            this.Controls.Add(this.lab_idlap);
            this.Controls.Add(this.lab_idtransaksi);
            this.Name = "Class2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Class2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.TextBox tb_jumlah;
        private System.Windows.Forms.TextBox tb_IDLaptop;
        private System.Windows.Forms.TextBox tb_idtransaksi;
        private System.Windows.Forms.Label lab_jumlah;
        private System.Windows.Forms.Label lab_idlap;
        private System.Windows.Forms.Label lab_idtransaksi;
    }
}