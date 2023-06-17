<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici.Master" AutoEventWireup="true" CodeBehind="NotEkleY.aspx.cs" Inherits="WebApplication2.NotEkleY" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            
            <br>
           <div>
                <asp:Label for="TxtOgrid" runat="server">ÖĞRENCİ NUMARASI</asp:Label>
                <asp:TextBox ID="TxtOgrid" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <div>
                <asp:Label for="DropDownList1" runat="server">DERS</asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Width="200px"></asp:DropDownList>
            </div>
            <div>
                <asp:Label for="TxtSınav1" runat="server">SINAV 1</asp:Label>
                <asp:TextBox ID="TxtSınav1" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <div>
                <asp:Label for="TxtSınav2" runat="server">SINAV 2</asp:Label>
                <asp:TextBox ID="TxtSınav2" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
             <div>
                <asp:Label for="TxtSınav3" runat="server">SINAV 3</asp:Label>
                <asp:TextBox ID="TxtSınav3" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
           
        </div>
        <asp:Button ID="Button1" runat="server"  Text="Kaydet" OnClick="Button1_Click" />
    </form>
</asp:Content>
