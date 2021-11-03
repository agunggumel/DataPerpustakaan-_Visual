namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtjumlah = new System.Windows.Forms.TextBox();
            this.txtkode = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpengarang = new System.Windows.Forms.TextBox();
            this.cmbjenis = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.cmbpenerbit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnproses = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jumlah Data";
            // 
            // txtjumlah
            // 
            this.txtjumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjumlah.Location = new System.Drawing.Point(138, 23);
            this.txtjumlah.Name = "txtjumlah";
            this.txtjumlah.Size = new System.Drawing.Size(111, 27);
            this.txtjumlah.TabIndex = 1;
            // 
            // txtkode
            // 
            this.txtkode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkode.Location = new System.Drawing.Point(138, 75);
            this.txtkode.Name = "txtkode";
            this.txtkode.Size = new System.Drawing.Size(167, 27);
            this.txtkode.TabIndex = 2;
            this.txtkode.TextChanged += new System.EventHandler(this.txtkode_TextChanged);
            // 
            // txtnama
            // 
            this.txtnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnama.Location = new System.Drawing.Point(138, 115);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(167, 27);
            this.txtnama.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kode Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama Buku";
            // 
            // txtpengarang
            // 
            this.txtpengarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpengarang.Location = new System.Drawing.Point(138, 199);
            this.txtpengarang.Name = "txtpengarang";
            this.txtpengarang.Size = new System.Drawing.Size(167, 27);
            this.txtpengarang.TabIndex = 6;
            this.txtpengarang.TextChanged += new System.EventHandler(this.txtpengarang_TextChanged);
            // 
            // cmbjenis
            // 
            this.cmbjenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbjenis.FormattingEnabled = true;
            this.cmbjenis.Items.AddRange(new object[] {
            "INTERAKTIF",
            "KOMIK",
            "TRADISIONAL BOOKS",
            "LEGENDA",
            "SEJARAH",
            "NOVEL",
            "CERPEN",
            "EDUKASI",
            ""});
            this.cmbjenis.Location = new System.Drawing.Point(138, 155);
            this.cmbjenis.Name = "cmbjenis";
            this.cmbjenis.Size = new System.Drawing.Size(167, 28);
            this.cmbjenis.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jenis Buku";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pengarang";
            // 
            // txtstok
            // 
            this.txtstok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstok.Location = new System.Drawing.Point(138, 284);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(167, 27);
            this.txtstok.TabIndex = 10;
            // 
            // cmbpenerbit
            // 
            this.cmbpenerbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpenerbit.FormattingEnabled = true;
            this.cmbpenerbit.Items.AddRange(new object[] {
            "ERLANGGA",
            "RINALDY MUNIR",
            "GAGAS MEDIA",
            "GRAMEDIA",
            "MIZAN",
            "BENTANG PUSTAKA",
            "NAURA BOOKS"});
            this.cmbpenerbit.Location = new System.Drawing.Point(138, 241);
            this.cmbpenerbit.Name = "cmbpenerbit";
            this.cmbpenerbit.Size = new System.Drawing.Size(167, 28);
            this.cmbpenerbit.TabIndex = 11;
            this.cmbpenerbit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Penerbit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Stok";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(328, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(528, 196);
            this.dataGridView1.TabIndex = 14;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(265, 18);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(63, 32);
            this.btncreate.TabIndex = 15;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(395, 70);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(63, 32);
            this.btnsimpan.TabIndex = 16;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(490, 70);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(63, 32);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnproses
            // 
            this.btnproses.Location = new System.Drawing.Point(586, 70);
            this.btnproses.Name = "btnproses";
            this.btnproses.Size = new System.Drawing.Size(63, 32);
            this.btnproses.TabIndex = 18;
            this.btnproses.Text = "Proses";
            this.btnproses.UseVisualStyleBackColor = true;
            this.btnproses.Click += new System.EventHandler(this.btnproses_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(679, 70);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(63, 32);
            this.btndelete.TabIndex = 19;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kode Buku";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nama Buku";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Jenis Buku";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Pengarang";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 140;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Penerbit";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 140;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Stok";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 140;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tanggal Input Data";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 140;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 331);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnproses);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbpenerbit);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbjenis);
            this.Controls.Add(this.txtpengarang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtkode);
            this.Controls.Add(this.txtjumlah);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtjumlah;
        private System.Windows.Forms.TextBox txtkode;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpengarang;
        private System.Windows.Forms.ComboBox cmbjenis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.ComboBox cmbpenerbit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnproses;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

