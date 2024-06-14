namespace Nieze.WPF.Labs.Lab5.Services.SubCategories;

public interface ISubCategoryService
{
    Result<int> Add(SubCategory subCategory);

    Result Delete(int id);

    Result<SubCategory> Get(int id);

    IEnumerable<SubCategory> GetAll();

    Result Update(SubCategory SubCategory);
}