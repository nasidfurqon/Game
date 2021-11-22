using System;

namespace Game
{
    class Attack : Induk
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
            Console.WriteLine($"peri :disini kamu akan melawan 3 monster itu dan kamu mempunyai senjata,"
            +"hadapi dengan sungguh sunguh agar kamu bisa menemui si bos");
            Console.ReadKey();
            while(enemyHealth>0 || enemyHealth2>0 || enemyHealth3>0)
            {   
                Random random=new Random();
                int presentaseMenghindar=random.Next(10);
                Console.WriteLine("Pilih Salah Satu monster yang akan kamu serang :");
                Console.WriteLine($"1.{enemy}, nyawa:({enemyHealth}), kelincahan : sedang \n2.{enemy2},"
                +$" nyawa:({enemyHealth2}), kelincahan : tinggi \n3.{enemy3}, nyawa:({enemyHealth3}),"
                +" kelincahan : sedang \n4.Keluar");
                int pilih=Convert.ToInt32(Console.ReadLine());
                if (pilih==1)
                {
                    if (enemyHealth<=0)
                    {
                        Console.WriteLine($"si {enemy} sudah mati");
                    }
                    else
                    {
                        Weapon weapon=new Weapon("Pedang","Light Saber","Kapak","Panah","Tombak"); 
                        if(presentaseMenghindar<=7)
                        {
                            Console.WriteLine($"kamu memberikan damage sebesar {UserDamage}");
                            enemyHealth-=UserDamage;
                            Console.WriteLine($"nyawa dari {enemy} tinggal {enemyHealth}");
                        }
                        if(presentaseMenghindar>7)
                        {
                            userHealth-=EnemyDamage;
                            Console.Write($"awasss,Si {enemy} berhasil menghindar,dia malah menyerangmu,nyawamu "
                            +$"sekarang hanya tinggal {userHealth} \n");
                        }
                    }
                }
                if (pilih==2)
                {
                    if (enemyHealth2<=0)
                    {
                        Console.WriteLine($"si {enemy2} sudah mati");
                    }
                    else
                    {
                        Weapon weapon=new Weapon("Pedang","Light Saber","Kapak","Panah","Tombak");
                        if(presentaseMenghindar<=5)
                        {
                            Console.WriteLine($"kamu memberikan damage sebesar {UserDamage}");
                            enemyHealth2-=UserDamage;
                            Console.WriteLine($"nyawa dari {enemy2} tinggal {enemyHealth2}");
                        }
                        if(presentaseMenghindar>5)
                        {
                            userHealth-=EnemyDamage;
                            Console.Write($"Si {enemy2} berhasil menghindar,dia malah menyerangmu,nyawamu "
                            +$"sekarang hanya tinggal {userHealth} \n");
                        }
                    }
                }
                if (pilih==3)
                {
                    if (enemyHealth3<=0)
                    {
                        Console.WriteLine($"si {enemy3} sudah mati");
                    }
                    else
                    {
                        Weapon weapon=new Weapon("Pedang","Light Saber","Kapak","Panah","Tombak");
                        if(presentaseMenghindar<=7)
                        {
                            Console.WriteLine($"kamu memberikan damage sebesar {UserDamage}");
                            enemyHealth3-=UserDamage;
                            Console.WriteLine($"nyawa dari {enemy3} tinggal {enemyHealth3}");
                        }
                        if(presentaseMenghindar>7)
                        {
                            userHealth-=EnemyDamage;
                            Console.Write($"Si {enemy3} berhasil menghindar,dia malah menyerangmu,nyawamu "
                            +$"sekarang hanya tinggal {userHealth} \n");                    
                        }
                    }
                }
                if (pilih==4)
                {
                    Menu menu= new Menu();
                }
                if (enemyHealth==0 && enemyHealth2==0 && enemyHealth3==0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"peri :'selamat!!,kamu berhasil mengalahkan 3 monster itu.'"
                    +$"sekarang si bos monster ada didepanmu,darah kamu tersisa {userHealth},"
                    +"tapi sebagai bentuk terima kasih darahmu kembai pulih menjadi 40");
                    Console.ReadKey();
                    AttackBos attackBos=new AttackBos("Naga Raksasa");
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