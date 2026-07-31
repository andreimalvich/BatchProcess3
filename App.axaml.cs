using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Metadata;
using BatchProcess3.Bootstrapp;
using BatchProcess3.ViewModels.Pages;
using BatchProcess3.Views.Pages;
using Microsoft.Extensions.DependencyInjection;

// Первым аргументом идет глобальная ссылка Avalonia, вторым - ваш C# namespace - 
// «подмешать» ваше пространство имен C# прямо внутрь глобального URL-адреса Avalonia.
[assembly: XmlnsDefinition("https://github.com/avaloniaui", "BatchProcess3.Controls")]

namespace BatchProcess3;

public partial class App : Application
{    
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
       // DataTemplates.Add(new ViewLocator());  если не прописать в axaml или если есть параметры
    }

    public override void OnFrameworkInitializationCompleted()
    {
        var collection = new ServiceCollection();        
        
        Bootstrapper.RegisterCommonServices(collection);

        var services = collection.BuildServiceProvider();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainView
            {
                DataContext = services.GetRequiredService<MainViewModel>()
            }; 
        }

        base.OnFrameworkInitializationCompleted();
    }
}