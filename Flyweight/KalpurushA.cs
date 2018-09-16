using System;
namespace Flyweight
{
    public class KalpurushA : Character
    {
        public KalpurushA()
        {
            // This may be a bulky process like getting the character vector from a font file.

            _symbol = 'আ';
        }

        public override string Generate(int size)
        {
            _size = size;

            return $"{_symbol} : {_size} em";
        }
    }
}
