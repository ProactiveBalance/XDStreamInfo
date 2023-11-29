using System.Collections.ObjectModel;

namespace XDStreamInfo.Signatures;

public class XdSignature
{



    public string Name { get; set; }
   
    public ulong Offset { get; set; } = 0;

    public string HexSignatureExpression { get; set; }

    public int MinimumLength { get; set; } = 0;
    
    public XdBytesParserBuilder.BytesParser? Parser { get; set; }

    public IDictionary<string, string> Tags { get; set; } = new Dictionary<string, string>();
    
    public CategoryType Category { get; set; } = CategoryType.Unknown;
    
    public string Version { get; set; }

    public List<string> PossibleExtensions { get; set; } = new List<string>();

    public List<string> PossibleMimeTypes { get; set; } = new List<string>(); 

    public string Description { get; set; }

    public IDictionary<string, object> ExtraInfo { get; set; } = new Dictionary<string, object>();

}