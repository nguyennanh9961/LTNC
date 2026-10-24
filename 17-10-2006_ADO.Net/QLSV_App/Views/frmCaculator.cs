using System;
using System.Globalization;
using System.Windows.Forms;

namespace QLSV_App.Views
{
    public partial class frmCaculator : Form
    {
        private double _giaTriTruoc = 0;
        private string _toanTu = "";
        private bool _dangNhapSoMoi = true;

        public frmCaculator()
        {
            InitializeComponent();
        }

        private void btnSo_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (_dangNhapSoMoi || txtDisplay.Text == "0")
                {
                    txtDisplay.Text = btn.Text;
                    _dangNhapSoMoi = false;
                }
                else
                {
                    if (txtDisplay.Text.Length < 16)
                    {
                        txtDisplay.Text += btn.Text;
                    }
                }
            }
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            if (_dangNhapSoMoi)
            {
                txtDisplay.Text = "0.";
                _dangNhapSoMoi = false;
            }
            else if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        private void btnToanTu_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (!_dangNhapSoMoi && !string.IsNullOrEmpty(_toanTu))
                {
                    ThucHienTinhToan();
                }

                if (double.TryParse(txtDisplay.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double val))
                {
                    _giaTriTruoc = val;
                }

                _toanTu = btn.Text;
                lblPhepTinh.Text = $"{_giaTriTruoc} {_toanTu}";
                _dangNhapSoMoi = true;
            }
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_toanTu))
            {
                lblPhepTinh.Text = $"{_giaTriTruoc} {_toanTu} {txtDisplay.Text} =";
                ThucHienTinhToan();
                _toanTu = "";
                _dangNhapSoMoi = true;
            }
        }

        private void ThucHienTinhToan()
        {
            if (!double.TryParse(txtDisplay.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double giaTriSau))
            {
                return;
            }

            double ketQua = 0;
            switch (_toanTu)
            {
                case "+":
                    ketQua = _giaTriTruoc + giaTriSau;
                    break;
                case "-":
                    ketQua = _giaTriTruoc - giaTriSau;
                    break;
                case "×":
                    ketQua = _giaTriTruoc * giaTriSau;
                    break;
                case "÷":
                    if (giaTriSau == 0)
                    {
                        MessageBox.Show("Không thể chia cho số 0!", "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDisplay.Text = "0";
                        _dangNhapSoMoi = true;
                        return;
                    }
                    ketQua = _giaTriTruoc / giaTriSau;
                    break;
                default:
                    return;
            }

            _giaTriTruoc = ketQua;
            txtDisplay.Text = ketQua.ToString(CultureInfo.InvariantCulture);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblPhepTinh.Text = "";
            _giaTriTruoc = 0;
            _toanTu = "";
            _dangNhapSoMoi = true;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            _dangNhapSoMoi = true;
        }

        private void btnXoaLui_Click(object sender, EventArgs e)
        {
            if (!_dangNhapSoMoi && txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                if (string.IsNullOrEmpty(txtDisplay.Text) || txtDisplay.Text == "-")
                {
                    txtDisplay.Text = "0";
                    _dangNhapSoMoi = true;
                }
            }
        }

        private void btnDoiDau_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double val))
            {
                val = -val;
                txtDisplay.Text = val.ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}
