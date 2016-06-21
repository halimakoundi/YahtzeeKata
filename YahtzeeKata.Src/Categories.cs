using System;

namespace YahtzeeKata.Src
{
    public class Categories
    {
        private IConsole _console;

        public Categories()
        {
        }

        public Categories(IConsole console)
        {
            this._console = console;
        }

        public virtual void RunNextCategory()
        {
            _console.PrintLine("Category: Ones");
        }
    }
}