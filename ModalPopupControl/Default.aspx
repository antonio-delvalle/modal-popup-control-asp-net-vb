<%@ Page Title="Home Page" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Default.aspx.vb" Inherits="ModalPopupControl._Default" %>

<%@ Register Src="UserControls/ModalPopupControl.ascx" TagName="ModalPopupControl"
    TagPrefix="uc1" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:UpdatePanel ID="updatepanel1" runat="server">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Button1" />
        </Triggers>
        <ContentTemplate>
            <uc1:ModalPopupControl ID="ModalPopupControl1" runat="server" />
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:Label ID="label1" runat="server" Text="Simple modal"></asp:Label>
    <asp:Button ID="Button1" runat="server" Text="Button" UseSubmitBehavior="false" />
    <hr />
    <asp:Label ID="label2" runat="server" Text="Simple modal with list"></asp:Label>
    <asp:Button ID="Button2" runat="server" Text="Button" UseSubmitBehavior="false" />
    <hr />
    <asp:Label ID="label3" runat="server" Text="Simple modal with Cancel button"></asp:Label>
    <asp:Button ID="Button3" runat="server" Text="Button" UseSubmitBehavior="false" />
</asp:Content>
