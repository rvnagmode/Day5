using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{

    public class Student
    {
        public event ErrorDelegate PassEvent;
        public event ErrorDelegate FailEvent;
        public int Marks(int marks)
        {
            if(marks>=40)
            {
                PassEvent();
            }
            
            else if(marks<40)
            {
                FailEvent();
            }
            return marks;
        }
    }
}
