using System.Windows;
using System.Windows.Controls;

namespace VocalWorkbench.Apps.Desktop.Controls
{
    public class WindowTitle : ContentControl
    {
        static WindowTitle()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowTitle), new FrameworkPropertyMetadata(typeof(WindowTitle)));
        }
    }
}
