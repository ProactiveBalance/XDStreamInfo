
using FluentAssertions;
using XDStreamInfo;
using static XDStreamInfo.XdBytesParserBuilder;

namespace XDStreamInfoTests.Core;

public class XdBytesParserBuilderUnitTest
{
    [Fact]
    public void signature_should_match()
    {
        var hexSignature = "21 06 07 24 0C";
        var stream = new MemoryStream(new byte[] {0x21, 0x06, 0x07, 0x24, 0x0C, 0xBA, 0x00, 0x46 });
        
        var parser = BuildBytesParserFromHexSignature(hexSignature);

        var results = parser(stream);
        results.Should().BeEmpty();
    }
    
    [Fact]
    public void signature_should_match_using_wildcards()
    {
        var hexSignature = "21 06 ?? 24 0C";
        var stream1 = new MemoryStream(new byte[] {0x21, 0x06, 0x07, 0x24, 0x0C, 0xBA, 0x00, 0x46 });
        var stream2 = new MemoryStream(new byte[] {0x21, 0x06, 0x9F, 0x24, 0x0C, 0xBA, 0x00, 0x46 });
        
        var parser = BuildBytesParserFromHexSignature(hexSignature);

        var results = parser(stream1);
        results.Merge(parser(stream2));
        
        results.Should().BeEmpty();
    }
    
    [Fact]
    public void signature_should_return_not_match()
    {
        var hexSignature = "21 07 ?? 24 0C";
        var stream = new MemoryStream(new byte[] {0x21, 0x06, 0x07, 0x24, 0x0C, 0xBA, 0x00, 0x46 });
        
        var parser = BuildBytesParserFromHexSignature(hexSignature);

        var results = parser(stream);
        results.Should().ContainKey("NO_MATCH");
    }
    
    [Fact]
    public void signature_should_return_eof()
    {
        var hexSignature = "21 07 ?? 24 0C";
        var stream = new MemoryStream(new byte[] {0x21, 0x07 });
        
        var parser = BuildBytesParserFromHexSignature(hexSignature);

        var results = parser(stream);
        results.Should().ContainKey("EOF");
    }
    
    [Fact]
    public void signature_should_throw()
    {
        var hexSignature = "";
        hexSignature.Invoking(y => BuildBytesParserFromHexSignature(hexSignature))
            .Should().Throw<ArgumentException>();
    }
}