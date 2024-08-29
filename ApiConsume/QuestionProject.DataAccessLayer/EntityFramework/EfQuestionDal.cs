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
    public class EfQuestionDal : GenericRepository<Question>, IQuestionDal
    {
        public EfQuestionDal(DataContext context) : base(context)
        {
        }
    }
}
