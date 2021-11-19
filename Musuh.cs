using System;

namespace Game
{
    class Musuh
    {
        public string Enemy {get;set;}
        public Musuh(string enemy)
        {
            Enemy=enemy;
            Console.WriteLine($"Mereka : {enemy}");
        }
    }
}