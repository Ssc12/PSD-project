<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="ChangePasswordPage.aspx.cs" Inherits="groupProject_TokoBeDia_.view.ChangePasswordPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Change Password Account"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Old Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="oldPasswordId" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="New Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="newPasswordId" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Confirm Password"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="confirmNewPasswordId" runat="server"></asp:TextBox>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="changePasswordBtn" runat="server" OnClick="doChangePassword" Text="Change Password" />
    </p>
    <p style="margin-left: 80px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="errorMsgId" runat="server"></asp:Label>
        <br />
    </p>
</asp:Content>

