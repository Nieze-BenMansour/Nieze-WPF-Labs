using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Windows;

namespace Nieze.WPF.Labs.Lab2
{
    public class MainWindowDataContext : ObservableObject
    {
        public MainWindowDataContext()
        {

        }

        public Visibility GreetingVisibility => IsNameNeeded ? Visibility.Collapsed : Visibility.Visible;

        private bool _isNameNeeded = true;

        public bool IsNameNeeded
        {
            get { return _isNameNeeded; }
            set
            {
                if (SetProperty(ref _isNameNeeded, value))
                {
                    OnPropertyChanged(nameof(GreetingVisibility));
                }
            }
        }

        public string? UserName { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

