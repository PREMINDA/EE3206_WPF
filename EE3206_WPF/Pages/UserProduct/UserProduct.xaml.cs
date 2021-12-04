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

namespace EE3206_WPF.Pages.UserProduct
{
    

    public partial class UserProduct : Page
    {
        DataBaseRepository repository = new DataBaseRepository();
        

        public UserProduct()
        {
            InitializeComponent();
            loadData();
            
        }

        private void loadData()
        {
            productdata.ItemsSource = repository.Products.ToList();
           
        }

        private void UserProductList_AddCart(object sender, RoutedEventArgs e)
        {
            var selectItem = (UserProductList)sender;
            var w = (UserWindow)Application.Current.Windows[0];
            Product productInfor =(Product)selectItem.DataContext;
            ICollection<OrderItem> OrderItems = w.GetOrderItems();
            
            OrderItem newOrderItem = new OrderItem();
            newOrderItem.ProductID = productInfor.ID;
            SetOrderItems(newOrderItem);
           
            

        }

        private void SetOrderItems(OrderItem oi) 
        {
            var w = (UserWindow)Application.Current.Windows[0];
            w.SetOrderItems(oi);
            _Count.Text=w.GetOrderItems().Count().ToString();
        }
    }
}
