using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using XDStreamInfo.Extensions;

[assembly: InternalsVisibleTo("XDStreamInfoTests")]
namespace XDStreamInfo.Signatures
{

public partial class XdSignaturesTable
{

    private void InitImages()
    {
        InternalTable.AddRange(new List<XdSignature>
        {

            new()
            {
                Name = "Icon",
                Category = CategoryType.Image,
                HexSignatureExpression = "00 00 01 00",
                PossibleMimeTypes = new() {"image/x-icon"},
                PossibleExtensions = new() {"ico"}
            },
            new()
            {
                Name = "ICNS",
                Category = CategoryType.Image,
                HexSignatureExpression = "69 63 6E 73",
                PossibleMimeTypes = new List<string>() {"image/x-icns"},
                PossibleExtensions = new List<string>() {"icns"},
                Description = "Apple Icon Image Format"
            },

            new()
            {
                Name = "PIC",
                Category = CategoryType.Image,
                HexSignatureExpression = "00",
                PossibleExtensions = new List<string>() {"pic", "pct"},
                PossibleMimeTypes = new List<string>() {"image/x-pict"},
                Description = "IBM Storyboard bitmap file"
            },

            new()
            {
                Name = "HEIC",
                Category = CategoryType.Image,
                Offset = 4,
                HexSignatureExpression = "66 74 79 70 68 65 69 06 66 74 79 70 6D",
                PossibleExtensions = new List<string>() {"heic", "heif"},
                PossibleMimeTypes = new List<string>() {"image/heic"},
                Description = "High Efficiency Image Container (HEIC)"
            },

            new()
            {
                Name = "GIF87A",
                Version = "GIF87a",
                Category = CategoryType.Image,
                HexSignatureExpression = "47 49 46 38 37 61",
                PossibleExtensions = new List<string>() {"gif"},
                PossibleMimeTypes = new List<string>() {"image/gif"},
                Description = "Image file encoded in the Graphics Interchange Format (GIF)"
            },
            new()
            {
                Name = "GIF89A",
                Version = "GIF89a",
                Category = CategoryType.Image,
                HexSignatureExpression = "47 49 46 38 39 61",
                PossibleExtensions = new List<string>() {"gif"},
                PossibleMimeTypes = new List<string>() {"image/gif"},
                Description = "Image file encoded in the Graphics Interchange Format (GIF)"
            },

            new()
            {
                Name = "TIFFLE",
                Version = "Little Endian",
                Category = CategoryType.Image,
                HexSignatureExpression = "49 49 2A 00",
                PossibleExtensions = new List<string>() {"tif", "tiff"},
                PossibleMimeTypes = new List<string>() {"image/tiff"},
                Description = "Tagged Image File Format (TIFF)"
            },
            new()
            {
                Name = "TIFFBE",
                Version = "Big Endian",
                Category = CategoryType.Image,
                HexSignatureExpression = "4D 4D 00 2A",
                PossibleExtensions = new List<string>() {"tif", "tiff"},
                PossibleMimeTypes = new List<string>() {"image/tiff"},
                Description = "Tagged Image File Format (TIFF)"
            },

            new()
            {
                Name = "CRFV2",
                Version = "v2",
                Category = CategoryType.Image,
                HexSignatureExpression = "49 49 2A 00 10 00 00 00 43 52",
                PossibleExtensions = new List<string>() {"cr2"},
                PossibleMimeTypes = new List<string>() {"image/x-canon-cr2"},
                Description = "Canon RAW Format Version 2\nCanon's RAW format is based on TIFF."
            },

            new()
            {
                Name = "KCI",
                Category = CategoryType.Image,
                HexSignatureExpression = "80 2A 5F D7",
                PossibleExtensions = new List<string>() {"cin"},
                Description = "Kodak Cineon image"
            },

            new()
            {
                Name = "SMPTEDPXIMAGEBE",
                Version = "Big Endian",
                Category = CategoryType.Image,
                HexSignatureExpression = "53 44 50 58",
                PossibleExtensions = new List<string>() {"dpx"},
                Description = "SMPTE DPX image"
            },

            new()
            {
                Name = "EXRIMAGE",
                Category = CategoryType.Image,
                HexSignatureExpression = "76 2F 31 01",
                PossibleExtensions = new List<string>() {"exr"},
                Description = "OpenEXR image"
            },

            new()
            {
                Name = "BPG",
                Category = CategoryType.Image,
                HexSignatureExpression = "42 50 47 FB",
                PossibleExtensions = new List<string>() {"bpg"},
                Description = "Better Portable Graphics format"
            },

            new()
            {
                Name = "JPEGRAW",
                Category = CategoryType.Image,
                HexSignatureExpression = "FF D8 FF DB",
                PossibleExtensions = new List<string>() {"jpg", "jpeg"},
                PossibleMimeTypes = new List<string>() {"image/jpeg"},
                Description = "JPEG raw file format"
            },
            new()
            {
                Name = "JPEGJFIF",
                Category = CategoryType.Image,
                HexSignatureExpression = "FF D8 FF E0 00 10 4A 46 49 46 00 01",
                PossibleExtensions = new List<string>() {"jpg", "jpeg", "jfif", "jif", "jpe", "pjpg"},
                PossibleMimeTypes = new List<string>() {"image/jpeg"},
                Description = "JPEG JFIF file format"
            },
            new()
            {
                Name = "JPEGEXIF",
                Category = CategoryType.Image,
                HexSignatureExpression = "FF D8 FF E1",
                PossibleExtensions = new List<string>() {"jpg", "jpeg", "jfif", "jif", "jpe", "pjpg"},
                PossibleMimeTypes = new List<string>() {"image/jpeg"},
                Description = "JPEG JFIF file format"
            },


            new()
            {
                Name = "JPEG2000",
                Category = CategoryType.Image,
                HexSignatureExpression = "00 00 00 0C 6A 50 20 20 0x0D 0A 87 0A",
                PossibleExtensions =
                    new List<string>() {"jp2", "j2k", "jpf", "jpm", "jpg2", "j2c", "jpc", "jpx", "mj2"},
                PossibleMimeTypes = new List<string>() {"image/jpeg"},
                Description = "JPEG 2000 file format"
            },

            new()
            {
                Name = "QOIMAGE",
                Category = CategoryType.Image,
                HexSignatureExpression = "71 6F 69 66",
                PossibleExtensions = new List<string>() {"qoi"},
                Description = "QOI - The “Quite OK Image Format”"
            },

            new()
            {
                Name = "ILBMIMAGE",
                Category = CategoryType.Image,
                HexSignatureExpression = "46 4F 52 4D",
                PossibleExtensions = new List<string>() {"ilbm", "lbm", "ibm", "iff"},
                Description = "IFF Interleaved Bitmap Image”"
            },

            new()
            {
                Name = "PNG",
                Category = CategoryType.Image,
                HexSignatureExpression = "89 50 4E 47 0D 0A 1A 0A",
                PossibleExtensions = new List<string>() {"png"},
                PossibleMimeTypes = new List<string>() {"image/png", "image/vnd.mozilla.apng", "image/x-png"},
                Description = "Image encoded in the Portable Network Graphics format"
            },

            new()
            {
                Name = "PSD",
                Category = CategoryType.Image,
                HexSignatureExpression = "38 42 50 53",
                PossibleMimeTypes = new List<string>() {"image/vnd.adobe.photoshop"},
                PossibleExtensions = new List<string>() {"psd"},
                Description = "Photoshop Document file, Adobe Photoshop's native file format"
            },

            new()
            {
                Name = "RIFFWAV",
                Category = CategoryType.Binary,
                HexSignatureExpression = "52 49 46 46 ?? ?? ?? ?? 57 41 56 45",
                PossibleMimeTypes = new List<string>()
                    {"audio/wav", "audio/vnd.wave", "audio/wave", "audio/x-pn-wav", "audio/x-wav"},
                PossibleExtensions = new List<string>() {"wav"},
                Description = "Waveform Audio File Format"
            },
        });
    }

}

}