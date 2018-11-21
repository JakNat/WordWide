using System.Collections.ObjectModel;
using WordWide.Model;
using WordWide.UI.Data;

namespace WordWide.UI.ViewModel
{
    public class WordViewModel : ViewModelBase
    {
        private readonly IWordDataService wordDataService;
        private Word selectedWord;

        public WordViewModel(IWordDataService wordDataService)
        {
            Words = new ObservableCollection<Word>();
            this.wordDataService = wordDataService;
        }
        public void Load()
        {
            var words = wordDataService.GetAll();
            Words.Clear();
            foreach (var word in words)
            {
                Words.Add(word);
            }
        }

        public ObservableCollection<Word> Words { get; set; }

        public Word SelectedWord
        {
            get { return selectedWord; }
            set {
                selectedWord = value;
                OnPropertyChanged(); 
            }
        }
    }
}
