using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
      class Student
    {

        public static int _Age { get; set; }

        public int Age { get; set; }
        public Student()
        {
            _Age++;
            Age = _Age;
        }


    }
}
