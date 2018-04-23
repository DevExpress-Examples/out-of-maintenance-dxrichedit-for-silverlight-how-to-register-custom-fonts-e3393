Imports Microsoft.VisualBasic
Imports System.Reflection
Imports System.Windows.Controls

Namespace RichEditCustomFontsSL
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			DevExpress.Xpf.Drawing.FontManager.RegisterFontFamily("Monotype Corsiva", System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Fonts.mtcorsva.ttf"))
			richEditControl1.Document.DefaultCharacterProperties.FontName = "Monotype Corsiva"
			richEditControl1.ApplyTemplate()
		End Sub
	End Class
End Namespace
