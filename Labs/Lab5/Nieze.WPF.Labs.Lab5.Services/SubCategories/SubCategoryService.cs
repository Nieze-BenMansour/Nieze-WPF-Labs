
namespace Nieze.WPF.Labs.Lab5.Services.SubCategories;

public class SubCategoryService : ISubCategoryService
{
    private const string _connectionString = "Data Source=/SubCategorys.db";

    public Result<int> Add(SubCategory SubCategory)
    {
        var contextOptions = new DbContextOptionsBuilder<ProductContext>()
            .UseSqlite(_connectionString)
            .Options;

        using var context = new ProductContext();

        context.SubCategorys.Add(SubCategory);
        return context.SaveChanges();
    }

    public Result Delete(int id)
    {
        var contextOptions = new DbContextOptionsBuilder<ProductContext>()
            .UseSqlite(_connectionString)
            .Options;

        using var context = new ProductContext();

        var SubCategory = context.SubCategorys.Find(id);

        if (SubCategory is null)
        {
            return Result.Fail("SubCategory not found");
        }

        context.SubCategorys.Remove(SubCategory);
        return Result.Ok();
    }

    public Result<SubCategory> Get(int id)
    {
        var contextOptions = new DbContextOptionsBuilder<ProductContext>()
            .UseSqlite(_connectionString)
            .Options;

        using var context = new ProductContext();

        var SubCategory = context.SubCategorys.Find(id);

        if (SubCategory is null)
        {
            return Result.Fail("SubCategory not found");
        }

        return SubCategory;
    }

    public IEnumerable<SubCategory> GetAll()
    {
        var contextOptions = new DbContextOptionsBuilder<ProductContext>()
            .UseSqlite(_connectionString)
            .Options;

        using var context = new ProductContext();

        var SubCategorys = context.SubCategorys.ToList();

        return SubCategorys;
    }

    public Result Update(SubCategory subCategory)
    {
        var contextOptions = new DbContextOptionsBuilder<ProductContext>()
            .UseSqlite(_connectionString)
            .Options;

        using var context = new ProductContext();

        var subCategoryToUpdate = context.SubCategorys.Find(subCategory.Id);

        if (subCategoryToUpdate is null)
        {
            return Result.Fail("SubCategory not found");
        }

        subCategoryToUpdate.Name = subCategory.Name;
        subCategoryToUpdate.CategoryName = subCategory.CategoryName;

        context.SubCategorys.Update(subCategoryToUpdate);
        return Result.Ok();
    }
}
