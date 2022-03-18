using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{

    public class User
    {
        public event ErrorDelegate AgeEvent;
        public int AcceptAge(int age)
        {
            if(age<18)
            {
                AgeEvent();
            }
            return age;
        }

    }
    
}
