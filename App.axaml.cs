using Avalonia;
using Avalonia.Markup.Xaml;
using AvaloniaExample.Views;
using Prism.DryIoc;
using Prism.Ioc;

namespace AvaloniaExample
{
    public partial class App : PrismApplication
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            base.Initialize();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<MainWindow>();
        }

        protected override AvaloniaObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}