<%@ Page Title="" Language="C#" MasterPageFile="~/view/TokoBeDia.Master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="groupProject_TokoBeDia_.view.ViewCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label2" runat="server" Text="View Cart (my cart)"></asp:Label>
        <br />
    </p>

     <p>
        <asp:GridView ID="cartListToUpdateAndDeleteId" runat="server" OnRowDataBound="cartListToUpdateAndDeleteId_RowDataBound" ShowFooter="True">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton OnClick="updateCartRedirect_Click" ID="updatelbRedirect" CommandArgument='<%# Eval("ProductsId")%>' runat="server" style="text-decoration:none">update</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>               
                </Columns>


                <Columns> 
                         <asp:TemplateField>
                                 <ItemTemplate>
                                     <asp:LinkButton OnClick="deleteCartRedirect_Click" ID="deletelbRedirect" CommandArgument='<%# Eval("ProductsId")%>' runat="server" style="text-decoration:none">delete</asp:LinkButton>
                                  </ItemTemplate>
                          </asp:TemplateField>
                </Columns>

              <Columns>

                    <asp:TemplateField>
                        <HeaderTemplate>ProductName</HeaderTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <HeaderTemplate>ProductPrice</HeaderTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField>
                        <HeaderTemplate>SubTotal</HeaderTemplate>
                    </asp:TemplateField>
               </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="To purchase, please insert the payment type below you want to apply:"></asp:Label>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="availablePaymentTypeView" runat="server">
        </asp:GridView>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Payment type"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="insertPaymentTypeTb" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 120px">
        &nbsp;<asp:Button ID="checkOutBtnId" runat="server" OnClick="goCheckOutTansaction" Text="Checkout" />
    &nbsp;&nbsp;&nbsp;
    </p>
    <p style="margin-left: 120px">
        <asp:Label ID="errorMsgId" runat="server"></asp:Label>
    </p>
    <p style="margin-left: 120px">
        &nbsp;</p>
</asp:Content>
