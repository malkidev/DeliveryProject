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
using BE;
using DAL;

namespace WpfApplication3
{
    /// <summary>
    /// Logique d'interaction pour UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        DALimp dal = new DALimp();
        DeliveryMen del = new DeliveryMen();
        public UserControl2()
        {
            InitializeComponent();
            this.IDc.ItemsSource = dal.GetAllDeliveryMen().Select(m => m.ID);
            this.DataContext = del;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dal.removeDeliveryMen(del);
        }

        private void IDc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DeliveryMen ado = new DeliveryMen();
           ado= dal.GetDEL(Int32.Parse(IDc.SelectedItem.ToString()));

            DataContext = ado;
        }
    }
}
