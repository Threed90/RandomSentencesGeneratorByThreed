using RandomSentencesGenerator;

Console.WriteLine("Hello, this is your first random generated sentence: ");

while (true)
{
    var sentence = SentenceGenerator.GenerateRandomSentence();
    Console.WriteLine(sentence);

    Console.WriteLine("Click [Enter] to generate new one or [Esc] to exit the application.");

    while (true)
    {
        var key = Console.ReadKey();

        if (key.Key == ConsoleKey.Enter)
        {
            break;
        }
        else if(key.Key == ConsoleKey.Escape)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Invalid key! You need to press [Enter] for new sentence or [Esc] for exit.");
        }
    }
    Console.WriteLine();
}
