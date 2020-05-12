using AdminCategoryService.Entities;
using AdminCategoryService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdminCategoryService.Repository
{
    public interface IAdminRepository
    {

        List<CategoryModel> GetAllCategories();
        List<SubCategoryModel> GetAllSubcategories();
        Task<bool> AddCategory(CategoryModel obj);
        Task<bool> AddSubcategory(SubCategoryModel obj);
        CategoryModel getCategoryid(int Cid);
        SubCategoryModel getsubcategorybyid(int Subid);
        void DeleteCategory(int Cid);
        void DeleteSubCategory(int Subid);
        Task<bool> updatecategory(CategoryModel obj);
        Task<bool> updatesubcategory(SubCategoryModel obj);
        List<SellerModel> GetAllSellers();
        List<UserModel> GetAllUsers();
    }
}