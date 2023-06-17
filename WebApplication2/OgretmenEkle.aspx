<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici.Master" AutoEventWireup="true" CodeBehind="OgretmenEkle.aspx.cs" Inherits="WebApplication2.OgretmenEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <br>
            <!-- Öğretmen Adı Soyadı -->
            <div>
                <asp:Label for="TxtOgrAd" runat="server">Öğretmen Ad Soyad</asp:Label>
                <asp:TextBox ID="TxtOgrAd" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <!-- Branş -->
            <div>
                <asp:Label for="DropDownList1" runat="server" Width="300px">Branş</asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Width="300px"></asp:DropDownList>
            </div>
            <br>
            <!-- Numara -->
            <div>
                <asp:Label for="TxtOgrTel" runat="server">Numara</asp:Label>
                <asp:TextBox ID="TxtOgrTel" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <!-- Mail -->
            <div>
                <asp:Label for="TxtOgrMail" runat="server">Mail</asp:Label>
                <asp:TextBox ID="TxtOgrMail" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <!-- Şifre -->
            <div>
                <asp:Label for="TxtOgrSifre" runat="server">Şifre</asp:Label>
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
