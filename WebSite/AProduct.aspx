<%@ Page Title="" Language="C#" MasterPageFile="~/ProductsMaster.master" AutoEventWireup="true" CodeFile="AProduct.aspx.cs" Inherits="AProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <asp:Label ID="lblProductID" runat="server" Text="ProductID" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtProductID" runat="server" Width="127px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblProductName" runat="server" Text="ProductName" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtProductName" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server"  Text="Price" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtPrice" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtQuantity" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" style="z-index: 1;" Text="OK" height="30px" width="55px" OnClick="btnOK_Click"/>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" height="30px" width="55px"  OnClick="btnCancel_Click"/>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ></asp:Label>    
</asp:Content>