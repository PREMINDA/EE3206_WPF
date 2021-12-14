using EE3206_WPF.Components;
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

namespace EE3206_WPF.Pages.UserOrders
{
    /// <summary>
    /// Interaction logic for UserOrders.xaml
    /// </summary>
    public partial class UserOrders : Page
    {
        public UserOrders()
        {
            InitializeComponent();
            using (DataBaseRepository repository = new DataBaseRepository())
            {
                
                var list = repository.Orders.Include("User").ToList();
                //var l = repository.Orders.Include("User").ToList();
                oredersData.ItemsSource = list;
            }
        }

        private void popwindow_CloseEnv(object sender, RoutedEventArgs e)
        {

        }

        private void newdata_SeeMoreList(object sender, RoutedEventArgs e)
        {
            OrderListItem singleorder = (OrderListItem)sender;
            
            
           MoreOrderInfo userWindow = new MoreOrderInfo();
           userWindow.SetUser(singleorder);
           userWindow.Show();

        }
    }
}
