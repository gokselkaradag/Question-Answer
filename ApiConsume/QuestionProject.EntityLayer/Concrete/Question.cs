using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionProject.EntityLayer.Concrete
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string Name { get; set; }
        public int CorrectOption { get; set; }
        public string OptionOne { get; set; }
        public string OptionTwo { get; set; }
        public string OptionThree { get; set; }
        public string OptionFour { get; set; }
        public Category? Category { get; set; }
        public int? CategoryID { get; set; }
    }
}
