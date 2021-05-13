using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    interface ICar
    {
        void SpeedUp();

        void SlowDown();

        string ShowCurrentSpeed();

        string ShowCarName();

        void StartEngine();
    }
}
