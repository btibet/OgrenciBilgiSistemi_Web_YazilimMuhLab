<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="DersGuncelle.aspx.cs" Inherits="WebApplication1.DersGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

      <form id="form1" runat="server">
        <div class="form-group">
           
            <div>
                <asp:Label for="TxtDersAdı" runat="server">Ders Adı</asp:Label>
                <asp:TextBox ID="TxtDersAdı" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="Button1_Click"  />

    </form>
</asp:Content>
