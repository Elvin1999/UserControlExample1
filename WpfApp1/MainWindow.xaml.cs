using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Key { get; set; } = "YyCLZ0tUWEVR5LhmOxU2~N5_DKq3BO09wuiDyyYk7cA~AnIe2DUX0rrV-lMgFs_kXLA5gEViyUs6v0AiM0La8hkXgQ2ydTUYo5mi8VO7koIu";
        public ApplicationIdCredentialsProvider Provider { get; set; }
        public MainWindow()
        {
            this.DataContext = this;
            Provider = new ApplicationIdCredentialsProvider(Key);
            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //lbl.Content = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
            //UserControl2 uc2 = new UserControl2();
            //uc2.Width = 350;
            //if (stckPanel.Children.Count!=0)
            //stckPanel.Children.RemoveAt(stckPanel.Children.Count - 1);
            //stckPanel.Children.Add(uc2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //UserControl1 uc1 = new UserControl1();
            //uc1.Width = 350;
            //if (stckPanel.Children.Count != 0)
            //    stckPanel.Children.RemoveAt(stckPanel.Children.Count - 1);
            //stckPanel.Children.Add(uc1);
        }
    }
}
