using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void setAgama()
        {
            ComboBox agama = cbAgama;
            string[] listAgama = new string[5];
            listAgama[0] = "Islam";
            listAgama[1] = "Kristen";
            listAgama[2] = "Hindu";
            listAgama[3] = "Budha";
            listAgama[4] = "Katolik";
            agama.Items.AddRange(listAgama);
        }

        private void setKota()
        {
            string[] listKota = new string[2];
            listKota[0] = "Cilacap";
            listKota[0] = "Purwokerto";

            lbKota.Items.Add("Cilacap");
            lbKota.Items.Add("Purwokerto");
        }

        private void setJurusan()
        {
            string[] listJurusan = new string[3];
            listJurusan[0] = "Teknik Informatika";
            listJurusan[1] = "Rekayasa Keamanan Siber";
            listJurusan[2] = "Teknik Rekayasa Multimedia";

            cbJurusan.Items.Clear();
            cbJurusan.Items.AddRange (listJurusan);
        }

        private void setStudi()
        {

            string[] listStudi = new string[2];
            listStudi[0] = "D3";
            listStudi[1] = "D4";

            cbStudi.Items.Clear();
            cbStudi.Items.AddRange(listStudi);
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            string jenisKelamin = "";
            if (rbLakiLaki.Checked)
            {
                jenisKelamin = "Laki Laki";
            } else if (rbPerempuan.Checked)
            {
                jenisKelamin = "Perempuan";
            }
            string info =
                "No Induk :\t\t" + tbNoInduk.Text + "\n" +
                "Nama :\t\t\t" + tbNamaMahasiswa.Text + "\n" +
                "Jenis Kelamin :\t\t" + jenisKelamin + "\n" +
                "Agama :\t\t\t" + cbAgama.Text+ "\n" +
                "Jurusan :\t\t\t" + cbJurusan.Text + "\n" +
                "Jenjang Studi :\t\t" + cbStudi.Text + "\n" +
                "Alamat :\t\t\t" + tbAlamat.Text + "\n" +
                "Kota :\t\t\t" + lbKota.Text + "\n" +
                "Telepon :\t\t\t" + tbTelepon.Text + "\n";

            MessageBox.Show(info,"Tampilan data",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            tbNoInduk.Clear();
            tbNamaMahasiswa.Clear();
            rbLakiLaki.Checked = false;
            rbPerempuan.Checked = false;
            cbAgama.SelectedIndex = -1;
            cbJurusan.SelectedIndex = -1;
            cbStudi.SelectedIndex = -1;
            tbAlamat.Clear();
            lbKota.SelectedIndex = -1;
            tbTelepon.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            setAgama();
            setJurusan();
            setStudi();
            setKota();
        }
        private void tbNoInduk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                tbNamaMahasiswa.Focus();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control &&  e.KeyCode == Keys.T) {
                btnTampil.PerformClick();
            }
        }
    }
}
