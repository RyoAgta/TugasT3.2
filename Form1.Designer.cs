namespace TugasTiga3
{
    partial class frmLathanTiga3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOk = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPesan3 = new TextBox();
            txtPesan1 = new TextBox();
            txtPesan2 = new TextBox();
            lstPekerjaan = new ListBox();
            txtNama = new TextBox();
            cmbPendidikan = new ComboBox();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.BackColor = SystemColors.ControlDark;
            btnOk.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.Location = new Point(12, 348);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(327, 29);
            btnOk.TabIndex = 0;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 1;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 2;
            label2.Text = "Pekerjaan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 64);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 3;
            label3.Text = "Pendidikan";
            label3.Click += label3_Click;
            // 
            // txtPesan3
            // 
            txtPesan3.Enabled = false;
            txtPesan3.Location = new Point(12, 307);
            txtPesan3.Name = "txtPesan3";
            txtPesan3.Size = new Size(327, 23);
            txtPesan3.TabIndex = 4;
            // 
            // txtPesan1
            // 
            txtPesan1.Enabled = false;
            txtPesan1.Location = new Point(12, 249);
            txtPesan1.Name = "txtPesan1";
            txtPesan1.Size = new Size(327, 23);
            txtPesan1.TabIndex = 5;
            // 
            // txtPesan2
            // 
            txtPesan2.Enabled = false;
            txtPesan2.Location = new Point(12, 278);
            txtPesan2.Name = "txtPesan2";
            txtPesan2.Size = new Size(327, 23);
            txtPesan2.TabIndex = 6;
            // 
            // lstPekerjaan
            // 
            lstPekerjaan.FormattingEnabled = true;
            lstPekerjaan.ItemHeight = 15;
            lstPekerjaan.Items.AddRange(new object[] { "Pedagang", "PNS", "Dosen", "Swasta", "ABRI" });
            lstPekerjaan.Location = new Point(95, 104);
            lstPekerjaan.Name = "lstPekerjaan";
            lstPekerjaan.Size = new Size(244, 139);
            lstPekerjaan.TabIndex = 7;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(95, 20);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(244, 23);
            txtNama.TabIndex = 8;
            // 
            // cmbPendidikan
            // 
            cmbPendidikan.FormattingEnabled = true;
            cmbPendidikan.Items.AddRange(new object[] { "SD", "SMP", "SMA", "Diploma", "Sarjana", "Pascasarjana" });
            cmbPendidikan.Location = new Point(95, 64);
            cmbPendidikan.Name = "cmbPendidikan";
            cmbPendidikan.Size = new Size(244, 23);
            cmbPendidikan.TabIndex = 9;
            // 
            // frmLathanTiga3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 392);
            Controls.Add(cmbPendidikan);
            Controls.Add(txtNama);
            Controls.Add(lstPekerjaan);
            Controls.Add(txtPesan2);
            Controls.Add(txtPesan1);
            Controls.Add(txtPesan3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOk);
            Name = "frmLathanTiga3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Latihan3.3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPesan3;
        private TextBox txtPesan1;
        private TextBox txtPesan2;
        private ListBox lstPekerjaan;
        private TextBox txtNama;
        private ComboBox cmbPendidikan;
    }
}