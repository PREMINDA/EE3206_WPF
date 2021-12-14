using EE3206_WPF.Components;
using EE3206_WPF.Database;
using EE3206_WPF.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
    enum MaType
    {
        product,service
    }

    public partial class Managment : Page
    {
        

        DataBaseRepository repository = new DataBaseRepository();
        String ImageLink;

        public Managment()
        {
            InitializeComponent();
            loadData();
            
        }

        private void loadData()
        {

            productdata.ItemsSource = repository.Products.ToList();
            servicedata.ItemsSource = repository.Services.ToList();
           

        }


        private void Product_DeleteButton(object sender, RoutedEventArgs e)
        {
            deletePros(sender, MaType.product);

        }

        private void Service_DeleteButton(object sender, RoutedEventArgs e)
        {
            deletePros(sender, MaType.service);
        }

        //Item Deleting process
        private void deletePros(object sender, MaType matype)
        {
            ServiceDetail serviseDetail = (ServiceDetail)sender;
            int id = serviseDetail.ID;
            popwindow.TextVal = String.Format("{0} is deleted", serviseDetail.SubTitle);
            popwindow.isOpen = true;
            //MessageBox.Show(id.ToString());
            deleteItem(id, matype);
        }

        //Deleting Specific Item
        private void deleteItem(int id,MaType type)
        {
            
       
            if (type == MaType.product)
            {
                ImageLink = repository.Products.Find(id).Link;
                repository.Products.Remove(repository.Products.Find(id));

            }
            else if (type == MaType.service) 
            {
                ImageLink = repository.Services.Find(id).Link;
                repository.Services.Remove(repository.Services.Find(id));
                
            }
            
            repository.SaveChanges();
            loadData();
        }

        private void popwindow_CloseEnv(object sender, RoutedEventArgs e)
        {
            popwindow.isOpen = false;
        }

        //private void dleteImage(String filePath) 
        //{
        //    File.Delete(filePath);
        //}
        
    }
}
