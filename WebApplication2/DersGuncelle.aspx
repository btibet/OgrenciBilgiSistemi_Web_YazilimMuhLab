<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici.Master" AutoEventWireup="true" CodeBehind="DersGuncelle.aspx.cs" Inherits="WebApplication2.DersGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            
                <!-- "DERS ID" etiketi -->
                <asp:Label for="txtDersID" runat="server">DERS ID</asp:Label>
                <!-- "txtDersID" olarak tanımlanan TextBox kontrolü -->
                <asp:TextBox ID="txtDersID" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <div>
                <!-- "DERS ADI" etiketi -->
                <asp:Label for="txtDersAd" runat="server">DERS ADI</asp:Label>
                <!-- "txtDersAd" olarak tanımlanan TextBox kontrolü -->
                <asp:TextBox ID="txtDersAd" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            
            <br>
            
        <!-- "Button1" olarak tanımlanan Button kontrolü -->
        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="Button1_Click"/>
    </form>
</asp:Content>
