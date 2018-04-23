using System.ComponentModel;
using System.Windows.Input;
using DevExpress.Mvvm;
using DevExpress.Xpf.Printing;
// ...

namespace SilverlightApplication1 {
    public class MainPageViewModel {
        public IDocumentPreviewModel PreviewModel { get; private set; }
        public ICommand CreateDocumentCommand { get; private set; }
        public DelegateCommand ClearDocumentCommand { get; private set; }

        public MainPageViewModel() {
            PreviewModel = new ReportServicePreviewModel {
                ServiceUri = "../ReportService1.svc",
                ReportName = "SilverlightApplication1.Web.XtraReport1, SilverlightApplication1.Web"
            };
            ClearDocumentCommand = new DelegateCommand(ExecuteClearDocumentCommand, CanExecuteClearDocumentCommand);
            CreateDocumentCommand = new DelegateCommand(ExecuteCreateDocumentCommand);
        }

        void ExecuteCreateDocumentCommand() {
            PreviewModel.CreateDocument();
            ClearDocumentCommand.RaiseCanExecuteChanged();
        }

        bool CanExecuteClearDocumentCommand() {
            return !PreviewModel.IsEmptyDocument;
        }

        void ExecuteClearDocumentCommand() {
            PreviewModel.Clear();
            ClearDocumentCommand.RaiseCanExecuteChanged();
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        void RaisePropertyChanged(string propertyName) {
            if(PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion


    }
}
