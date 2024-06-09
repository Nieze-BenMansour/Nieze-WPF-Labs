using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Nieze.WPF.Labs.Lab3
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

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Create a DoubleAnimation to animate the opacity of the canvas elements
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1.0; // Fully opaque
            animation.To = 0.0; // Fully transparent
            animation.Duration = TimeSpan.FromSeconds(1); // Animation duration

            // Set the animation to target the Opacity property of each canvas
            firstCanvas.BeginAnimation(Canvas.OpacityProperty, animation);
            circleCanvas.BeginAnimation(Canvas.OpacityProperty, animation);
            secondCanvas.BeginAnimation(Canvas.OpacityProperty, animation);
        }
    }
}