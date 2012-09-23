
Public Class ModalPopupControl
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ModalPopupControl_btnOk.OnClientClick = String.Format("fnClickOK('{0}','{1}')", ModalPopupControl_btnOk.UniqueID, "")
        ModalPopupControl_btnCancel.OnClientClick = String.Format("fnClickCancelar('{0}','{1}')", ModalPopupControl_btnCancel.UniqueID, "")
    End Sub

    Public Enum ModalPopupControlButtons
        Accept = 1
        AcceptCancel = 2
    End Enum


#Region "Properties"

    Public ReadOnly Property PostBackOption() As String
        Get
            Return ModalPopupControl_lblPostBackOption.Text
        End Get
    End Property

    Private _width As Unit = Unit.Pixel(550)
    Public Property Width() As Unit
        Get
            Return _width
        End Get
        Set(ByVal value As Unit)
            _width = value
        End Set
    End Property

    Private _backgroundCssClass As String
    Public Property BackgroundCssClass() As String
        Get
            Return _backgroundCssClass
        End Get
        Set(ByVal value As String)
            _backgroundCssClass = value
            mpext.BackgroundCssClass = _backgroundCssClass
        End Set
    End Property

    Private _cssClass As String
    Public Property CssClass() As String
        Get
            Return _cssClass
        End Get
        Set(ByVal value As String)
            _cssClass = value
            pnlPopup.CssClass = _cssClass
        End Set
    End Property


#End Region

