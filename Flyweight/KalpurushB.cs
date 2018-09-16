using System;
namespace Flyweight
{
    public class KalpurushB : Character
    {
        public KalpurushB()
        {
            // This may be a bulky process like getting the character vector from a font file.

            _symbol = 'ব';
        }

        public override string Generate(int size)
        {
            _size = size;

            return $"{_symbol} : {_size} em";
        }
    }
}
