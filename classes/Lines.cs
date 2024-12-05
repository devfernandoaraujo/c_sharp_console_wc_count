using System.Text;
/// <summary>
/// Returns the number of lines in a file
/// </summary> <summary>
/// 
/// </summary>
internal class Lines : ICount
{
    private readonly string _filePath;

    internal Lines(string filePath)
    {
        _filePath = filePath;
    }

    private long CountWords()
    {
        char[] delimiterChars = {'\n'};
        var text = File.ReadAllText(_filePath).Split(delimiterChars);
        
        return (int)text.Count();
    }

    public string Execute()
    {
        long wordCount = CountWords();
       return $"{wordCount}";
    }
}