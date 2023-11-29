using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using XDStreamInfo.Extensions;

[assembly: InternalsVisibleTo("XDStreamInfoTests")]

namespace XDStreamInfo.Signatures
{

    public partial class XdSignaturesTable
    {

        public XdSignaturesTable()
        {
            this.InitGeneral();
            this.InitImages();
            this.InitText();
            
            this.CompileTable();

            InternalTable = InternalTable.OrderByDescending(s => s.MinimumLength).ToList();
        }


        private List<XdSignature> CompileTable()
        {
            foreach (var signature in InternalTable)
            {
                if (signature.Parser == null)
                {
                    try
                    {
                        signature
                            .BuildBytesParser()
                            .CalcMinimumLength();
                    }
                    catch (FormatException fex)
                    {
                        throw new XdSignatureException(signature,
                            $"Signature '{signature.Name}' with HexSignatureExpression '{signature.HexSignatureExpression}' looks wrong!",
                            fex);
                    }
                }
            }

            return InternalTable;
        }

        /// <summary>
        /// Known signatures InternalTable.
        /// </summary>
        /// <see cref="https://www.wikiwand.com/en/List_of_file_signatures"/>
        /// <see cref="https://mimetype.io/"/>
        internal readonly List<XdSignature> InternalTable = new List<XdSignature>();


        public List<XdSignature> Scan(Stream stream)
        {
            var result = new List<XdSignature>();

            foreach (var signature in InternalTable)
            {
                if (signature?.Parser != null)
                {
                    var parseResult = signature.Parser(stream);
                    if (!parseResult.Any())
                    {
                        result.Add(signature);
                    }
                }
            }

            return result;
        }
        
        public List<XdSignature> Verify(Stream stream, string fileName)
        {
            var result = new List<XdSignature>();

            var fileExtension = Path.GetExtension(fileName).TrimStart('.');
            foreach (var signature in InternalTable)
            {
                if (signature?.Parser != null)
                {
                    var parseResult = signature.Parser(stream);
                    if (!parseResult.Any() && signature.PossibleExtensions.Contains(fileExtension))
                    {
                        result.Add(signature);
                    }
                }
            }

            return result;
        }
    }

}