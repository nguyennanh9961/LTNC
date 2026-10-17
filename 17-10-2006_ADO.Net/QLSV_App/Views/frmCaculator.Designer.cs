namespace QLSV_App.Views
{
    partial class frmCaculator
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            lblPhepTinh = new Label();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnChia = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnNhan = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnTru = new Button();
            btn0 = new Button();
            btnCham = new Button();
            btnBang = new Button();
            btnCong = new Button();
            btnC = new Button();
            btnCE = new Button();
            btnXoaLui = new Button();
            btnDoiDau = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.White;
            txtDisplay.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            txtDisplay.Location = new Point(12, 35);
            txtDisplay.MaxLength = 20;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(300, 52);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPhepTinh
            // 
            lblPhepTinh.Font = new Font("Segoe UI", 9F);
            lblPhepTinh.ForeColor = Color.DimGray;
            lblPhepTinh.Location = new Point(12, 9);
            lblPhepTinh.Name = "lblPhepTinh";
            lblPhepTinh.Size = new Size(300, 20);
            lblPhepTinh.TabIndex = 1;
            lblPhepTinh.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCE
            // 
            btnCE.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCE.Location = new Point(12, 95);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(68, 50);
            btnCE.TabIndex = 2;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnC.Location = new Point(88, 95);
            btnC.Name = "btnC";
            btnC.Size = new Size(68, 50);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnXoaLui
            // 
            btnXoaLui.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnXoaLui.Location = new Point(164, 95);
            btnXoaLui.Name = "btnXoaLui";
            btnXoaLui.Size = new Size(68, 50);
            btnXoaLui.TabIndex = 4;
            btnXoaLui.Text = "⌫";
            btnXoaLui.UseVisualStyleBackColor = true;
            btnXoaLui.Click += btnXoaLui_Click;
            // 
            // btnChia
            // 
            btnChia.BackColor = Color.FromArgb(224, 242, 254);
            btnChia.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnChia.Location = new Point(240, 95);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(72, 50);
            btnChia.TabIndex = 5;
            btnChia.Text = "÷";
            btnChia.UseVisualStyleBackColor = false;
            btnChia.Click += btnToanTu_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn7.Location = new Point(12, 153);
            btn7.Name = "btn7";
            btn7.Size = new Size(68, 50);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnSo_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn8.Location = new Point(88, 153);
            btn8.Name = "btn8";
            btn8.Size = new Size(68, 50);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnSo_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn9.Location = new Point(164, 153);
            btn9.Name = "btn9";
            btn9.Size = new Size(68, 50);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnSo_Click;
            // 
            // btnNhan
            // 
            btnNhan.BackColor = Color.FromArgb(224, 242, 254);
            btnNhan.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnNhan.Location = new Point(240, 153);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(72, 50);
            btnNhan.TabIndex = 9;
            btnNhan.Text = "×";
            btnNhan.UseVisualStyleBackColor = false;
            btnNhan.Click += btnToanTu_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn4.Location = new Point(12, 211);
            btn4.Name = "btn4";
            btn4.Size = new Size(68, 50);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnSo_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn5.Location = new Point(88, 211);
            btn5.Name = "btn5";
            btn5.Size = new Size(68, 50);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnSo_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn6.Location = new Point(164, 211);
            btn6.Name = "btn6";
            btn6.Size = new Size(68, 50);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnSo_Click;
            // 
            // btnTru
            // 
            btnTru.BackColor = Color.FromArgb(224, 242, 254);
            btnTru.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnTru.Location = new Point(240, 211);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(72, 50);
            btnTru.TabIndex = 13;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = false;
            btnTru.Click += btnToanTu_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn1.Location = new Point(12, 269);
            btn1.Name = "btn1";
            btn1.Size = new Size(68, 50);
            btn1.TabIndex = 14;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnSo_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn2.Location = new Point(88, 269);
            btn2.Name = "btn2";
            btn2.Size = new Size(68, 50);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnSo_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn3.Location = new Point(164, 269);
            btn3.Name = "btn3";
            btn3.Size = new Size(68, 50);
            btn3.TabIndex = 16;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnSo_Click;
            // 
            // btnCong
            // 
            btnCong.BackColor = Color.FromArgb(224, 242, 254);
            btnCong.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnCong.Location = new Point(240, 269);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(72, 50);
            btnCong.TabIndex = 17;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = false;
            btnCong.Click += btnToanTu_Click;
            // 
            // btnDoiDau
            // 
            btnDoiDau.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDoiDau.Location = new Point(12, 327);
            btnDoiDau.Name = "btnDoiDau";
            btnDoiDau.Size = new Size(68, 50);
            btnDoiDau.TabIndex = 18;
            btnDoiDau.Text = "±";
            btnDoiDau.UseVisualStyleBackColor = true;
            btnDoiDau.Click += btnDoiDau_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn0.Location = new Point(88, 327);
            btn0.Name = "btn0";
            btn0.Size = new Size(68, 50);
            btn0.TabIndex = 19;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnSo_Click;
            // 
            // btnCham
            // 
            btnCham.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCham.Location = new Point(164, 327);
            btnCham.Name = "btnCham";
            btnCham.Size = new Size(68, 50);
            btnCham.TabIndex = 20;
            btnCham.Text = ".";
            btnCham.UseVisualStyleBackColor = true;
            btnCham.Click += btnCham_Click;
            // 
            // btnBang
            // 
            btnBang.BackColor = Color.FromArgb(25, 118, 210);
            btnBang.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnBang.ForeColor = Color.White;
            btnBang.Location = new Point(240, 327);
            btnBang.Name = "btnBang";
            btnBang.Size = new Size(72, 50);
            btnBang.TabIndex = 21;
            btnBang.Text = "=";
            btnBang.UseVisualStyleBackColor = false;
            btnBang.Click += btnBang_Click;
            // 
            // frmCaculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 390);
            Controls.Add(btnBang);
            Controls.Add(btnCham);
            Controls.Add(btn0);
            Controls.Add(btnDoiDau);
            Controls.Add(btnCong);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnTru);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnNhan);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnChia);
            Controls.Add(btnXoaLui);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(lblPhepTinh);
            Controls.Add(txtDisplay);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmCaculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Label lblPhepTinh;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnChia;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnNhan;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnTru;
        private Button btn0;
        private Button btnCham;
        private Button btnBang;
        private Button btnCong;
        private Button btnC;
        private Button btnCE;
        private Button btnXoaLui;
        private Button btnDoiDau;
    }
}
