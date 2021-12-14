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
using System.Windows.Shapes;

namespace EE3206_WPF.Windows
{
    /// <summary>
    /// Interaction logic for MoreOrderInfo.xaml
    /// </summary>
    public partial class MoreOrderInfo : Window
    {
        User user;
        public MoreOrderInfo()
        {
            InitializeComponent();
        }



        internal void SetUser(OrderListItem data)
        {
            
            int ID = data.OrderID;
            lodaOrderItem(ID);
        }

        private void lodaOrderItem(int id)
        {
            using (DataBaseRepository repository = new DataBaseRepository())
            {

                //var list = repository.Orders.Include("User").ToList();
                //var l = repository.Orders.Include("User").ToList();
                Order asd = repository.Orders.Include("OrderItem").Include("OrderItem.Product").SingleOrDefault(x => x.ID == id);
                user = asd.User;
                Name.Text = user.Name;
                Email.Text = user.Email;
                Tel.Text = user.TelNum;
                SinglorederList.ItemsSource = asd.OrderItem.ToList();
            }
        }
    }
}
