<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="groupProject_TokoBeDia_.view.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>
           <asp:Label ID="regWelcomeLabel" runat="server" Text="Fill The Registration Form below"></asp:Label>
        <br />
        <br />
        
    </div>
        <asp:Label ID="regEmailLabel" runat="server" Text="Email"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="regEmailId" runat="server" Width="230px" autocomplete="off"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="regNameLabel" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="regNameId" runat="server" Width="230px" autocomplete="off"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="regPasswordLabel" runat="server" Text="Password"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="regPasswordId" runat="server" Width="230px" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="regConfirmPwLabel" runat="server" Text="Confirm Password"></asp:Label>
        &nbsp;
        <asp:TextBox ID="regConfirmPwId" runat="server" Width="230px" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="regGenderLabel" runat="server" Text="Gender"></asp:Label>
        <br />
        <asp:RadioButtonList ID="genderID" runat="server" Width="107px">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="registerBtnId" runat="server" OnClick="doRegister" Text="Register" />
        <br />
        <br />
        <asp:Label ID="errorMsgID" runat="server"></asp:Label>
    </p>
</asp:Content>
