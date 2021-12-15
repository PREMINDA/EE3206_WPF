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
    /// Interaction logic for MoreServiceWindow.xaml
    /// </summary>
    public partial class MoreServiceWindow : Window
    {
        User user;
        public MoreServiceWindow()
        {
            InitializeComponent();
        }



        internal void setuser(AppoinmentListItem singleservice)
        {
            int ID = singleservice.AppoinmentID;
            Appoinment userdata = (Appoinment)singleservice.DataContext;
            user = userdata.User;
            lodaOrderItem(ID);
        }

        private void lodaOrderItem(int id)
        {
            using (DataBaseRepository repository = new DataBaseRepository())
            {

                //var list = repository.Orders.Include("User").ToList();
                //var l = repository.Orders.Include("User").ToList();
                Appoinment asd = repository.Appoinments.Include("AppoiServices").Include("AppoiServices.Service").SingleOrDefault(x => x.ID == id);
                Name.Text = user.Name;
                Email.Text = user.Email;
                Tel.Text = user.TelNum;
                SinglServiceList.ItemsSource = asd.AppoiServices.ToList();
            }
        }
    }
}
