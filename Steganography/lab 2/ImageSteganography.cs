using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    class ImageSteganography : Steganography
    {
        public int calculateFreeSiezOfImage(int width, int height, int bits)
        {
            return width * height * bits;
        }

        public int calculateSiezOfImageToBetaken(int width, int height, int bits)
        {
            return width * height * bits;
        }

        public int calculateMaxSiezOfText(int textLength, string extension)
        {
            byte[] extensionBytes = Encoding.ASCII.GetBytes(extension);
            return textLength + extensionBytes.Length+ extensionLenghtBinary;
        }

        public Bitmap EncryptBinaryInImage(Bitmap bmp, string textBinary,string extension, int bitsForR, int bitsForG, int bitsForB)
        {
            try
            {
                int maxsize = (bitsForR + bitsForG + bitsForB) * bmp.Height * bmp.Width;
                textBinary = createEncodingHeder(textBinary.Length, extension, maxsize, bitsForR + bitsForG + bitsForB) + textBinary;
                while (textBinary.Length % (bitsForR + bitsForG + bitsForB) != 0)
                {
                    textBinary += '0';
                }
                int R = 0, G = 0, B = 0;
                int rMask = 0, gMask = 0, bMask = 0;
                int counter = 0;
                if (bitsForR <= 8 && bitsForG <= 8 && bitsForB <= 8 && textBinary.Length <= ((bitsForR + bitsForG + bitsForB) * bmp.Height * bmp.Width))
                {
                    rMask = 255 << bitsForR;
                    gMask = 255 << bitsForG;
                    bMask = 255 << bitsForB;
                    for (int i = 0; i < bmp.Height; i++)
                    {
                        for (int j = 0; j < bmp.Width; j++)
                        {
                            Color pixel = bmp.GetPixel(j, i);
                            R = pixel.R & rMask;
                            G = pixel.G & gMask;
                            B = pixel.B & bMask;

                            if (counter + bitsForR + bitsForG + bitsForB > textBinary.Length)
                                break;
                            R |= Convert.ToInt32(textBinary.Substring(counter, bitsForR), 2);
                            G |= Convert.ToInt32(textBinary.Substring(counter + bitsForR, bitsForG), 2);
                            B |= Convert.ToInt32(textBinary.Substring(counter + bitsForR + bitsForG, bitsForB), 2);
                            counter += bitsForR + bitsForG + bitsForB;

                            bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                        }
                        if (counter + bitsForR + bitsForG + bitsForB > textBinary.Length)
                            break;
                    }

                }
                return bmp;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public string DecryptBinaryInImage(Bitmap bmp, int bitsForR, int bitsForG, int bitsForB, out string extension)
        {
            try
            {
                string maxsize = Convert.ToString((bitsForR + bitsForG + bitsForB) * bmp.Height * bmp.Width, 2);
                int andR = 255 >> (8 - bitsForR), andG = 255 >> (8 - bitsForG), andB = 255 >> (8 - bitsForB);
                int R, G, B;
                StringBuilder textBinary = new StringBuilder();
                Color pixel;
                int counter = 1000, elementsToSkip = 0, ammountToTake = 0, bitsSum = bitsForR + bitsForG + bitsForB;
                extension = "";
                for (int j = 0; j < bmp.Width; j++)
                {
                    pixel = bmp.GetPixel(j, 0);
                    R = pixel.R & andR;
                    G = pixel.G & andG;
                    B = pixel.B & andB;
                    textBinary.Append(Convert.ToString(R, 2).PadLeft(bitsForR, '0'));
                    textBinary.Append(Convert.ToString(G, 2).PadLeft(bitsForG, '0'));
                    textBinary.Append(Convert.ToString(B, 2).PadLeft(bitsForB, '0'));
                    if (textBinary.Length >= maxsize.Length + extensionLenghtBinary)
                    {
                        extension = convertBinaryToString(textBinary.ToString().Substring(0, extensionLenghtBinary));
                        counter = Convert.ToInt32(textBinary.ToString().Substring(extensionLenghtBinary, maxsize.Length), 2) + extensionLenghtBinary + maxsize.Length;
                        ammountToTake = Convert.ToInt32(textBinary.ToString().Substring(extensionLenghtBinary, maxsize.Length), 2);

                        textBinary.Clear();
                        elementsToSkip = maxsize.Length + extensionLenghtBinary;
                        break;
                    }

                }

                if (bitsForR <= 8 && bitsForG <= 8 && bitsForB <= 8)
                {
                    for (int i = 0; i < bmp.Height; i++)
                    {
                        for (int j = 0; j < bmp.Width; j++)
                        {
                            pixel = bmp.GetPixel(j, i);
                            R = pixel.R & andR;
                            G = pixel.G & andG;
                            B = pixel.B & andB;
                            textBinary.Append(Convert.ToString(R, 2).PadLeft(bitsForR, '0'));
                            textBinary.Append(Convert.ToString(G, 2).PadLeft(bitsForG, '0'));
                            textBinary.Append(Convert.ToString(B, 2).PadLeft(bitsForB, '0'));

                            counter -= bitsSum;
                            if (counter <= 0)
                                break;
                        }
                        if (counter <= 0)
                            break;
                    }
                }
                string text2 = textBinary.ToString().Substring(elementsToSkip).Substring(0, ammountToTake);
                return text2;
            }
            catch(Exception ex)
            {
                extension = "";
                return null;
            }
        }

        public Bitmap EncryptImageInImage(Bitmap bmp, Bitmap bmp2, int bitsForR, int bitsForG, int bitsForB)
        {
            try
            {
                int maxsize = (bitsForR + bitsForG + bitsForB) * bmp.Height * bmp.Width;
                int R = 0, G = 0, B = 0;
                if (bitsForR <= 8 && bitsForG <= 8 && bitsForB <= 8)
                {
                    int moveR = (8 - bitsForR);
                    int moveG = (8 - bitsForG);
                    int moveB = (8 - bitsForB);

                    int rMaskVisible = 255 << bitsForR;
                    int gMaskVisible = 255 << bitsForG;
                    int bMaskVisible = 255 << bitsForB;

                    int rMaskInvisible = 255 >> bitsForR;
                    int gMaskInvisible = 255 >> bitsForG;
                    int bMaskInvisible = 255 >> bitsForB;
                    for (int i = 0; i < bmp.Height; i++)
                    {
                        for (int j = 0; j < bmp.Width; j++)
                        {
                            Color pixel2 = bmp2.GetPixel(j, i);
                            Color pixel = bmp.GetPixel(j, i);
                            R = (pixel.R & rMaskVisible) + ((pixel2.R >> moveR) & rMaskInvisible);
                            G = (pixel.G & gMaskVisible) + ((pixel2.G >> moveG) & gMaskInvisible);
                            B = (pixel.B & bMaskVisible) + ((pixel2.B >> moveB) & bMaskInvisible);
                            bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                        }

                    }

                }
                return bmp;
            }
            catch (Exception ex)
            {   
                return null;
            }
        }

        public Bitmap DecryptImageInImage(Bitmap bmp, int bitsForR, int bitsForG, int bitsForB)
        {
            try
            {
                int R = 0, G = 0, B = 0;


                if (bitsForR <= 8 && bitsForG <= 8 && bitsForB <= 8)
                {
                    int moveR = (8 - bitsForR);
                    int moveG = (8 - bitsForG);
                    int moveB = (8 - bitsForB);

                    int rMaskInvisible = 255 >> moveR;
                    int gMaskInvisible = 255 >> moveG;
                    int bMaskInvisible = 255 >> moveB;

                    for (int i = 0; i < bmp.Height; i++)
                    {
                        for (int j = 0; j < bmp.Width; j++)
                        {

                            Color pixel = bmp.GetPixel(j, i);
                            R = (pixel.R & rMaskInvisible) << moveR;
                            G = (pixel.G & gMaskInvisible) << moveR;
                            B = (pixel.B & bMaskInvisible) << moveB;

                            bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                        }

                    }

                }
                return bmp;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public string CheckImage(Bitmap bmp)
        {
            int R, G, B;
            StringBuilder textBinary = new StringBuilder();
          
            Color pixel;
            string extension = "";
            for (int r = 1; r <= 8; r++)
            {
                for (int g = 1; g <= 8; g++)
                {
                    for (int b = 1; b <= 8; b++)
                    {
                        for (int j = 0; j < extensionLenghtBinary; j++)
                        {
                            int andR = 255 >> (8 - r), andG = 255 >> (8 - g), andB = 255 >> (8 - b);
                            pixel = bmp.GetPixel(j, 0);
                            R = pixel.R & andR;
                            G = pixel.G & andG;
                            B = pixel.B & andB;
                            textBinary.Append(Convert.ToString(R, 2).PadLeft(r, '0'));
                            textBinary.Append(Convert.ToString(G, 2).PadLeft(g, '0'));
                            textBinary.Append(Convert.ToString(B, 2).PadLeft(b, '0'));
                            if (textBinary.Length >= extensionLenghtBinary)
                            {
                                extension = convertBinaryToString(textBinary.ToString().Substring(0, extensionLenghtBinary));
                                if (extensionsList.Contains(extension))
                                {
                                    return "Zdjęcie jest steganografem i zawiera plik z rozszeżeniem " + extension;
                                }
                                textBinary.Clear();
                                break;
                                
                            }
                        }  
                    }   
                }  
            }
            return "Zdjęcie nie jest steganografem";

        }
    }
}
