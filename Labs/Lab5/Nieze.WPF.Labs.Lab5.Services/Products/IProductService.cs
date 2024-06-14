namespace Nieze.WPF.Labs.Lab5.Services.Products;

public interface IProductService
{
    Result<int> Add(Product product);

    Result Delete(int id);

    Result<Product> Get(int id);

    IEnumerable<Product> GetAll();

    Result Update(Product product);    
}