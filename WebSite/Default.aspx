<%@ Page Title="" Language="C#" MasterPageFile="~/ProductsMaster.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <br />
            <asp:Label ID="lblProduct" runat="server" style="z-index: 1; width: 320px" Text="Please enter a product to filter the list"></asp:Label>
            <br />
            <asp:TextBox ID="txtProduct" runat="server" style="z-index: 1; width: 170px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; width: 120px" Text="Filter" OnClick="btnApply_Click" />
            <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; width: 120px" Text="Display All" OnClick="btnDisplayAll_Click"/>
            <br />
            <br />
            <asp:ListBox ID="lstProducts" runat="server" style="z-index: 1; height: 200px; width: 350px"></asp:ListBox>
            <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; width: 400px"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" style="z-index: 1; " Text="Add" height="30px" width="55px" OnClick="btnAdd_Click"  />
            <asp:Button ID="Button2" runat="server" style="z-index: 1; " Text="Edit" height="30px" width="55px" OnClick="btnEdit_Click" />
            <asp:Button ID="Button3" runat="server" style="z-index: 1; " Text="Delete" height="30px" width="55px" OnClick="btnDelete_Click"/>
        
</asp:Content>