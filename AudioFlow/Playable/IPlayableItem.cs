using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioFlow.Playable
{
    /// <summary>
    /// Базовый интерфейс для источника данных. Привязанные к аудиодвижкам реализации должны реализовывать его.
    /// </summary>
    public interface IPlayableItem
    {
        public int SamplesRate { get; }

        public bool IsEnded { get; }

        public float[] ReadFragment(int length);
    }
}
