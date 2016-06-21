using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using YahtzeeKata.Src;

namespace YathzeeKata.Tests
{
    [TestFixture]
    class YahtzeeGameShould
    {
        [Test]
        public void RunFirstCategory()
        {
            var categories = new Mock<Categories>();
            var game = new YathzeeGame(categories.Object);

            game.Run();

            categories.Verify(c => c.RunNextCategory());
        }
    }
}
