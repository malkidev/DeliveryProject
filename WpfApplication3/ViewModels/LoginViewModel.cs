using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApplication3.Model;
using WpfApplication3.Views;

namespace WpfApplication3.View
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public ForgotCom myforgotcom { get; set; }
        public ReplaceCommand MyReplaceUCCommand { get; set; }
        public LoginV loginuc { get; set; }
        public LoginModel myloginmodel { get; set; }
        public string password
        {
            get { return myloginmodel.password; }
            set
            {
                myloginmodel.password = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("password"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel(Views.LoginV loginUC)
        {
            loginuc = loginUC;
            MyReplaceUCCommand = new ReplaceCommand();
            myloginmodel = new LoginModel();
            MyReplaceUCCommand.ReplaceUserControl += OKbutt;
            myforgotcom = new ForgotCom();
            myforgotcom.ReplaceUserControl += Forgotbutt;


        }
        public void OKbutt(string obj)
        {
            myloginmodel.password = loginuc.password.Text;
            myloginmodel.identifier = loginuc.identifier.Text;
            if (myloginmodel.CheckPassword())
            {
                ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Clear();
                ((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Add(new MenuV());
            }
            else
                MessageBox.Show("Wrong Password Or Identifier", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

        }
        public void Forgotbutt(string obj)
        {
                MessageBox.Show("Guess with your birth date!! Good Luck You have 3 essais ", "Forgot", MessageBoxButton.OK, MessageBoxImage.Information);

        }
        
    }
}
