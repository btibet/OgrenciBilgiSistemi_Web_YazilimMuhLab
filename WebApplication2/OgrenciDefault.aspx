﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.Master" AutoEventWireup="true" CodeBehind="OgrenciDefault.aspx.cs" Inherits="WebApplication2.OgrenciDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <!-- Numara bilgisini girmek için kullanılan TextBox -->
            <div>
                <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control" Enabled="false">Numara</asp:TextBox>
            </div>
            <br />
            <!-- Ad ve soyad bilgisini girmek için kullanılan TextBox -->
            <div>
                <asp:TextBox ID="TxtAdSoyad" runat="server" CssClass="form-control" Enabled="false">Ad Soyad</asp:TextBox>
            </div>
            <br />
            <!-- Mail adresini girmek için kullanılan TextBox -->
            <div>
                <asp:TextBox ID="TxtMail" runat="server" CssClass="form-control" Enabled="false">Mail</asp:TextBox>
            </div>
            <br />
            <!-- Telefon numarasını girmek için kullanılan TextBox -->
            <div>
                <asp:TextBox ID="TxtTelefon" runat="server" CssClass="form-control" Enabled="false">Telefon</asp:TextBox>
            </div>
            <br />
            <!-- Şifre bilgisini girmek için kullanılan TextBox -->
            <div>
                <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control" Enabled="false">Şifre</asp:TextBox>
            </div>
        </div>
        
        <!-- Şifre değiştirme işlemini gerçekleştirmek için kullanılan buton -->
        <asp:Button ID="Button4" runat="server" Text="ŞİFRE DEĞİŞTİR" CssClass="btn btn-primary" OnClick="Button4_Click"/>
    </form>
</asp:Content>
