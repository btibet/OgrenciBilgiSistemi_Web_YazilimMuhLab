﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici.Master" AutoEventWireup="true" CodeBehind="DuyuruGuncelleY.aspx.cs" Inherits="WebApplication2.DuyuruGuncelleY" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <%-- DUYURU ID --%>
                <asp:Label for="TxtDuyuruId" runat="server">DUYURU ID</asp:Label>
                <asp:TextBox ID="TxtDuyuruId" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <div>
                <%-- DUYURU BAŞLIĞI --%>
                <asp:Label for="TxtDuyuruBaslik" runat="server">DUYURU BAŞLIĞI</asp:Label>
                <asp:TextBox ID="TxtDuyuruBaslik" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            <div>
                <%-- İÇERİK --%>
                <asp:Label for="TxtDuyuruicerik" runat="server">İÇERİK</asp:Label>
                <textarea id="TxtDuyuruicerik" rows="6" class="form-control" runat="server"></textarea>
            </div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-primary" OnClick="Button1_Click" />
    </form>
</asp:Content>
