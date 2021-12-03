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

namespace EE3206_WPF.Pages.UserLogin
{
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Page
    {
        public UserLogin()
        {
            InitializeComponent();

            Uri adminLogLink = new Uri("/Pages/AdminLogin/AdminLogin.xaml", UriKind.Relative);
            _adminLogLink.NavigateUri = adminLogLink;


            Uri reglink = new Uri("/Pages/UserRegister/UserRegister.xaml", UriKind.Relative);
            _userRegLink.NavigateUri = reglink;
        }

        private void RoundButton_Submitclick(object sender, RoutedEventArgs e)
        {
           
            using (DataBaseRepository repository = new DataBaseRepository())
            {
                User user = new User()
                {
                    Email = _UserName.EnteredValue,
                    Password = _UserPassword.Password
                };
                User exsitsUser = repository.Users.Where(m => m.Email == user.Email).Select(m => m).SingleOrDefault();

                if (exsitsUser != null)
                {
                    if (exsitsUser.Password == user.Password)
                    {
                        UserWindow userWindow = new UserWindow();
                        userWindow.SetUser(exsitsUser);
                        userWindow.Show();
                        
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


