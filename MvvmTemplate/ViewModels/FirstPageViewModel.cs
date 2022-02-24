using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MvvmTemplate.ViewModels;

public class FirstPageViewModel : ObservableObject
{
    private string text = "First Page: Text From ViewModel";

    private string textLoaded;

    public FirstPageViewModel()
    {
        LoadCommand = new RelayCommand(PageLoaded);
    }

    public IRelayCommand LoadCommand { get; }

    public string Text
    {
        get => text;
        private set => SetProperty(ref text, value);
    }

    public string TextLoaded
    {
        get => textLoaded;
        private set => SetProperty(ref textLoaded, value);
    }

    public void PageLoaded()
    {
        TextLoaded = "First Page: Text From ViewModel On View Loaded";
    }
}