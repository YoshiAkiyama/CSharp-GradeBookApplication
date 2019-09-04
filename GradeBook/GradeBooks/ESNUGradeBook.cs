using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class ESNUGradeBook : BaseGradeBook
    {
        public ESNUGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.ESNU;
        }
    }
}
