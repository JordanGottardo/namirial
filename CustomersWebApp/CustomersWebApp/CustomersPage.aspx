<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomersPage.aspx.cs" Inherits="CustomersWebApp.CustomersPage" %>

<%@ Register Src="~/Customers.ascx" TagPrefix="uc1" TagName="Customers" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:Customers runat="server" ID="Customers" />
        </div>
    </form>
</body>
</html>
