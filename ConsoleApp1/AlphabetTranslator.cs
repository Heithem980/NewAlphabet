using System;
using System.Collections.Generic;

class AlphabetTranslator
{
    private Dictionary<char, string> translationMap;

    public AlphabetTranslator(Dictionary<char, string> translationMap)
    {
        this.translationMap = translationMap;
    }

    public string Translate(string text)
    {
        string textToUpper = text.ToUpper();
        string newText = "";

        foreach (char originalChar in textToUpper)
        {
            if (translationMap.ContainsKey(originalChar))
            {
                newText += translationMap[originalChar];
            }
            else
            {
                newText += originalChar;
            }
        }

        return newText;
    }
}
