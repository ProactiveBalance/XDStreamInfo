using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using XDStreamInfo.Extensions;

[assembly: InternalsVisibleTo("XDStreamInfoTests")]
namespace XDStreamInfo.Signatures
{

public partial class XdSignaturesTable
{

    private void InitText()
    {
        InternalTable.AddRange(new List<XdSignature>
        {

            new()
            {
                Name = "SCRIPTWITHSHEBANG",
                Category = CategoryType.Text,
                HexSignatureExpression = "23 21",
                PossibleExtensions = new List<string> {"sh", "bash", "pl", "py"},
                Description = "Script Shebang #!"
            },

            new()
            {
                Name = "UTF8BOM",
                Category = CategoryType.Text,
                HexSignatureExpression = "EF BB BF",
                PossibleExtensions = new List<string>() {"txt"},
                PossibleMimeTypes = new List<string>() {"text/plain"},
                Description = "UTF-8 byte order mark, commonly seen in text files"
            },
            new()
            {
                Name = "UTF16LEBOM",
                Category = CategoryType.Text,
                HexSignatureExpression = "FF FE",
                PossibleExtensions = new List<string>() {"txt"},
                PossibleMimeTypes = new List<string>() {"text/plain"},
                Description = "UTF-16LE byte order mark, commonly seen in text files"
            },
            new()
            {
                Name = "UTF16BEBOM",
                Category = CategoryType.Text,
                HexSignatureExpression = "FE FF",
                PossibleExtensions = new List<string>() {"txt"},
                PossibleMimeTypes = new List<string>() {"text/plain"},
                Description = "UTF-16BE byte order mark, commonly seen in text files"
            },
            new()
            {
                Name = "UTF32LEBOM",
                Category = CategoryType.Text,
                HexSignatureExpression = "FF FE 00 00",
                PossibleExtensions = new List<string>() {"txt"},
                PossibleMimeTypes = new List<string>() {"text/plain"},
                Description = "UTF-32LE byte order mark, commonly seen in text files"
            },
            new()
            {
                Name = "UTF32BEBOM",
                Category = CategoryType.Text,
                HexSignatureExpression = "00 00 FE FF",
                PossibleExtensions = new List<string>() {"txt"},
                PossibleMimeTypes = new List<string>() {"text/plain"},
                Description = "UTF-32BE byte order mark, commonly seen in text files"
            },
            new()
            {
                Name = "UTF7BOM",
                Category = CategoryType.Text,
                HexSignatureExpression = "2B 2F 76", /* 38, */
                Description = "UTF-7 byte order mark, commonly seen in text files"
            },
            new()
            {
                Name = "SCSUBOM",
                Category = CategoryType.Text,
                HexSignatureExpression = "0E FE FF",
                PossibleExtensions = new List<string>() {"txt"},
                PossibleMimeTypes = new List<string>() {"text/plain"},
                Description = "UTF-7 byte order mark, commonly seen in text files"
            },
            new()
            {
                Name = "UTFEBCDICBOM",
                Category = CategoryType.Text,
                HexSignatureExpression = "DD 73 66 73",
                PossibleExtensions = new List<string>() {"txt"},
                PossibleMimeTypes = new List<string>() {"text/plain"},
                Description = "UTF-7 byte order mark, commonly seen in text files"
            },

        });
    }

}

}