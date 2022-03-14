using CommunityToolkit.Mvvm.ComponentModel;

namespace MvvmTemplate.Objects
{
    [INotifyPropertyChanged]
    public partial class TestClass
    {
        [ObservableProperty] 
        public int number;
        [ObservableProperty]
        public string text;
    }
}
