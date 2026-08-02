using BatchProcess3.MainApp;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BatchProcess3.ViewModels.Pages;

public partial class ActionsPageViewModel() : PageViewModel(ApplicationPageNames.Actions)
{   
    public string Test { get; set; } = "Action";
}
