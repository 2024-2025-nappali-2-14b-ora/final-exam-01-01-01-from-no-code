using CommunityToolkit.Mvvm.ComponentModel;

namespace KretaProject.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private object _currentView;

        private readonly StudentViewModel _studentViewModel;
        private readonly ControlPanelViewModel _controlPanelViewModel;
        private readonly SchoolClassViewModel _schoolClassViewModel;

        public MainViewModel()
        {
            _studentViewModel = new StudentViewModel();
            _controlPanelViewModel = new ControlPanelViewModel();
            _schoolClassViewModel = new SchoolClassViewModel();
            CurrentView = _controlPanelViewModel;
        }
    }
}
