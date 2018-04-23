using System.Windows.Input;
using DevExpress.Xpf.Core.Commands;
using DevExpress.Xpf.Printing;

namespace ToolbarCustomizationDemo
{
    public class MainPageViewModel
    {
        readonly ReportPreviewModel previewModel;
        readonly DelegateCommand<object> createCommand;

        public IDocumentPreviewModel PreviewModel { get { return previewModel; } }
        public ICommand CreateCommand { get { return createCommand; } }

        public MainPageViewModel()
        {
            previewModel = new ReportPreviewModel() { ServiceUri = "../ReportService.svc", ReportTypeName = "ToolbarCustomizationDemo.Web.SampleReport" };
            createCommand = new DelegateCommand<object>(ExecuteCreateCommand, CanExecuteCreateCommand);
        }

        bool CanExecuteCreateCommand(object parameter)
        {
            return true;
        }

        void ExecuteCreateCommand(object parameter)
        {
            previewModel.CreateDocument();
        }
    }
}
