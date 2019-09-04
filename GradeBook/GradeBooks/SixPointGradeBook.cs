using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class SixPointGradeBook : BaseGradeBook
    {
        public SixPointGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.SixPoint;
        }
    }
}