#Region "Methods"
    ''' <summary>
    ''' Show method with a simple message
    ''' </summary>
    ''' <param name="message"></param>
    ''' <remarks></remarks>
    Public Sub Show(ByVal Message As String)

        ModalPopupControl_lblMessage.Text = Message
        ModalPopupControl_lblTitle.Text = ""

        pnlPopup.Width = _width
        mpext.Show()
    End Sub

    ''' <summary>
    ''' Show method with a simple message, in the form of a list.
    ''' </summary>
    ''' <param name="Message"></param>
    ''' <remarks></remarks>
    Public Sub Show(ByVal Message As List(Of String))

        ModalPopupControl_lblMessage.Text = "<ul>"
        For Each item In Message
            ModalPopupControl_lblMessage.Text &= "<li>" & item & "</li>"
        Next
        ModalPopupControl_lblMessage.Text &= "</ul>"
        ModalPopupControl_lblMessage.Style.Add("display", "block")

        ModalPopupControl_lblTitle.Text = ""

        Me.ModalPopupControl_btnCancel.Style.Add("display", "none")
      
        pnlPopup.Width = _width
        mpext.Show()

    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Mensaje"></param>
    ''' <param name="Title"></param>
    ''' <remarks></remarks>
    Public Sub ShowM(ByVal Mensaje As String, ByVal Title As String)

        ModalPopupControl_lblMessage.Text = Mensaje
        ModalPopupControl_lblTitle.Text = Title

        Me.ModalPopupControl_btnCancel.Style.Add("display", "none")
        pnlPopup.Width = _width
        mpext.Show()
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Mensaje"></param>
    ''' <remarks></remarks>
    Public Sub Show(ByVal Mensaje As List(Of String), ByVal Title As String)

        ModalPopupControl_lblMessage.Text = "<ul>"
        For Each item In Mensaje
            ModalPopupControl_lblMessage.Text &= "<li>" & item & "</li>"
        Next
        ModalPopupControl_lblMessage.Text &= "</ul>"
        ModalPopupControl_lblMessage.Style.Add("display", "block")

        ModalPopupControl_lblTitle.Text = Title
        Me.ModalPopupControl_btnCancel.Style.Add("display", "none")
        pnlPopup.Width = _width
        mpext.Show()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Mensaje"></param>
    ''' <param name="Title"></param>
    ''' <param name="Buttons"></param>
    ''' <remarks></remarks>
    Public Sub Show(ByVal Mensaje As String, ByVal Title As String, ByVal Buttons As ModalPopupControlButtons)

        ModalPopupControl_lblMessage.Text = Mensaje
        ModalPopupControl_lblTitle.Text = Title
        If Buttons = ModalPopupControlButtons.Accept Then
            Me.ModalPopupControl_btnCancel.Style.Add("display", "none")
        Else
            Me.ModalPopupControl_btnCancel.Style.Remove("display")
        End If

        pnlPopup.Width = _width
        mpext.Show()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Mensaje"></param>
    ''' <param name="Title"></param>
    ''' <param name="Buttons"></param>
    ''' <remarks></remarks>

    Public Sub Show(ByVal Mensaje As List(Of String), ByVal Title As String, ByVal Buttons As ModalPopupControlButtons)
        ModalPopupControl_lblMessage.Text = "<ul>"
        For Each item In Mensaje
            ModalPopupControl_lblMessage.Text &= "<li>" & item & "</li>"
        Next
        ModalPopupControl_lblMessage.Text &= "</ul>"
        ModalPopupControl_lblMessage.Style.Add("display", "block")

        ModalPopupControl_lblTitle.Text = Title

        If Buttons = ModalPopupControlButtons.Accept Then
            Me.ModalPopupControl_btnCancel.Style.Add("display", "none")
        Else
            Me.ModalPopupControl_btnCancel.Style.Remove("display")
        End If

        pnlPopup.Width = _width
        mpext.Show()
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Mensaje"></param>
    ''' <param name="Title"></param>
    ''' <param name="Buttons"></param>
    ''' <param name="PostBackOption"></param>
    ''' <remarks></remarks>
    Public Sub Show(ByVal Mensaje As String, ByVal Title As String, ByVal Buttons As ModalPopupControlButtons, ByVal PostBackOption As String)
        ModalPopupControl_lblMessage.Text = Mensaje
        ModalPopupControl_lblTitle.Text = Title

        If Buttons = ModalPopupControlButtons.Accept Then
            Me.ModalPopupControl_btnCancel.Style.Add("display", "none")
        Else
            Me.ModalPopupControl_btnCancel.Style.Remove("display")
        End If

        ModalPopupControl_lblPostBackOption.Text = PostBackOption

        pnlPopup.Width = _width
        mpext.Show()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Mensaje"></param>
    ''' <param name="Title"></param>
    ''' <param name="Buttons"></param>
    ''' <param name="PostBackOption"></param>
    ''' <remarks></remarks>
    Public Sub Show(ByVal Mensaje As List(Of String), ByVal Title As String, ByVal Buttons As ModalPopupControlButtons, ByVal PostBackOption As String)
        ModalPopupControl_lblMessage.Text = "<ul>"
        For Each item In Mensaje
            ModalPopupControl_lblMessage.Text &= "<li>" & item & "</li>"
        Next
        ModalPopupControl_lblMessage.Text &= "</ul>"
        ModalPopupControl_lblMessage.Style.Add("display", "block")

        ModalPopupControl_lblTitle.Text = Title

        If Buttons = ModalPopupControlButtons.Accept Then
            Me.ModalPopupControl_btnCancel.Style.Add("display", "none")
        Else
            Me.ModalPopupControl_btnCancel.Style.Remove("display")
        End If

        ModalPopupControl_lblPostBackOption.Text = PostBackOption

        pnlPopup.Width = _width
        mpext.Show()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Hide()

        ModalPopupControl_lblMessage.Text = ""
        ModalPopupControl_lblTitle.Text = ""
        mpext.Hide()
    End Sub

#End Region

#Region "Events"

    '----------------------------------
    ' Exposing the click event of the ok button
    '----------------------------------
    Public Event OkButtonPressed(ByVal sender As Object, ByVal e As EventArgs)

    Public Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ModalPopupControl_btnOk.Click
        RaiseEvent OkButtonPressed(Me, e)
    End Sub

    '----------------------------------
    ' Exposing the click event of the cancel button
    '----------------------------------
    Public Event CancelButtonPressed(ByVal sender As Object, ByVal e As EventArgs)

    Protected Sub OnCancelButtonPressed(ByVal sender As Object, ByVal e As EventArgs) Handles ModalPopupControl_btnCancel.Click

        RaiseEvent CancelButtonPressed(Me, e)

    End Sub

#End Region

End Class