using System;

namespace lab_4
{
    public class OLED_tv : Tv
    {
        private int colorDepth;

        public int ColorDepth
        {
            get
            {
                return colorDepth;
                
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Передана некорректная яркость");
                }
                else
                {
                    colorDepth = value;
                }
            }
        }
        
        private int refreshRate;

        public int RefreshRate
        {
            get
            {
                return refreshRate;
                
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Передана некорректная частота обновления");
                }
                else
                {
                    refreshRate = value;
                }
            }
        }
        
        public override string ToString()
        {
            return "\nМодель: " + Model + ", срок службы: " + Age + ", количество каналов: " + NumOfChannels + ", диагональ: " + Diagonal + ", глубина цвета: " + ColorDepth + ", частота обновления: " + RefreshRate;
        }
    }
}