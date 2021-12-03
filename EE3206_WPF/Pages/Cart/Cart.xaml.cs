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
            int a = 2;

            using (DataBaseRepository repository = new DataBaseRepository()) 
            {
                Product pro = repository.Products.Find(1);
                int b = 2;

                Order or = new Order();
                OrderItem newor = new OrderItem();
                newor.product = pro;
                newor.price = pro.price;
                or.user = user;
                or.orderItems.Add(newor);

                repository.Orders.Add(or);
                repository.SaveChanges();


            }
        }
    }
}
