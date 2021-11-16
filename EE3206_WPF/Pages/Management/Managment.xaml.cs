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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EE3206_WPF.Pages.Management
{
    enum matype
    {
        product,service
    }

    public partial class Managment : Page
    {
        ServiceDetail serviseDetail;

        DataBaseRepository repository = new DataBaseRepository();

        public Managment()
        {
            InitializeComponent();
            loadData();
        }

        private void Product_DeleteButton(object sender, RoutedEventArgs e)
        {
            serviseDetail = (ServiceDetail)sender;
            int id = serviseDetail.ID;
            popwindow.TextVal = String.Format("{0} is deleted", serviseDetail.SubTitle);
            popwindow.isOpen = true;
            //MessageBox.Show(id.ToString());
            deleteItem(id, matype.product);

        }

        private void Service_DeleteButton(object sender, RoutedEventArgs e)
        {
            serviseDetail = (ServiceDetail)sender;
            int id = serviseDetail.ID;
            popwindow.TextVal = String.Format("{0} is deleted", serviseDetail.SubTitle);
            popwindow.isOpen = true;
            //MessageBox.Show(id.ToString());
            deleteItem(id, matype.service);
        }

        private void loadData()
        {

            productdata.ItemsSource = repository.Products.ToList();
            servicedata.ItemsSource = repository.Services.ToList();

        }

        private void deleteItem(int id,matype type)
        {
            if (type == matype.product)
            {
                repository.Products.Remove(repository.Products.Find(id));
            }
            else if (type == matype.service) 
            {
                repository.Services.Remove(repository.Services.Find(id));
            } 
            repository.SaveChanges();
            loadData();
        }

        private void popwindow_CloseEnv(object sender, RoutedEventArgs e)
        {
            popwindow.isOpen = false;
        }
    }
}
