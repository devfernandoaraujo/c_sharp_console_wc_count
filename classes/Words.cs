using System.Text;
/// <summary>
/// Returns the number of words in a file
/// </summary> <summary>
/// 
/// </summary>
internal class Words : ICount
{
    private readonly string _filePath;

    internal Words(string filePath)
    {
        _filePath = filePath;
    }

    private long CountWords()
    {
        char[] delimiterChars = { ' ', '\t', '\n', '\r' };
        var text = File.ReadAllText(_filePath);
        var words = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries); 

        return (int)words.LongLength;
    }

    public string Execute()
    {
        long wordCount = CountWords();
        return $"{wordCount}";
    }
}