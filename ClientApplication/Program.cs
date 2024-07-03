// Program Class can be found in the project name ClientApplication under the solution folder name Client Application

using AbstractFactoryPattern;
using ClientApplication;
using InterfacePattern;

Console.WriteLine("Hello, from Ziggy Rafiq!");

// Client code using Windows factory
IUIComponentFactory windowsFactory = new WindowsUIComponentFactory();
Client windowsClient = new Client(windowsFactory);
windowsClient.RenderUI();

Console.WriteLine();

// Client code using macOS factory
IUIComponentFactory macOSFactory = new MacOSUIComponentFactory();
Client macOSClient = new Client(macOSFactory);
macOSClient.RenderUI();

