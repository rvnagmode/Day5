using Day5;
namespace Day5
{
    public delegate void ErrorDelegate();
    public class Testing
    {
        /*static void ErrorMsg()
        {
            Console.WriteLine("not valid age for voting");
        }
        static void PassMsg()
        {
            Console.WriteLine("you are pass");
        }
        static void FailMsg()
        {
            Console.WriteLine("you are fail");
        }
        */
        static void Event1Msg()
        {
            Console.WriteLine("low balance in acc");
        }
        static void Event2Msg()
        {
            Console.WriteLine("balance is zero or less than 100");
        }
        static void Event3Msg()
        {
            Console.WriteLine("insuffient balance");
        }
        static void Main(string[] args)
        {
            /*User u = new User();
            u.AgeEvent += new ErrorDelegate(ErrorMsg);
            int age = u.AcceptAge(5);
            Console.WriteLine("your age is : " + age);
            if(age > 18)
                Console.WriteLine("you are eligible for voting");
            */

            /*Student s = new Student();
            s.PassEvent += new ErrorDelegate(PassMsg);
            s.FailEvent += new ErrorDelegate(FailMsg);
            int marks = s.Marks(41);
            Console.WriteLine(marks);
            */

            Bank b = new Bank();
            b.WithdrawnEvent1 += new ErrorDelegate(Event1Msg);
            b.WithdrawnEvent2 += new ErrorDelegate(Event2Msg);
            b.WithdrawnEvent3 += new ErrorDelegate(Event3Msg);
            //b.Deposit(13000);
            double money = b.Withdraw(11000);
            Console.WriteLine(money);

        }
    }

}
