using BatchProcess3.MainApp;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace BatchProcess3.ViewModels.Pages;

public partial class MainViewModel : ViewModelBase
{
    private readonly PageFactory _pageFactory;


    [ObservableProperty]    
    private bool _sideMenuExpanded = true;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(HomePageIsActive))]
    [NotifyPropertyChangedFor(nameof(ProcessPageIsActive))]
    [NotifyPropertyChangedFor(nameof(ActionsPageIsActive))]
    [NotifyPropertyChangedFor(nameof(MacrosPageIsActive))]
    [NotifyPropertyChangedFor(nameof(ReporterPageIsActive))]
    [NotifyPropertyChangedFor(nameof(HistoryPageIsActive))]
    [NotifyPropertyChangedFor(nameof(SettingsPageIsActive))]
    private PageViewModel _currentPage;

    public bool HomePageIsActive => CurrentPage.PageName == ApplicationPageNames.Home;
    public bool ProcessPageIsActive => CurrentPage.PageName == ApplicationPageNames.Process;
    public bool ActionsPageIsActive => CurrentPage.PageName == ApplicationPageNames.Actions;
    public bool MacrosPageIsActive => CurrentPage.PageName == ApplicationPageNames.Macros;
    public bool ReporterPageIsActive => CurrentPage.PageName == ApplicationPageNames.Reporter;
    public bool HistoryPageIsActive => CurrentPage.PageName == ApplicationPageNames.History;
    public bool SettingsPageIsActive => CurrentPage.PageName == ApplicationPageNames.Settings;    

    public MainViewModel(PageFactory pageFactory)
    {
        _pageFactory = pageFactory ?? throw new ArgumentNullException(nameof(pageFactory));

        CurrentPage = _pageFactory.GetPageViewModel<SettingsPageViewModel>();
    }


    [RelayCommand]
    private void SideMenuResize() => SideMenuExpanded = !SideMenuExpanded;       
        

    [RelayCommand]
    private void GoToHomePage() => CurrentPage = _pageFactory.GetPageViewModel<HomePageViewModel>();    

    [RelayCommand]
    private void GoToProcessPage() => CurrentPage = _pageFactory.GetPageViewModel<ProcessPageViewModel>();

    [RelayCommand]
    private void GoToActionsPage() => CurrentPage = _pageFactory.GetPageViewModel<ActionsPageViewModel>();

    [RelayCommand]
    private void GoToMacrosPage() => CurrentPage = _pageFactory.GetPageViewModel<MacrosPageViewModel>();
    
    [RelayCommand]
    private void GoToReporterPage() => CurrentPage = _pageFactory.GetPageViewModel<ReporterPageViewModel>();
    
    [RelayCommand]
    private void GoToHistoryPage() => CurrentPage = _pageFactory.GetPageViewModel<HistoryPageViewModel>();
    
    [RelayCommand]
    private void GoToSettingsPage() => CurrentPage = _pageFactory.GetPageViewModel<SettingsPageViewModel>();
   
}
