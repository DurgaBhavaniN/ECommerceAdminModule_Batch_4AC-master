using AdminCategoryService.Entities;
using AdminCategoryService.Manager;
using AdminCategoryService.Models;
using AdminCategoryService.Repository;
using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace TestAdminServices
{
    class TestAdminManager
    {
        AdminManager _manager;
        [SetUp]
        public void setup()
        {
            _manager = new AdminManager(new AdminRepositoty(new EmartDBContext()));

        }
        [TearDown]
        public void Teardown()
        {
            _manager = null;
        }

        //Adding Category
        [Test]
        [Description("AddCategory")]
        public async Task AddCategory()
        {
            try
            {
                var cId = 565;
                var cName = "book";
                var CDetail = "all books";
                var cat = new CategoryModel { Cid = cId, Cname = cName, Cdetails = CDetail };
                var mock = new Mock<IManager>();
                mock.Setup(x => x.AddCategory(cat)).ReturnsAsync(true);
                var result = await _manager.AddCategory(cat);
                Assert.AreEqual(true,result);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.InnerException.Message);
            }
        }


    


    //Adding SubCategory
    [Test]
    [Description("Add SubCategory")]
    public async Task AddSubCategory()
    {
        try
        {
            var subId = 122;
            var sName = "hdfa";
            var sDetail = "jbcahv";
            var cId = 565;
            var gst = 7;
            var subcat = new SubCategoryModel { Subid = subId, Subname = sName, Sdetails = sDetail, Cid = cId, Gst = gst };
            var mock = new Mock<IManager>();
                mock.Setup(x => x.AddSubcategory(subcat)).ReturnsAsync(true);
                var result = await _manager.AddSubcategory(subcat);
            Assert.IsNotNull(result, "TestPassed");
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.InnerException.Message);
        }
    }

    //Getting Category by CategoryId
    [Test]
    [Description("Testing GetbyId for category")]
    [TestCase(565)]
    public void GetByCategory_Sucess(int cid)
    {
        try
        {
            var mock = new Mock<IManager>();
            var result = mock.Setup(x => x.getCategoryid(cid));
            Assert.IsNotNull(result, "TestPassed");
        }
        catch (Exception ex)
        {
            Assert.IsNotNull(ex.InnerException.Message);
        }
    }

    //Getting Category by CategoryId
    [Test]
    [Description("Testing GetbyId for category")]
    [TestCase(576)]
    public void GetByCategory_Failure(int cid)
    {
        try
        {
            var mock = new Mock<IManager>();
            var result = mock.Setup(x => x.getCategoryid(cid));
            Assert.IsNull(result, "TestPassed");
        }
        catch (Exception ex)
        {
            Assert.IsNotNull(ex.InnerException.Message);
        }
    }

    //Success TestCase
    [Test]
    [Description("Testing get by id for  Subcategory")]
    [TestCase(122)]
    public void Getbysubcategory_success(int subid)
    {
        try
        {
            var mock = new Mock<IManager>();
            var result = mock.Setup(x => x.getsubcategorybyid(subid));
            Assert.IsNotNull(result, "TestPassed");
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.InnerException.Message);
        }

    }
    //Failure TestCase
    [Test]
    [Description("Testing get by id for  Subcategory")]
    [TestCase(999)]
    [TestCase(1000)]
    public void Getbysubcategory_Failure(int subid)
    {
        try
        {
            var mock = new Mock<IManager>();
            var result = mock.Setup(x => x.getsubcategorybyid(subid));
            Assert.IsNull(result, "TestPassed");
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.InnerException.Message);
        }

    }

    //Testing Delete Category
    [Test]
    [Description("Testing delete by id for  category")]
    [TestCase(330)]
    [TestCase(340)]
    public void DeleteCategory(int cid)
    {
        try
        {
            var mock = new Mock<IManager>();
            var result = mock.Setup(x => x.DeleteCategory(cid));

            Assert.IsNotNull(result);
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.InnerException.Message);
        }
    }
    //Testing Delete subCategory
    [Test]
    [Description("Testing delete by id for  subcategory")]
    [TestCase(701)]
    [TestCase(702)]
    public void DeleteSubcategory(int subid)
    {
        try
        {
            var mock = new Mock<IManager>();
            var result = mock.Setup(x => x.DeleteSubCategory(subid));
            Assert.IsNotNull(result);
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.InnerException.Message);
        }
    }



    //Fetching List of Categories
    [Test]
    [Description("GetCategoryList")]
    public void GetCategoryList()
    {
        try
        {
            var mock = new Mock<IManager>();
            var result = mock.Setup(x => x.GetAllCategories());
            Assert.IsNotNull(result);
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.InnerException.Message);
        }
    }




    //Fetching All Users
    [Test]
    [Description("GetAllUsers")]
    public void GetUsersList()
    {
        try
        {
            var mock = new Mock<IManager>();
            var result = mock.Setup(x => x.GetAllUsers());
            Assert.IsNotNull(result);
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.InnerException.Message);
        }

    }






    //Fetching the list of all sellers
    [Test]
    [Description("GetAllSellers")]
    public void GetSellersList()
    {
        try
        {
            var mock = new Mock<IManager>();
            var result = mock.Setup(x => x.GetAllSellers());
            Assert.IsNotNull(result);
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.InnerException.Message);
        }
    }






    //Fetching the list of subcategories
    [Test]
    [Description("GetSubCategorylist")]
    public void GetSubcategoryList()
    {
        try
        {
            var mock = new Mock<IManager>();
            var result = mock.Setup(x => x.GetAllSubcategories());
            Assert.IsNotNull(result);
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.InnerException.Message);
        }
    }









    //Mock Testing of Updatesubcategory
    [Test]
    [Description("UpdateSubcategory")]
    public async Task UpdateSubCategory()
    {
        try
        {
            SubCategoryModel sub = new SubCategoryModel() { Subid = 122, Subname = "pen", Cid = 1, Gst = 4, Sdetails = "def" };
            var mock = new Mock<IManager>();
            mock.Setup(x => x.updatesubcategory(sub)).ReturnsAsync(true);
            var result = await _manager.updatesubcategory(sub);
            Assert.AreEqual(true, result);

        }
        catch (Exception ex)
        {
            Assert.Fail(ex.InnerException.Message);
        }
    }

    //Mock Testing of Updatecategory
    [Test]
    [Description("UpdateCategory")]
    public async Task UpdateCategory()
    {
        try
        {
            CategoryModel cat = new CategoryModel() { Cid = 565, Cname = "fashion", Cdetails = "menfashion" };
            var mock = new Mock<IManager>();
            mock.Setup(x => x.updatecategory(cat)).ReturnsAsync(true);
            var result = await _manager.updatecategory(cat);
            Assert.AreEqual(true, result);

        }
        catch (Exception ex)
        {
            Assert.Fail(ex.InnerException.Message);
        }
    }


}
}

