
using System.Text.RegularExpressions; 
class Dictionary
{
    static Dictionary<string, int> CountWords(string text)
    {
        Dictionary<string, int> frequencies = new Dictionary<string, int>();

        string[] words = Regex.Split(text, @"\W+");

        foreach (string word in words)
        {
            if (frequencies.ContainsKey(word))
            {
                frequencies[word]++;
            }
            else
            {
                frequencies[word] = 1;
            }
        }
        return frequencies;
    }

    static void Main()
    {
        string text = "u i a i u i a i";
        Dictionary<string, int> frequencies = CountWords(text);
        foreach (KeyValuePair<string, int> entry in frequencies)
        {
            string word = entry.Key;
            int frequency = entry.Value;
            Console.WriteLine("{0}: {1}", word, frequency);
        }
    }
}