using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class OneToFourGradeBook : BaseGradeBook
    {
        public OneToFourGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.OneToFour
        }
    }
}
