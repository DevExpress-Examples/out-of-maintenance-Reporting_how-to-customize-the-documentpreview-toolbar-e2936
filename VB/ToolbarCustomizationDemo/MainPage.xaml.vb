Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports DevExpress.Xpf.Bars
' ...

Namespace ToolbarCustomizationDemo
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			AddHandler preview.BarManager.ItemClick, AddressOf BarManager_ItemClick
		End Sub

		Private Sub BarManager_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			If e.Item.Name = "clearButton" Then
				CType(DataContext, MainPageViewModel).PreviewModel.Clear()
			End If
		End Sub

	End Class
End Namespace
