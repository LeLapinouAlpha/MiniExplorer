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
        private static Dictionary<string, (string type, int imageIndex)> ExtensionData { get; } = new Dictionary<string, (string, int)>
        {
            { ".3ds", ("Fichier 3DS", 2) },
            { ".aac", ("Fichie audio AAC", 3) },
            { ".ai", ("Illustration Adobe Illustrator", 4) },
            { ".avi", ("Vidéo AVI", 5) },
            { ".bin", ("Fichier Binaire", 6) },
            { ".bmp", ("Image Bitmap", 7) },
            { ".raw", ("Données image brutes", 8) },
            { ".css", ("Feuille de style en cascade", 9) },
            { ".csv", ("Fichier Valeurs Séparées par des Virgules", 10) },
            { ".dat", ("Fichier de Données", 11) },
            { ".dll", ("Bibliothèque de liaison dynamique", 12) },
            { ".dmg", ("Image Disque Apple", 13) },
            { ".doc", ("Document Microsoft Word", 14) },
            { ".docx", ("Document Microsoft Word Open XML", 14) },
            { ".eps", ("Fichier PostScript Encapsulé", 15) },
            { ".exe", ("Application", 16) },
            { ".flv", ("Vidéo FLV", 17) },
            { ".gif", ("Fichier Image GIF", 18) },
            { ".html", ("Document HTML", 19) },
            { ".ini", ("Fichier de configuration", 20) },
            { ".iso", ("Image Disque ISO", 21) },
            { ".jar", ("Archive Java", 22) },
            { ".java", ("Fichier Source Java", 23) },
            { ".jpg", ("Image JPEG", 24) },
            { ".js", ("Fichier source JavaScript", 25) },
            { ".midi", ("Fichier MIDI", 26) },
            { ".mkv", ("Vidéo MKV", 27) },
            { ".mov", ("Vidéo MOV", 28) },
            { ".mp3", ("Fichier audio MP3", 29) },
            { ".mp4", ("Vidéo MP4", 30) },
            { ".pdb", ("Fichier de débogage PDB", 31) },
            { ".pdf", ("Document PDF", 32) },
            { ".png", ("Image PNG", 33) },
            { ".ppt", ("Présentation PowerPoint", 34) },
            { ".ps", ("Fichier source PostScript", 35) },
            { ".psd", ("Image Photoshop", 36) },
            { ".rar", ("Archive WinRar", 37) },
            { ".sql", ("Fichier source SQL", 38) },
            { ".svg", ("Image vectorielle SVG", 39) },
            { ".tif", ("Image TIFF", 40) },
            { ".txt", ("Document texte", 41) },
            { ".xls", ("Tableur Excel", 42) },
            { ".xlsx", ("Tableur Excel Open XML", 43) },
            { ".zip", ("Archive ZIP", 44) },
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
            return ExtensionData.TryGetValue(fileExtension.ToLower(), out var fileType) ? fileType.type : "Fichier";
        }

        public static int GetImageIndex(string fileExtension)
        {
            return ExtensionData.TryGetValue(fileExtension.ToLower(), out var fileType) ? fileType.imageIndex : 1;
        }
    }
}
