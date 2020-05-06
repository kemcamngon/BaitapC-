using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4_part1_vidu1
{
    public partial class TinhTongbt1 : Form
    {
        public TinhTongbt1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNhapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '.') ||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtNhapb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '.') ||
                (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }
        private void btntong_Click(object sender, EventArgs e)
        {
            if (txtNhapa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số nguyên a");
                txtNhapa.Focus();
                return;
            }

            if (txtNhapb.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số nguyên b");
                txtNhapb.Focus();
                return;
            }

            double a = Convert.ToDouble(txtNhapa.Text);
            double b = Convert.ToDouble(txtNhapb.Text);
            if(a > b)
            {
                double tong1 = ((a + b) * (a - b + 1) / 2);
                MessageBox.Show("tổng từ " + txtNhapb.Text + " đến " + txtNhapa.Text + " là " + tong1);
            }
            if (b > a)
            {
                double tong2 = ((a + b) * (b - a + 1) / 2);
                MessageBox.Show("tổng từ " + txtNhapa.Text + " đến " + txtNhapb.Text + " là " + tong2);
            }
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtNhapa.Text = "";
            txtNhapb.Text = "";
            txtNhapa.Focus();
            return;
        }
    }
}
