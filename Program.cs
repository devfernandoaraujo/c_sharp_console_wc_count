using System.IO;    
using System;

if (args.Length == 0)
{
    Console.WriteLine("Please one of the following arguments: ");
    Console.WriteLine("1. -c: Just count the number of words in the file");
    Console.WriteLine("2. file path that will be read");
    Console.WriteLine("Example cwc -c file.txt");
    return;
}

string command = string.Empty;
string filePath = string.Empty;

if (args.Length < 2)
{
    filePath = args[0];
}
else
{
    command = args[0];
    filePath = args[2];
}




ICount wc = null;

switch(command)
{
    case "-c":
        wc = new FileSize(filePath);
        break;
    case "-m":
        wc = new CharCount(filePath);
        break;
    case "-l":
        wc = new Lines(filePath);
        break;
    case "-w":  
        wc = new Words(filePath);
        break;
    default:
        wc = new Default(filePath);
        break;
}

Console.WriteLine($"{wc?.Execute()} {filePath}");