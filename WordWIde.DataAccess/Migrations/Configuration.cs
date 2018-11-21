namespace WordWIde.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WordWide.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<WordWIde.DataAccess.WordWideDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WordWIde.DataAccess.WordWideDbContext context)
        {
            context.Words.AddOrUpdate(
                e => e.EnglishWord,
                new Word { EnglishWord = "one", TranslateWord = "jeden", Progress = 0.1 },
                new Word { EnglishWord = "two", TranslateWord = "dwa", Progress = 0.2 },
                new Word { EnglishWord = "three", TranslateWord = "trzy", Progress = 0.3 },
                new Word { EnglishWord = "four", TranslateWord = "cztery", Progress = 0.4 },
                new Word { EnglishWord = "five", TranslateWord = "pięć", Progress = 0.1 }
                );
        }
    }
}
