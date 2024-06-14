using Nieze.WPF.Labs.Lab5.Services.Products;
using System.Windows;

namespace Nieze.WPF.Labs.Lab5.Desktop
{
    /// <summary>
    /// Interaction logic for AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        public int CurrentId { get; set; }

        public AddProductWindow(int currentId)
        {
            InitializeComponent();
            CurrentId = currentId;

            IProductService productService = new ProductService();
            var product = productService.Get(currentId);
            DataContext = product.Value;
        }
    }
}
