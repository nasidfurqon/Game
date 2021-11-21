using System;

namespace Game
{
    class Menu : Damage
    {
        public Menu()
        {
            while(true)
            {
                Console.WriteLine("Apa yang akan kamu lakukan?");
                Console.WriteLine("1.Analisa Situasi \n2.Serang monster");
                int pilihanMenu=Convert.ToInt32(Console.ReadLine());
                if (pilihanMenu==1)
                {
                    Console.WriteLine("Mereka : Monster Kalajengking,Semut Raksasa dan Ular Raksasa."
                    +"kamu memiliki 20 nyawa");
                }
                if (pilihanMenu==2)
                {
                    Attack attack=new Attack("Monster Kalajengking","Semut Raksasa","Ular Raksasa");
                }
            }
        }
    }
}