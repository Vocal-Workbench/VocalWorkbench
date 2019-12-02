using ReactiveUI;
using VocalWorkbench.Apps.Desktop.Features.Splash.ViewModels;

namespace VocalWorkbench.Apps.Desktop.Features.Splash.Views
{
    public partial class SplashWindow : IViewFor<SplashWindowViewModel>
    {
        private SplashWindowViewModel _viewModel;

        public SplashWindow()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {

            });
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = value as SplashWindowViewModel;
        }

        public SplashWindowViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                _viewModel = value;
                DataContext = value;
            }
        }
    }
}
