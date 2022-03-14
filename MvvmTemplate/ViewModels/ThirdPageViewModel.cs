using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MvvmTemplate.Objects;

namespace MvvmTemplate.ViewModels;

public partial class ThirdPageViewModel : ObservableObject
{

    [ObservableProperty] 
    private TestClass customObject = new()
    {
        Text = "Property from Object:"
    };

    [ObservableProperty]
    private int count;

    [ICommand]
    private void IncrementCount()
	{
		Count++;
        CustomObject.Number++;
    }
}