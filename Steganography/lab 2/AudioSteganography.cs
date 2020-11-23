using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class AudioSteganography : Steganography
    {

        public int calculateMaxSiezOfWave(uint numberOfSamples, int bits)
        {
            return (int)numberOfSamples * bits;
        }

        public int calculateMaxSiezOfText(int textLengt,string extension)
        {
            byte[] extensionBytes = Encoding.ASCII.GetBytes(extension);
            return textLengt + extensionBytes.Length + extensionLenghtBinary;
        }

        private uint CalculateSumPowerOfTwo(int power)
        {
            uint sum = 0;
            for (int i = 0; i < power; i++)
            {
                sum += (uint)Math.Pow(2, i);
            }
            return sum;
        }

        public WaveFille EncryptBinaryInWave(byte[] wav, string textBinary, int bity, string extension)
        {
            try
            {
                WaveFille audio = new WaveFille(wav);
                int maxsize = (int)audio.totalSamples * bity;
                int counter = 0;
                textBinary = createEncodingHeder(textBinary.Length, extension, maxsize, bity) + textBinary;
                int y = textBinary.Length;
                while (textBinary.Length % (bity) != 0)
                {
                    textBinary += '0';
                }
                if (textBinary.Length <= maxsize && bity <= audio.bitsPerSample)
                {
                    if(audio.bitsPerSample == 8 )
                    {
                        //uint quant = CalculateSumPowerOfTwo((int)audio.bitsPerSample) - CalculateSumPowerOfTwo(bity);
                        uint quant = (uint)((0xFF << bity) & 0xFF);
                        for (int i = 0; i < audio.samples.Count; i++)
                        {
                            uint sampleValue = audio.samples[i];
                            sampleValue = (sampleValue & (uint)quant);
                            sampleValue |= Convert.ToByte(textBinary.Substring(counter, bity), 2);
                            audio.samples[i] = sampleValue;
                            counter += bity;
                          
                            if (counter >= textBinary.Length)
                                break;
                        }
                        
                    }
                    if (audio.bitsPerSample == 16)
                    {

                        uint quant2 = CalculateSumPowerOfTwo((int)audio.bitsPerSample) - CalculateSumPowerOfTwo(bity);
                        uint quant = (uint)((0xFFFF << bity) & 0xFFFF);
                        for (int i = 0; i < audio.samples.Count; i++)
                        {
                            uint sampleValue = audio.samples[i];
                            sampleValue = (sampleValue & (uint)quant);
                            sampleValue |= Convert.ToUInt16(textBinary.Substring(counter, bity), 2);
                            audio.samples[i] = sampleValue;
                            counter += bity;
                          
                            if (counter >= textBinary.Length)
                                break;
                        }
                    }
                    audio.Save(counter/ bity);

                    return audio;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                return null;
            }

        }

        public string DecryptBinaryInWave(byte[] wav, int bity, out string extension)
        {
            try
            {
                WaveFille audio = new WaveFille(wav);
                int counter = 0, ammountToTake = 0, elementsToSkip = 0;
                string maxsize = Convert.ToString(audio.totalSamples * bity, 2);
                uint andBity = 0;// CalculateSumPowerOfTwo(bity);
                if (audio.bitsPerSample == 8)
                {
                    andBity = (uint)(0xFF >> (8 - bity));
                }
                if (audio.bitsPerSample == 16)
                {
                    andBity = (uint)(0xFFFF >> (16 - bity));
                }
                extension = "";
                StringBuilder binaryDataStringBiulder = new StringBuilder();
                if (bity <= audio.bitsPerSample)
                {
                    for (int i = 0; i < audio.samples.Count; i++)
                    {
                        uint samplequant = audio.samples[i] & (uint)andBity;
                        binaryDataStringBiulder.Append(Convert.ToString(samplequant, 2).PadLeft(bity, '0'));
                        if (binaryDataStringBiulder.Length >= maxsize.Length + extensionLenghtBinary)
                        {
                            extension = convertBinaryToString(binaryDataStringBiulder.ToString().Substring(0, extensionLenghtBinary));
                            counter = Convert.ToInt32(binaryDataStringBiulder.ToString().Substring(extensionLenghtBinary, maxsize.Length), 2) + extensionLenghtBinary + maxsize.Length;
                            ammountToTake = Convert.ToInt32(binaryDataStringBiulder.ToString().Substring(extensionLenghtBinary, maxsize.Length), 2);

                            binaryDataStringBiulder.Clear();
                            elementsToSkip = maxsize.Length + extensionLenghtBinary;
                            break;
                        }

                    }

                    for (int i = 0; i < audio.samples.Count && counter > 0; i++)
                    {
                        uint samplequant = audio.samples[i] & (uint)andBity;
                        binaryDataStringBiulder.Append(Convert.ToString(samplequant, 2).PadLeft(bity, '0'));
                        counter-= bity;
                    }
                    return binaryDataStringBiulder.ToString().Substring(elementsToSkip).Substring(0, ammountToTake);
                }
                return null;
            }
            catch (Exception ex)
            {
                extension = "";
                return null;
            }
        }

        public string CheckWav(WaveFille audio)
        {
            StringBuilder textBinary = new StringBuilder();

            string extension = "";
            uint andBity = 0;
            for (int bity = 1; bity <= audio.bitsPerSample; bity++)
            {
                //andBity = CalculateSumPowerOfTwo(bity);
                if (audio.bitsPerSample == 8)
                {
                    andBity = (uint)(0xFF >> (8 - bity));
                }
                if (audio.bitsPerSample == 16)
                {
                    andBity = (uint)(0xFFFF >> (16 - bity));
                }
                for (int j = 0; j < extensionLenghtBinary; j++)
                {
                    uint samplequant = audio.samples[j] & (uint)andBity;
                    textBinary.Append(Convert.ToString(samplequant, 2).PadLeft(bity, '0'));
                    if (textBinary.Length >= extensionLenghtBinary)
                    {
                        extension = convertBinaryToString(textBinary.ToString().Substring(0, extensionLenghtBinary));
                        if (extensionsList.Contains(extension))
                        {
                            return "Plik wav jest steganografem i zawiera plik z rozszeżeniem " + extension;
                        }
                        textBinary.Clear();
                        break;
                    }
                }   
            }
            return "Plik wav nie jest steganografem";

        }
    }
}
