using EE3206_WPF.Components;
using EE3206_WPF.Database;
using EE3206_WPF.Models;
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

namespace EE3206_WPF.Pages.AdminList
{
    
    public partial class AdminList : Page
    {
        private UsersDetail asd;
        private int id;
        DataBaseRepository repository = new DataBaseRepository();

        public AdminList()
        {
           
            InitializeComponent();
            loadData();  
            
        }

        private void loadData()
        {

                listdata.ItemsSource=repository.Admins.ToList();

        }

        private void BrowseBackButton_BackButton(object sender, RoutedEventArgs e)
        {
           
            
        }

        private void UsersDetail_DeleteButton(object sender, RoutedEventArgs e)
        {
            asd = (UsersDetail)sender;
            id = asd.IdValue;
            popwindow.TextVal = String.Format("{0} is deleted", asd.Username);
            popwindow.isOpen = true;
            //MessageBox.Show(id.ToString());
            deleteItem(id);


        }

        private void deleteItem(int id)
        {
            repository.Admins.Remove(repository.Admins.Find(id));
            repository.SaveChanges();
            loadData();
        }

        private void popwindow_CloseEnv(object sender, RoutedEventArgs e)
        {
            popwindow.isOpen = false;
        }
    }

    
}
