using EE3206_WPF.Components;
using EE3206_WPF.Database;
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

namespace EE3206_WPF.Pages.AppoinPa
{
    /// <summary>
    /// Interaction logic for AppoinPa.xaml
    /// </summary>
    public partial class AppoinPa : Page
    {
        public AppoinPa()
        {
            InitializeComponent();

            using (DataBaseRepository repository = new DataBaseRepository())
            {

                var list = repository.Appoinments.Include("User").ToList();
                //var l = repository.Orders.Include("User").ToList();
                AppoinmentData.ItemsSource = list;
            }
        }

        private void popwindow_CloseEnv(object sender, RoutedEventArgs e)
        {

        }

        private void AppoinmentListItem_SeeMoreServiceList(object sender, RoutedEventArgs e)
        {

            AppoinmentListItem singleservice = (AppoinmentListItem)e.Source;


            MoreServiceWindow userwindow = new MoreServiceWindow();
            userwindow.setuser(singleservice);
            userwindow.Show();

        }
    }
}
