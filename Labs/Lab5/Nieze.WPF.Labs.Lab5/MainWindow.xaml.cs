namespace Nieze.WPF.Labs.Lab5;

public partial class MainWindow : Window
{
    private readonly IProductService _productService = new ProductService();
    private readonly ISubCategoryService _subCategoryService = new SubCategoryService();

    private CollectionViewSource categoryViewSource;

    public MainWindow()
    {
        InitializeComponent();
        categoryViewSource = (CollectionViewSource)FindResource(nameof(categoryViewSource));
        DataContext = new ProductCommands();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        var products = _productService.GetAll();

        var productViewModels = products.ToViewModels();
        categoryViewSource.Source = productViewModels;
    }
}