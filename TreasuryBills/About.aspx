<%@ Page Title="Fill the form below" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="TreasuryBills.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    First Name: <asp:TextBox ID="tbFirstName" runat="server" /><br />
    Last Name: <asp:TextBox ID="tbLastName" runat="server" /><br />
    Account Number: <asp:TextBox ID="tbAccountNumber" runat="server" /><br />
    Age: <asp:TextBox ID="tbAge" runat="server" /><br />
    Home Address: <asp:TextBox ID="tbAddress" runat="server" /><br />
    <asp:Button ID="tbSend" Text="Submit" runat="server" OnClick="tbSend_Click" />
    <br />
    <asp:Label ID="lbResult" runat="server" />
</asp:Content>
