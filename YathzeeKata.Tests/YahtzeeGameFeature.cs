using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using YahtzeeKata.Src;

namespace YathzeeKata.Tests
{
    [TestFixture]
    public class YahtzeeGameFeature
    {
        [TestCase]
        public void RunCategoryOne()
        {
            var printedLines = new List<string>();
            var console = new Mock<IConsole>();
            console.Setup(c => c.PrintLine(It.IsAny<string>()))
                .Callback<string>(result => printedLines.Add(result));
            var categories = new Categories(console.Object);

            var game = new YathzeeGame(categories);

            game.Run();

            Assert.That(printedLines[0], Is.EqualTo("Category: Ones"));
        }
    }
}