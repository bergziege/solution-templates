using System.Windows.Input;

using WpfApplication.Ui.Common;

namespace WpfApplication.Ui.Main {
    public interface IMainViewModel {
        RelayCommand ShowInfoCommand { get; }

    }
}