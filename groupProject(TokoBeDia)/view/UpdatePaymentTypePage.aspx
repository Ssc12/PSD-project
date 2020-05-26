<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="UpdatePaymentTypePage.aspx.cs" Inherits="groupProject_TokoBeDia_.view.UpdatePaymentTypePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <p>
        <asp:Label ID="Label7" runat="server" Text="Current Payment Type Data"></asp:Label>
    </p>
      <p>
          <asp:Label ID="Label4" runat="server" Text="Type : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="toBeUpdatePaymentTypeName" runat="server"></asp:Label>
    </p>
      <p>
          &nbsp;</p>
      <p>
        <asp:Label ID="Label6" runat="server" Text="Update Payment Type"></asp:Label>
        <br />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Type"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="updatePaymentTypeNameId" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p style="margin-left: 40px">
        <asp:Button ID="updatePaymentTypeBtnId" runat="server" OnClick="doUpdatePaymenttType" Text="Update Payment Type" />
    </p>
    <p style="margin-left: 80px">
&nbsp;&nbsp;
        <asp:Label ID="errorMsgId" runat="server"></asp:Label>
    </p>
    <p style="margin-left: 40px">
        &nbsp;</p>
</asp:Content>
