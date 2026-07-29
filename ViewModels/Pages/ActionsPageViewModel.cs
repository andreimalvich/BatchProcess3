using BatchProcess3.MainApp;

namespace BatchProcess3.ViewModels.Pages;

public partial class ActionsPageViewModel() : PageViewModel(ApplicationPageNames.Actions)
{
    public string Test { get; set; } = "Action";
}
