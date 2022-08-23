using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioFlow.Playable
{
    /// <summary>
    /// Обертка для реализаций ISampleProvider из NAudio.
    /// </summary>
    public class NA_PlayableItem : IPlayableItem
    {
        private ISampleProvider _source;

        public int SamplesRate => _source.WaveFormat.SampleRate;

        public bool IsEnded {get; private set;}

        public float[] ReadFragment(int length)
        {
            float[] buffer=new float[length];
            int samplesRead=_source.Read(buffer, 0, length);
            if (samplesRead < length)
            {
                IsEnded = true;
            }
            return buffer;
        }
    }
}
