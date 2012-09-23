<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ModalPopupControl.ascx.vb"
    Inherits="ModalPopupControl.ModalPopupControl" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>
<link href="../UserControls/ModalPopupControl.css" rel="stylesheet" type="text/css" />
<asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server">
</asp:ScriptManagerProxy>
<ajax:ModalPopupExtender ID="mpext" runat="server" BackgroundCssClass="modalBackground"
    TargetControlID="pnlPopup" PopupControlID="pnlPopup">
</ajax:ModalPopupExtender>
<asp:Panel ID="pnlPopup" runat="server" Style="display: none;" DefaultButton="ModalPopupControl_btnOk">
    <table width="100%" class="ModalPopupControl_wrap">
        <tr class="topHandle">
            <td align="left" runat="server" class="ModalPopupControl_title">
                &nbsp;
                <asp:Label ID="ModalPopupControl_lblTitle" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td valign="middle" align="left" class="ModalPopupControl_message">
                <asp:Label ID="ModalPopupControl_lblMessage" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="ModalPopupControl_buttons" align="right">
                <table style="width: 200px">
                    <tr>
                        <td align="right">
                            <asp:Button ID="ModalPopupControl_btnOk" runat="server" Height="28" Width="93" Text="OK" />
                        </td>
                        <td align="right">
                            <asp:Button ID="ModalPopupControl_btnCancel" runat="server" Height="28" Width="93" Text="Cancel" />
                        </td>
                        <asp:Label ID="ModalPopupControl_lblPostBackOption" Style="display: none" runat="server"></asp:Label>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Panel>
<script type="text/javascript">
    function fnClickOK(sender, e) {
        __doPostBack(sender, e);
    }

    function fnClickCancelar(sender, e) {
        __doPostBack(sender, e);
    }
</script>
