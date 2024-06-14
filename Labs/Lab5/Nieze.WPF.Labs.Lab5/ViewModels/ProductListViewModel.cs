using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Nieze.WPF.Labs.Lab5.Domain;
using System.Windows;

namespace Nieze.WPF.Labs.Lab5.Desktop.ViewModels;

public record ProductListViewModel(int Id, string Name, string SubCategoryName);

public record ProductAddOrUpdateViewModel(int Id, string Name, string SubCategoryName, string Description);

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
    public void AddProductCommand(int id)
    {
        new AddProductWindow(id).Show();
    }
}