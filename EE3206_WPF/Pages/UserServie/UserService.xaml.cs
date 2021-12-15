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
            timebutton.Content = "AM";
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


            AppoiServices appoiService = new AppoiServices()
            {
                ServiceID = asd
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
            
            using (DataBaseRepository repository = new DataBaseRepository())
            {
                if (AppoiServices.Count() >= 1)
                {

                    if (checkISEmpty())
                    {
                        popwindow.TextVal = "Fill data first";
                        popwindow.isOpen = true;
                    }
                    else
                    {
                        repository.Appoinments.Add(storeModal());
                        repository.SaveChanges();
                        clearList();
                        EmptySetData();

                        popwindow.TextVal = "You successfully Make an Appoinment";
                        popwindow.isOpen = true;
                    }    
                }
                else
                {
                    popwindow.TextVal = "You List Is Empty";
                    popwindow.isOpen = true;
                }
            }
        }

        private void EmptySetData()
        {
            HH.Text = null;
            MM.Text = null;
            datevalue.SelectedDate = null;
        }

        private void popwindow_CloseEnv(object sender, RoutedEventArgs e)
        {
            popwindow.isOpen = false;
        }

        private void timebutton_Click(object sender, RoutedEventArgs e)
        {
            switch (timebutton.Content)
            {
                case "AM":
                    timebutton.Content = "PM";
                    break;
                default:
                    timebutton.Content = "AM";
                    break;
            }
        }

        private bool checkISEmpty()
        {

            if (datevalue.SelectedDate == null)
            {
                return true;
            }
            return String.IsNullOrEmpty(HH.Text) || String.IsNullOrEmpty(MM.Text);
        }

        private Appoinment storeModal()
        {
            User user = (User)currentWindow.GetUser();
            Appoinment ap = new Appoinment();
            User us = new User()
            {
                ID = user.ID
            };

            string time = String.Format("{0}:{1} {2}", HH.Text, MM.Text, timebutton.Content);


            ap.UserID = us.ID;
            ap.AppoiServices = AppoiServices;
            ap.Date = datevalue.SelectedDate.Value.ToShortDateString();
            ap.Time = time;

            return ap;
        }
    }

}

