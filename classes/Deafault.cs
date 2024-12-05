using System.Text;
/// <summary>
/// Returns return the default values for -c -l -w as the number of bytes, lines and words in a file
/// </summary>
internal class Default : ICount
{
    private readonly string _filePath;

    internal Default(string filePath)
    {
        _filePath = filePath;
    }

    public string Execute()
    {
        StringBuilder sb = new();


        ICount counter = new Lines(_filePath);
        sb.Append($"{counter.Execute()} ");

        counter = new Words(_filePath);
        sb.Append($"{counter.Execute()} ");

        counter = new FileSize(_filePath);
        sb.Append($"{counter.Execute()} ");



        return sb.ToString();
    }
}