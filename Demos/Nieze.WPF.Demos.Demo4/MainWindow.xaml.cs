using System.Collections;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nieze.WPF.Demos.Demo4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadDataButton_Click(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = GetDataSet();
        }

        public ArrayList GetDataSet()
        {
            ArrayList items = new ArrayList();
            for (var count = 0; count < 10000; ++count)
            {
                items.Add(string.Format("Item {0}", count));
            }
            return items;
        }
    }
}