using System.Windows;

namespace Nieze.WPF.Demos.Demo3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var windowExemple = new WindowExemple();
            windowExemple.Show();
        }
    }
}