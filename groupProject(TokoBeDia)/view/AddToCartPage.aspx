<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="AddToCartPage.aspx.cs" Inherits="groupProject_TokoBeDia_.view.AddToCartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label2" runat="server" Text="Add To Cart Page"></asp:Label>
        <br />
    </p>
    
        <p>
        <asp:Label ID="Label1" runat="server" Text="Selected product data to be add to cart"></asp:Label>
    </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Name  : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="toBeAddToCartProductName" runat="server"></asp:Label>
    </p>
        <p>
        &nbsp;<asp:Label ID="Label8" runat="server" Text="Stock : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="toBeAddToCartProductStock" runat="server"></asp:Label>
    </p>
        <p>
            <asp:Label ID="Label9" runat="server" Text="Price : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="toBeAddToCartProductPrice" runat="server"></asp:Label>
    </p>
        <p>
            <asp:Label ID="Label10" runat="server" Text="Product Type  : "></asp:Label>
&nbsp;<asp:Label ID="toBeAddToCartProductType" runat="server"></asp:Label>
    </p>
    <p>
            &nbsp;</p>
    <p>
            <asp:Label ID="Label11" runat="server" Text="Determine quantity to be add to cart"></asp:Label>
    </p>
    <p>
            <asp:Label ID="Label12" runat="server" Text="Quantity"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="addToCartQuantity" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 40px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="addToCartQuantityBtn" runat="server" OnClick="addItemToCart" Text="Add To Cart" />
    </p>
    <p style="margin-left: 40px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="errorMsgId" runat="server"></asp:Label>
    </p>
</asp:Content>
