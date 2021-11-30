using EE3206_WPF.Database;
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
    /// <summary>
    /// Interaction logic for UserService.xaml
    /// </summary>
    public partial class UserService : Page
    {
        DataBaseRepository repository = new DataBaseRepository();
        public UserService()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            servicedata.ItemsSource = repository.Services.ToList();
        }
    }
}
