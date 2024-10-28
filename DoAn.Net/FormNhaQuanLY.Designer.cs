namespace DoAn.Net
{
    partial class FormNhaQuanLY
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
            menuStrip1 = new MenuStrip();
            quảnLýNhânViênToolStripMenuItem = new ToolStripMenuItem();
            quảnLýXeToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            thốngKêThôngTinToolStripMenuItem = new ToolStripMenuItem();
            thànhViênHệThốngToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýNhânViênToolStripMenuItem, quảnLýXeToolStripMenuItem, quảnLýToolStripMenuItem, thốngKêThôngTinToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            quảnLýNhânViênToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thànhViênHệThốngToolStripMenuItem });
            quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            quảnLýNhânViênToolStripMenuItem.Size = new Size(149, 24);
            quảnLýNhânViênToolStripMenuItem.Text = "Quản lý thành viên ";
            // 
            // quảnLýXeToolStripMenuItem
            // 
            quảnLýXeToolStripMenuItem.Name = "quảnLýXeToolStripMenuItem";
            quảnLýXeToolStripMenuItem.Size = new Size(156, 24);
            quảnLýXeToolStripMenuItem.Text = "Quản lý thông tin xe";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(140, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý đơn hàng";
            // 
            // thốngKêThôngTinToolStripMenuItem
            // 
            thốngKêThôngTinToolStripMenuItem.Name = "thốngKêThôngTinToolStripMenuItem";
            thốngKêThôngTinToolStripMenuItem.Size = new Size(148, 24);
            thốngKêThôngTinToolStripMenuItem.Text = "Thống kê thông tin";
            // 
            // thànhViênHệThốngToolStripMenuItem
            // 
            thànhViênHệThốngToolStripMenuItem.Name = "thànhViênHệThốngToolStripMenuItem";
            thànhViênHệThốngToolStripMenuItem.Size = new Size(226, 26);
            thànhViênHệThốngToolStripMenuItem.Text = "Thành viên hệ thống";
            // 
            // FormNhaQuanLY
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormNhaQuanLY";
            Text = "FormNhaQuanLy";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýXeToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem thốngKêThôngTinToolStripMenuItem;
        private ToolStripMenuItem thànhViênHệThốngToolStripMenuItem;
    }
}