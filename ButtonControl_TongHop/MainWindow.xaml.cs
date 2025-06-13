using System.Windows;


namespace ButtonControl_TongHop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnThoat_Click(object sender, RoutedEventArgs e)
        {

            Close();
        }

        private void BtnTong_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int tong = a + b;

                tbKetQua.Text = tong.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ vào cả hai ô.", "Lỗi định dạng", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
