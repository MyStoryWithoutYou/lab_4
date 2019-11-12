using System;
using System.IO;

namespace lab_4
{
    public class Controller : ISwitchable
    {
        OLED_tv oledTv = new OLED_tv();
        LCD_tv lcdTv = new LCD_tv();
        
        Tv[] tvArray = new Tv[2];

        string str1 = "";

        Services services = new Services();

        public void readExample()
        {
            using (FileStream fstream = File.OpenRead($"/Users/aliakseihudyma/RiderProjects/лабы 2 курс/lab_4/input.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                string[] words = textFromFile.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                int j = 0;
                oledTv.Model = words[j];
                oledTv.Age = int.Parse(words[j += 1]);
                oledTv.NumOfChannels = int.Parse(words[j += 1]);
                oledTv.Diagonal = int.Parse(words[j += 1]);
                oledTv.ColorDepth = int.Parse(words[j += 1]);
                oledTv.RefreshRate = int.Parse(words[j += 1]);

                lcdTv.Model = words[j += 1];
                lcdTv.Age = int.Parse(words[j += 1]);
                lcdTv.NumOfChannels = int.Parse(words[j += 1]);
                lcdTv.Diagonal = int.Parse(words[j += 1]);
                lcdTv.Brightness = int.Parse(words[j += 1]);
                lcdTv.RefreshRate = int.Parse(words[j += 1]);

                if (fstream != null)
                {
                    fstream.Close();
                }
            }
        }

        public void exampleIntoArray()
        {
            tvArray[0] = oledTv;
            tvArray[1] = lcdTv;
        }

        public void printUnsortedArray()
        {
            foreach (Tv tv in tvArray)
            {
                Console.WriteLine(tv);
            }
        }
        public void chooseAccordingToParameters()
        {
            Console.WriteLine("\nВвод диапазона диагонали");
            services.enterRange();
            
            Console.WriteLine("\n***** Телевизоры с заданным диапазоном диагонали *****");
            foreach (Tv tv in tvArray)
            {
                if (tv.Diagonal > services.StartRange & tv.Diagonal < services.EndRange)
                {
                    Console.WriteLine(tv);
                    
                    str1 = tv.ToString();
                }
            }
            
            string str = str1;
            
            using (FileStream fstream = new FileStream($"/Users/aliakseihudyma/RiderProjects/лабы 2 курс/lab_4/output.txt", FileMode.OpenOrCreate))//starting a stream of writing into a file
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(str);//transforming string into bytes
                fstream.Write(array, 0, array.Length);//writing bytes into the file
            }
        }

        public void bubbleSort()
        {
            Tv temp;
            for (int i = 0; i < tvArray.Length - 1; i++)
            {
                bool f = false;
                for (int j = 0; j < tvArray.Length - i - 1; j++)
                {
                    if (tvArray[j+1].NumOfChannels < tvArray[j].NumOfChannels)
                    {
                        f = true;
                        temp = tvArray[j+1];
                        tvArray[j+1] = tvArray[j];
                        tvArray[j] = temp;
                    }                   
                }
                if(!f) break;
            }
            Console.WriteLine("\n***** Минимальный элемент по количеству каналов *****");
            Console.WriteLine(tvArray[0]);
        }
        public Controller()
        {
           
        }

        public string switchOn()
        {
            return "Телевизор включен";
        }

        public string switchOff()
        {
            return "Телевизор выключен";
        }
    }
}