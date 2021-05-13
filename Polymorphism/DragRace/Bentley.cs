using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    class Bentley : ICar
    {
        private int currentSpeed = 0;

        public void SpeedUp()
        {
            currentSpeed += 13;
        }

        public void SlowDown()
        {
            currentSpeed += 13;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }
        public string ShowCarName()
        {
            return "Bentley";
        }

        public void StartEngine()
        {
            Console.WriteLine("-- silence ---");
        }
    }
}
