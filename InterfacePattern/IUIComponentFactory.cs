// // Abstract Factory Interface found in the project name InterfacePattern under the solution folder name Interface Pattern

namespace InterfacePattern;
public interface IUIComponentFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}
