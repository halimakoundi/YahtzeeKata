namespace YahtzeeKata.Src
{
    public class YathzeeGame
    {
        private Categories _categories;

        public YathzeeGame(Categories categories)
        {
            _categories = categories;
        }

        public void Run()
        {
            _categories.RunNextCategory();
        }
    }
}
