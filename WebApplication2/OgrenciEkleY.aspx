﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici.Master" AutoEventWireup="true" CodeBehind="OgrenciEkleY.aspx.cs" Inherits="WebApplication2.OgrenciEkleY" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label for="TxtOgrNum" runat="server">Öğrenci Numara</asp:Label>
                <asp:TextBox ID="TxtOgrNum" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                <!-- Öğrenci numarasının girileceği metin kutusu -->
            </div>
            <br>
            <div>
                <asp:Label for="TxtOgrAd" runat="server">Öğrenci Adı</asp:Label>
                <asp:TextBox ID="TxtOgrAd" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                <!-- Öğrenci adının girileceği metin kutusu -->
            </div>
            <br>
            <div>
                <asp:Label for="TxtOgrSoyad" runat="server">Öğrenci Soyadı</asp:Label>
                <asp:TextBox ID="TxtOgrSoyad" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                <!-- Öğrenci soyadının girileceği metin kutusu -->
            </div>
            <br>
            <div>
                <asp:Label for="TxtOgrTel" runat="server">Öğrenci Telefon No.</asp:Label>
                <asp:TextBox ID="TxtOgrTel" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                <!-- Öğrenci telefon numarasının girileceği metin kutusu -->
            </div>
            <br>
            <div>
                <asp:Label for="TxtOgrMail" runat="server">Öğrenci Mail</asp:Label>
                <asp:TextBox ID="TxtOgrMail" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                <!-- Öğrenci e-posta adresinin girileceği metin kutusu -->
            </div>
            <br>
            <div>
                <asp:Label for="TxtOgrSifre" runat="server">Öğrenci Şifre</asp:Label>
                <asp:TextBox ID="TxtOgrSifre" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                <!-- Öğrenci şifresinin girileceği metin kutusu -->
            </div>
            <br>
            <div>
                <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click1" />
                <!-- Kaydet butonu -->
            </div>
        </div>
    </form>
</asp:Content>
