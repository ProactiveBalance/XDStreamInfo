
using System.Text.RegularExpressions;
using XDStreamInfo.Signatures;

public class Program
{
    private int Scan(string fileName)
    {
        Stream inputStream;
        
        if (fileName == "-")
        {
            inputStream = new MemoryStream();
            Console.OpenStandardInput().CopyTo(inputStream);
        }
        else if (!File.Exists(fileName))
        {
           Console.Error.WriteLine("File not found!");
           return -1;
        }
        else
        {
            inputStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        }

        var signaturesTable = new XdSignaturesTable();

        var found = signaturesTable.Scan(inputStream);

        Console.WriteLine($"Found {found.Count} matching signature(s): ");
        foreach (var fs in found)
        {
            Console.WriteLine($"{fs.Name}({fs.Version}): {fs.Description}.");
        }

        return 0;
    }
    
    private int Verify(string fileName)
    {
        string extension;
        Stream inputStream;
        
        if (!File.Exists(fileName))
        {
           Console.Error.WriteLine("File not found!");
           return -1;
        }
        else
        {
            inputStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        }

        var signaturesTable = new XdSignaturesTable();

        var verified = signaturesTable.Verify(inputStream, fileName);

        Console.WriteLine($"Verified {verified.Count} matching signature(s): ");
        foreach (var fs in verified)
        {
            Console.WriteLine($"{fs.Name}({fs.Version}): {fs.Description}.");
        }

        return 0;
        
        return 0;
    }

    private static void PrintUsage()
    {
        Console.WriteLine("XdStreamInfoCLI v0.1 usage:");
        Console.WriteLine("xdsi <option>");
        Console.WriteLine();
        Console.WriteLine("Allowed options:");
        Console.WriteLine("scan <-|fileName> : Scans file for signature.");
        Console.WriteLine("verify <fileName> : Verify if signature corresponds with file extension.");
    }
    
    public static int Main(params string[] args)
    {
        var allowedOptions = new Regex(@"scan|verify");
        
        if (args.Length < 1 || !allowedOptions.IsMatch(args[0]))
        {
            PrintUsage();
            return 0;
        }

        var option = args[0];
        if (option == "scan")
        {
            return new Program().Scan(args[1]);
        }
        else if (option == "verify")
        {
            return new Program().Verify(args[1]);
        }
        
        return 0;
    }
    
}