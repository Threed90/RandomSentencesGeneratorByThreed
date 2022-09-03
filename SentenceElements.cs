namespace RandomSentencesGenerator
{
    public static class SentenceElements
    {
        private static readonly List<string> names = new() { "Peter", "Michell", "Jane", "Steve" };
        private static readonly List<string> places = new() { "Sofia", "Plovdiv", "Varna", "Burgas" };
        private static readonly List<string> verbs = new() { "eats", "holds", "sees", "plays with", "brings" };
        private static readonly List<string> nouns = new() { "stones", "cake", "apple", "laptop", "bikes" };
        private static readonly List<string> adverbs = new() { "slowly", "diligently", "warmly", "sadly", "rapidly" };
        private static readonly List<string> details = new() { "near the river", "at home", "in the park" };
        public static IReadOnlyCollection<string> Names => names.AsReadOnly();
        public static IReadOnlyCollection<string> Places => places.AsReadOnly();
        public static IReadOnlyCollection<string> Verbs => verbs.AsReadOnly();
        public static IReadOnlyCollection<string> Nouns => nouns.AsReadOnly();
        public static IReadOnlyCollection<string> Adverbs => adverbs.AsReadOnly();
        public static IReadOnlyCollection<string> Details => details.AsReadOnly();

        public static void AddName(string name)
        {
            names.Add(name);
        }
        public static void AddPlace(string place)
        {
            places.Add(place);
        }
        public static void AddVerb(string verb)
        {
            verbs.Add(verb);
        }
        public static void AddNoun(string noun)
        {
            nouns.Add(noun);
        }
        public static void AddAdverb(string adverb)
        {
            adverbs.Add(adverb);
        }
        public static void AddDetail(string detail)
        {
            details.Add(detail);
        }
    }
}
