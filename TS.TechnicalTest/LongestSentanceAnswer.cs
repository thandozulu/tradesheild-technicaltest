
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        // Split sentences by '.', '!' or '?'
        var sentences = s.Split(new[] { '.', '!', '?' });
        
        // Initialize the maximum word count
        int maxWords = 0;
        
        // Iterate through each sentence
        foreach (var sentence in sentences)
        {
            // Trim spaces and split by whitespace to count words
            var words = sentence.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            // Update maxWords
            if (wordCount > maxWords)
            {
                maxWords = wordCount;
            }
        }
        
        return maxWords;
    }
}
