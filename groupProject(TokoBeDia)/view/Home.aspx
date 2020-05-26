<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="groupProject_TokoBeDia_.view.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>
         <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Welcome,"></asp:Label>
        <asp:Label ID="userGreetingId" runat="server"></asp:Label>
    
    </p>
    <p>
         <asp:Label ID="recommendedProdectLabel" runat="server" Text="Recommended for you"></asp:Label>
    
    </p>
    <p>
         <asp:GridView ID="randomProductTableId" runat="server" OnRowDataBound="randomProductTableId_RowDataBound">
              <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="addToCartRedirect_Click" ID="addToCartRedirectBtn" CommandArgument='<%# Eval("ProductsId")%>' runat="server" style="text-decoration:none">Add To Cart</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
         </asp:GridView>
         &nbsp;
        &nbsp;&nbsp;&nbsp;
            
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <asp:Button ID="gotoviewUserPgBtnId" runat="server" Text="View User" Width="136px" OnClick="gotoViewUserPg" />
&nbsp;<asp:Button ID="gotoInsertProductPgBtnId" runat="server" Text="Insert Product" Width="136px" OnClick="gotoInsertProductPg" />
&nbsp;<asp:Button ID="gotoUpdateProductPgBtnId" runat="server" Text="Update Product" Width="136px" OnClick="gotoUpdateProductPg" />
&nbsp;<asp:Button ID="gotoViewProductTypeBtnId" runat="server" Text="View Product Type" Width="165px" OnClick="gotoViewProduct" />
&nbsp;<asp:Button ID="gotoInsertProductTypePgBtnId" runat="server" Text="Insert Product Type" Width="166px" OnClick="gotoInsertProductTypePg" />
&nbsp;
        <asp:Button ID="gotoUpdateProductTypePgBtnId" runat="server" Text="Update Product Type" Width="172px" OnClick="gotoUpdateProductTypePg" />
        <br />
        <br />
        <asp:Button ID="gotoviewPaymentTypePgBtn" runat="server" Text="View Payment Type" Width="169px" OnClick="gotoViewPaymentTypePg" />
&nbsp;<asp:Button ID="gotoInsertPaymentTypePgBtn" runat="server" Text="Insert Payment Type" Width="176px" OnClick="gotoInsertPaymentTypePg" />
&nbsp;<asp:Button ID="gotoUpdatePaymentTypePgBtn" runat="server" Text="Update Payment Type" Width="186px" OnClick="gotoUpdatePaymentTypePg" />
        &nbsp;
         <asp:Button ID="goToViewCartBtn" runat="server" OnClick="gotoViewCartPage" Text="View Cart" />
&nbsp;
         <asp:Button ID="goToViewTranscactionHistoryBtn" runat="server" OnClick="gotoViewTransactionHistoryPage" Text="View Transaction History" />
&nbsp;<asp:Button ID="gotoTransactionReportPgBtn" runat="server" OnClick="gotoTransactionReportPage" Text="View Transaction Report" />
    
    </p>
    <p>
        <br />
        <br />
    
    </p>
</asp:Content>
