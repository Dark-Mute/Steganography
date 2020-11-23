using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class WaveFille
    {
        public byte[] data;
        public uint channels { get; private set; }
        public uint bitsPerSample { get; private set; }

        private readonly int start = 0x2E;
        public uint totalSamples { get; private set; }
        public List<uint> samples;

        public WaveFille(byte[] data)
        {
            this.data = data;
            channels = BitConverter.ToUInt16(data, 0x16);
            bitsPerSample = BitConverter.ToUInt16(data, 0x22);
            if (bitsPerSample == 8 || bitsPerSample == 16 )
            {
                
                totalSamples = (BitConverter.ToUInt32(data, 0x28)) / (bitsPerSample / 8);// / channels) / (bitsPerSample / 8);
                samples = new List<uint>();
                int i = 0;
                for (int n = 0; n < totalSamples; n++)
                {
                    switch (bitsPerSample)
                    {
                        case 8:
                            samples.Add(data[start + i]);
                            break;
                        case 16:
                        default:
                            samples.Add(BitConverter.ToUInt16(data, start + i));
                            break;
                    }
                    i += (int)(bitsPerSample / 8);
                }
               
            }
            else
            {
                this.data = null;
            }
        }

        public void Save(int changed)
        {
            if (bitsPerSample == 8 || bitsPerSample == 16 )
            {
                int i = 0;
                for (int n = 0; n <= changed; n++)
                {
                    switch (bitsPerSample)
                    {
                        case 8:
                            data[start + i] = (byte)samples[n];
                            break;
                        case 16:
                            data[start + i] = (byte)(samples[n] & 0xFF);
                            data[start + i + 1] = (byte)((samples[n] >> 8) & 0xFF);
                            break;           
                    }
                    i += (int)(bitsPerSample / 8);
                }
            }
        }
    }
}
