<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="ViewPaymentType.aspx.cs" Inherits="groupProject_TokoBeDia_.view.ViewPaymentType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Payment Type"></asp:Label>
    </p>
    <p>
        <br />
        <asp:GridView ID="viewPaymentTypeTableId" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="gotoinsertPaymentTypeId" runat="server" Text="Insert" OnClick="gotoInsertPaymentTypePg" />
        &nbsp;&nbsp;
        <asp:Button ID="gotoViewupdatePaymentTypeId" runat="server" Text="Update" OnClick="gotoViewUpdatePaymentTypePg" />
        &nbsp;&nbsp;
        <asp:Button ID="gotoViewdeletePaymentTypeId" runat="server" Text="Delete" OnClick="gotoViewDeletePaymentType" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
