using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MvvmTemplate.ViewModels;

public class SecondPageViewModel : ObservableObject
{
	private int count;

	public SecondPageViewModel()
	{
		IncrementCountCommand = new RelayCommand(IncrementCount);
	}

	public IRelayCommand IncrementCountCommand { get; }

	public int Count
	{
		get => count;
		private set => SetProperty(ref count, value);
	}

	private void IncrementCount()
	{
		Count++;
	}
}