namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startKilometers;
        private double _endKilometers;
        private double _liters;

        public Car(double startOdo)
        {
            _startKilometers = startOdo;
        }

        public Car(double startOdo, double endingOdo, double liters)
        {
            _startKilometers = startOdo;
            _endKilometers = endingOdo;
            _liters = liters;
        }

        public double CalculateConsumption()
        {
            return _liters / _endKilometers;
        }

        private double ConsumptionPer100Km()
        {
            return CalculateConsumption() * 100;
        }

        public bool GasHog()
        {
            if (ConsumptionPer100Km() > 15)
            {
                return true;
            }

            return false;
        }

        public bool EconomyCar()
        {
            if (ConsumptionPer100Km() < 5)
            {
                return true;
            }

            return false;
        }

        public void FillUp(int mileage, double liters)
        {
            _startKilometers += mileage;
            _liters += liters;
        }
    }
}
