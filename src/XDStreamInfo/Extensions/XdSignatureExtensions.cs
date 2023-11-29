using XDStreamInfo.Signatures;

namespace XDStreamInfo.Extensions;

public static class XdSignatureExtensions
{
    public static XdSignature BuildBytesParser(
        this XdSignature signature)
    {
        if (signature == null)
        {
            throw new ArgumentNullException(nameof(signature));
        }

        if (string.IsNullOrWhiteSpace(signature.HexSignatureExpression))
        {
            throw new ArgumentException("BytesParser builder depends on HexSignatureExpression filled in properly!");
        }

        signature.Parser = XdBytesParserBuilder.BuildBytesParserFromHexSignature(signature.HexSignatureExpression);

        return signature;
    }

    public static XdSignature CalcMinimumLength(
        this XdSignature signature)
    {
        signature.MinimumLength = signature.HexSignatureExpression.Split(' ').Length;
        return signature;
    }
}