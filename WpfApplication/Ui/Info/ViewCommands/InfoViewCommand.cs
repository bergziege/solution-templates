using WpfApplication.Helper;
using WpfApplication.Ui.Common;
using WpfApplication.Ui.Main;

namespace WpfApplication.Ui.Info.ViewCommands {
    public class InfoViewCommand: ViewCommandBase {
        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public InfoViewCommand(IGenericFactory genericFactory, IWindowParentHelper windowParentHelper)
                : base(genericFactory, windowParentHelper) {
        }

        public void Execute() {
            IWindow infoView = GenericFactory.Resolve<InfoView>();
            IInfoViewModel viewModel = GenericFactory.Resolve<IInfoViewModel>();

            infoView.DataContext = viewModel;

            IWindowParentHelper parentHelper = GenericFactory.Resolve<IWindowParentHelper>();
            parentHelper.SetOwner<MainView>(infoView);

            infoView.ShowDialog();
        }
    }
}