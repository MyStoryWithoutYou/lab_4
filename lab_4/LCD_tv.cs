using System;

namespace lab_4
{
    public class LCD_tv : Tv
    {
        private int brightness;

        public int Brightness
        {
            get
            {
                return brightness;
                
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Передана некорректная яркость");
                }
                else
                {
                    brightness = value;
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

        public LCD_tv(string model, int age, int numOfChannels, int diagonal, int brightness, int refreshRate) : base(model, age, numOfChannels, diagonal)
        {
            this.brightness = brightness;
            this.refreshRate = refreshRate;
        }
        
        public LCD_tv()
        {
            
        }

        public override string ToString()
        {
            return "\nМодель: " + Model + ", срок службы: " + Age + ", количество каналов: " + NumOfChannels + ", диагональ: " + Diagonal + ", яркость: " + Brightness + ", частота обновления: " + RefreshRate;
        }
    }
}