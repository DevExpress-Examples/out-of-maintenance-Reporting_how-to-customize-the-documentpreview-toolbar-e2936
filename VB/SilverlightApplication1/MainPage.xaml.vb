Imports Microsoft.VisualBasic
Imports System.Windows.Controls
' ...

Namespace SilverlightApplication1
	Partial Public Class MainPage
		Inherits UserControl
		Private ReadOnly Property ViewModel() As MainPageViewModel
			Get
				Return CType(DataContext, MainPageViewModel)
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
