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

namespace EE3206_WPF.Components
{
    /// <summary>
    /// Interaction logic for UsersDetail.xaml
    /// </summary>
    public partial class UsersDetail : UserControl
    {


        public int IdValue
        {
            get { return (int)GetValue(IdValueProperty); }
            set { SetValue(IdValueProperty, value); }
        }

      
        public static readonly DependencyProperty IdValueProperty =
            DependencyProperty.Register("IdValue", typeof(int), typeof(UsersDetail), new PropertyMetadata(0));





        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Username.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UsernameProperty =
            DependencyProperty.Register("Username", typeof(string), typeof(UsersDetail), new PropertyMetadata("NA"));



        public string Email
        {
            get { return (string)GetValue(EmailProperty); }
            set { SetValue(EmailProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Email.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmailProperty =
            DependencyProperty.Register("Email", typeof(string), typeof(UsersDetail), new PropertyMetadata("NA"));




        public string TelephoneNum
        {
            get { return (string)GetValue(TelephoneNumProperty); }
            set { SetValue(TelephoneNumProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TelephoneNum.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TelephoneNumProperty =
            DependencyProperty.Register("TelephoneNum", typeof(string), typeof(UsersDetail), new PropertyMetadata("NA"));




        public UsersDetail()
        {
            InitializeComponent();
        }
    }
}
