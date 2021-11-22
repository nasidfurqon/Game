using System;

namespace Game
{
    class AttackBos :Induk
    {
        public string BosName {get;set;}
        public AttackBos(string bosName)
        {
            BosName=bosName;
            int enemyHealth=40;
            int bosDamage=4;
            int jumlahRegen=3;
            Console.WriteLine($"peri :'hai pahlawan..kamu sudah menemui si bos yaitu {bosName},disini kamu memiliki beberapa'"
            +" keistimewaan,yaitu kamu bisa me regen darahmu sebanyak 3 kali dengan sekali regen +2 darah");
            Console.ReadKey();
            while(enemyHealth>0)
            {
                Random random=new Random();
                int presentaseMenghindar=random.Next(10);
                Console.WriteLine("apa yang akan kamu lakukan :");
                Console.WriteLine($"1.Cek status bos \n2.serang si Bos \n3.Regen darahmu");
                int pilih=Convert.ToInt32(Console.ReadLine());
                if (pilih==1)
                {
                    Console.WriteLine($"si {bosName} memiliki darah sebesar {enemyHealth} dan setiap serangan"
                    +$" memiliki damage sebesar {bosDamage} ,kelincahan : sangat lincah");
                }
                if(pilih==2)
                {
                    if (enemyHealth<=0)
                    {
                        Console.WriteLine($"si {bosName} sudah mati");
                        Console.WriteLine("Kamu menang!!");
                    }
                    else
                    {
                        Console.WriteLine($"Darah si {bosName} : {enemyHealth}");
                        Weapon weapon=new Weapon("Pedang","Light Saber","Kapak","Panah","Tombak"); 
                        if(presentaseMenghindar<=3)
                        {
                            Console.WriteLine($"kamu memberikan damage sebesar {UserDamage}");
                            enemyHealth-=UserDamage;
                            Console.WriteLine($"nyawa dari si {bosName} tinggal {enemyHealth}");
                        }
                        if(presentaseMenghindar>3)
                        {
                            userHealth-=bosDamage;
                            Console.Write($"awasss,Si {bosName} berhasil menghindar,dia malah menyerangmu,nyawamu "
                            +$"sekarang hanya tinggal {userHealth} \n");
                        }
                    }
                }
                if(pilih==3)
                {
                    if(jumlahRegen<=0)
                    {
                        Console.WriteLine("Kemampuan Regenmu sudah habis");
                    }
                    else
                    {
                        Console.WriteLine($"darahmu sekarang {userHealth}");
                        Console.WriteLine("Ketik regen untuk mengisi darahmu kembali");
                        string jawab=Console.ReadLine();
                        if(jawab=="regen")
                        {   
                            userHealth+=2;
                            if(userHealth<=40)
                            {
                                jumlahRegen-=1;
                                Console.WriteLine($"darahmu sekarang sudah menjadi {userHealth}");
                                Console.WriteLine($"Kemampuan regenmu tinggal {jumlahRegen} kali");
                            }
                            else
                            {
                                Console.WriteLine("Darah Maksimal");
                            }
                        }
                        else
                        {
                            Console.WriteLine("input tidak valid!!");
                        }
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
                        Story story=new Story();
                    }
                }
            }
        }
    }
}