<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TreasuryBills._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Welcome to the Treasury Bills Portal</h2>
            <p>
                Treasury bills (or T-bills) are short-term securities that mature in one year or less from their issue date. 
                T-bills are purchased for a price less than or equal to their par (face) value, and when they mature, Treasury pays their par value.
            </p>
            <p>
                <a class="btn btn-default" href="https://localhost:44318/About">Enroll Today &raquo;</a>
            </p>
        </div>  

        <div class="col-md-5">
            <h2>Update Customer record</h2>
            <p>
               Any new updates? No worries...Here, you can edit the information<br /> you submitted to us with ease simply by filling the form below:
            </p>
            
                First Name: <asp:TextBox ID="tbFName" runat="server" /><br />
                Last Name: <asp:TextBox ID="tbLName" runat="server" /><br />
                Account Number: <asp:TextBox ID="tbAcctNum" runat="server" /><br />
                Age: <asp:TextBox ID="tbAge" runat="server" /><br />
                Home Address: <asp:TextBox ID="tbAddr" runat="server" /><br />
                <asp:Button ID="tuUpdateButton" Text="Submit" runat="server" OnClick="tuUpdateButton_Click"/>
                <br />
                <asp:Label ID="lbResult" runat="server" />
        </div> 

        <div class="col-md-6">
            <h2>Delete Customer record</h2>
            <p>
               In this section, you can choose to delete the records<br /> of client(s) that no longer show interest in the Treasury Bill plan.<br />
               Simply enter your account number below to have your record deleted:
            </p>
            
                Account Number: <asp:TextBox ID="tbDeleteAcctNum" runat="server" /><br />
                <asp:Button ID="tbDeleteButton" Text="Submit" runat="server" OnClick="tbDeleteButton_Click"/>
                <br />
                <asp:Label ID="deletedRowsInfo" runat="server" />
        </div> 

                <div class="col-md-6">
            <h2>View all Interested Customers</h2>
            <p>
               In this section, you can view the records of all clients that have shown<br /> interest in the Treasury Bills plan.
               Simply enter the number of rows you want to be shown:
            </p>
            
                Enter number: <asp:TextBox ID="tbNumOfCust" runat="server" /><br />
                <asp:Button ID="tbGetCust" Text="Submit" runat="server" OnClick="tbGetCust_Click"/>
                <br />
                <asp:Label ID="label" runat="server" />
                <asp:GridView ID="dataTable" runat="server" />
        </div> 

    </div>

</asp:Content>