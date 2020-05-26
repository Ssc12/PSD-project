<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="UpdateCartPage.aspx.cs" Inherits="groupProject_TokoBeDia_.view.UpdateCartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label2" runat="server" Text="Update Cart Page"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Selected cart product data to be update"></asp:Label>
    </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Name  : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="toBeUpdateCartProductName" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;<asp:Label ID="Label9" runat="server" Text="Price : "></asp:Label>
            &nbsp;&nbsp; &nbsp;
            <asp:Label ID="toBeUpdateCartProductPrice" runat="server"></asp:Label>
    </p>
        <p>
            <asp:Label ID="Label10" runat="server" Text="Product Type  : "></asp:Label>
&nbsp;&nbsp;&nbsp;<asp:Label ID="toBeUpdateCartProductType" runat="server"></asp:Label>
            &nbsp;&nbsp;
    </p>
        <p>
            <asp:Label ID="Label8" runat="server" Text="Remaining Stock : "></asp:Label>
            <asp:Label ID="toBeUpdateCartProductStock" runat="server"></asp:Label>
&nbsp;</p>
    <p>
            <asp:Label ID="Label11" runat="server" Text="Quantity on my Cart : "></asp:Label>
            <asp:Label ID="toBeUpdateCartQuantity" runat="server"></asp:Label>
        &nbsp;
            <asp:Label ID="Label13" runat="server" Text="(this quantity exclude from remaining stock)"></asp:Label>
    </p>
    <p>
            &nbsp;</p>
    <p>
            <asp:Label ID="Label12" runat="server" Text="Update your Cart Quantity for this product"></asp:Label>
    </p>
    <p>
            <asp:Label runat="server" Text="Quantity"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="updateNewCartQuantityTb" runat="server"></asp:TextBox>
    </p>
    <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="updateCartQuantityBtn" runat="server" OnClick="goUpdateCartQuantity" Text="Update Cart" />
    </p>
    <p style="margin-left: 80px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="errorMsgId" runat="server"></asp:Label>
        <br />
    </p>
</asp:Content>
