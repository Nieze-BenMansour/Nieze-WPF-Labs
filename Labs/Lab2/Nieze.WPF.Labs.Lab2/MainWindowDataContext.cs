using FormationWPF.Lab2;
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
                if (Set(ref _isNameNeeded, value))
                {
                    RaisePropertyChanged(nameof(GreetingVisibility));
                }
            }
        }

        public string? UserName { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

