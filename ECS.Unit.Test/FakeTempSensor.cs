using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Unit.Test
{
  class FakeTempSensor : ITempSensor
    {

        //private Random gen = new Random();


        public int GetTemp()
        {
            
            return 69;
        }


        public bool RunSelfTest()
        {
            return true;
        }
    }
}
