Imports Microsoft.VisualBasic
Imports System.Windows.Input
Imports DevExpress.Xpf.Core.Commands
Imports DevExpress.Xpf.Printing
' ...

Namespace ToolbarCustomizationDemo
	Public Class MainPageViewModel
		Private ReadOnly previewModel_Renamed As ReportPreviewModel
		Private ReadOnly createCommand_Renamed As DelegateCommand(Of Object)

		Public ReadOnly Property PreviewModel() As IDocumentPreviewModel
			Get
				Return previewModel_Renamed
			End Get
		End Property
		Public ReadOnly Property CreateCommand() As ICommand
			Get
				Return createCommand_Renamed
			End Get
		End Property

		Public Sub New()
			previewModel_Renamed = New ReportPreviewModel() With _ 
			{.ServiceUri = "../ReportService.svc", .ReportName = "ToolbarCustomizationDemo.Web.SampleReport"}
			createCommand_Renamed = _ 
			New DelegateCommand(Of Object)(AddressOf ExecuteCreateCommand, AddressOf CanExecuteCreateCommand)
		End Sub

		Private Function CanExecuteCreateCommand(ByVal parameter As Object) As Boolean
			Return True
		End Function

		Private Sub ExecuteCreateCommand(ByVal parameter As Object)
			previewModel_Renamed.CreateDocument()
		End Sub
	End Class
End Namespace
