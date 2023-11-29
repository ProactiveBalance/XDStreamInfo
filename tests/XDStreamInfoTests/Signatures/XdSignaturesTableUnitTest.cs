using FluentAssertions;
using XDStreamInfo;
using XDStreamInfo.Signatures;

namespace XDStreamInfoTests.Signatures;

public class XdSignaturesTableUnitTest
{
    [Fact]
    public void should_compile_table()
    {
        var signatures = new XdSignaturesTable();
        signatures.InternalTable.Should().NotContainNulls();
    }

    [Fact]
    public void scan_should_run_full_scan_no_exceptions()
    {
        var signatures = new XdSignaturesTable();
        signatures.InternalTable.Should().NotContainNulls();

        var stream = new MemoryStream(new byte[] {0x9F, 0xF9});

        signatures.Scan(stream).Should().BeEmpty();
    }
    
    [Fact]
    public void scan_should_find_gif89a_image()
    {
        var signatures = new XdSignaturesTable();
        signatures.InternalTable.Should().NotContainNulls();

        var stream = new MemoryStream(new byte[] {0x47, 0x49, 0x46, 0x38, 0x39, 0x61, 0x21, 0x06, 0x77});

        var results = signatures.Scan(stream);
            
        results.Should().ContainSingle(s => s.Name.Equals("GIF89A"));
    }
    
    
    [Fact]
    public void verify_should_find_gif89a_image()
    {
        var signatures = new XdSignaturesTable();
        signatures.InternalTable.Should().NotContainNulls();

        var stream = new MemoryStream(new byte[] {0x47, 0x49, 0x46, 0x38, 0x39, 0x61, 0x21, 0x06, 0x77});

        var results = signatures.Verify(stream, "testing.gif");
            
        results.Should().ContainSingle(s => s.Name.Equals("GIF89A"));
    }
}