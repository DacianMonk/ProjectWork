<%@ Page Title="" Language="C#" MasterPageFile="~/ProductsMaster.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <br />
            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; width: 323px;" Text="Are you sure you want to delete this Product?"></asp:Label>
            <br />
            <asp:Button ID="btnYes" runat="server" style="z-index: 1;" height="26px" width="59px" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" style="z-index: 1;" height="26px" width="59px" Text="No" OnClick="btnNo_Click" />

</asp:Content>

