using System.Windows;

namespace MvvmTemplate;

public interface IViewFactory
{
    FrameworkElement? ResolveView(object viewModel);
}