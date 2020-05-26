<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="ViewProductType.aspx.cs" Inherits="groupProject_TokoBeDia_.view.ViewProductType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Product Type"></asp:Label>
        <br />
        <asp:GridView ID="viewProductTypeTableId" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="gotoinsertProductTypeId" runat="server" Text="Insert" OnClick="gotoInsertProductTypePg" />
        &nbsp;&nbsp;
        <asp:Button ID="gotoViewupdateProductTypeId" runat="server" Text="Update" OnClick="gotoViewUpdateProductTypePg" />
        &nbsp;&nbsp;
        <asp:Button ID="gotoViewdeleteProductTypeId" runat="server" Text="Delete" OnClick="gotoViewDeleteProductType" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>