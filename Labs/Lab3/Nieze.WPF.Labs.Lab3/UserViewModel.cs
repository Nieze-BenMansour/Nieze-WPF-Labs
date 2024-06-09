namespace Nieze.WPF.Labs.Lab3;

using System.ComponentModel;


public class UserViewModel : INotifyPropertyChanged
{
    private string _name = "Alex";
    private int _age = 40;

    public string Name
    {
        get { return _name; }
        set
        {
            if (_name != value)
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
    }

    public int Age
    {
        get { return _age; }
        set
        {
            if (_age != value)
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

