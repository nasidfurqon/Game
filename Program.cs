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
            while(true)
            {
                Console.WriteLine("Apa yang akan kamu lakukan?");
                Console.WriteLine("1.Analisa Situasi \n2.Serang monster \n3.lihat status monster");
                int pilihanMenu=Convert.ToInt32(Console.ReadLine());
                if (pilihanMenu==1)
                {
                    Console.WriteLine("Mereka : Monster Kalajengking,Semut Raksasa dan Ular Raksasa");
                }
                if (pilihanMenu==2)
                {
                    Console.WriteLine("Pilih Salah Satu");
                    Console.WriteLine("1.Monster Kalajengking(7,0) \n2.Semut Raksasa(3,0) \n3.Ular Raksasa(10,0)");   
                }
                if(pilihanMenu==3)
                {

                }
            }
        }
    }
}