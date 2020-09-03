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
using DAL;

namespace WpfApplication3.ViewModel2
{
    /// <summary>
    /// Logique d'interaction pour DeliveryMenUserControl.xaml
    /// </summary>
    public partial class DeliveryMenUserControl : UserControl
    {
        public DeliveryMenUserControl()
        {
            InitializeComponent();
            DALimp test = new DALimp();
            listView.ItemsSource = test.GetAllDeliveryMen();
        }
    }
}
