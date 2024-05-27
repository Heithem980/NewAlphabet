internal class Program
{

    //private Dictionary<char, char> translationMap;



    private static void Main(string[] args)
    {
        Dictionary<char, string> translationMap = new Dictionary<char, string>()
        {
            {'A', "@"},
            {'B', "8"},
            {'C', "("},
            {'D', "|)"},
            {'E', "3"},
            {'F', "#"},
            {'G', "6"},
            {'H', "[-]"},
            {'I', "|"},
            {'J', "_|"},
            {'K', "|<"},
            {'L', "1"},
            {'M', "[]\\/[]"},
            {'N', "[]\\[]"},
            {'O', "0"},
            {'P', "|D"},
            {'Q', "(,)"},
            {'R', "|Z"},
            {'S', "$"},
            {'T', "']['"},
            {'U', "|_|"},
            {'V', "\\/"},
            {'W', "\\/\\/"},
            {'X', "}{"},
            {'Y', "`/"},
            {'Z', "2"},

        };



        // Create an instance 
        AlphabetTranslator translator = new AlphabetTranslator(translationMap);


        
        // Text to translate
        string originalText = "Hello World!";

        
        string translatedText = translator.Translate(originalText);

        
        Console.WriteLine(translatedText);



        
    }
}