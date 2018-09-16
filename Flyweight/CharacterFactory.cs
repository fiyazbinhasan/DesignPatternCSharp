using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class CharacterFactory
    {
        private readonly Dictionary<char, Character> _characters = new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            Character character = null;

            if (_characters.ContainsKey(key))
            {
                character = _characters[key];
            }
            else
            {
                switch (key)
                {
                    case 'A': character = new KalpurushA(); break;
                    case 'B': character = new KalpurushB(); break;
                }
                _characters.Add(key, character);
            }
            return character;
        }
    }
}
