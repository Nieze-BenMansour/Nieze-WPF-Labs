using System.Windows;

namespace FormationWPF.Demo2;

/// <summary>
/// Interaction logic for ExempleWindow_INotify.xaml
/// </summary>
public partial class ExempleWindow_INotify : Window
{
    public ExempleWindow_INotify()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        var exempleWindow_ObservableObject = new ExempleWindow_ObservableObject();
        exempleWindow_ObservableObject.Show();
    }
}
