using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Nieze.WPF.Demos.Demo3
{
    /// <summary>
    /// Interaction logic for WindowExemple.xaml
    /// </summary>
    public partial class WindowExemple : Window
    {
        public WindowExemple()
        {
            InitializeComponent();
        }

        public void SetTrue(object sender, RoutedEventArgs e) 
        {
            Grid.SetIsSharedSizeScope(dp1, true);
            txt1.Text = "IsSharedSizeScope Property is set to " + Grid.GetIsSharedSizeScope(dp1).ToString();
        }

        public void SetFalse(object sender, RoutedEventArgs e)
        {

        }
    }
}
