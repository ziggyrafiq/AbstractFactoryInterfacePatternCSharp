// macOS Concrete Products found in the project name AbstractFactoryPattern under the solution folder name AbstractFactory Pattern

using InterfacePattern;

namespace AbstractFactoryPattern;

public class MacOSButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a macOS style button.");
    }
}
