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

namespace EE3206_WPF.Pages.Cart
{
    /// <summary>
    /// Interaction logic for Cart.xaml
    /// </summary>
    public partial class Cart : Page
    {
        UserWindow currentWindow;
        ICollection<OrderItem> orderItems = new List<OrderItem>();
        public Cart()
        {
            InitializeComponent();
            currentWindow = (UserWindow)Application.Current.Windows[0];
            orderItems = currentWindow.GetOrderItems();
            loadData();
        }

        private void checkout(object sender, RoutedEventArgs e)
        {
            using (DataBaseRepository repository = new DataBaseRepository())
            {
                if (orderItems.Count() >= 1)
                {
                    User user = (User)currentWindow.GetUser();
                    Order or = new Order();
                    User us = new User()
                    {
                        ID = user.ID
                    };

                    or.UserID = us.ID;
                    or.OrderItem = orderItems;

                   //repository.Orders.Add(or);
                    //repository.SaveChanges();
                }
                else 
                {
                    popwindow.TextVal = "You List Is Empty";
                    popwindow.isOpen = true;
                }
                //var l = repository.Orders.Include("OrderItem").ToList();
            }
        }

        private void clearCartList(object sender, RoutedEventArgs e)
        {
            currentWindow.clearCartList();
            currentWindow.clearOrderList();
            clear();
        }

        private void loadData()
        {
            ICollection<Product> products = currentWindow.GetProducts();
            productdata.ItemsSource = products.ToList();
        }
        private void clear()
        {
            productdata.ItemsSource = new List<Product>();
            orderItems = new List<OrderItem>();
        }

        private void popwindow_CloseEnv(object sender, RoutedEventArgs e)
        {
            popwindow.isOpen = false;
        }
    }
}
