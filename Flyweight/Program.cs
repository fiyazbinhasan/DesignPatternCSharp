using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            string document = "ABBAA";
            var characters = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            var fontSize = new Random();

            foreach (char c in characters)
            {
                Character character = factory.GetCharacter(c);
                Console.WriteLine(character.Generate(fontSize.Next(10, 15)));
            }

            Console.ReadKey();
        }
    }
}
