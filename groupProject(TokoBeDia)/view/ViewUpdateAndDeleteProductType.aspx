<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="ViewUpdateAndDeleteProductType.aspx.cs" Inherits="groupProject_TokoBeDia_.view.ViewUpdateAndDeleteProductType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Select Product Type to Update or Delete"></asp:Label>
        <br />
    </p>
    <p>
        <asp:GridView ID="productTypeListToUpdateAndDeleteId" runat="server">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="updateRedirect_Click" ID="updatelbRedirect" CommandArgument='<%# Eval("ProductTypesId")%>' runat="server" style="text-decoration:none">update</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

               <Columns>
                <asp:TemplateField>
                   <ItemTemplate>
                        <asp:LinkButton OnClick="deleteRedirect_Click" ID="deletelbRedirect" CommandArgument='<%# Eval("ProductTypesId")%>' runat="server" style="text-decoration:none">delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="validateDeleteIsReferencesID" runat="server"></asp:Label>
    </p>
</asp:Content>