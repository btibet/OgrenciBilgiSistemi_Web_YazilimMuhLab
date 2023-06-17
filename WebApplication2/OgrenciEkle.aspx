<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="OgrenciEkle.aspx.cs" Inherits="WebApplication2.OgrenciEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <!-- Öğrenci Numarası -->
                <asp:Label for="TxtOgrNum" runat="server">Öğrenci Numarası</asp:Label>
                <asp:TextBox ID="TxtOgrNum" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <div>
                <!-- Öğrenci Adı -->
                <asp:Label for="TxtOgrAd" runat="server">Öğrenci Adı</asp:Label>
                <asp:TextBox ID="TxtOgrAd" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <div>
                <!-- Öğrenci Soyadı -->
                <asp:Label for="TxtOgrSoyad" runat="server">Öğrenci Soyadı</asp:Label>
                <asp:TextBox ID="TxtOgrSoyad" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <div>
                <!-- Öğrenci Telefon Numarası -->
                <asp:Label for="TxtOgrTel" runat="server">Öğrenci Telefon Numarası</asp:Label>
                <asp:TextBox ID="TxtOgrTel" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <div>
                <!-- Öğrenci E-Posta Adresi -->
                <asp:Label for="TxtOgrMail" runat="server">Öğrenci E-Posta Adresi</asp:Label>
                <asp:TextBox ID="TxtOgrMail" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <div>
                <!-- Öğrenci Şifresi -->
                <asp:Label for="TxtOgrSifre" runat="server">Öğrenci Şifresi</asp:Label>
                <asp:TextBox ID="TxtOgrSifre" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <div>
                <!-- Kaydet Butonu -->
                <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click1" />
            </div>
        </div>
    </form>
</asp:Content>
