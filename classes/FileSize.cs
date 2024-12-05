using System.Text;
/// <summary>
/// Returns the number of bytes in a file
/// </summary> <summary>
/// 
/// </summary>
internal class FileSize : ICount
{
    private readonly string _filePath;

    internal FileSize(string filePath)
    {
        _filePath = filePath;
    }

    private long CountWords()
    { 
        long fileSize = new FileInfo(_filePath).Length; 
        return (int)fileSize;
    }

    public string Execute()
    {
        long wordCount = CountWords();
        return $"{wordCount}";
    }
}