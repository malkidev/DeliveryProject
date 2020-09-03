using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApplication3.Model;
using WpfApplication3.ViewModel2;

namespace WpfApplication3.View
{
    class MenuViewModel : INotifyPropertyChanged
    {
        public ReplaceCommand DelCommand { get; set; }
        public ReplaceCommand DistCommand { get; set; }
        public ReplaceCommand ClientCommand { get; set; }
        public ReplaceCommand StatCommand { get; set; }

        public MenuV loginuc { get; set; }
        public MenuModel myloginmodel { get; set; }
 
        public event PropertyChangedEventHandler PropertyChanged;

        public System.Windows.Controls.ContentControl page;
        public MenuViewModel(MenuV loginUC, System.Windows.Controls.ContentControl page1)
        {
            loginuc = loginUC;
            DelCommand = new ReplaceCommand();
            DistCommand = new ReplaceCommand();
            ClientCommand = new ReplaceCommand();
            StatCommand = new ReplaceCommand();
            myloginmodel = new MenuModel();
            DelCommand.ReplaceUserControl += Delbutt;
            DistCommand.ReplaceUserControl += Distbutt;
            ClientCommand.ReplaceUserControl += Clientbutt;
            StatCommand.ReplaceUserControl += Statbutt;
            page = page1;
        }

        private void Distbutt(string obj)
        {

            this.page.Content = new UserControl1();
        }

        private void Statbutt(string obj)
        {
            this.page.Content = new UserControl1();
        }

        private void Clientbutt(string obj)
        {
            page.Content = new UserControl1();
        }

        private void Delbutt(string obj)
        {
            page.Content = new DeliveryMenUserControl();
        }

      
}

    }
