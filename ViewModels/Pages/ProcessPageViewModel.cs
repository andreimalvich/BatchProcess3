using BatchProcess3.MainApp;

namespace BatchProcess3.ViewModels.Pages;

public partial class ProcessPageViewModel() : PageViewModel(ApplicationPageNames.Process)
{
    public string Test { get; set; } = "Process";     
}
