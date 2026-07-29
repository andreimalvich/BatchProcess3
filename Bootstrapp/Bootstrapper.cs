using BatchProcess3.MainApp;
using BatchProcess3.ViewModels.Pages;
using Microsoft.Extensions.DependencyInjection;
using System;

using HomePageViewModel = BatchProcess3.ViewModels.Pages.HomePageViewModel;
using MainViewModel = BatchProcess3.ViewModels.Pages.MainViewModel;

namespace BatchProcess3.Bootstrapp;

public static class Bootstrapper
{
    public static void RegisterCommonServices(IServiceCollection collection)
    {
        // Singleton Services
        collection.AddSingleton<MainViewModel>();
        collection.AddSingleton<HomePageViewModel>();

        //// Page Factory Callback
        //collection.AddSingleton<Func<Type, PageViewModel>>(x => type => type switch
        //{
        //    _ when type == typeof(HomePageViewModel) => x.GetRequiredService<HomePageViewModel>(),
        //    _ when type == typeof(ProcessPageViewModel) => x.GetRequiredService<ProcessPageViewModel>(),
        //    _ when type == typeof(MacrosPageViewModel) => x.GetRequiredService<MacrosPageViewModel>(),
        //    _ when type == typeof(ActionsPageViewModel) => x.GetRequiredService<ActionsPageViewModel>(),
        //    _ when type == typeof(ReporterPageViewModel) => x.GetRequiredService<ReporterPageViewModel>(),
        //    _ when type == typeof(HistoryPageViewModel) => x.GetRequiredService<HistoryPageViewModel>(),
        //    _ when type == typeof(SettingsPageViewModel) => x.GetRequiredService<SettingsPageViewModel>(),

        //    _ => throw new InvalidOperationException($"Page of type {type?.FullName} has no view model"),

        //});

        // Абсолютно динамическая фабрика страниц
        collection.AddSingleton<Func<Type, PageViewModel>>(x => type =>
            (PageViewModel)x.GetRequiredService(type ?? throw new ArgumentNullException(nameof(type))));


        // Page Factory
        collection.AddSingleton<PageFactory>();

        // Transient Services
        collection.AddTransient<ActionsPageViewModel>();
        collection.AddTransient<HistoryPageViewModel>();
        collection.AddTransient<MacrosPageViewModel>();
        collection.AddTransient<ProcessPageViewModel>();
        collection.AddTransient<ReporterPageViewModel>();
        collection.AddTransient<SettingsPageViewModel>();

    }
}
