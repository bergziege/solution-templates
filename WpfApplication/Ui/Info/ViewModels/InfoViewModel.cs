using ReactiveUI;

namespace WpfApplication.Ui.Info.ViewModels {
    public class InfoViewModel : ReactiveObject, IInfoViewModel {
        private string _exampleContent;

        public string ExampleContent
        {
            get { return _exampleContent; }
            private set { this.RaiseAndSetIfChanged(ref _exampleContent, value); }
        }

        public void LoadData() {
            ExampleContent = "Beispieltext";
        }
    }
}