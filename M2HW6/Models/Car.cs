using M2HW6.Enums;

namespace M2HW6.Models
{
    public class Car : Transport
    {
        public Car(string name, DateTime dateOfManufacture, GearboxType gearbox, double accelerationTo100KM, double engineCapacity)
            : base(name, dateOfManufacture)
        {
            Gearbox = gearbox;
            AccelerationTo100KM = accelerationTo100KM;
            EngineCapacity = engineCapacity;
        }

        public GearboxType Gearbox { get; set; }
        public double AccelerationTo100KM { get; set; }
        public double EngineCapacity { get; set; }
    }
}
