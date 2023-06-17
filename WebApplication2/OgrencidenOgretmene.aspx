<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.Master" AutoEventWireup="true" CodeBehind="OgrencidenOgretmene.aspx.cs" Inherits="WebApplication2.OgrencidenOgretmene" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
    <!-- Form etiketi, sunucu tarafında çalışabilen bir web formu tanımlar -->
        <div class="form-group">
        <!-- Form alanlarını gruplandırmak için bir bölme oluşturur -->
            <div>
                <asp:Label for="TxtGonderen" runat="server" Width="300px">GÖNDEREN</asp:Label>
                <!-- Label etiketi, metin veya başlık için bir etiket oluşturur -->
                <asp:TextBox ID="TxtGonderen" runat="server" CssClass="form-control" Width="300px" Enabled="False"></asp:TextBox>
                <!-- TextBox kontrolü, metin girişi için bir alan oluşturur -->
            </div>
            <br>
            <div>
                <asp:Label for="DropDownList1" runat="server" Width="300px">ALICI</asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Width="300px"></asp:DropDownList>
                <!-- DropDownList kontrolü, bir listeden bir seçenek seçmek için bir açılır liste oluşturur -->
            </div>
            <br>    
            <div>
                <asp:Label for="TxtBaslik" runat="server" Width="500px">BAŞLIK</asp:Label>
                <asp:TextBox ID="TxtBaslik" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
            <br>    
            <div>
                <asp:Label for="TxtMesajicerik" runat="server" Width="500px">İÇERİK</asp:Label>
                <!-- Textarea etiketi, çok satırlı bir metin girisi için bir alan oluşturur -->
                <textarea id="TxtMesajicerik" rows="6" class="form-control" runat="server" Width="500px"></textarea>
            </div>
        </div>
        <asp:Button ID="BtnGonder" runat="server" Text="GÖNDER" OnClick="BtnGonder_Click" />
        <!-- Button kontrolü, bir buton oluşturur -->
    </form>
</asp:Content>
