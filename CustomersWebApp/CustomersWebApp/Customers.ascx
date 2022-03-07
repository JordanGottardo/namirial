<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Customers.ascx.cs" Inherits="CustomersWebApp.Customers" %>

<center>
    <h1>This is user control</h1>
    <hr />
    <asp:GridView ID="GridView1" AllowPaging="True" OnPageIndexChanging="GridView1OnPageIndexChanging" runat="server">
    </asp:GridView>
</center>