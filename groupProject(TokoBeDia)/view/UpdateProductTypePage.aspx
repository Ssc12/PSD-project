<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="UpdateProductTypePage.aspx.cs" Inherits="groupProject_TokoBeDia_.view.UpdateProductTypePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <p>
        <asp:Label ID="Label7" runat="server" Text="Current Product Type Data"></asp:Label>
    </p>
      <p>
          <asp:Label ID="Label4" runat="server" Text=" Name : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="toBeUpdateProductTypeName" runat="server"></asp:Label>
    </p>
      <p>
          <asp:Label ID="Label5" runat="server" Text="Description : "></asp:Label>
&nbsp;&nbsp;
          <asp:Label ID="toBeUpdateProductTypeDesc" runat="server"></asp:Label>
    </p>
      <p>
          &nbsp;</p>
      <p>
        <asp:Label ID="Label6" runat="server" Text="Update Product Type"></asp:Label>
        <br />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="updateProductTypeNameId" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="updateProductTypeDescId" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 40px">
        <asp:Button ID="insertProductTypeBtnId" runat="server" OnClick="doUpdateProductType" Text="Update Product Type" />
    </p>
    <p style="margin-left: 80px">
&nbsp;&nbsp;
        <asp:Label ID="errorMsgId" runat="server"></asp:Label>
    </p>
    <p style="margin-left: 40px">
        &nbsp;</p>
</asp:Content>