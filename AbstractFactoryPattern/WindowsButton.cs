// Windows Concrete Products found in the project name AbstractFactoryPattern under the solution folder name AbstractFactory Pattern

using InterfacePattern;

namespace AbstractFactoryPattern;
public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a Windows style button.");
    }

}
