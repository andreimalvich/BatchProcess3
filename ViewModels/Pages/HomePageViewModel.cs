using BatchProcess3.MainApp;

namespace BatchProcess3.ViewModels.Pages;

public partial class HomePageViewModel() : PageViewModel(ApplicationPageNames.Home)
{
    public string Test { get; set; } = "Home";
}
