Imports System.Windows.Input
Imports DevExpress.Xpf.Mvvm
Imports DevExpress.Xpf.Printing
' ...

Namespace ToolbarCustomizationDemo
	Public Class MainPageViewModel
        Public Property PreviewModel() As IDocumentPreviewModel
        Public Property CreateCommand() As ICommand

		Public Sub New()
            PreviewModel = New ReportPreviewModel With {
                .ServiceUri = "../ReportService.svc",
                .ReportName = "ToolbarCustomizationDemo.Web.SampleReport"
            }
            CreateCommand = New DelegateCommand(Sub() PreviewModel.CreateDocument())
		End Sub
	End Class
End Namespace
