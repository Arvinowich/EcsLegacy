namespace ECS
{
    public class Heater : IHeater
    {
        public bool heaterOn = false;      
        public void TurnOn()
        {
            System.Console.WriteLine("Heater is on");
            heaterOn = true;
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off");
            heaterOn = false;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}