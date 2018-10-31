Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Skins

Namespace XtraGridTutorial
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Public Shared Sub Main()
            SkinManager.EnableFormSkins()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New MainForm())
        End Sub
    End Class
End Namespace
