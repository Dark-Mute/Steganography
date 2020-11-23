using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    abstract class Steganography
    {
        protected int extensionLenghtBinary = 48;
        protected List<string> extensionsList = new List<string> {
                "txt","blend","m",
                "jpg", "png", "gif", "bmp", "tiff", "psd",
                "mp4", "mkv", "avi", "mov", "mpg", "vob",
                "mp3", "aac", "wav", "flac", "ogg", "mka", "wma",
                "pdf", "doc", "xls", "ppt", "docx", "odt",
                "zip", "rar", "7z", "tar", "iso",
                "mdb", "accde", "frm", "sqlite",
                "exe", "dll", "so", "class"
            };

        public bool checkExtension(string extension)
        {
            return extensionsList.Contains(extension);
        }
        public string convertBinaryToString(string binary, bool removeZeros = true)
        {
            byte[] bytes = convertBinaryToByteArray(binary, removeZeros);
            return Encoding.ASCII.GetString(bytes);
        }

        public byte[] convertBinaryToByteArray(string binary, bool removeZeros = true)
        {
            if (binary != null)
            {
                while (binary.Length % 8 != 0)
                {
                    binary += '0';
                }
                List<Byte> byteList = new List<Byte>();
                for (int i = 0; i < binary.Length; i += 8)
                {
                    byteList.Add(Convert.ToByte(binary.Substring(i, 8), 2));
                }
                if (removeZeros)
                {
                    byteList.RemoveAll(s => s == 0);
                }
                return byteList.ToArray();
            }
            return null;
        }

        public string convertBytesToString(byte[] bytes)
        {
            if (bytes != null)
            {
                StringBuilder sb = new StringBuilder();

                foreach (char c in bytes)
                {
                    sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
                }
                return sb.ToString();
            }
            return null;
        }

        public string createEncodingHeder(int textlenght, string extension, int maxSize, int bitSum)
        {
            byte[] extensionBytes = Encoding.ASCII.GetBytes(extension);
            string extensionBinnary = convertBytesToString(extensionBytes).PadRight(extensionLenghtBinary, '0');
            string maxsize = Convert.ToString(maxSize, 2);
            string lenght = Convert.ToString(textlenght, 2).PadLeft(maxsize.Length, '0');
            int y = lenght.Length + extensionBinnary.Length;
            return extensionBinnary + lenght;
        }

        public void calculateMemoryUsageAndShowInLable( int taken, Label label)
        {
            double takenInB = Math.Round(taken / 8.0,0);
            double takenInKb = Math.Round((takenInB / 1024.0) / 8, 2);
            double takenInMb = Math.Round((takenInKb / 1024.0), 2);
            double takenInGb = Math.Round((takenInMb / 1024.0), 2);
            label.Text = takenInGb.ToString() + "Mb";
            if (takenInGb > 1)
            {
                label.Text = takenInGb.ToString() + "Gb";
                return;
            }
            if (takenInMb > 1)
            {
                label.Text = takenInMb.ToString() + "Mb";
                return;
            }
            if (takenInKb > 1)
            {
                label.Text = takenInKb.ToString() + "Kb";
                return;
            }
            if (takenInB > 1)
            {
                label.Text = takenInB.ToString() + "b";
                return;
            }
        }


    }
}
