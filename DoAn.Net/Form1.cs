namespace DoAn.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDn_Click(object sender, EventArgs e)
        {
            string user = txtU.Text;
            string pass = txtP.Text;

            if (user == "admin" || pass == "123")
            {
                FormNhaQuanLY f2 = new FormNhaQuanLY();
                f2.ShowDialog();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng ", "Lỗi" , MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
