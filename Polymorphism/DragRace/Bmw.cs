using System;

namespace DragRace
{
    public class Bmw : ICar
    {
        private int currentSpeed = 0;

        public void SpeedUp()
        {
            currentSpeed += 15;
        }

        public void SlowDown()
        {
            currentSpeed += 15;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string ShowCarName()
        {
            return "Bmw";
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}