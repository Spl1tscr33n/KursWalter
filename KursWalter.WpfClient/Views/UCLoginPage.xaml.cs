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

namespace KursWalter.WpfClient.UserControls
{
    /// <summary>
    /// Interaktionslogik für UCLogin.xaml
    /// </summary>
    public partial class UCLoginPage : UserControl
    {
        public UCLoginPage()
        {
            InitializeComponent();
            btMinLogin.Content = "5";
        }

        private void btMinLogin_Click(object sender, RoutedEventArgs e)
        {
            if (this.btMinLogin.Content.ToString() == "5")
            {
                this.btMinLogin.Content = "6";
                UCLogin.Height = btMinLogin.ActualHeight;
            }
            else
            {
                this.btMinLogin.Content = "5";
                UCLogin.Height = 160;
            }

        }

        private void lbPwDontNow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
        }
    }
}
