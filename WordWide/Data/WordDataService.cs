using System;
using System.Collections.Generic;
using System.Linq;
using WordWide.Model;
using WordWIde.DataAccess;

namespace WordWide.UI.Data
{
    public class WordDataService : IWordDataService
    {
        private Func<WordWideDbContext> contextCreator;

        //TODO func contextcreator
        public WordDataService(Func<WordWideDbContext> contextCreator)
        {
            this.contextCreator = contextCreator;
            
        }
        public IEnumerable<Word> GetAll() {
            using (var ctx = contextCreator())
            {
                //TODO no tracking
                return ctx.Words.AsNoTracking().ToList();
            }
            
        }
    }


}
