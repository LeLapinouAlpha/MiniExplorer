using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExplorer.Utils
{
    public static class File
    {
        private static Dictionary<string, string> FileTypes { get; } = new Dictionary<string, string>
        {
                { ".txt", "Text File" },
                { ".pdf", "Portable Document Format" },
                { ".doc", "Microsoft Word Document" },
                { ".docx", "Microsoft Word Document" },
                { ".xls", "Microsoft Excel Spreadsheet" },
                { ".xlsx", "Microsoft Excel Spreadsheet" },
                { ".dll", "Shared library" },
                { ".exe", "Application" }
        };
        private static string[] FileSizeUnits { get; } = ["bytes", "Ko", "Mo", "Go", "To"];

        public static string FileSizeToString(long fileSizeInBytes)
        {
            const int scale = 1024;
            int unitIndex = 0;

            double size = fileSizeInBytes;
            while (size >= scale && unitIndex < FileSizeUnits.Length - 1)
            {
                size /= scale;
                unitIndex++;
            }

            return string.Format("{0:N1} {1}", size, FileSizeUnits[unitIndex]);
        }


        public static string GetFileType(string fileExtension)
        {
            return FileTypes.TryGetValue(fileExtension.ToLower(), out var fileType) ? fileType : "Unknown file type";
        }
    }
}
