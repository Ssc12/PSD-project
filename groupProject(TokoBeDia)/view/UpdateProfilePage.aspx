<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="UpdateProfilePage.aspx.cs" Inherits="groupProject_TokoBeDia_.view.UpdateProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Update Your Profile Here"></asp:Label>
    &nbsp;<br />
    </p>
    <p>
    <asp:Label ID="Label3" runat="server" Text="Email :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="updateProfileEmailId" runat="server"></asp:TextBox>
    </p>
    <p>
    <asp:Label ID="Label4" runat="server" Text="Name :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="updateProfileNameId" runat="server"></asp:TextBox>
    </p>
    <p>
    <asp:Label ID="Label5" runat="server" Text="Gender :"></asp:Label>
&nbsp;<asp:RadioButtonList ID="updateProfileGenderID" runat="server" Width="107px">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        </p>
    <p style="margin-left: 80px">
        <asp:Button ID="updateProfileBtnId" runat="server" OnClick="doUpdateProfile" Text="Update Profile" />
    </p>
    <p style="margin-left: 80px">
        &nbsp;&nbsp;
        <asp:Label ID="errorMsgId" runat="server"></asp:Label>
    </p>
</asp:Content>
