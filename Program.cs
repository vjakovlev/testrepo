using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Viktor = new Employee("Viktor");
            Console.WriteLine(Viktor.GetName());

            Console.WriteLine("----");

            Manager Milosh = new Manager("Milosh", 200);

            Console.WriteLine(Milosh.GetName());
            Console.WriteLine(Milosh.GetPaychekc());

            Console.WriteLine("----");


            Employee Martin = new Manager("Martin", 500);

            Console.WriteLine(Martin.GetName());

            //ova nema da mozes
            Console.WriteLine(Martin.Paycheck);
            Console.WriteLine(Martin.GetPaychekc());

            //ova ke mozes, se vika kastiranje (vo slucajov downcast), ama uste ne sme go ucele
            Console.WriteLine(((Manager)Martin).Paycheck);


            Console.ReadLine();


        }
    }
}
