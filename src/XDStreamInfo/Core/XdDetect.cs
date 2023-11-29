using System.Text;

namespace XDCore;

public class XdDetect : IDisposable, IAsyncDisposable
{

    
    
    public readonly byte[] BomUtf8 = new byte[]{0xEF, 0xBB, 0xBF};
    public readonly byte[] BomUtf16Be = new byte[]{0xFE, 0xFF};
    public readonly byte[] BomUtf16Le = new byte[]{0xFF, 0xFE};
    public readonly byte[] BomUtf32Be = new byte[]{0x00, 0x00, 0xFE, 0xFF};
    public readonly byte[] BomUtf32Le = new byte[]{0xFF, 0xFE, 0x00, 0x00};
    public readonly byte[] BomUtf7 = new byte[]{0x2B, 0x2F, 0x76};
    public readonly byte[] BomUtf1 = new byte[]{0xF7, 0x64, 0x4C};
    public readonly byte[] BomUtfEbcdic = new byte[]{0xDD, 0x73, 0x66, 0x73};
    public readonly byte[] BomScsu = new byte[]{0x0E, 0xFE, 0xFF};
    public readonly byte[] BomBocu1= new byte[]{0xFB, 0xEE, 0x28};
    public readonly byte[] BomGb18030= new byte[]{0x84, 0x31, 0x95, 0x33};
    
   
    
    public static string GetSupportedEncodings()
    {
        var encs = Encoding.GetEncodings().Select(e => e.Name + "->" + e.DisplayName + "(" + e.CodePage.ToString() + ")");
        return String.Join("\n", encs);
    }
    
    
    private const ushort DefaultPeekSize = 64;
    private int peekSize = DefaultPeekSize;
    private byte[] peekBlock;
   
    
    public Stream InputStream { get; set; }
    
    public string? ContentType { get; set; }



    public XdDetect(Stream input)
    {
        InputStream = input;
        
        peekBlock = new byte[peekSize];
    }
    
    // public ValueTask<(Encoding?, DetectionResult)> DetectAsync()
    // {
    //     Encoding? result = null;
    //     
    //     peekSize = await file.ReadAsync(peekBlock, 0, peekSize, cancellationToken);
    //
    //     // Detect by Byte Order Mark
    //     var resultFromBom = await FromByteOrderMark(buf.Take(peekSize).ToArray());
    //     if (resultFromBom != null)
    //     {
    //         result = resultFromBom;
    //         resultHow = DetectionResult.ByBom;
    //     }
    //     
    //     return (result, resultHow);
    // }
    

    

    public async ValueTask<Encoding?> DetectByteOrderMark(byte[] peekBlock)
    {
        Encoding? result = null;
        
        if (peekBlock.Take(BomUtf32Be.Length).SequenceEqual(BomUtf32Be))
        {
            result = Encoding.GetEncoding("Utf-32BE");
        }
        else if (peekBlock.Take(BomUtf32Le.Length).SequenceEqual(BomUtf32Le))
        {
            result = Encoding.GetEncoding("Utf-32LE");
        }
        else if (peekBlock.Take(BomUtf16Be.Length).SequenceEqual(BomUtf16Be))
        {
            result = Encoding.GetEncoding("Utf-16BE");
        }
        else if (peekBlock.Take(BomUtf16Le.Length).SequenceEqual(BomUtf16Le))
        {
            result = Encoding.GetEncoding("Utf-16LE");
        }
        else if (peekBlock.Take(BomUtf8.Length).SequenceEqual(BomUtf8))
        {
            result = Encoding.GetEncoding("Utf-8");
        }

        return result;
    }
    
    public Encoding FromXmlScaning(byte[] peekBlock, string charsToTest = "<>?/\"")
    {
        return Encoding.Default;
    }

    public Encoding FromJsonScaning(byte[] peekBlock, string charsToTest = "{}[]\"")
    {
        return Encoding.Default;
    }

    public void Dispose()
    {
        InputStream.Dispose();
    }

    public async ValueTask DisposeAsync()
    {
        await InputStream.DisposeAsync();
    }
}