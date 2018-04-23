using System.Windows.Input;
using DevExpress.Xpf.Mvvm;
using DevExpress.Xpf.Printing;
// ...

namespace ToolbarCustomizationDemo {
    public class MainPageViewModel {
        public IDocumentPreviewModel PreviewModel { get; private set; }
        public ICommand CreateCommand { get; private set; }

        public MainPageViewModel() {
            PreviewModel = new ReportPreviewModel {
                ServiceUri = "../ReportService.svc",
                ReportName = "ToolbarCustomizationDemo.Web.SampleReport"
            };
            CreateCommand = new DelegateCommand(() => PreviewModel.CreateDocument());
        }
    }
}
