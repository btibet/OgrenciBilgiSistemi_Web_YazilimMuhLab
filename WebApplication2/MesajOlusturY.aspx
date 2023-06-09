﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici.Master" AutoEventWireup="true" CodeBehind="MesajOlusturY.aspx.cs" Inherits="WebApplication2.MesajOluşturY" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <%-- GÖNDEREN Label ve TextBox --%>
                <asp:Label for="TxtGonderen" runat="server" Width="300px">GÖNDEREN</asp:Label>
                <asp:TextBox ID="TxtGonderen" runat="server" CssClass="form-control" Width="300px" Enabled="False"></asp:TextBox>
            </div>
            <br>
            <div>
                <%-- ALICI Label ve TextBox --%>
                <asp:Label for="TxtAlici" runat="server">ALICI</asp:Label>
                <asp:TextBox ID="TxtAlici" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
            <br>
            <div>
                <%-- BAŞLIK Label ve TextBox --%>
                <asp:Label for="TxtBaslik" runat="server" Width="500px">BAŞLIK</asp:Label>
                <asp:TextBox ID="TxtBaslik" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
            <br>
            <div>
                <%-- İÇERİK Label ve TextBox --%>
                <asp:Label for="Txticerik" runat="server" Width="500px">İÇERİK</asp:Label>
                <asp:TextBox ID="Txticerik" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
        <%-- GÖNDER Button --%>
        <asp:Button ID="BtnGonder" runat="server" Text="GÖNDER" OnClick="BtnGonder_Click" />
    </form>
</asp:Content>
