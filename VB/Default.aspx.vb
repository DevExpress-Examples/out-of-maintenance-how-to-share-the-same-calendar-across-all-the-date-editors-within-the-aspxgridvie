Imports System
Imports DevExpress.Web.Data
Imports DevExpress.Web

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        If Not IsPostBack Then
            Grid.StartEdit(0)
        End If
    End Sub

    Protected Sub Grid_RowUpdating(ByVal sender As Object, ByVal e As ASPxDataUpdatingEventArgs)
        e.Cancel = True
    End Sub

    Protected Sub Grid_CellEditorInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewEditorEventArgs)
        SetupCalendarOwner(TryCast(e.Editor, ASPxDateEdit))
    End Sub

    Protected Sub Grid_AutoFilterCellEditorInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewEditorEventArgs)
        SetupCalendarOwner(TryCast(e.Editor, ASPxDateEdit))
    End Sub

    Private Sub SetupCalendarOwner(ByVal editor As ASPxDateEdit)
        If editor Is Nothing Then
            Return
        End If
        editor.PopupCalendarOwnerID = "__ReferenceDateEdit"
    End Sub

End Class
