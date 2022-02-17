using NUnit.Framework;

namespace ECS.Unit.Test
{
    public class Tests
    {
        private ECS uut;
        [SetUp]
        public void Setup()
        {
            Heater heater = new Heater();
            FakeTempSensor fakeTempSensor = new FakeTempSensor();
            uut = new ECS(23, heater, fakeTempSensor);
        }

        [Test]
        public void Test_tempSensor_GetCurTemp_Lig_69()
        {
            int w = uut.GetCurTemp();
            Assert.AreEqual(69, uut.GetCurTemp());
        }


        [Test]
        public void Test_RunSelfTest_Is_True()
        {
            Assert.AreEqual(true, uut.RunSelfTest()); //tester runSelfTest
        }


    }
}