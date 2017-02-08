using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Radio
    {
        private int minVolume = 0;
        private int maxVolume = 9;
        private int volume;
        private double minChannel = 20000.0;
        private double maxChannel = 26000.0;
        private double channel;
        public bool Power;


        public double Channel
        {
            get
            {
                return channel;
            }
            set
            {
                if (value <= maxChannel && value >= minChannel) channel = value;
                else if (value > maxChannel)
                {
                    channel = maxChannel;
                }
                else if (value < minChannel)
                {
                    channel = minChannel;
                }
            }
        }

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= maxVolume && value >= minVolume) volume = value;
                else if (value > maxVolume)
                {
                    volume = maxVolume;
                }
                else if (value < minVolume)
                {
                    volume = minVolume;
                }
            }
        }
    }
}