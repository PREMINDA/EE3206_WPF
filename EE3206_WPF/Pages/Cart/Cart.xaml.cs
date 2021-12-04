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
        public Cart()
        {
            InitializeComponent();
            var w = (UserWindow)Application.Current.Windows[0];
            User user = (User)w.GetUser();
            ICollection<OrderItem> orderItems = (ICollection<OrderItem>)w.GetOrderItems();

            using (DataBaseRepository repository = new DataBaseRepository()) 
            {

                //Order or = new Order();
                //User us = new User()
                //{
                //    ID = user.ID
                //};

                //or.UserID = us.ID;
                //or.OrderItem = orderItems;

                //repository.Orders.Add(or);
                //repository.SaveChanges();
                var l = repository.Orders.Include("OrderItem").ToList();
            }
        }
    }
}
