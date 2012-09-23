Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ModalPopupControl1.Show("This is the message of the ModalPopupControl!", "Information", ModalPopupControl.ModalPopupControlButtons.Accept)
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ModalPopupControl1.Show(New List(Of String)(New String() {"This is the message of the ModalPopupControl!", "In a list!"}), "Information", ModalPopupControl.ModalPopupControlButtons.Accept)
    End Sub
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ModalPopupControl1.Show("This is a modal window with cancel button", "Information", ModalPopupControl.ModalPopupControlButtons.AcceptCancel)
    End Sub

#Region "ModalPopupControl"
    Sub ModalPopupControl1_OkButtonPressed(ByVal sender As Object, ByVal args As EventArgs) Handles ModalPopupControl1.OkButtonPressed


    End Sub
    Sub ModalPopupControl1_CancelButtonPressed(ByVal sender As Object, ByVal args As EventArgs) Handles ModalPopupControl1.CancelButtonPressed

    End Sub
#End Region


End Class