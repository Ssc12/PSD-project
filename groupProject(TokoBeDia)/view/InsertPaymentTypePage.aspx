<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="InsertPaymentTypePage.aspx.cs" Inherits="groupProject_TokoBeDia_.view.InsertPaymentTypePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Insert New Payment Type"></asp:Label>
        <br />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Type"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="paymentTypeNameId" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 40px">
        <asp:Button ID="insertPaymentTypeBtnId" runat="server" OnClick="doInsertPaymentType" Text="Insert Payment Type" />
    </p>
    <p style="margin-left: 80px">
&nbsp;&nbsp;
        <asp:Label ID="errorMsgId" runat="server"></asp:Label>
    </p>
    <p style="margin-left: 40px">
        &nbsp;</p>
</asp:Content>