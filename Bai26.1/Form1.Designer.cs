using System.Windows.Forms;

namespace Bai5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textMau = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNha = new System.Windows.Forms.Button();
            this.btnDe = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txmau = new System.Windows.Forms.TextBox();
            this.textTu = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(81, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phép Tính Phân Số";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox1.Location = new System.Drawing.Point(21, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân Số 1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 23);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(97, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 23);
            this.textBox4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mẫu  Số : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tử Số : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textMau);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(297, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 135);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phân Số 2";
            // 
            // textMau
            // 
            this.textMau.Location = new System.Drawing.Point(116, 82);
            this.textMau.Name = "textMau";
            this.textMau.Size = new System.Drawing.Size(56, 26);
            this.textMau.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 26);
            this.textBox1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(42, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mẫu Số : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(42, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tử Số : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNha);
            this.groupBox3.Controls.Add(this.btnDe);
            this.groupBox3.Controls.Add(this.btnDiv);
            this.groupBox3.Controls.Add(this.btnSum);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox3.Location = new System.Drawing.Point(12, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 133);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phép Tính";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnNha
            // 
            this.btnNha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNha.Location = new System.Drawing.Point(19, 84);
            this.btnNha.Name = "btnNha";
            this.btnNha.Size = new System.Drawing.Size(72, 40);
            this.btnNha.TabIndex = 6;
            this.btnNha.Text = "Nhân";
            this.btnNha.UseVisualStyleBackColor = true;
            this.btnNha.Click += new System.EventHandler(this.btnNha_Click);
            // 
            // btnDe
            // 
            this.btnDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDe.Location = new System.Drawing.Point(136, 33);
            this.btnDe.Name = "btnDe";
            this.btnDe.Size = new System.Drawing.Size(72, 40);
            this.btnDe.TabIndex = 5;
            this.btnDe.Text = "Trừ";
            this.btnDe.UseVisualStyleBackColor = true;
            this.btnDe.Click += new System.EventHandler(this.btnDe_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(136, 84);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(72, 40);
            this.btnDiv.TabIndex = 4;
            this.btnDiv.Text = "Chia";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSum.Location = new System.Drawing.Point(19, 38);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(72, 40);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "Cộng";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txmau);
            this.groupBox4.Controls.Add(this.textTu);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox4.Location = new System.Drawing.Point(297, 323);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 122);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kết Quả ";
            // 
            // txmau
            // 
            this.txmau.Location = new System.Drawing.Point(90, 82);
            this.txmau.Name = "txmau";
            this.txmau.Size = new System.Drawing.Size(56, 34);
            this.txmau.TabIndex = 10;
            // 
            // textTu
            // 
            this.textTu.Location = new System.Drawing.Point(90, 33);
            this.textTu.Name = "textTu";
            this.textTu.Size = new System.Drawing.Size(56, 34);
            this.textTu.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 535);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 55);
            this.button5.TabIndex = 7;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(21, 473);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 56);
            this.button6.TabIndex = 8;
            this.button6.Text = "Tiếp Tục";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(534, 688);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sử Lý Phân Số";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textMau;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNha;
        private System.Windows.Forms.Button btnDe;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.TextBox txmau;
        private System.Windows.Forms.TextBox textTu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

