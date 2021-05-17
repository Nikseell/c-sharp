using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    class MiniCooper: ICar, INitrous
    {
        private int currentSpeed = 0;

        public void SpeedUp()
        {
            currentSpeed += 30;
        }

        public void SlowDown()
        {
            currentSpeed += 30;
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 15;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string ShowCarName()
        {
            return "Mini Cooper";
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}
