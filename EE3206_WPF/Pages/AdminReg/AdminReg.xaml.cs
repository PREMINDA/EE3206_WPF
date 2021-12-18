using EE3206_WPF.Database;
using EE3206_WPF.Models;
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

namespace EE3206_WPF.Pages.AdminReg
{
    /// <summary>
    /// Interaction logic for AdminReg.xaml
    /// </summary>
    public partial class AdminReg : Page
    {
        Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

        public AdminReg()
        {
            InitializeComponent();
        }

        private void RoundButton_Submitclick(object sender, RoutedEventArgs e)
        {
            using (DataBaseRepository repository = new DataBaseRepository())
            {
               

                Admin admin = new Admin()
                {
                    Name = UserName.EnteredValue,
                    Email = Email.EnteredValue,
                    TelNum = TelephoneNum.EnteredValue,
                    Password = Password.Password

                };

                if (String.IsNullOrEmpty(UserName.EnteredValue) || String.IsNullOrEmpty(Email.EnteredValue) || String.IsNullOrEmpty(TelephoneNum.EnteredValue) || String.IsNullOrEmpty(Password.Password))
                {
                    popwindow.TextVal = "Every thing should be fill";
                    popwindow.isOpen = true;
                }
                else if (!regex.IsMatch(Email.EnteredValue)) 
                {
                    popwindow.TextVal = "Email is not valid";
                    popwindow.isOpen = true;
                }
                else if (Password.Password != RePassword.Password)
                {
                    popwindow.TextVal = "Password Not Matched";
                    popwindow.isOpen = true;
                }
                else
                {
                    Admin exsitsAdmin=repository.Admins.Where(m => m.Email == admin.Email).Select(m=>m).SingleOrDefault();
                    if (exsitsAdmin != null)
                    {
                        popwindow.TextVal = "Enterde Email Already Exists";
                        popwindow.isOpen = true;
                    }
                    else
                    {
                        repository.Admins.Add(admin);
                        repository.SaveChanges();

                        if (this.NavigationService.CanGoBack)
                        {

                            this.NavigationService.GoBack();

                        }
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
