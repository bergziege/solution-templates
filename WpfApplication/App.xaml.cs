using System.Windows;

using Microsoft.Practices.Unity;

using WpfApplication.Helper;
using WpfApplication.Ui.Common;
using WpfApplication.Ui.Info;
using WpfApplication.Ui.Info.ViewModels;
using WpfApplication.Ui.Main;
using WpfApplication.Ui.Main.ViewModels;

namespace WpfApplication {
    /// <summary>
    ///     Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application {
        /// <summary>Löst das <see cref="E:System.Windows.Application.Startup" />-Ereignis aus.</summary>
        /// <param name="e">Ein <see cref="T:System.Windows.StartupEventArgs" />, das die Ereignisdaten enthält.</param>
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);

            UnityContainer container = new UnityContainer();

            container.RegisterType<IWindowParentHelper, WindowParentHelper>(new ContainerControlledLifetimeManager());
            container.RegisterType<IGenericFactory, UnityResolver>(new ContainerControlledLifetimeManager());

            container.RegisterType<IMainViewModel, MainViewModel>();
            container.RegisterType<IInfoViewModel, InfoViewModel>();

            IGenericFactory factory = container.Resolve<IGenericFactory>();

            IWindow mainView = factory.Resolve<MainView>();

            IWindowParentHelper parentHelper = factory.Resolve<IWindowParentHelper>();
            parentHelper.RegisterWindow((Window)mainView);

            IMainViewModel mainViewModel = factory.Resolve<IMainViewModel>();
            mainView.DataContext = mainViewModel;
            MainWindow = (Window)mainView;
            MainWindow.Show();
        }
    }
}