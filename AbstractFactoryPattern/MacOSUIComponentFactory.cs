// macOS Factory found in the project name AbstractFactoryPattern under the solution folder name AbstractFactory Pattern

using InterfacePattern;

namespace AbstractFactoryPattern;
public class MacOSUIComponentFactory : IUIComponentFactory
{
    public IButton CreateButton()
    {
        return new MacOSButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacOSCheckbox();
    }
}
