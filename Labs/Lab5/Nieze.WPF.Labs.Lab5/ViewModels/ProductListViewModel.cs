using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Nieze.WPF.Labs.Lab5.Domain;

namespace Nieze.WPF.Labs.Lab5.Desktop.ViewModels;

public record ProductListViewModel(int Id, string Name, string SubCategoryName);

[ObservableObject]
public partial class ProductAddOrUpdateViewModel 
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string SubCategoryName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    [RelayCommand]
    public void AddOrUpdateProduct()
    {
        IProductService productService = new ProductService();

        if (Id == 0)
        {
            var productToAdd = new Product()
            {
                Name = Name,
                SubCategoryName = SubCategoryName,
                Description = Description,
            };
            productService.Add(productToAdd);

            MessageBox.Show("Product added successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            return;
        }

        var product = new Product()
        {
            Name = Name,
            SubCategoryName = SubCategoryName,
            Description = Description,
            Id = Id
        };

        productService.Update(product);

        MessageBox.Show("Product updated successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}

public static class ProductExtensions
{
    public static ProductListViewModel ToViewModel(this Product product)
    {
        return new ProductListViewModel(Id: product.Id, SubCategoryName: product.SubCategoryName, Name: product.Name);
    }

    public static IEnumerable<ProductListViewModel> ToViewModels(this IEnumerable<Product> products)
    {
        foreach (var product in products) yield return ToViewModel(product);
    }
}

public partial class ProductCommands : ObservableObject
{
    [RelayCommand]
    public void AddProduct()
    {
        new AddProductWindow(0).Show();
    }

    [RelayCommand]
    public void UpdateProduct(int id)
    {
        new AddProductWindow(id).Show();
    }

    [RelayCommand]
    public void DeleteProduct(int id)
    {
        MessageBoxResult result = MessageBox.Show(
                "Do you want to delete this product?",
                "Delete Product",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
            );

        if (result == MessageBoxResult.Yes)
        {
            IProductService productService = new ProductService();
            productService.Delete(id);
            MessageBox.Show("Product deleted successfully.");
        }
        else
        {
            MessageBox.Show("Product deleted canceled.");
        }
    }
}