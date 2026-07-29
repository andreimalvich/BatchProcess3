using BatchProcess3.MainApp;

namespace BatchProcess3.ViewModels.Pages;

public partial class HistoryPageViewModel() : PageViewModel(ApplicationPageNames.History)
{
    public string Test { get; set; } = "History";
}
