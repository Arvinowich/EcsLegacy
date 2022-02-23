using System;
using System.Security.Principal;

namespace ECS
{
    public class ECS
    {
        private int _threshold;
        private int _windowThreshold;
        private readonly ITempSensor _tempSensor;
        private readonly IHeater _heater;

        public ECS(int thr, IHeater heater, ITempSensor tempSensor)
        {
            SetThreshold(thr);
            _tempSensor = tempSensor;
            _heater = heater;
        }
        
        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            Console.WriteLine($"Temperatur measured was {t}");
            if (t < _threshold)
            {
                _heater.TurnOn();
            }
            else
            {
                _heater.TurnOff();
            }


        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }
        
        public void SetWindowThreshold(int thr)
        {
            _windowThreshold = thr;
        }

        public int GetWindowThreshold()
        {
            return _windowThreshold;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}
