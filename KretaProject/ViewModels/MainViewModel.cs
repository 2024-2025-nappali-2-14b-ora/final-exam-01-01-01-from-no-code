using CommunityToolkit.Mvvm.ComponentModel;

namespace KretaProject.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private object _currentView;
    }
}
