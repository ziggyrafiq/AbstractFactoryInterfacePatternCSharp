// Client Class can be found in the project name ClientApplication under the solution folder name Client Application
using InterfacePattern;

namespace ClientApplication;
public class Client
{
    private readonly IUIComponentFactory _factory;

    public Client(IUIComponentFactory factory)
    {
        _factory = factory;
    }

    public void RenderUI()
    {
        IButton button = _factory.CreateButton();
        ICheckbox checkbox = _factory.CreateCheckbox();

        button.Render();
        checkbox.Render();
    }
}
