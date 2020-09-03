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

namespace WpfApplication3.ViewModel2
{
    /// <summary>
    /// Logique d'interaction pour FinaleMenudel.xaml
    /// </summary>
    public partial class FinaleMenudel : UserControl
    {
        public FinaleMenudel()
        {
            InitializeComponent();
            DeliveryMenUserControl ado = new DeliveryMenUserControl();
          //  this.page5.Content = ado;
    
        }
    }
}
