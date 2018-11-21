using System;

namespace WordWide.Model
{
    public class Word
    {
        public int Id { get; set; }
        public string EnglishWord { get; set; }
        public string TranslateWord { get; set; }
        public double Progress { get; set; }
    }
}
