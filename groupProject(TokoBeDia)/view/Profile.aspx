<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="groupProject_TokoBeDia_.view.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Your Profile"></asp:Label>
    </p>
    <asp:Label ID="Label3" runat="server" Text="Email :"></asp:Label>
&nbsp;<asp:Label ID="profileEmailId" runat="server"></asp:Label>
&nbsp;<p>
        <asp:Label ID="Label2" runat="server" Text="Name  : "></asp:Label>
        <asp:Label ID="profileNameId" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Gender :"></asp:Label>
&nbsp;<asp:Label ID="profileGenderId" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="gotoUpdateProfilePgId" runat="server" OnClick="gotoUpdateProfilePg" Text="Update Profile" />
    </p>
&nbsp;&nbsp; 
    <asp:Button ID="gotoChangePasswordPgId" runat="server" OnClick="gotoChangePasswordPg" Text="Change Password" />
</asp:Content>
