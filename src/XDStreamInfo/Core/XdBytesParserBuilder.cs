namespace XDStreamInfo;

public static class XdBytesParserBuilder
{
    
    public delegate IDictionary<string, string> BytesParser(Stream stream);

    public static BytesParser BuildSequenceBytesParser(BytesParser[] parsers, ulong offset = 0) {
        return (stream) =>
        {
            stream.Seek((long)offset, SeekOrigin.Begin);
            
            var results = new Dictionary<string, string>();
            foreach (var bp in parsers)
            {
                results.Merge(bp(stream));
            }
            
            return results;
        };
    }
    
    public static BytesParser BuildEqualByteParser(string singleByteHexSignature)
    {
        var signatureByte = Convert.ToByte(singleByteHexSignature, 16);

        return (stream) =>
        {
            var results = new Dictionary<string, string>();
           
            var byteRead = stream.ReadByte();
            if (byteRead <= -1)
            {
                results.Add("EOF", $"End of file reached unexpectedly at {stream.Position}!");
            }
            else if (byteRead != signatureByte)
            {
                results.Add("NO_MATCH", $"Expected {signatureByte:X} but found {byteRead:X} at {stream.Position}!");
            }

            return results;
        };
    }

    public static BytesParser BuildEqualOrSkipByteParser(string singleByteHexSignature)
    {
        if (singleByteHexSignature !=  "??")
        {
            return BuildEqualByteParser(singleByteHexSignature);
        }

        return (stream) =>
        {
            var results = new Dictionary<string, string>();
            
            var byteRead = stream.ReadByte();
            
            if (byteRead <= -1)
            {
                results.Add("EOF", $"End of file reached unexpectedly at {stream.Position}!");
            }

            return results;
        };
    }

    public static BytesParser BuildBytesParserFromHexSignature(string hexSignature, ulong offset = 0)
    {
        if (string.IsNullOrWhiteSpace(hexSignature))
        {
            throw new ArgumentException("BytesParser builder depends on HexSignatureExpression filled in properly!");
        }
        
        var hexSignatureBytes = hexSignature.Split(' ');

        var parsers = new BytesParser[hexSignatureBytes.Length];
        var i = 0;
        foreach (var singleByteHexSignature in hexSignatureBytes)
        {
            parsers[i++] = BuildEqualOrSkipByteParser(singleByteHexSignature);
        }

        return  BuildSequenceBytesParser(parsers, offset);
    }
}