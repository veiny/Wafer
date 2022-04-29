using Microsoft.UI.Xaml;
namespace Wafer.Uwp;
public partial class App : Application
{
    public App() => this.InitializeComponent();
    protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args) => new Window() { Title = "Wafer UI3.0", Content = new Shell() }.Activate();
}
