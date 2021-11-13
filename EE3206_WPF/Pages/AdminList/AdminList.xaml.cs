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
       
       
        public AdminList()
        {
           
            InitializeComponent();
            loadData();  
            
        }

        private void loadData()
        {
            using (DataBaseRepository repository = new DataBaseRepository())
            {

                listdata.ItemsSource=repository.Admins.ToList();
                

            }
        }

        private void BrowseBackButton_BackButton(object sender, RoutedEventArgs e)
        {
            //while (NavigationService.CanGoBack)
            //{
            //    NavigationService.RemoveBackEntry();
            //}
           

            
        }
    }

    
}
