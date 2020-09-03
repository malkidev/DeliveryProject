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
using WpfApplication3.View;
using WpfApplication3.ViewModel2;

namespace WpfApplication3
{
    /// <summary>
    /// Logique d'interaction pour UserControl3.xaml
    /// </summary>
    public partial class MenuV : UserControl
    {
        MenuViewModel mymenuvm { get; set; }
        public MenuV()
        {
           
            InitializeComponent();

            //ContentControl page = (ContentControl)FindResource(Name = "page5");
            mymenuvm = new MenuViewModel(this,page);
            this.DataContext = mymenuvm;

        }
        
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;

        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

    }
}
