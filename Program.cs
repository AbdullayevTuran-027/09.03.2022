using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ay = "gjgjgkj";
            if (ay == "Yanvar" || ay == "Dekabr" || ay == "Fevral")
            {
                Console.WriteLine("Qis Feslidi");
            }
            else if (ay == "Mart" || ay == "Aprel" || ay == "May")
            {
                Console.WriteLine("Yaz Feslidi");
            }
            else if (ay == "Iyun" || ay == "Iyul" || ay == "Avqust")
            {
                Console.WriteLine("Yay Feslidi");
            }
            else if (ay == "Sentyabr" || ay == "Oktyabr" || ay == "Noyabr")
            {
                Console.WriteLine("Payiz feslidi");
            }
            else
            {
                Console.WriteLine("Bele ay yoxu");
            }
        }
    }
}
