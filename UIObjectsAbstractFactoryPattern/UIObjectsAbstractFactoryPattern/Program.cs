using UIObjectsAbstractFactoryPattern;
using UIObjectsAbstractFactoryPattern.Factories;

IUIFactory macFactory = MacFactory.GetInstance();
IUIFactory windowsFactory = WindowsFactory.GetInstance();

Application macApplication = new(macFactory);
macApplication.RenderComponents();

Application windowsApplication = new(windowsFactory);
windowsApplication.RenderComponents();
