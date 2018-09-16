using System;
using Xunit;

namespace Flyweight.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            char uppercasedA  = 'A';

            Character kalpurushA = new CharacterFactory().GetCharacter(uppercasedA);

            Assert.Equal("আ : 12 em", kalpurushA.Generate(12));
        }
    }
}
