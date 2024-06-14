using System.Windows;

namespace Nieze.WPF.Demos.Demo1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var produit = new ProduitViewModel(name: "Savon Liquide", code: "88999");

            if (produit.Name == "Savon Liquide")
            {
                NameTb.Text = "Savon";
            }
            else 
            {
                NameTb.Text = produit.Name; 
            }
            

        }
    }
}