namespace DoAn.Net
{
    partial class Form1
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
            btnDn = new Button();
            txtU = new TextBox();
            label2 = new Label();
            txtP = new TextBox();
            btnThoat = new Button();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnDn
            // 
            btnDn.Font = new Font("Times New Roman", 13.8F);
            btnDn.Location = new Point(188, 295);
            btnDn.Name = "btnDn";
            btnDn.Size = new Size(165, 45);
            btnDn.TabIndex = 0;
            btnDn.Text = "Đăng nhập";
            btnDn.UseVisualStyleBackColor = true;
            btnDn.Click += btnDn_Click;
            // 
            // txtU
            // 
            txtU.Font = new Font("Times New Roman", 13.8F);
            txtU.Location = new Point(346, 148);
            txtU.Name = "txtU";
            txtU.Size = new Size(125, 34);
            txtU.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(188, 222);
            label2.Name = "label2";
            label2.Size = new Size(102, 26);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtP
            // 
            txtP.Font = new Font("Times New Roman", 13.8F);
            txtP.Location = new Point(346, 219);
            txtP.Name = "txtP";
            txtP.Size = new Size(125, 34);
            txtP.TabIndex = 4;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 13.8F);
            btnThoat.Location = new Point(393, 295);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(102, 45);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F);
            label1.Location = new Point(188, 151);
            label1.Name = "label1";
            label1.Size = new Size(54, 26);
            label1.TabIndex = 1;
            label1.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(188, 33);
            label3.Name = "label3";
            label3.Size = new Size(375, 51);
            label3.TabIndex = 6;
            label3.Text = "Quản lý bán xe Ô tô";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnThoat);
            Controls.Add(txtP);
            Controls.Add(label2);
            Controls.Add(txtU);
            Controls.Add(label1);
            Controls.Add(btnDn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDn;
        private TextBox txtU;
        private Label label2;
        private TextBox txtP;
        private Button btnThoat;
        private Label label1;
        private Label label3;
    }
}
