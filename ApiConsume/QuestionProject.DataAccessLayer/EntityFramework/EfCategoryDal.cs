using QuestionProject.DataAccessLayer.Abstract;
using QuestionProject.DataAccessLayer.Concrete;
using QuestionProject.DataAccessLayer.Repositories;
using QuestionProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionProject.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(DataContext context) : base(context)
        {
        }
    }
}
