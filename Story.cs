using System;

namespace Game
{
    class Story
    {
        public Story()
        {
            Console.WriteLine("Memulai Game....");
            Console.Write("siapa namamu : ");
            string name=Console.ReadLine();
            Console.WriteLine($"peri :'{name},bangun....bangun....'");
            Console.ReadKey();
            Console.WriteLine($"{name} : ada apa ini,dan saya dimana?'");
            Console.ReadKey();
            Console.WriteLine("peri :'kamu sedang terjebak di universe lain,dan kamu terpilih menjadi pahlawan'");
            Console.ReadKey();
            Console.WriteLine($"{name} :'apa? ,pahlawan?'");
            Console.ReadKey();
            Console.WriteLine("peri :'iya,diluar sana ada 3 monster dari universe lain seperti kamu.."
            +" 3 monster itu berbahaya dan 3 monster itu mempunyai Bos yang kekuatannya jauh lebih berbahaya dari "
            +"3 monster itu '");
            Console.ReadKey();
            Console.WriteLine($"{name} :'lalu bagaimana saya bisa kembali ke tempat asalku?'");
            Console.ReadKey();
            Console.WriteLine("peri :'kalahkan 3 monster itu terlebih dahulu agar bisa menemui si Bos!!'"
            +"lalu kalahkan si bos agar kamu bisa kembali ke tempat asalmu");
            Console.ReadKey();
            Console.WriteLine($"peri :'monster sudah mendekat!!,semoga beruntung {name}'");
            Menu menu=new Menu();
        }
    }
}