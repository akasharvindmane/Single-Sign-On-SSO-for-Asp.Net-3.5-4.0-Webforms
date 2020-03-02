<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationSSO.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <span style="float:right">
                <asp:button ID="Timer1" runat="server" Interval="1000" OnClick="lnkbtnlogout_Click" Text="Logout">
                </asp:button>
            </span>
            <h2>Axiata Azure AD User</h2>
            <h1><asp:label ID="signedIn" runat="server" /></h1> <hr /> 
            <asp:label ID="claimType" runat="server" />  <hr /> 
            <asp:label ID="claimValue" runat="server" />  <hr /> 
            <asp:label ID="claimValueType" runat="server" />  <hr /> 
            <asp:label ID="claimSubjectName" runat="server" />  <hr /> 
            <asp:label ID="claimIssuer" runat="server" />  <hr /> 
             <%--<asp:label ID="originalIssuer" runat="server" />  <hr />--%> 
             <%--<asp:label ID="properties" runat="server" />  <hr />--%> 
        </div>
        <div>  
            <h2>Axiata Database User</h2>
                <asp:GridView ID="GridView1" runat="server" BackColor="#FFF" BorderColor="#000" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">  
                   <FooterStyle BackColor="White" ForeColor="Black" />  
                    <HeaderStyle BackColor="White" Font-Bold="True" ForeColor="Black" />  
                    <PagerStyle ForeColor="Black" HorizontalAlign="Center" />  
                    <RowStyle BackColor="White" ForeColor="Black" />  
                    <SelectedRowStyle BackColor="#fff" Font-Bold="True" ForeColor="black" />  
                    <SortedAscendingCellStyle BackColor="#fff" />  
                    <SortedAscendingHeaderStyle BackColor="#fff" />  
                    <SortedDescendingCellStyle BackColor="#fff" />  
                    <SortedDescendingHeaderStyle BackColor="#fff" /></asp:GridView>  
            </div> 
        
            
    </form>
</body>
</html>
