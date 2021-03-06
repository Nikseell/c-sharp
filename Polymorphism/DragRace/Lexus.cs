using System;

namespace DragRace
{
    public class Lexus : ICar, INitrous
    {
        private int currentSpeed = 0;

        public void SpeedUp()
        {
            currentSpeed += 17;
        }

        public void SlowDown()
        {
            currentSpeed += 17;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string ShowCarName()
        {
            return "Lexus";
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 20;
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}