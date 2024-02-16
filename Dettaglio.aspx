<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Template.Master" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="Ecommerce.Dettaglio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-lg m-4">
        <h2 ID="ttlProduct" runat="server" >Nome Prodotto</h2>
        <img ID="img" src="" alt="" class="w-50" runat="server" />
        <p ID="txtDescription" runat="server" > </p>
        <p ID="txtPrice" runat="server" > </p>
        <asp:Button ID="btnAddCart" runat="server" Text="Aggiungi al carrello" CssClass="btn btn-outline-secondary" OnClick="btnAddCart_Click" />
    </div>
</asp:Content>
