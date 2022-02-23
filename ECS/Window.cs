namespace ECS;

public class Window
{
    public void Open()
    {
        System.Console.WriteLine("Window is opening");
    }

    public void Close()
    {
        System.Console.WriteLine("Window is closing");
    }

    public bool RunSelfTest()
    {
        return true;
    }
}