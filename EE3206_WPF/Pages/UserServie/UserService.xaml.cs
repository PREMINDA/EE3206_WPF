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

namespace EE3206_WPF.Pages.UserServie
{
    class ListItem
    {
        public string name { get; set; }
        public int price { get; set; }
    }

    public partial class UserService : Page
    {
        ICollection<ListItem> selectedList = new List<ListItem>();
        ICollection<AppoiServices> AppoiServices = new List<AppoiServices>();
        UserWindow currentWindow;

        DataBaseRepository repository = new DataBaseRepository();
        public UserService()
        {
            InitializeComponent();
            currentWindow = (UserWindow)Application.Current.Windows[0];
            load();
        }

        private void load()
        {
            servicedata.ItemsSource = repository.Services.ToList();
            selectdata.ItemsSource = selectedList;
        }

        private void UserServiceList_AddServiceList(object sender, RoutedEventArgs e)
        {
           
            UserServiceList asd = (UserServiceList)e.Source;
            Service newservice = (Service)asd.DataContext;
            ListItem item = new ListItem()
            {
                name = asd.ServiceName,
                price = asd.ServicePrice
            };
            addDataTOConfirmList(newservice.ID);
            addAndRefreshList(item);
        }

        private void addDataTOConfirmList(int asd)
        {
            Service serviceA = new Service()
            {
                ID=asd
            };

            AppoiServices appoiService = new AppoiServices()
            {
                Service = serviceA
            };

            AppoiServices.Add(appoiService);

        }

        private void addAndRefreshList(ListItem i)
        {

            selectedList.Add(i);
            selectdata.ItemsSource = selectedList;
            selectdata.Items.Refresh();
        }

        private void clearList() 
        {
            AppoiServices = new List<AppoiServices>();
            selectedList = new List<ListItem>();
            selectdata.ItemsSource = selectedList;
            selectdata.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clearList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var inMyString = datevalue.SelectedDate.Value.ToShortDateString();
            using (DataBaseRepository repository = new DataBaseRepository())
            {
                if (AppoiServices.Count() >= 1)
                {
                    User user = (User)currentWindow.GetUser();
                    Appoinment ap = new Appoinment();
                    User us = new User()
                    {
                        ID = user.ID
                    };

                    ap.UserID = us.ID;
                    ap.AppoiServices = AppoiServices;

                    repository.Appoinments.Add(ap);
                    repository.SaveChanges();
                    clearList();

                    popwindow.TextVal = "You successfully Make an Appoinment";
                    popwindow.isOpen = true;
                }
                else
                {
                    popwindow.TextVal = "You List Is Empty";
                    popwindow.isOpen = true;
                }
                //var l = repository.Orders.Include("OrderItem").ToList();
            }
        }

        private void popwindow_CloseEnv(object sender, RoutedEventArgs e)
        {
            popwindow.isOpen = false;
        }
    }

}

