<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="ViewTransactionHistory.aspx.cs" Inherits="groupProject_TokoBeDia_.view.ViewTransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Transaction History</p>
    <p>
        <asp:GridView ID="viewTransactionHistoryTable" runat="server"  >
            
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;
        <asp:Button ID="gotoViewTransactionReportBtn" runat="server" Text="View Transaction Report" OnClick="gotoViewTransactionReportPg" />
        &nbsp;&nbsp;
        </p>
    <p>
        &nbsp;</p>
</asp:Content>
