using System;

namespace lab_4
{
    public class Services
    {
        private int startRange;
        private int endRange;
        private int minimal;
        private int average;

        public int Minimal
        {
            get { return minimal; }
            set { minimal = value; }
        }
        
        public int Average
        {
            get { return average; }
            set { average = value; }
        }

        public int StartRange
        {
            get { return startRange; }
            set { startRange = value; }
        }
        
        public int EndRange
        {
            get { return endRange; }
            set { endRange = value; }
        }


        public void enterRange()
        {
            Console.WriteLine("Введите начало диапазона: ");
            startRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона: ");
            endRange = Convert.ToInt32(Console.ReadLine());
        }
    }
}