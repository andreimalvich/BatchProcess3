using BatchProcess3.MainApp;

namespace BatchProcess3.ViewModels.Pages;

public partial class SettingsPageViewModel() : PageViewModel(ApplicationPageNames.Settings)
{
    public string Test { get; set; } = "Settings";
}
