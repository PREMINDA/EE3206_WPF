using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EE3206_WPF.Pages.AdminLogin
{
    /// <summary>
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Page
    {
        public AdminLogin()
        {
            InitializeComponent();

            Uri loglink = new Uri("/Pages/UserLogin/UserLogin.xaml", UriKind.Relative);
            _userLogLink.NavigateUri = loglink;

            Uri reglink = new Uri("/Pages/UserRegister/UserRegister.xaml", UriKind.Relative);
            _useRegLink.NavigateUri = reglink;
        }
    }
}
