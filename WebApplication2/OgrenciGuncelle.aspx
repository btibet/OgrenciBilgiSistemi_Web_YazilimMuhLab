<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="WebApplication2.OgrenciGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <%-- Öğrenci ID'si için etiket ve metin kutusu --%>
                <asp:Label for="TxtOgrid" runat="server">Öğrenci ID</asp:Label>
                <asp:TextBox ID="TxtOgrid" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <div>
                <%-- Öğrenci Adı için etiket ve metin kutusu --%>
                <asp:Label for="TxtOgrAd" runat="server">Öğrenci Adı</asp:Label>
                <asp:TextBox ID="TxtOgrAd" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <div>
                <%-- Öğrenci Soyadı için etiket ve metin kutusu --%>
                <asp:Label for="TxtOgrSoyad" runat="server">Öğrenci Soyadı</asp:Label>
                <asp:TextBox ID="TxtOgrSoyad" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <div>
                <%-- Öğrenci Telefon No. için etiket ve metin kutusu --%>
                <asp:Label for="TxtOgrTel" runat="server">Öğrenci Telefon No.</asp:Label>
                <asp:TextBox ID="TxtOgrTel" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <div>
                <%-- Öğrenci Mail için etiket ve metin kutusu --%>
                <asp:Label for="TxtOgrMail" runat="server">Öğrenci Mail</asp:Label>
                <asp:TextBox ID="TxtOgrMail" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <div>
                <%-- Öğrenci Şifre için etiket ve metin kutusu --%>
                <asp:Label for="TxtOgrSifre" runat="server">Öğrenci Şifre</asp:Label>
                <asp:TextBox ID="TxtOgrSifre" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br />
            
            <%-- Güncelle butonu --%>
            <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="Button1_Click" />
        </div>

    </form>
</asp:Content>
