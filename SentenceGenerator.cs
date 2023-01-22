namespace RandomSentencesGenerator
{
    public static class SentenceGenerator
    {
        public static string GenerateRandomSentence()
        {
            var random = new Random();

            var nameIndex = random.Next(0, SentenceElements.Names.Count);
            Thread.Sleep(199);
            var placeIndex = random.Next(0, SentenceElements.Places.Count);
            Thread.Sleep(200);
            var verbsIndex = random.Next(0, SentenceElements.Verbs.Count);
            Thread.Sleep(200);
            var nounsIndex = random.Next(0, SentenceElements.Nouns.Count);
            Thread.Sleep(200);
            var adverbsIndex = random.Next(0, SentenceElements.Adverbs.Count);
            Thread.Sleep(200);
            var detailsIndex = random.Next(0, SentenceElements.Details.Count);

            var who = $"{SentenceElements.Names.ToArray()[nameIndex]} from {SentenceElements.Places.ToArray()[placeIndex]}";
            var action = $"{SentenceElements.Adverbs.ToArray()[adverbsIndex]} {SentenceElements.Verbs.ToArray()[verbsIndex]} {SentenceElements.Nouns.ToArray()[nounsIndex]}";
            var sentence = $"{who} {action} {SentenceElements.Details.ToArray()[detailsIndex]}";

            return sentence;
        }
    }
}