using System;

namespace lab_4
{
    public class Tv
    {
        private string model;

        public string Model
        {
            get
            {
                return model;
            }
            set
            { 
                if (value.Length == 0 || value.Trim() == string.Empty)
                {
                    Console.WriteLine("Передана некорректная модель");
                    model = "Телевизор";
                }
                else
                {
                    model = value;
                }
            }
        }
        
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Передано некорректное значение возраста");
                    age = 3;
                }
                else
                {
                    age = value;
                }
            }
        }

        private int numOfChannels;

        public int NumOfChannels
        {
            get
            {
                return numOfChannels;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Передано некорректное количество каналов");
                    numOfChannels = 5;
                }
                else
                {
                    numOfChannels = value;

                }
            }
        }

        private int diagonal;

        public int Diagonal
        {
            get
            {
                return diagonal;
            }
            set
            {
                if (value <= 20)
                {
                    Console.WriteLine("Передано некорректное значение диагонали");
                    diagonal = 32;
                }
                else
                {
                    diagonal = value;
                }
            }
        }

        public Tv(string model, int age, int numOfChannels, int diagonal)
        {
            Model = model;
            Age = age;
            NumOfChannels = numOfChannels;
            Diagonal = diagonal;
        }

        public Tv()
        {
            
        }

        public override string ToString()
        {
            return "\nМодель: " + Model + ", срок службы: " + Age + ", количество каналов: " + NumOfChannels +
                   ", диагональ: " + Diagonal;
        }
    }
}
