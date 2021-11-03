using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int jumlah;
        string[] kode;
        string[] nama;
        string[] jenis;
        string[] pengarang;
        string[] penerbit;
        int[] stok;
        int i = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtpengarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            jumlah = Convert.ToInt32(txtjumlah.Text);

            kode = new string[jumlah];
            nama = new string[jumlah];
            jenis = new string[jumlah];
            pengarang= new string[jumlah];
            penerbit = new string[jumlah];
            stok = new int[jumlah];

            txtkode.Focus();

        }

        private void txtkode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (i < jumlah)
            {
                kode[i] = txtkode.Text;
                nama[i] = txtnama.Text;
                jenis[i] = cmbjenis.Text;
                pengarang[i] = txtpengarang.Text;
                penerbit[i] = cmbpenerbit.Text;

                stok[i] = Convert.ToInt32(txtstok.Text);
                i++;

            }
            else
            {
                MessageBox.Show("Batas input data hanya sampai" + jumlah);
            }
            txtkode.Text = "";
            txtnama.Text = "";
            cmbjenis.Text = "";
            txtpengarang.Text = "";
            cmbpenerbit.Text = "";
            txtstok.Text = "";
         

            txtkode.Focus();
        }

        private void btnproses_Click(object sender, EventArgs e)
        {
            

            for (int j = 0; j < jumlah; j++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[j].Cells[0].Value = j + 1;
                dataGridView1.Rows[j].Cells[1].Value = kode[j];
                dataGridView1.Rows[j].Cells[2].Value = nama[j];
                dataGridView1.Rows[j].Cells[3].Value = jenis[j];
                dataGridView1.Rows[j].Cells[4].Value = pengarang[j];
                dataGridView1.Rows[j].Cells[5].Value = penerbit[j];
                dataGridView1.Rows[j].Cells[6].Value = stok[j];


             
            }
       }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtkode.Clear();
            txtnama.Clear();
            txtpengarang.Clear();
            txtstok.Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
