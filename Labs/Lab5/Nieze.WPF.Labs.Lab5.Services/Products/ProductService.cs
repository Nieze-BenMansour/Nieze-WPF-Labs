namespace Nieze.WPF.Labs.Lab5.Services.Products;

public class ProductService : IProductService
{
    private const string _connectionString = "Data Source=/products.db";

    public Result<int> Add(Product product)
    {
        var contextOptions = new DbContextOptionsBuilder<ProductContext>()
            .UseSqlite(_connectionString)
            .Options;

        using var context = new ProductContext();

        context.Products.Add(product);
        return context.SaveChanges();
    }

    public Result Delete(int id)
    {
        var contextOptions = new DbContextOptionsBuilder<ProductContext>()
            .UseSqlite(_connectionString)
            .Options;

        using var context = new ProductContext();

        var product = context.Products.Find(id);

        if (product is null)
        {
            return Result.Fail("Product not found");
        }

        context.Products.Remove(product);
        return Result.Ok();
    }

    public Result<Product> Get(int id)
    {
        var contextOptions = new DbContextOptionsBuilder<ProductContext>()
            .UseSqlite(_connectionString)
            .Options;

        using var context = new ProductContext();

        var product = context.Products.Find(id);

        if(product is null)
        {
            return Result.Fail("Product not found");
        }

        return product;
    }

    public IEnumerable<Product> GetAll()
    {
        var contextOptions = new DbContextOptionsBuilder<ProductContext>()
            .UseSqlite(_connectionString)
            .Options;

        using var context = new ProductContext();

        var products = context.Products.ToList();

        return products;
    }

    public Result Update(Product product)
    {
        var contextOptions = new DbContextOptionsBuilder<ProductContext>()
            .UseSqlite(_connectionString)
            .Options;

        using var context = new ProductContext();

        var productToUpdate = context.Products.Find(product.Id);

        if (productToUpdate is null)
        {
            return Result.Fail("Product not found");
        }

        productToUpdate.Name = product.Name;
        productToUpdate.Description = product.Description;
        productToUpdate.SubCategoryName = product.SubCategoryName;

        context.Products.Update(productToUpdate);
        return Result.Ok();
    }
}
