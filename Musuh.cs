using System;

namespace Game
{
    class Musuh : HealthAndAttack
    {
        public string Enemy {get;set;}
        public string Enemy2 {get;set;}
        public string Enemy3 {get;set;}

        public Musuh(string enemy,string enemy2,string enemy3)
        {
            Enemy=enemy;
            Enemy2=enemy2;
            Enemy3=enemy3;
            int Health =10;
            int Health2 =3;
            int Health3=15;   
            Console.WriteLine("Pilih Salah Satu");
            Console.WriteLine($"1.{enemy} ({Health}) \n2.{enemy2} ({Health2}) \n3.{enemy3} ({Health3}) \n4.Keluar");
            int pilih=Convert.ToInt32(Console.ReadLine());
            if (pilih==1)
            {
                Weapon weapon=new Weapon("Pedang","Shotgun","Pisau","Pistol","Tombak"); 
                Health-=Damage;
                Console.WriteLine($"Darah dari {enemy} tinggal {Health}");
                if (Health==0)
                {
                    Console.WriteLine($"The {enemy} is dead");
                }
            }
            if (pilih==2)
            {
                Weapon weapon=new Weapon("Pedang","Shotgun","Pisau","Pistol","Tombak");
                Health2-=Damage;                
                Console.WriteLine($"Darah dari {enemy2} tinggal {Health2}");
                if (Health2==0)
                {
                    Console.WriteLine($"The {enemy2} is dead");
                }
            }
            if (pilih==3)
            {
                Weapon weapon=new Weapon("Pedang","Shotgun","Pisau","Pistol","Tombak");
                Health3-=Damage;                
                Console.WriteLine($"Darah dari {enemy3} tinggal {Health3}");
                if (Health3==0)
                {
                    Console.WriteLine($"The {enemy3} is dead");
                }
            }
        }
    }
}