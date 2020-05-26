<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="InsertProductTypePage.aspx.cs" Inherits="groupProject_TokoBeDia_.view.InsertProductTypePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Insert New Product Type"></asp:Label>
        <br />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="productTypeNameId" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="productTypeDescId" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 40px">
        <asp:Button ID="insertProductTypeBtnId" runat="server" OnClick="doInsertProductType" Text="Insert Product Type" />
    </p>
    <p style="margin-left: 80px">
&nbsp;&nbsp;
        <asp:Label ID="errorMsgId" runat="server"></asp:Label>
    </p>
    <p style="margin-left: 40px">
        &nbsp;</p>
</asp:Content>
