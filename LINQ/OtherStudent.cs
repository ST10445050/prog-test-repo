using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public partial class Student
    {
        // Create a grade method that returns a students grade (Eg. A, B, C)
        public string Grade()
        {
            switch (Marks)
            {
                case int i when i >= 95:
                    return "A";
                case int i when i >= 75:
                    return "B";
                case int i when i >= 50:
                    return "C";
                    default:
                    return "D";

            }
        }

    }
}
