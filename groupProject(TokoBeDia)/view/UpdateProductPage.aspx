<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="UpdateProductPage.aspx.cs" Inherits="groupProject_TokoBeDia_.view.UpdateProductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <p>
        <asp:Label ID="Label1" runat="server" Text="Current Product Data"></asp:Label>
    </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Name  : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="toBeUpdatedProductName" runat="server"></asp:Label>
    </p>
        <p>
        &nbsp;<asp:Label ID="Label8" runat="server" Text="Stock : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="toBeUpdatedProductStock" runat="server"></asp:Label>
    </p>
        <p>
            <asp:Label ID="Label9" runat="server" Text="Price : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="toBeUpdatedProductPrice" runat="server"></asp:Label>
    </p>
        <p>
            <asp:Label ID="Label10" runat="server" Text="Product Type  : "></asp:Label>
&nbsp;<asp:Label ID="toBeUpdatedProductType" runat="server"></asp:Label>
    </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="Label7" runat="server" Text="Update Product"></asp:Label>
        <br />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Name "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="updateProductNameId" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Stock"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="updateProductStockId" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="updateProductPriceId" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Product Type "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="productTypeNameId" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="updateProductBtnId" runat="server" OnClick="doUpdateProduct" Text="Update Product" Width="186px" />
    <p style="margin-left: 40px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="errorMsgId" runat="server"></asp:Label>
    </p>
</asp:Content>