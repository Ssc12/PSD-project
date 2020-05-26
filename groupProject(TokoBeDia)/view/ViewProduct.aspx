<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="groupProject_TokoBeDia_.view.ViewProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>
        
        View Product Page<br />
        <br />
        <asp:GridView ID="viewProductTableId" runat="server" OnRowDataBound="viewProductTableId_RowDataBound">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="addToCartRedirect_Click" ID="addToCartRedirectBtn" CommandArgument='<%# Eval("ProductsId")%>' runat="server" style="text-decoration:none">Add To Cart</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="gotoinsertProductBtnId" runat="server" OnClick="goToInsertProductPg" Text="Insert" />
&nbsp;
        <asp:Button ID="gotoupdateProductBtnId" runat="server" OnClick="goToUpdateProductPage" Text="Update" />
&nbsp;&nbsp;
        <asp:Button ID="deleteProductBtnId" runat="server" OnClick="goToDeletePg" Text="Delete" />
    </p>
</asp:Content>