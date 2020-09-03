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

namespace WpfApplication3.ViewModel2
{
    /// <summary>
    /// Logique d'interaction pour FinaleMenuDist.xaml
    /// </summary>
    public partial class FinaleMenuDist : UserControl
    {
        public FinaleMenuDist()
        {
            InitializeComponent();
            DistUserControl ado = new DistUserControl();
            this.page5.Content = ado;
        }
    }
}
