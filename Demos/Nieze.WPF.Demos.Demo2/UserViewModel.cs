using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Annotations;

namespace FormationWPF.Demo2;

public class UserViewModel
{
    public int Age { get; set; }

    public string Name { get; set; }

    public string Skills { get; set; }
}


public class OtherUserViewModel : INotifyPropertyChanged
{
    public int Age { get; set; } = 30;

    public string Skills { get; set; } = "C#, WPF, .NET, Blazor";

    public event PropertyChangedEventHandler? PropertyChanged;

    private string _name = "David";

    public string Name
    {
        get { return _name; }
        set
        {

            Task.Delay(3000).Wait();

            _name = value;
            if (_name != "David")
            {
                _name = "David";
            }
            PropertyChanged?.Invoke(
                this, new PropertyChangedEventArgs(nameof(Name)));

        }
    }
}

public class ObservableUserViewModel : ObservableObject
{
    public int Age { get; set; } = 30;

    public string Skills { get; set; } = "C#, WPF, .NET, Blazor";


    private string _name = "David";

    public string Name
    {
        get { return _name; }
        set
        {
            Task.Delay(3000).Wait();

            if (_name != "David")
            {
                SetProperty(ref _name, "David");
            }
        }
    }
}
