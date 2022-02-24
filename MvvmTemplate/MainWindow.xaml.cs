using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace MvvmTemplate;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        DataContext = Ioc.Default.GetRequiredService<MainViewModel>();
    }
}