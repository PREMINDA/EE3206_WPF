using EE3206_WPF.Database;
using EE3206_WPF.Models;
using EE3206_WPF.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace EE3206_WPF.Pages.UserRegister
{
    /// <summary>
    /// Interaction logic for UserRegister.xaml
    /// </summary>
    public partial class UserRegister : UserControl
    {
        private string _password;
        Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

        public string Password { get { return _password; } set { _password = value;} }

       

        public UserRegister()
        {
            InitializeComponent();
            Uri loglink = new Uri("/Pages/UserLogin/UserLogin.xaml", UriKind.Relative);
            _userLogLink.NavigateUri = loglink;

            Uri adminLoglink = new Uri("/Pages/AdminLogin/AdminLogin.xaml", UriKind.Relative);
            _adminLogLink.NavigateUri = adminLoglink;

        }

        private void RoundButton_Submitclick(object sender, RoutedEventArgs e)
        {
            using (DataBaseRepository repository = new DataBaseRepository())
            {
                

                User user = new User()
                {
                    Name = UserName.EnteredValue,
                    Email = Email.EnteredValue,
                    TelNum = TelephoneNum.EnteredValue,
                    Password = Passwordin.Password

                };

                if (String.IsNullOrEmpty(UserName.EnteredValue) || String.IsNullOrEmpty(Email.EnteredValue) || String.IsNullOrEmpty(TelephoneNum.EnteredValue) || String.IsNullOrEmpty(Passwordin.Password))
                {
                    popwindow.TextVal = "Every thing should be fill";
                    popwindow.isOpen = true;
                }
                else if (!regex.IsMatch(Email.EnteredValue))
                {
                    popwindow.TextVal = "Email is not valid";
                    popwindow.isOpen = true;
                }
                else if (Passwordin.Password != RePassword.Password)
                {
                    popwindow.TextVal = "Password Not Matched";
                    popwindow.isOpen = true;
                }
                else
                {
                    User exsitsUser = repository.Users.Where(m => m.Email == user.Email).Select(m => m).SingleOrDefault();
                    if (exsitsUser != null)
                    {
                        popwindow.TextVal = "Enterde Email Already Exists";
                        popwindow.isOpen = true;
                    }
                    else
                    {
                        repository.Users.Add(user);
                        repository.SaveChanges();

                        NavigationService nav = NavigationService.GetNavigationService(this);
                        nav.Navigate(new Uri("/Pages/UserLogin/UserLogin.xaml", UriKind.Relative));
                        
                    }

                }

            }

        }

        private void popwindow_CloseEnv(object sender, RoutedEventArgs e)
        {
            popwindow.isOpen = false;
        }

    }
}
