using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExplorer.Utils
{
    public static class File
    {


        /*
         * **************************************************************************************
         * *                                      PROPERTIES                                    *
         * **************************************************************************************
        */
        private static Dictionary<string, string> Types { get; } = new Dictionary<string, string>
        {
                { ".txt", "Fichier texte" },
                { ".pdf", "Portable Document Format" },
                { ".doc", "Document Microsoft Word" },
                { ".docx", "Document Microsoft Word " },
                { ".xls", "Tableur Microsoft Excel " },
                { ".xlsx", "Tableur Microsoft Excel" },
                { ".dll", "Bibliothèque dynamique" },
                { ".exe", "Application" }
        };

        private static Dictionary<string, int> Icons { get; } = new Dictionary<string, int>
        {
                { ".txt", 2 },
                { ".pdf", 3 },
                { ".doc", 1 },
                { ".docx", 1 },
                { ".xls", 1 },
                { ".xlsx", 1},
                { ".dll", 1 },
                { ".exe", 1 }
        };

        private static string[] SizeUnits { get; } = ["octets", "Ko", "Mo", "Go", "To"];

        /*
         * **************************************************************************************
         * *                                       METHODS                                      *
         * **************************************************************************************
        */
        public static string SizeToString(long fileSizeInBytes)
        {
            const int scale = 1024;
            int unitIndex = 0;

            double size = fileSizeInBytes;
            while (size >= scale && unitIndex < SizeUnits.Length - 1)
            {
                size /= scale;
                unitIndex++;
            }

            return string.Format("{0:N1} {1}", size, SizeUnits[unitIndex]);
        }


        public static string GetFileType(string fileExtension)
        {
            return Types.TryGetValue(fileExtension.ToLower(), out var fileType) ? fileType : "Type iconnu";
        }

        public static int GetImageIndex(string fileExtension)
        {
            return Icons.TryGetValue(fileExtension.ToLower(), out var imageIndex) ? imageIndex : 1;
        }
    }
}
