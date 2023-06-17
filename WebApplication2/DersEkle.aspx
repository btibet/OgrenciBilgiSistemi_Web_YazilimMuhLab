<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici.Master" AutoEventWireup="true" CodeBehind="DersEkle.aspx.cs" Inherits="WebApplication2.DersEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            
            <br>
            <div>
                <!-- "DERS AD" etiketi -->
                <asp:Label for="TxtDersAd" runat="server">DERS AD </asp:Label>
                <!-- "TxtDersAd" olarak tanımlanan TextBox kontrolü -->
                <asp:TextBox ID="TxtDersAd" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
           
        </div>
        <!-- "Button1" olarak tanımlanan Button kontrolü -->
         <asp:Button ID="Button1" runat="server"  Text="Kaydet" OnClick="Button1_Click" />
    </form>
</asp:Content>