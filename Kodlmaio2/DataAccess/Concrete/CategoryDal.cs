using Kodlmaio2.DataAccess.Abstract;
using Kodlmaio2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlmaio2.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {

        List<Category> categories;
        public CategoryDal()
        {
            categories = new List<Category>
            {
                new Category{Id=1,Name="Web"},
                new Category{Id=2,Name="Mobil"},
                new Category{Id=3,Name="Masaüstü"},
            };
        }


        public void Add(Category entity)
        {
            categories.Add(entity);
        }

        public void Delete(int id)
        {
            var deletedCategory = categories.First(c => c.Id == id);
            if (deletedCategory != null)
            {
                categories.Remove(deletedCategory);
            }
        }

        public Category Get(int id)
        {
           return categories.First(c => c.Id == id);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category entity)
        {
            var updatedCategory = categories.First(c => c.Id == entity.Id);
            updatedCategory.Name = entity.Name;
            updatedCategory.Id = entity.Id;
        }
    }
}
