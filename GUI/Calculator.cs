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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbFirst.Text = "";
            tbSecond.Text = "";
            tbResult.Text = "";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                int first = int.Parse(tbFirst.Text);
                int second = int.Parse(tbSecond.Text);

                tbResult.Text = (first + second).ToString();
            }catch (FormatException ex)
            {
                showErrorMessage("Gagal memproses data, pastikan input yang kamu masukkan merupakan angka desimal");
            } catch (Exception ex)
            {
                showErrorMessage("Gagal memproses data : "+ex.ToString());
            }
        }

        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            try
            {
                int first = int.Parse(tbFirst.Text);
                int second = int.Parse(tbSecond.Text);

                tbResult.Text = (first - second).ToString();
            }
            catch (FormatException ex)
            {
                showErrorMessage("Gagal memproses data, pastikan input yang kamu masukkan merupakan angka desimal");
            }
            catch (Exception ex)
            {
                showErrorMessage("Gagal memproses data : " + ex.ToString());
            }
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            try
            {
                int first = int.Parse(tbFirst.Text);
                int second = int.Parse(tbSecond.Text);

                tbResult.Text = (first * second).ToString();
            }
            catch (FormatException ex)
            {
                showErrorMessage("Gagal memproses data, pastikan input yang kamu masukkan merupakan angka desimal");
            }
            catch (Exception ex)
            {
                showErrorMessage("Gagal memproses data : " + ex.ToString());
            }
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            try
            {
                float first = float.Parse(tbFirst.Text);
                float second = float.Parse(tbSecond.Text);

                tbResult.Text = (first / second).ToString();
            }
            catch (FormatException ex)
            {
                showErrorMessage("Gagal memproses data, pastikan input yang kamu masukkan merupakan angka desimal");
            }
            catch (Exception ex)
            {
                showErrorMessage("Gagal memproses data : " + ex.ToString());
            }
        }
    }
}
