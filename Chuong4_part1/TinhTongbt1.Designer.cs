namespace Chuong4_part1_vidu1
{
    partial class TinhTongbt1
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
            this.lbNhapa = new System.Windows.Forms.Label();
            this.lbNhapb = new System.Windows.Forms.Label();
            this.txtNhapa = new System.Windows.Forms.TextBox();
            this.txtNhapb = new System.Windows.Forms.TextBox();
            this.btntong = new System.Windows.Forms.Button();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNhapa
            // 
            this.lbNhapa.AutoSize = true;
            this.lbNhapa.Location = new System.Drawing.Point(67, 37);
            this.lbNhapa.Name = "lbNhapa";
            this.lbNhapa.Size = new System.Drawing.Size(45, 13);
            this.lbNhapa.TabIndex = 0;
            this.lbNhapa.Text = "Nhập a:";
            // 
            // lbNhapb
            // 
            this.lbNhapb.AutoSize = true;
            this.lbNhapb.Location = new System.Drawing.Point(67, 75);
            this.lbNhapb.Name = "lbNhapb";
            this.lbNhapb.Size = new System.Drawing.Size(45, 13);
            this.lbNhapb.TabIndex = 1;
            this.lbNhapb.Text = "Nhập b:";
            // 
            // txtNhapa
            // 
            this.txtNhapa.Location = new System.Drawing.Point(138, 34);
            this.txtNhapa.Name = "txtNhapa";
            this.txtNhapa.Size = new System.Drawing.Size(100, 20);
            this.txtNhapa.TabIndex = 2;
            this.txtNhapa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapa_KeyPress);
            // 
            // txtNhapb
            // 
            this.txtNhapb.Location = new System.Drawing.Point(138, 72);
            this.txtNhapb.Name = "txtNhapb";
            this.txtNhapb.Size = new System.Drawing.Size(100, 20);
            this.txtNhapb.TabIndex = 3;
            this.txtNhapb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapb_KeyPress);
            // 
            // btntong
            // 
            this.btntong.Location = new System.Drawing.Point(47, 122);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(75, 23);
            this.btntong.TabIndex = 4;
            this.btntong.Text = "Tổng";
            this.btntong.UseVisualStyleBackColor = true;
            this.btntong.Click += new System.EventHandler(this.btntong_Click);
            // 
            // btnLamlai
            // 
            this.btnLamlai.Location = new System.Drawing.Point(163, 122);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(75, 23);
            this.btnLamlai.TabIndex = 5;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(281, 122);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // TinhTongbt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.btntong);
            this.Controls.Add(this.txtNhapb);
            this.Controls.Add(this.txtNhapa);
            this.Controls.Add(this.lbNhapb);
            this.Controls.Add(this.lbNhapa);
            this.Name = "TinhTongbt1";
            this.Text = "TinhTongbt1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhapa;
        private System.Windows.Forms.Label lbNhapb;
        private System.Windows.Forms.TextBox txtNhapa;
        private System.Windows.Forms.TextBox txtNhapb;
        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnThoat;
    }
}