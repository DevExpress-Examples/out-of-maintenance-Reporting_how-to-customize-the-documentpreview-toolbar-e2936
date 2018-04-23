Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.Windows.Input
Imports DevExpress.Mvvm
Imports DevExpress.Xpf.Printing
' ...

Namespace SilverlightApplication1
	Public Class MainPageViewModel
		Private privatePreviewModel As IDocumentPreviewModel
		Public Property PreviewModel() As IDocumentPreviewModel
			Get
				Return privatePreviewModel
			End Get
			Private Set(ByVal value As IDocumentPreviewModel)
				privatePreviewModel = value
			End Set
		End Property
		Private privateCreateDocumentCommand As ICommand
		Public Property CreateDocumentCommand() As ICommand
			Get
				Return privateCreateDocumentCommand
			End Get
			Private Set(ByVal value As ICommand)
				privateCreateDocumentCommand = value
			End Set
		End Property
		Private privateClearDocumentCommand As DelegateCommand
		Public Property ClearDocumentCommand() As DelegateCommand
			Get
				Return privateClearDocumentCommand
			End Get
			Private Set(ByVal value As DelegateCommand)
				privateClearDocumentCommand = value
			End Set
		End Property

		Public Sub New()
			PreviewModel = New ReportServicePreviewModel With {.ServiceUri = "../ReportService1.svc", .ReportName = "SilverlightApplication1.Web.XtraReport1, SilverlightApplication1.Web"}
			ClearDocumentCommand = New DelegateCommand(AddressOf ExecuteClearDocumentCommand, AddressOf CanExecuteClearDocumentCommand)
			CreateDocumentCommand = New DelegateCommand(AddressOf ExecuteCreateDocumentCommand)
		End Sub

		Private Sub ExecuteCreateDocumentCommand()
			PreviewModel.CreateDocument()
			ClearDocumentCommand.RaiseCanExecuteChanged()
		End Sub

		Private Function CanExecuteClearDocumentCommand() As Boolean
			Return Not PreviewModel.IsEmptyDocument
		End Function

		Private Sub ExecuteClearDocumentCommand()
			PreviewModel.Clear()
			ClearDocumentCommand.RaiseCanExecuteChanged()
		End Sub

		#Region "INotifyPropertyChanged"

		Public Event PropertyChanged As PropertyChangedEventHandler

		Private Sub RaisePropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
		#End Region


	End Class
End Namespace
