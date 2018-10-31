Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace XtraGridTutorial
    Public NotInheritable Class ValidationErrorStringsHelper

        Private Sub New()
        End Sub

        Public Shared Function GetDateErrorMessage(ByVal fieldName As String) As String
            Return String.Format("The {0} field cannot store the future date", fieldName)
        End Function

        Public Shared Function GetAccountErrorMessage(ByVal fieldName As String) As String
            Return String.Format("You cannot leave the {0} field empty", fieldName)
        End Function

    End Class
End Namespace
