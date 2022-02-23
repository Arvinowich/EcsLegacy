using System;
using NUnit.Framework;

namespace ECS.Unit.Test
{
    public class Tests
    {
        private ECS uut;
        [SetUp]
        public void Setup()
        {
            FakeHeater fakeHeater = new FakeHeater();
            //Heater heater = new Heater();
            FakeTempSensor fakeTempSensor = new FakeTempSensor();
            uut = new ECS(23, fakeHeater, fakeTempSensor);
        }

        [Test]
        public void Test_tempSensor_GetCurTemp_Lig_69()
        {
            int w = uut.GetCurTemp();
            Assert.AreEqual(69, uut.GetCurTemp());
        }


        [Test]
        public void Test_RunSelfTestTempSensor_Is_True()
        {
            Assert.AreEqual(true, uut.RunSelfTest()); //tester runSelfTest
        }

        
        [Test]
        public void Test_RunSelfTestHeater_Is_True()
        {
            Assert.AreEqual(true, uut.RunSelfTest()); //tester runSelfTest
        }
        
        [Test]
        public void Test_setThreshold_69()
        {
            uut.SetThreshold(69);
            Assert.AreEqual(69, uut.GetThreshold()); //tester runSelfTest
        }
        
        [Test]
        public void Test_Regulate_ExceptionsForPrints_tempBiggerThanThreshold()
        {
            Assert.That( () => uut.Regulate(), Throws.TypeOf<NotSupportedException>());
        }
        
        [Test]
        public void Test_Regulate_ExceptionsForPrints_tempLessThanThreshold()
        {
            uut.SetThreshold(100);
            Assert.That( () => uut.Regulate(), Throws.TypeOf<NotImplementedException>());
        }
        
        //Så langt så godt
    }
}