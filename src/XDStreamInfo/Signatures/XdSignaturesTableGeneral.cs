using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using XDStreamInfo.Extensions;

[assembly: InternalsVisibleTo("XDStreamInfoTests")]
namespace XDStreamInfo.Signatures
{

public partial class XdSignaturesTable
{

    private void InitGeneral()
    {
        InternalTable.AddRange(new List<XdSignature>
        {

            new()
            {
                Name = "SQLite Database",
                Category = CategoryType.Binary,
                HexSignatureExpression = "53 5 4C 69 74 65 20 66 6F 72 6D 61 74 20 33 00",
                PossibleMimeTypes = new List<string> {"application/vnd.sqlite3",},
                PossibleExtensions = new List<string>() {"sqlitedb", "sqlite", "db", "sqlite3"},
                Description = "SQLite Database",
                Version = "3.0"
            },

            new()
            {
                Name = "Zip",
                Category = CategoryType.Compressed,
                HexSignatureExpression = "50 4B 03 04",
                PossibleMimeTypes = new()
                    {"application/zip", "application/x-zip-compressed", "application/zip-compressed"},
                PossibleExtensions = new()
                {
                    "zip", "aar", "apk", "docx", "epub", "ipa", "jar", "kmz", "maff", "msix", "odp", "ods", "odt",
                    "pk3", "pk4", "pptx", "usdz", "vsdx", "xlsx", "xpi"
                },
                Description = "Zip compressed"
            },
            new()
            {
                Name = "Pdf",
                Category = CategoryType.Binary,
                HexSignatureExpression = "25 50 44 46 2D",
                PossibleMimeTypes = new List<string>() {"application/pdf", "application/x-pdf"},
                PossibleExtensions = new List<string>() {"pdf"},
                Description = "Portable Document Format"
            },

            new()
            {
                Name = "Lotus 1-2-3 spreadsheet",
                Category = CategoryType.Binary,
                Version = "v1",
                HexSignatureExpression = "00 00 02 00 06 04 06 00 08 00 00 00 00 00",
                PossibleMimeTypes = new List<string>() {"application/vnd.lotus-1-2-3"},
                PossibleExtensions = new List<string>() {"wk1"},
                Description = "Lotus 1-2-3 spreadsheet (v1) file"
            },
            new()
            {
                Name = "Lotus 1-2-3 spreadsheet",
                Category = CategoryType.Binary,
                Version = "v3",
                HexSignatureExpression = "00 00 1A 00 00 10 04 00 00 00 00 00",
                PossibleMimeTypes = new List<string>() {"application/vnd.lotus-1-2-3"},
                PossibleExtensions = new List<string>() {"wk3"},
                Description = "Lotus 1-2-3 spreadsheet (v3) file"
            },
            new()
            {
                Name = "Lotus 1-2-3 spreadsheet",
                Category = CategoryType.Binary,
                Version = "v4, v5",
                HexSignatureExpression = "00 00 1A 00 02 10 04 00 00 00 00 00",
                PossibleMimeTypes = new List<string>() {"application/vnd.lotus-1-2-3"},
                PossibleExtensions = new List<string>() {"wk4", "wk5"},
                Description = "Lotus 1-2-3 spreadsheet (v4, v5) file"
            },
            new()
            {
                Name = "Lotus 1-2-3 spreadsheet",
                Category = CategoryType.Binary,
                Version = "v9",
                HexSignatureExpression = "00 00 1A 00 05 10 04",
                PossibleMimeTypes = new List<string>() {"application/vnd.lotus-1-2-3"},
                PossibleExtensions = new List<string>() {"123"},
                Description = "Lotus 1-2-3 spreadsheet (v9) file"
            },

            new()
            {
                Name = "Amiga Hunk executable file",
                Category = CategoryType.Binary,
                HexSignatureExpression = "00 00 03 F3"
            },

            new()
            {
                Name = "Quark Express document",
                Version = "Little Endian",
                Category = CategoryType.Binary,
                HexSignatureExpression = "00 00 49 49 58 50 52",
                PossibleExtensions = new List<string>() {"qxd", "qwd", "qwt", "qxb", "qxl", "qxt"},
                PossibleMimeTypes = new List<string>() {"application/vnd.quark.quarkxpress"},
            },
            new()
            {
                Name = "Quark Express document",
                Version = "Big Endian",
                Category = CategoryType.Binary,
                HexSignatureExpression = "00 00 4D 4D 58 50 52",
                PossibleExtensions = new List<string>() {"qxd", "qwd", "qwt", "qxb", "qxl", "qxt"},
                PossibleMimeTypes = new List<string>() {"application/vnd.quark.quarkxpress"},
            },


            new()
            {
                Name = "Password Gorilla Password Database",
                Category = CategoryType.Binary,
                HexSignatureExpression = "50 57 53 33",
                PossibleExtensions = new List<string>() {"psafe3"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
            },

            new()
            {
                Name = "Libpcap File Format",
                Version = "Little Endian",
                Category = CategoryType.Binary,
                HexSignatureExpression = "D4 C3 B2 A1",
                PossibleExtensions = new List<string>() {"pcap"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
            },
            new()
            {
                Name = "Libpcap File Format",
                Version = "Big Endian",
                Category = CategoryType.Binary,
                HexSignatureExpression = "A1 B2 C3 D4",
                PossibleExtensions = new List<string>() {"pcap"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
            },
            new()
            {
                Name = "Libpcap File Format (nanoseconds resolution)",
                Version = "Little Endian",
                Category = CategoryType.Binary,
                HexSignatureExpression = "4D 3C B2 A1",
                PossibleExtensions = new List<string>() {"pcap"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
            },
            new()
            {
                Name = "Libpcap File Format (nanoseconds resolution) ",
                Version = "Big Endian",
                Category = CategoryType.Binary,
                HexSignatureExpression = "A1 B2 3C 4D",
                PossibleExtensions = new List<string>() {"pcap"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
            },

            new()
            {
                Name = "PCAP Next Generation Dump File Format",
                Category = CategoryType.Binary,
                HexSignatureExpression = "0A 0D 0D 0A",
                PossibleExtensions = new List<string>() {"pcapng"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
            },

            new()
            {
                Name = "Redhat Package Manager (RPM) package",
                Category = CategoryType.Binary,
                HexSignatureExpression = "ED AB EE DB",
                PossibleExtensions = new List<string>() {"rpm"},
                PossibleMimeTypes = new List<string>() {"application/x-rpm"},
            },

            new()
            {
                Name = "Amazon Kindle Update Package",
                Category = CategoryType.Binary,
                HexSignatureExpression = "53 50 30 31",
                PossibleExtensions = new List<string>() {"bin"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
            },

            new()
            {
                Name = "WAD",
                Category = CategoryType.Binary,
                HexSignatureExpression = "49 57 41 44",
                PossibleExtensions = new List<string>() {"wad"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "Main resource file of Doom"
            },

            new()
            {
                Name = "PIF",
                Category = CategoryType.Binary,
                HexSignatureExpression = "00",
                PossibleExtensions = new List<string>() {"pif"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "Windows Program Information File"
            },
            new()
            {
                Name = "SEA",
                Category = CategoryType.Binary,
                HexSignatureExpression = "00",
                PossibleExtensions = new List<string>() {"sea"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "Mac Stuffit Self-Extracting Archive"
            },
            new()
            {
                Name = "YTR",
                Category = CategoryType.Binary,
                HexSignatureExpression = "00",
                PossibleExtensions = new List<string>() {"ytr"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "IRIS OCR data file"
            },

            new()
            {
                Name = "PDB",
                Category = CategoryType.Binary,
                Offset = 11,
                HexSignatureExpression =
                    "00 00 00 00 00 00 00 00" +
                    "00 00 00 00 00 00 00 00" +
                    "00 00 00 00 00 00 00 00",
                PossibleExtensions = new List<string>() {"pdb", "oprc", "pqa"},
                PossibleMimeTypes = new List<string>() {"application/vnd.palm"},
                Description = "PalmPilot Database/Document File"
            },

            new()
            {
                Name = "DBA",
                Category = CategoryType.Binary,
                HexSignatureExpression = "BE BA FE CA",
                PossibleExtensions = new List<string>() {"dba"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "Palm Desktop Calendar Archive"
            },
            new()
            {
                Name = "DBA",
                Category = CategoryType.Binary,
                HexSignatureExpression = "00 01 42 44",
                PossibleExtensions = new List<string>() {"dba"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "Palm Desktop To Do Archive"
            },
            new()
            {
                Name = "TDA",
                Category = CategoryType.Binary,
                HexSignatureExpression = "00 01 44 54",
                PossibleExtensions = new List<string>() {"tda"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "Palm Desktop Calendar Archive"
            },

            new()
            {
                Name = "TDF$",
                Category = CategoryType.Binary,
                HexSignatureExpression = "54 44 46 24",
                PossibleExtensions = new List<string>() {"tdf$"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "Telegram Desktop File"
            },
            new()
            {
                Name = "TDEF",
                Category = CategoryType.Binary,
                HexSignatureExpression = "54 44 45 46",
                PossibleExtensions = new List<string>() {"tdef"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "Telegram Desktop Encrypted File"
            },

            new()
            {
                Name = "PDDFA",
                Category = CategoryType.Binary,
                HexSignatureExpression = "00 01 00 00",
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "Palm Desktop Data File (Access format)"
            },

            new()
            {
                Name = "3GP",
                Category = CategoryType.Binary,
                Offset = 4,
                HexSignatureExpression = "66 74 79 70 33 67",
                PossibleExtensions = new List<string>() {"3gp", "3g2"},
                PossibleMimeTypes = new List<string>() {"audio/3gpp", "video/3gpp"},
                Description = "3rd Generation Partnership Project 3GPP and 3GPP2 multimedia files"
            },


            new()
            {
                Name = "ZLZW",
                Category = CategoryType.Compressed,
                HexSignatureExpression = "1F 9D",
                PossibleExtensions = new List<string>() {"z"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "Compressed file (often tar zip) using Lempel-Ziv-Welch algorithm"
            },
            new()
            {
                Name = "ZLZH",
                Category = CategoryType.Compressed,
                HexSignatureExpression = "1F A0",
                PossibleExtensions = new List<string>() {"z"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "Compressed file (often tar zip) using LZH algorithm"
            },
            new()
            {
                Name = "LZHM0",
                Category = CategoryType.Compressed,
                Offset = 2,
                HexSignatureExpression = "2D 68 6C 30 2D",
                PossibleExtensions = new List<string>() {"lzh"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "Lempel Ziv Huffman archive file Method 0 (No compression)"
            },
            new()
            {
                Name = "LZHM5",
                Category = CategoryType.Compressed,
                Offset = 2,
                HexSignatureExpression = "2D 68 6C 35 2D",
                PossibleExtensions = new List<string>() {"lzh"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "Lempel Ziv Huffman archive file Method 5 (8KiB sliding window)"
            },

            new()
            {
                Name = "AABDF",
                Category = CategoryType.Binary,
                HexSignatureExpression = "42 41 43 4B 4D 49 4B 45 44 49 53 4B",
                PossibleExtensions = new List<string>() {"bac"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "AmiBack Amiga Backup data file"
            },
            new()
            {
                Name = "AABIF",
                Category = CategoryType.Binary,
                HexSignatureExpression = "49 4E 44 58",
                PossibleExtensions = new List<string>() {"idx"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "AmiBack Amiga Backup index file"
            },

            new()
            {
                Name = "BPLF",
                Category = CategoryType.Binary,
                HexSignatureExpression = "62 70 6C 69 73 74",
                PossibleExtensions = new List<string>() {"plist"},
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "Binary Property List file"
            },

            new()
            {
                Name = "BZIP2",
                Category = CategoryType.Compressed,
                HexSignatureExpression = "42 5A 68",
                PossibleExtensions = new List<string>() {"bz2", "boz"},
                PossibleMimeTypes = new List<string>() {"application/x-bzip2"},
                Description = "Compressed file using Bzip2 algorithm"
            },

            new()
            {
                Name = "RNCAV1",
                Version = "v1",
                Category = CategoryType.Compressed,
                HexSignatureExpression = "52 4E 43 01",
                Description = "Compressed file using Rob Northen Compression (version 1) algorithm"
            },
            new()
            {
                Name = "RNCAV2",
                Version = "v2",
                Category = CategoryType.Compressed,
                HexSignatureExpression = "52 4E 43 02",
                Description = "Compressed file using Rob Northen Compression (version 2) algorithm"
            },

            new()
            {
                Name = "NURUIMAGE",
                Category = CategoryType.Binary,
                HexSignatureExpression = "4E 55 52 55 49 4D 47",
                PossibleExtensions = new List<string>() {"nui"},
                Description = "nuru ASCII/ANSI image file"
            },
            new()
            {
                Name = "NURUPALETTE",
                Category = CategoryType.Binary,
                HexSignatureExpression = "4E 55 52 55 50 41 4C",
                PossibleExtensions = new List<string>() {"nup"},
                Description = "nuru ASCII/ANSI palette file"
            },

            new()
            {
                Name = "LZIP",
                Category = CategoryType.Compressed,
                HexSignatureExpression = "4C 5A 49 50",
                PossibleExtensions = new List<string>() {"lz"},
                Description = "lzip compressed file"
            },

            new()
            {
                Name = "CPIO",
                Category = CategoryType.Compressed,
                HexSignatureExpression = "30 37 30 37 30 37",
                PossibleExtensions = new List<string>() {"cpio"},
                PossibleMimeTypes = new List<string>() {"application/x-cpio"},
                Description = "cpio archive file"
            },

            new()
            {
                Name = "DOSMZEXE",
                Category = CategoryType.Executable,
                HexSignatureExpression = "4D 5A",
                PossibleExtensions = new List<string>()
                {
                    "exe", "dll", "mui", "sys", "scr", "cpl", "ocx", "ax", "iec", "ime", "rs", "tsp", "fon", "efi",
                    "msi", "com", "bat"
                },
                PossibleMimeTypes = new List<string>() {"application/x-msdownload"},
                Description = "DOS MZ executable and its descendants (including NE and PE)"
            },
            new()
            {
                Name = "DOSZMEXE",
                Category = CategoryType.Executable,
                HexSignatureExpression = "4D 5A",
                PossibleExtensions = new List<string>() {"exe"},
                PossibleMimeTypes = new List<string>() {"application/x-msdownload"},
                Description = "DOS ZM executable and its descendants (rare)"
            },


            new()
            {
                Name = "RAR150",
                Version = "v1.50+",
                Category = CategoryType.Compressed,
                HexSignatureExpression = "52 61 72 21 1A 07 00",
                PossibleExtensions = new List<string>() {"rar"},
                PossibleMimeTypes = new List<string>() {"application/vnd.rar"},
                Description = "Roshal ARchive compressed archive v1.50 onwards"
            },
            new()
            {
                Name = "RAR500",
                Version = "v5.00+",
                Category = CategoryType.Compressed,
                HexSignatureExpression = "52 61 72 21 1A 07 01 00",
                PossibleExtensions = new List<string>() {"rar"},
                PossibleMimeTypes = new List<string>() {"application/vnd.rar"},
                Description = "Roshal ARchive compressed archive v5.00 onwards"
            },

            new()
            {
                Name = "ELF",
                Version = "v5.00+",
                Category = CategoryType.Binary,
                HexSignatureExpression = "7F 45 4C 46",
                Description = "Executable and Linkable Format"
            },

            new()
            {
                Name = "COM",
                Category = CategoryType.Binary,
                HexSignatureExpression = "C9",
                PossibleExtensions = new List<string>() {"com"},
                PossibleMimeTypes = new List<string>() {"application/x-msdownload"},
                Description = "CP/M 3 and higher with overlays"
            },

            new()
            {
                Name = "JAVACLASS",
                Category = CategoryType.Executable,
                HexSignatureExpression = "CA FE BA BE",
                PossibleExtensions = new List<string>() {"class"},
                PossibleMimeTypes = new List<string>() {"application/java-vm"},
                Description = "Java class file, Mach-O Fat Binary"
            },

            new()
            {
                Name = "MACHOBIN32BITS",
                Category = CategoryType.Binary,
                //Offset = 0x1000,
                HexSignatureExpression = "FE ED FA CE",
                Description = "Mach-O binary (32-bit)"
            },
            new()
            {
                Name = "MACHOBIN64BITS",
                Category = CategoryType.Binary,
                //Offset = 0x1000,
                HexSignatureExpression = "FE ED FA CF",
                Description = "Mach-O binary (64-bit)"
            },

            new()
            {
                Name = "MACHOBIN32BITSREVERSE",
                Category = CategoryType.Binary,
                HexSignatureExpression = "CE FA ED FE",
                Description = "Mach-O binary (reverse byte ordering scheme, 32-bit)"
            },
            new()
            {
                Name = "MACHOBIN64BITSREVERSE",
                Category = CategoryType.Binary,
                HexSignatureExpression = "CF FA ED FE",
                Description = "Mach-O binary (reverse byte ordering scheme, 64-bit)"
            },

            new()
            {
                Name = "JKS",
                Category = CategoryType.Binary,
                HexSignatureExpression = "FE ED FE ED",
                Description = "JKS JavakeyStore"
            },

            new()
            {
                Name = "POSTSCRIPT",
                Category = CategoryType.Binary,
                HexSignatureExpression = "25 21 50 53",
                PossibleMimeTypes = new List<string>() {"application/postscript"},
                PossibleExtensions = new List<string>() {"ps"},
                Description = "PostScript document"
            },

            new()
            {
                Name = "ENCAPPOSTSCRIPT30",
                Version = "3.0",
                Category = CategoryType.Binary,
                HexSignatureExpression = "25 21 50 53 2D 41 64 6F " +
                                         "62 65 2D 33 2E 30 20 45 " +
                                         "50 53 46 2D 33 2E 30",
                PossibleMimeTypes = new List<string>() {"application/postscript"},
                PossibleExtensions = new List<string>() {"eps", "epsf"},
                Description = "Encapsulated PostScript file version 3.0"
            },
            new()
            {
                Name = "ENCAPPOSTSCRIPT31",
                Version = "3.1",
                Category = CategoryType.Binary,
                HexSignatureExpression = "25 21 50 53 2D 41 64 6F " +
                                         "62 65 2D 33 2E 31 20 45 " +
                                         "50 53 46 2D 33 2E 30",
                PossibleMimeTypes = new List<string>() {"application/postscript"},
                PossibleExtensions = new List<string>() {"eps", "epsf"},
                Description = "Encapsulated PostScript file version 3.1"
            },

            new()
            {
                Name = "MSWINHTMLHELP",
                Category = CategoryType.Binary,
                HexSignatureExpression = "49 54 53 46 03 00 00 00 60 00 00 00",
                PossibleMimeTypes = new List<string>() {"application/vnd.ms-htmlhelp"},
                PossibleExtensions = new List<string>() {"chm"},
                Description = "MS Windows HtmlHelp Data"
            },

            new()
            {
                Name = "MSWINHELP",
                Category = CategoryType.Binary,
                HexSignatureExpression = "3F 5F",
                PossibleMimeTypes = new List<string>() {"application/winhlp"},
                PossibleExtensions = new List<string>() {"hlp"},
                Description = "Windows 3.x/95/98 Help file"
            },

            new()
            {
                Name = "ASF",
                Category = CategoryType.Binary,
                HexSignatureExpression = "30 26 B2 75 8E 66 CF 11 A6 D9 00 AA 00 62 CE 6C",
                PossibleMimeTypes = new List<string>() {"video/x-ms-asf", "audio/x-ms-wma", "video/x-ms-wmv"},
                PossibleExtensions = new List<string>() {"asf", "wma", "wmv"},
                Description = "Advanced Systems Format"
            },

            new()
            {
                Name = "MSSDI",
                Category = CategoryType.Binary,
                HexSignatureExpression = "24 53 44 49 30 30 30 31",
                PossibleMimeTypes = new List<string>() {"application/octet-stream"},
                Description = "System Deployment Image, a disk image format used by Microsoft"
            },

            new()
            {
                Name = "OGG",
                Category = CategoryType.Binary,
                HexSignatureExpression = "4F 67 67 53",
                PossibleMimeTypes = new List<string>() {"audio/ogg", "video/ogg"},
                PossibleExtensions = new List<string>() {"ogg", "oga", "ogv"},
                Description = "Ogg, an open source media container format"
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