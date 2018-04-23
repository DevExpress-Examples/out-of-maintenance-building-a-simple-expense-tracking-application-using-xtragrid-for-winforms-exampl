Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Skins

Namespace XtraGridTutorial
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
        <STAThread> _
        Public Shared Sub Main()
            DevExpress.UserSkins.BonusSkins.Register()
            SkinManager.EnableFormSkins()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New MainForm())
        End Sub
	End Class
End Namespace
