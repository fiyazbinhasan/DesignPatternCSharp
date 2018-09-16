using System;
namespace Flyweight
{
    public abstract class Character
    {
        protected char _symbol;
        protected int _size;

        public abstract string Generate(int size);
    }
}
