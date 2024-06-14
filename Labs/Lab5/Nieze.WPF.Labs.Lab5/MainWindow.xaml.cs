using Nieze.WPF.Labs.Lab5.Desktop.ViewModels;
using Nieze.WPF.Labs.Lab5.Domain;
using Nieze.WPF.Labs.Lab5.Services.Products;
using Nieze.WPF.Labs.Lab5.Services.SubCategories;
using System.Windows;
using System.Windows.Data;

namespace Nieze.WPF.Labs.Lab5;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly IProductService _productService = new ProductService();
    private readonly ISubCategoryService _subCategoryService = new SubCategoryService();

    private CollectionViewSource categoryViewSource;

    public MainWindow()
    {
        InitializeComponent();
        categoryViewSource =
                (CollectionViewSource)FindResource(nameof(categoryViewSource));
        DataContext = new ProductCommands();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {

        var product = new Product
        {
            Name = "Playstation1",
            Description = "Playstation1 is good!",
            SubCategoryName = "Consoles"
        };

        var subCategory = new SubCategory
        {
            Name = "Consoles",
            CategoryName = "Gaming"
        };

        var subCategory1 = new SubCategory
        {
            Name = "Toys",
            CategoryName = "Gaming"
        };

        _productService.Add(product);
        _subCategoryService.Add(subCategory);
        _subCategoryService.Add(subCategory1);

        var products = _productService.GetAll();

        var subCategories = _subCategoryService.GetAll();


        var productViewModels = products.ToViewModels();
        categoryViewSource.Source = productViewModels;
    }

}