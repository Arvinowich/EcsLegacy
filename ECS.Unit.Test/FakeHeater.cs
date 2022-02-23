namespace ECS.Unit.Test;

public class FakeHeater : IHeater
{
    public void TurnOn()
    {
        throw new System.NotImplementedException();
    }

    public void TurnOff()
    {
        throw new System.NotSupportedException();
    }

    public bool RunSelfTest()
    {
        return true;
    }
}