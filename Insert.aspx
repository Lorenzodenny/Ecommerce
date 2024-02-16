<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Template.Master" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="Ecommerce.Insert" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <asp:Label ID="LblProdottiTotali" runat="server" Text=""></asp:Label>
 <br />
 NOME:<asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
 DESCRIZIONE:<asp:TextBox ID="TxtDescription" runat="server"></asp:TextBox>
 IMG:<asp:TextBox ID="TxtImage" runat="server"></asp:TextBox>
 PREZZO:<asp:TextBox ID="TxtPrezzo" runat="server"></asp:TextBox>
 

 <asp:Button ID="BtnCrea" runat="server" Text="Crea" OnClick="BtnCrea_Click"  />

</asp:Content>
