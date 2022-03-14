using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;
using MvvmTemplate.IServices;
using MvvmTemplate.Services;
using MvvmTemplate.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace MvvmTemplate;

/// <summary>
///     Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        var conventionViewFactory = new NamingConventionViewFactory();

        Ioc.Default.ConfigureServices(
            new ServiceCollection()
                //Services
                .AddSingleton<ISettingsService, SettingsService>()
                // //Page ViewModels
                .AddTransient<FirstPageViewModel>()
                .AddTransient<SecondPageViewModel>()
                .AddTransient<ThirdPageViewModel>()
                //WPF
                .AddSingleton<MainViewModel>()
                //.AddSingleton<IViewFactory>(mappingViewFactory)
                .AddSingleton<IViewFactory>(conventionViewFactory)
                .BuildServiceProvider());
    }
}