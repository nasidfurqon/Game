using System;

namespace Game
{
    class Attack : Damage
    {
        public string Enemy {get;set;}
        public string Enemy2 {get;set;}
        public string Enemy3 {get;set;}

        public Attack(string enemy,string enemy2,string enemy3)
        {
            Enemy=enemy;
            Enemy2=enemy2;
            Enemy3=enemy3;
            int enemyHealth =20;
            int enemyHealth2 =6;
            int enemyHealth3=10; 
            int userHealth=20;
            while(enemyHealth>0 || enemyHealth2>0 || enemyHealth3>0)
            {
                Random random=new Random();
                int presentaseMenghindar=random.Next(10);
                Console.WriteLine("Pilih Salah Satu");
                Console.WriteLine($"1.{enemy}, nyawa:({enemyHealth}), kelincahan : sedang \n2.{enemy2},"
                +$" nyawa:({enemyHealth2}), kelincahan : tinggi \n3.{enemy3}, nyawa:({enemyHealth3}),"
                +" kelincahan : sedang \n4.Keluar");
                int pilih=Convert.ToInt32(Console.ReadLine());
                if (pilih==1)
                {
                    Weapon weapon=new Weapon("Pedang","Shotgun","Pisau","Pistol","Tombak"); 
                    if(presentaseMenghindar<=7)
                    {
                        enemyHealth-=UserDamage;
                        Console.WriteLine($"nyawa dari {enemy} tinggal {enemyHealth}");
                    }
                    if(presentaseMenghindar>7)
                    {
                        userHealth-=EnemyDamage;
                        Console.Write($"awasss,Si {enemy} berhasil menghindar,dia malah menyerangmu,nyawamu "
                        +$"sekarang hanya tinggal {userHealth} \n");
                    }
                    if (enemyHealth==0)
                    {
                        Console.WriteLine($"si {enemy} sudah mati");
                    }
                }
                if (pilih==2)
                {
                    Weapon weapon=new Weapon("Pedang","Shotgun","Pisau","Pistol","Tombak");
                    if(presentaseMenghindar<=5)
                    {
                        enemyHealth2-=UserDamage;
                        Console.WriteLine($"nyawa dari {enemy2} tinggal {enemyHealth2}");
                    }
                    if(presentaseMenghindar>5)
                    {
                        userHealth-=EnemyDamage;
                        Console.Write($"Si {enemy2} berhasil menghindar,dia malah menyerangmu,nyawamu "
                        +$"sekarang hanya tinggal {userHealth} \n");
                    }
                    if (enemyHealth2==0)
                    {
                        Console.WriteLine($"si {enemy2} sudah mati");
                    }
                }
                if (pilih==3)
                {
                    Weapon weapon=new Weapon("Pedang","Shotgun","Pisau","Pistol","Tombak");
                    if(presentaseMenghindar<=7)
                    {
                        enemyHealth3-=UserDamage;
                        Console.WriteLine($"nyawa dari {enemy3} tinggal {enemyHealth3}");
                    }
                    if(presentaseMenghindar>7)
                    {
                        userHealth-=EnemyDamage;
                        Console.Write($"Si {enemy3} berhasil menghindar,dia malah menyerangmu,nyawamu "
                        +$"sekarang hanya tinggal {userHealth} \n");                    
                    }
                    if (enemyHealth3==0)
                    {
                        Console.WriteLine($"si {enemy3} sudah mati");
                    }
                }
                if (pilih==4)
                {
                    Menu menu= new Menu();
                }
                if (enemyHealth==0 && enemyHealth2==0 && enemyHealth3==0)
                {
                    Console.WriteLine("Kamu Menang!!");
                    Console.WriteLine(" ");
                    Console.WriteLine("1.Main Lagi");
                    int pilihan=Convert.ToInt32(Console.ReadLine());
                    if(pilihan==1)
                    {
                        Menu menu=new Menu();
                    }
                }
                if(userHealth==0)
                {
                    Console.WriteLine("Kamu kalah!!");
                    Console.WriteLine(" ");
                    Console.WriteLine("1.Main Lagi");
                    int pilihan=Convert.ToInt32(Console.ReadLine());
                    if(pilihan==1)
                    {
                        Menu menu=new Menu();
                    }
                }
            }  
        }
    }
}