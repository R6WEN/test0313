using System;

namespace test0313
{
    class Program
    {
        static void Main(string[] args)
        {



            int hp = 100;
            while (true)
            {
                if (hp < 0)
                {
                    Console.WriteLine("蝙蝠湯");
                    break;

                }
                string input = Console.ReadLine();
                int attack = int.Parse(input);
                hp = hp - attack;
                Console.WriteLine("hp=" + hp);
              



            }

            Console.ReadKey();



        }
    }
}
