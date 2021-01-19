using System;

namespace Modul2_1_aktivitetsdiagram
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int age;
            int money = 0;

            Console.WriteLine("Enter age:");
            string strAge = Console.ReadLine();
            age = Convert.ToInt32(strAge);
            money = 15000;

            do
            {
                Console.WriteLine(money);
                Console.WriteLine(age);

                if (money > 20000 || age < 60)
                {

                    Console.WriteLine("You are saving a little.");
                    money = money + 500;
                }
                else
                {
                    Console.WriteLine("You are saving a lot.");
                    money = money + 1000;
                }

                age++;

            } while (money < 20000 && age < 65);

            Console.WriteLine("You retired by the age of " + age + ".");
            Console.WriteLine("You saved " + money + " dollars.");

        }
    }
}
