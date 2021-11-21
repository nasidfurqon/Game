using System;
namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Memulai Game....");
            Console.Write("siapa namamu : ");
            string name=Console.ReadLine();
            Console.WriteLine($"hai {name} Kamu sedang terjebak di gua");
            Console.WriteLine($"{name} : 'suara siapa itu?'");
            Console.WriteLine("itu adalah suara monster dari luar gua yang sedang kelaparan");
            Menu menu=new Menu();
        }
    }
}