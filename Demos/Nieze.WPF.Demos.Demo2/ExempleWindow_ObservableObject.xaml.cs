using System.Windows;

namespace FormationWPF.Demo2
{
    /// <summary>
    /// Interaction logic for ExempleWindow_ObservableObject.xaml
    /// </summary>
    public partial class ExempleWindow_ObservableObject : Window
    {
        public ExempleWindow_ObservableObject()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var exempleWindow_ObservableObject = new ExempleWindow_DataTemplate();
            exempleWindow_ObservableObject.Show();
        }
    }
}
