<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici.Master" AutoEventWireup="true" CodeBehind="OgretmenGuncelle.aspx.cs" Inherits="WebApplication2.OgretmenGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label for="TxtOgrid" runat="server">Öğretmen ID</asp:Label>
                <asp:TextBox ID="TxtOgrid" runat="server" CssClass="form-control" Width="200px" Enabled="false"></asp:TextBox>
            </div>
            <br>
            <br>
            <div>
                <asp:Label for="TxtOgrAd" runat="server">Öğretmen Ad Soyad</asp:Label>
                <asp:TextBox ID="TxtOgrAd" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <div>
                <asp:Label for="DropDownList1" runat="server" Width="300px">Branş</asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Width="300px"></asp:DropDownList>
            </div>
            <br>
            <div>
                <asp:Label for="TxtOgrTel" runat="server">Numara</asp:Label>
                <asp:TextBox ID="TxtOgrTel" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <div>
                <asp:Label for="TxtOgrSifre" runat="server">Şifre</asp:Label>
                <asp:TextBox ID="TxtOgrSifre" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>

            <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="Button1_Click" />
        </div>

    </form>
</asp:Content>
