// Windows Factory found in the project name AbstractFactoryPattern under the solution folder name AbstractFactory Pattern

using InterfacePattern;

namespace AbstractFactoryPattern;
public class WindowsUIComponentFactory : IUIComponentFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WindowsCheckbox();
    }
}
