<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.Master" AutoEventWireup="true" CodeBehind="OgrenciMesajOlustur.aspx.cs" Inherits="WebApplication2.OgrenciMesajOlustur" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label for="TxtGonderen" runat="server" Width="300px">GÖNDEREN</asp:Label>
                <!-- Gönderenin adını görüntülemek için etkinleştirilmiş metin kutusu -->
                <asp:TextBox ID="TxtGonderen" runat="server" CssClass="form-control" Width="300px" Enabled="False"></asp:TextBox>
            </div>
            <br>
            <div>
                <asp:Label for="TxtAlici" runat="server">ALICI</asp:Label>
                <!-- Mesajın alıcısının girileceği metin kutusu -->
                <asp:TextBox ID="TxtAlici" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
            <br>    
            <div>
                <asp:Label for="TxtBaslik" runat="server" Width="500px">BAŞLIK</asp:Label>
                <!-- Mesajın başlığının girileceği metin kutusu -->
                <asp:TextBox ID="TxtBaslik" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
            <br>    
            <div>
                <asp:Label for="TxtMesajicerik" runat="server" Width="500px">İÇERİK</asp:Label>
                <!-- Mesajın içeriğinin girileceği çok satırlı metin kutusu -->
                <textarea id="TxtMesajicerik" rows="6" class="form-control" runat="server" Width="500px"></textarea>
            </div>
        </div>
        <!-- Mesajı göndermek için kullanılacak düğme -->
        <asp:Button ID="BtnGonder" runat="server" Text="GÖNDER" OnClick="BtnGonder_Click" />
    </form>
</asp:Content>
