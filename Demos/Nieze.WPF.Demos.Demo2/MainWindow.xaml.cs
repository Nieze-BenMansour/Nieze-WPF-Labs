using System.Windows;
using System.Windows.Input;

namespace FormationWPF.Demo2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private UserViewModel DC => (UserViewModel)DataContext;

    public MainWindow()
    {
        InitializeComponent();
        DataContext = new UserViewModel { Age = 30, Name = "David", Skills = "C#, WPF, .NET, Blazor" };
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        var exempleWindow_INotify = new ExempleWindow_INotify();

        exempleWindow_INotify.Show();
    }

    private void LostKeyBoardFocusNameTextBox(object sender, KeyboardFocusChangedEventArgs e)
    {
        if (DC != null && DC.Name == "David")
        {
            return;
        }

        Task.Delay(3000).Wait();

        nameTb.Text = "David";
    }
}