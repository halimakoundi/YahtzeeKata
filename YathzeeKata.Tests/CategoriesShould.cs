using Moq;
using NUnit.Framework;
using YahtzeeKata.Src;

namespace YathzeeKata.Tests
{
    [TestFixture]
    class CategoriesShould
    {
        [Test]
        public void PrintNextCategoryName()
        {
            var printedLine = string.Empty;
            var console = new Mock<IConsole>();
            console.Setup(c => c.PrintLine(It.IsAny<string>()))
                .Callback<string>(r => printedLine = r);
            var categories = new Categories(console.Object);
            categories.RunNextCategory();

            Assert.That(printedLine, Is.EqualTo("Category: Ones"));
        }
    }
}
