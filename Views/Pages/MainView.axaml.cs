using Avalonia.Controls;
using BatchProcess3.ViewModels;

using BatchProcess3.ViewModels.Pages;
namespace BatchProcess3.Views.Pages;

public partial class MainView : Window
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Svg_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e)
    {
        if (e.ClickCount != 2)
        {
            return;
        }

        (DataContext as MainViewModel)?.SideMenuResizeCommand?.Execute(null);        
    }
}