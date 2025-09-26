using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace bai3
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

        private void button1_Click(object sender, EventArgs e)
        {
            ThemSoVaoComboBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThemSoVaoComboBox();
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTinh.Items.Clear();
            if (cboSo.SelectedItem != null)
            {
                int so = (int)cboSo.SelectedItem;
                for (int i = 1; i <= so; i++)
                {
                    if (so % i == 0)
                    {
                        lstTinh.Items.Add(i);
                    }
                }
            }
        }
        private void ThemSoVaoComboBox()
        {
            if (int.TryParse(txtSo.Text, out int so))
            {
                if (!cboSo.Items.Contains(so))
                {
                    cboSo.Items.Add(so);
                }
                cboSo.SelectedItem = so;
                txtSo.Clear();
                txtSo.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                txtSo.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (var item in lstTinh.Items)
            {
                tong += Convert.ToInt32(item);
            }
            MessageBox.Show("Tổng các ước số = " + tong);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (var item in lstTinh.Items)
            {
                int uoc = Convert.ToInt32(item);
                if (uoc % 2 == 0) dem++;
            }
            MessageBox.Show("Số lượng ước chẵn = " + dem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (var item in lstTinh.Items)
            {
                int uoc = Convert.ToInt32(item);
                if (LaNguyenTo(uoc)) dem++;
            }
            MessageBox.Show("Số lượng ước số nguyên tố = " + dem);
        }

        private bool LaNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
