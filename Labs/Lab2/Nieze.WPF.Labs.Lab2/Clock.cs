using FormationWPF.Lab2;
using System.ComponentModel;
using System.Windows.Threading;

namespace Nieze.WPF.Labs.Lab2
{
    public class Clock : ObservableObject
    {
        public string CurrentTime => DateTime.Now.ToLongTimeString();

        public event PropertyChangedEventHandler PropertyChanged;

        private DispatcherTimer _timer;

        public Clock()
        {
            // setup _timer to refresh CurrentTime
            _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            //_timer.Tick += (sender, o) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentTime)));
            _timer.Tick += (sender, o) => RaisePropertyChanged(nameof(CurrentTime));
            _timer.Start();
        }
    }
}
