<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ReadImportExcel._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 

    <div class="row">
        <div class="col-md-4">
  
            <br />
            <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" Text="Upload" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblEror" runat="server" Font-Bold="True" ForeColor="Red" Text="No File Selected for Upload" Visible="False"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Has Header ?" />

<asp:RadioButtonList ID="rbHDR" runat="server">

    <asp:ListItem Text = "Yes" Value = "Yes" Selected = "True" >

    </asp:ListItem>

    <asp:ListItem Text = "No" Value = "No"></asp:ListItem>

</asp:RadioButtonList>
            <br />
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
  
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
  
        </div>
    </div>

</asp:Content>
