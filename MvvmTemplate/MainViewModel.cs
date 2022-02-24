using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using MvvmTemplate.ViewModels;

namespace MvvmTemplate;

public class MainViewModel : ObservableObject
{
    private ObservableObject? _selectedViewModel;

    public MainViewModel()
    {
        ShowFirstViewModel =
            new RelayCommand(() => SelectedViewModel = Ioc.Default.GetRequiredService<FirstPageViewModel>());
        ShowSecondViewModel =
            new RelayCommand(() => SelectedViewModel = Ioc.Default.GetRequiredService<SecondPageViewModel>());

        SelectedViewModel = Ioc.Default.GetRequiredService<FirstPageViewModel>();
    }

    public ICommand ShowFirstViewModel { get; }
    public ICommand ShowSecondViewModel { get; }

    public ObservableObject? SelectedViewModel
    {
        get => _selectedViewModel;
        set => SetProperty(ref _selectedViewModel, value);
    }
}