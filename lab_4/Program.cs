﻿using System;

namespace lab_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.readExample();
            controller.exampleIntoArray();
            controller.printUnsortedArray();
            controller.chooseAccordingToParameters();
            controller.bubbleSort();
            controller.turnOn();
            controller.turnOff();
        }
    }
}