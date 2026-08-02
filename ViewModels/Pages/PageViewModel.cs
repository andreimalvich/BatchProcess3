using BatchProcess3.MainApp;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BatchProcess3.ViewModels.Pages;

public partial class PageViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial ApplicationPageNames PageName { get; set; } 

    protected PageViewModel(ApplicationPageNames pageName)
    {
        PageName = pageName;
    }
}