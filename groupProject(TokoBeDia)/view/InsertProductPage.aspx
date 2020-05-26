<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="InsertProductPage.aspx.cs" Inherits="groupProject_TokoBeDia_.view.InsertProductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Insert New Product"></asp:Label>
        <br />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Name "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="productNameId" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Stock"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="productStockId" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="productPriceId" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Product Type Name"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="productTypeNameId" runat="server" Width="185px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="insertProductBtnId" runat="server" OnClick="doInsertProduct" Text="Insert Product" Width="186px" />
    <p style="margin-left: 40px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="errorMsgId" runat="server"></asp:Label>
        <asp:RequiredFieldValidator ID="name" ControlToValidate="productNameId" ErrorMessage="Please input product name"   runat="server"></asp:RequiredFieldValidator>
    </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </asp:Content>

