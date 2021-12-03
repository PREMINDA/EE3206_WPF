using EE3206_WPF.Components;
using EE3206_WPF.Database;
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

namespace EE3206_WPF.Pages.UserList
{
    /// <summary>
    /// Interaction logic for UserList.xaml
    /// </summary>
    public partial class UserList : Page
    {
        private UsersDetail usersDetail;
        private int id;
        DataBaseRepository repository = new DataBaseRepository();

        public UserList()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {

            listdata.ItemsSource = repository.Users.ToList();

        }

        private void BrowseBackButton_BackButton(object sender, RoutedEventArgs e)
        {


        }

        private void UsersDetail_DeleteButton(object sender, RoutedEventArgs e)
        {
            usersDetail = (UsersDetail)sender;
            id = usersDetail.IdValue;
            popwindow.TextVal = String.Format("{0} is deleted", usersDetail.Username);
            popwindow.isOpen = true;
            //MessageBox.Show(id.ToString());
            deleteItem(id);

        }

        private void deleteItem(int id)
        {
            repository.Users.Remove(repository.Users.Find(id));
            repository.SaveChanges();
            loadData();
        }

        private void popwindow_CloseEnv(object sender, RoutedEventArgs e)
        {
            popwindow.isOpen = false;
        }
    }
}
