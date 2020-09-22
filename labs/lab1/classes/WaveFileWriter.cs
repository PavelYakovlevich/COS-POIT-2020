using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab1.classes
{
    class WaveFileWriter
    {
        public readonly byte[] RIFF_HEADER = new byte[] { 0x52, 0x49, 0x46, 0x46 };
        public readonly byte[] FORMAT_WAVE = new byte[] { 0x57, 0x41, 0x56, 0x45 };
        public readonly byte[] FORMAT_TAG = new byte[] { 0x66, 0x6d, 0x74, 0x20 };
        public readonly byte[] AUDIO_FORMAT = new byte[] { 0x01, 0x00 };
        public readonly byte[] SUBCHUNK_ID = new byte[4] { 0x64, 0x61, 0x74, 0x61 };
        public const int BYTES_PER_SAMPLE = 2;

        private byte[] PackageInt(long source, int length = 2)
        {
            if ((length != 2) && (length != 4) && (length != 8))
                throw new ArgumentException("length must be either 2 or 4 or 8", "length");
            byte[] retVal = new byte[length];
            byte offset = 0;

            for (int i = 0; i < length; i++)
            {
                retVal[i] = (byte)((source >> offset) & 0xFF);
                offset += 8;
            }

            return retVal;
        }

        private void WriteHeader(System.IO.Stream targetStream, int byteStreamSize, int channelCount, int sampleRate)
        {
            int byteRate = sampleRate * channelCount * BYTES_PER_SAMPLE;
            int blockAlign = channelCount * BYTES_PER_SAMPLE;

            targetStream.Write(RIFF_HEADER, 0, RIFF_HEADER.Length);
            targetStream.Write(PackageInt(byteStreamSize + 42, 4), 0, 4);

            targetStream.Write(FORMAT_WAVE, 0, FORMAT_WAVE.Length);
            targetStream.Write(FORMAT_TAG, 0, FORMAT_TAG.Length);
            targetStream.Write(PackageInt(16, 4), 0, 4);//Subchunk1Size    

            targetStream.Write(AUDIO_FORMAT, 0, AUDIO_FORMAT.Length);//AudioFormat   
            targetStream.Write(PackageInt(channelCount, 2), 0, 2);
            targetStream.Write(PackageInt(sampleRate, 4), 0, 4);
            targetStream.Write(PackageInt(byteRate, 4), 0, 4);
            targetStream.Write(PackageInt(blockAlign, 2), 0, 2);
            targetStream.Write(PackageInt(BYTES_PER_SAMPLE * 8), 0, 2);
            //targetStream.Write(PackageInt(0,2), 0, 2);//Extra param size
            targetStream.Write(SUBCHUNK_ID, 0, SUBCHUNK_ID.Length);
            targetStream.Write(PackageInt(byteStreamSize, 4), 0, 4);
        }

        public void RecordSignal(string fileName, List<short> values)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                WriteHeader(fs, values.Count * sizeof(short), 1, 44100);
                byte[] soundData = GetSoundData(values);
                fs.Write(soundData, 0, soundData.Length);
                fs.Close();
            }
        }

        private byte[] GetSoundData(List<short> values)
        {
            byte[] res = new byte[values.Count * sizeof(short)];

            Buffer.BlockCopy(values.ToArray(), 0, res, 0, res.Length);

            return res;
        }
    }
}
