using System.Collections.Generic;
using WordWide.Model;

namespace WordWide.UI.Data
{
    public interface IWordDataService
    {
        IEnumerable<Word> GetAll();
    }
}