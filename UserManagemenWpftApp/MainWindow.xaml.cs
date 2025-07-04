using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusinessObjects;
using Services;

namespace UserManagemenWpftApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserServices userService = new UserServices();
        public MainWindow()
        {
            InitializeComponent();
            HienThiToanBoUsers();
        }

        private void HienThiToanBoUsers()
        {
           List<User> users = userService.GetAllUsers();
            lbUser.ItemsSource = users;
        }
    }
}