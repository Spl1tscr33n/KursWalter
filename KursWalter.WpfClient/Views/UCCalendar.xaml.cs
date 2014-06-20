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
    /// Interaktionslogik für UCCalendar.xaml
    /// </summary>
    public partial class UCCalendar : UserControl
    {
        public UCCalendar()
        {
            InitializeComponent();
            btMinCalendar.Content = "5";
        }

        private void btMinCalendar_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(btMinCalendar.Content) == "5")
            {
                this.btMinCalendar.Content = "6";
                this.Height = btMinCalendar.ActualHeight;
            }
            else
            {
                this.btMinCalendar.Content = "5";
                this.Height = 160;
            }
        }
    }
}
