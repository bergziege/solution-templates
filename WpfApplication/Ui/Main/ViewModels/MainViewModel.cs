using ReactiveUI;

using WpfApplication.Ui.Common;
using WpfApplication.Ui.Info.ViewCommands;

namespace WpfApplication.Ui.Main.ViewModels {
    public class MainViewModel : ReactiveObject, IMainViewModel {
        private readonly InfoViewCommand _infoViewCommand;

        public MainViewModel(InfoViewCommand infoViewCommand) {
            _infoViewCommand = infoViewCommand;
        }

        private RelayCommand _showInfoCommand;
        /// <summary>
        /// </summary>
        public RelayCommand ShowInfoCommand
        {
            get
            {
                if (_showInfoCommand == null)
                    _showInfoCommand = new RelayCommand(ShowInfo, CanShowInfo);

                return _showInfoCommand;
            }
        }

        private bool CanShowInfo() {
            return true;
        }

        private void ShowInfo() {
            _infoViewCommand.Execute();
        }
    }
}