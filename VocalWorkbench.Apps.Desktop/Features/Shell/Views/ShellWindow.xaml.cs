using ReactiveUI;
using VocalWorkbench.Apps.Desktop.Features.Shell.ViewModels;

namespace VocalWorkbench.Apps.Desktop.Features.Shell.Views
{
    public partial class ShellWindow : IViewFor<ShellWindowViewModel>
    {
        private ShellWindowViewModel _viewModel;

        public ShellWindow()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {

            });
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = value as ShellWindowViewModel;
        }

        public ShellWindowViewModel ViewModel
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
