﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmplifierApplication
{
    class Amplifier
    {
        private int maxVolume = 100;
        private int minVolume = 0;
        private int volume;

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
