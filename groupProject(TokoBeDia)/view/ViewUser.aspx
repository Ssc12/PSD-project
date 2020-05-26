<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="groupProject_TokoBeDia_.view.ViewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="user list view"></asp:Label>
        <br />
    </p>
    <p>
        <asp:GridView ID="viewUserListTableId" runat="server" OnRowDataBound="viewUserListTableId_RowDataBound">
        </asp:GridView>
    </p>
    <p>
        <asp:Label runat="server" Text="UserId"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="userIdforRolesChange" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Roles(administrator/member)"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="rolesIdforChange" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Status(active/blocked)"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="statusIdforChange" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 80px">
        <asp:Button ID="changeRolesOrStatusBtnId" runat="server" OnClick="doChangeRolesOrStatus" Text="Change roles/status" />
    </p>
    <p style="margin-left: 80px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="errorMsgId" runat="server"></asp:Label>
    </p>
</asp:Content>
