using Pizza.UI.ViewModels;
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

namespace Pizza.UI.Views
{
    /// <summary>
    /// Interaction logic for RestaurantForm.xaml
    /// </summary>
    public partial class RestaurantForm : UserControl
    {
        public RestaurantForm()
        {
            InitializeComponent();

        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            _ = MainViewModel.Instance.AddRestaurantAsync();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _ = MainViewModel.Instance.GetRestaurantsAsync();
        }
    }
}
