using EE3206_WPF.Database;
using EE3206_WPF.Models;
using EE3206_WPF.Windows;
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

        private void RoundButton_Submitclick(object sender, RoutedEventArgs e)
        {
            using (DataBaseRepository repository = new DataBaseRepository())
            {
                Admin admin = new Admin()
                {
                    Email = _adminemail.EnteredValue,
                    Password = _adminpassword.Password
                };
                Admin exsitsAdmin = repository.Admins.Where(m => m.Email == admin.Email).Select(m => m).SingleOrDefault();

                if (exsitsAdmin != null)
                {
                    if (exsitsAdmin.Password == admin.Password)
                    {
                        AdminWindow adminwindow = new AdminWindow();
                        adminwindow.GetUser(exsitsAdmin);
                        adminwindow.Show();

                        var w = Application.Current.Windows[0];
                        if (w != null) w.Close();


                    }
                    else
                    {
                        popwindow.TextVal = "Entered Password is Wrong Try Again";
                        popwindow.isOpen = true;
                    }

                }
                else
                {
                    popwindow.TextVal = "Entered Email is Worng Try Again";
                    popwindow.isOpen = true;
                }
            }

        }

        private void popwindow_CloseEnv(object sender, RoutedEventArgs e)
        {
            popwindow.isOpen = false;
        }
    }
}
