using System.Text;
/// <summary>
/// Returns the number of characters in a file
/// </summary>
internal class CharCount : ICount
{
    private readonly string _filePath;

    internal CharCount(string filePath)
    {
        _filePath = filePath;
    }

    private long CountWords()
    {
        
        var text  = File.ReadAllText(_filePath).ToCharArray();
        return (int)text.Length;
    }

    public string Execute()
    {
        long wordCount = CountWords();
        return $"{wordCount}";
    }
}