using System.Windows;

namespace Nieze.WPF.Labs.Lab2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private MainWindowDataContext DC => (MainWindowDataContext)DataContext;

    public MainWindow()
    {
        InitializeComponent();
    }

    public void OnSubmitClicked(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(DC.UserName))
        {
            return;
        }

        DC.IsNameNeeded = false;

        //MessageBox.Show($"Hello {DC.UserName}!");
    }
}