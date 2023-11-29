
namespace XDStreamInfo.Signatures;

public class XdSignatureException : Exception
{
    private XdSignature Signature { get; }
    
    /// <summary>
    /// Default constructor.
    /// </summary>
    public XdSignatureException(XdSignature signature)
    {
        Signature = signature;
    }
    
    /// <summary>
    /// Constructor used with a message.
    /// </summary>
    /// <param name="signature">The faulty signature instance.</param>
    /// <param name="message">String message of exception.</param>
    public XdSignatureException(XdSignature signature, string message)
        : base(message)
    {
        Signature = signature;
    }
    
    /// <summary>
    /// Constructor used with a message and an inner exception.
    /// </summary>
    /// <param name="signature">The faulty signature instance.</param>
    /// <param name="message">String message of exception.</param>
    /// <param name="inner">Reference to inner exception.</param>
    public XdSignatureException(XdSignature signature, string message, Exception inner)
        : base(message, inner)
    {
        Signature = signature;
    }

}