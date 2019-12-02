using System;
using System.Reactive.Disposables;
using System.Windows;
using ReactiveUI;
using Splat;
using VocalWorkbench.Apps.Desktop.Features.Shell.ViewModels;
using VocalWorkbench.Apps.Desktop.Features.Shell.Views;

namespace VocalWorkbench.Apps.Desktop
{
    public partial class App : Application
    {
        public class BindingHookFixerer : IPropertyBindingHook
        {
            public bool ExecuteHook(object source, object target, Func<IObservedChange<object, object>[]> getCurrentViewModelProperties, Func<IObservedChange<object, object>[]> getCurrentViewProperties, BindingDirection direction)
            {
                return true;
            }
        }

        private readonly CompositeDisposable _applicationDisposables = new CompositeDisposable();

        protected override void OnStartup(StartupEventArgs e)
        {
            var shellWindowViewModel = new ShellWindowViewModel();

            // Fix this bat-shit nonsense.
            Locator.CurrentMutable.UnregisterAll<IPropertyBindingHook>();
            Locator.CurrentMutable.Register<IPropertyBindingHook>(() => new BindingHookFixerer());

            var shell = new ShellWindow
            {
                ViewModel = shellWindowViewModel
            };

            shell.Show();

            base.OnStartup(e);
        }
    }
}
