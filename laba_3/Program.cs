using System;

namespace laba_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Монстры: ");
            Monsters monster = new Monsters("Хищный", "плотоядный", "злой монстр", 190);
            Console.WriteLine(monster.Print());

            Monsters monster1 = new Monsters("Дружелюбный", "травоядный", "добрый монстр", 190);
            Console.WriteLine(monster1.Print());
            Console.ReadLine();

        }
    }
}