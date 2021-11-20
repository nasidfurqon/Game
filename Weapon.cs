using System;

namespace Game
{
    class Weapon: HealthAndAttack
    {
        public string Senjata{get;set;}
        public string Senjata2{get;set;}
        public string Senjata3{get;set;}
        public string Senjata4{get;set;}
        public string Senjata5{get;set;}
        public Weapon(string senjata,string senjata2,string senjata3,string senjata4,string senjata5)
        {
            Senjata=senjata;
            Senjata2=senjata2;
            Senjata3=senjata3;
            Senjata4=senjata4;
            Senjata5=senjata5;
            Console.WriteLine($"Silahkan Pilih Senjatamu : \n1.{senjata} \n2.{senjata2}"
            +$" \n3.{senjata3} \n4.{senjata4} "
            +$"\n5.{senjata5} ");
            int pilihan=Convert.ToInt32(Console.ReadLine());
            if (pilihan==1)
            {   
                Console.WriteLine($"Kamu memilih {senjata},damage yang kamu berikan sebesar {Damage}");
            }
            if (pilihan==2)
            {
                Console.WriteLine($"Kamu memilih {senjata2},damage yang kamu berikan sebesar {Damage}");
            }
            if (pilihan==3)
            {
                Console.WriteLine($"Kamu memilih {senjata3},damage yang kamu berikan sebesar {Damage}");
                
            }
            if (pilihan==4)
            {
                Console.WriteLine($"Kamu memilih {senjata4},damage yang kamu berikan sebesar {Damage}");
                
            }
            if (pilihan==5)
            {
                Console.WriteLine($"Kamu memilih {senjata5},damage yang kamu berikan sebesar {Damage}");

            }
        }
    }
}
