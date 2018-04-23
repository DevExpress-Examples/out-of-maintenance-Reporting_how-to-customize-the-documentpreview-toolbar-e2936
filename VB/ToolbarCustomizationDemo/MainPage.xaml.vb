Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports DevExpress.Xpf.Bars
' ...

Namespace ToolbarCustomizationDemo
	Partial Public Class MainPage
        Inherits UserControl
        Public ReadOnly Property ViewModel() As MainPageViewModel
            Get
                Return CType(DataContext, MainPageViewModel)
            End Get
        End Property

		Public Sub New()
			InitializeComponent()
			AddHandler preview.BarManager.ItemClick, AddressOf BarManager_ItemClick
		End Sub

		Private Sub BarManager_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			If e.Item.Name = "clearButton" Then
                ViewModel.PreviewModel.Clear()
			End If
		End Sub
	End Class
End Namespace
