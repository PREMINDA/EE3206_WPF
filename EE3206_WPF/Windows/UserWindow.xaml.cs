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
using System.Windows.Shapes;

namespace EE3206_WPF.Windows
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        User user;
        ICollection<OrderItem> OrderItems = new List<OrderItem>();
        ICollection<Product> products = new List<Product>();

        public UserWindow()
        {
            InitializeComponent();
         
           // _userName.Text = user.Name;

        }

        public void SetUser(object newuser)
        {
            user = (User)newuser;
            _userName.Text = user.Name;
        }

        public object GetUser() 
        {
            return user;
        }

        public void SetOrderItems(OrderItem product)
        {
            OrderItems.Add(product);
        }

        public ICollection<OrderItem> GetOrderItems()
        {
            return OrderItems;
        }

        public void SetProduct(Product product)
        {
            products.Add(product);
        }

        public ICollection<Product> GetProducts()
        {
            return products;
        }



    }
}
