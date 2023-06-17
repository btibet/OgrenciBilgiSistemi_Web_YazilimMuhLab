<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="NotGuncelle.aspx.cs" Inherits="WebApplication2.NotGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <form id="Form1" runat="server">
        <div class="form-group">
            
            <!-- DERS ADI alanı için bir etiket ve metin kutusu -->
            <div>
                <asp:Label for="TxtDersAd" runat="server">DERS ADI</asp:Label>
                <asp:TextBox ID="TxtDersAd" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            
            <!-- ÖĞRENCİ ID alanı için bir etiket ve metin kutusu -->
            <div>
                <asp:Label for="TxtOgrid" runat="server">ÖĞRENCİ ID</asp:Label>
                <asp:TextBox ID="TxtOgrid" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            
            <!-- ÖĞRENCİ ADI SOYADI alanı için bir etiket ve metin kutusu -->
            <div>
                <asp:Label for="TxtOgrAdSoyad" runat="server">ÖĞRENCİ ADI SOYADI</asp:Label>
                <asp:TextBox ID="TxtOgrAdSoyad" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            
            <!-- SINAV1 alanı için bir etiket ve metin kutusu -->
            <div>
                <asp:Label for="TxtOgrSınav1" runat="server">SINAV1</asp:Label>
                <asp:TextBox ID="TxtOgrSınav1" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            
            <!-- SINAV2 alanı için bir etiket ve metin kutusu -->
            <div>
                <asp:Label for="TxtOgrSınav2" runat="server">SINAV2</asp:Label>
                <asp:TextBox ID="TxtOgrSınav2" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br>
            
            <!-- SINAV3 alanı için bir etiket ve metin kutusu -->
            <div>
                <asp:Label for="TxtOgrSınav3" runat="server">SINAV3</asp:Label>
                <asp:TextBox ID="TxtOgrSınav3" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br />
            
            <!-- ORTALAMA alanı için bir etiket ve metin kutusu -->
            <div>
                <asp:Label for="TxtOgrSınavOrt" runat="server">ORTALAMA</asp:Label>
                <asp:TextBox ID="TxtOgrOrt" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            
            <!-- DURUM alanı için bir etiket ve metin kutusu -->
            <div>
                <asp:Label for="TxtOgrDurum" runat="server">DURUM</asp:Label>
                <asp:TextBox ID="TxtOgrDurum" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <br />
            
            <!-- HESAPLA butonu -->
            <asp:Button ID="Button1" runat="server" Text="HESAPLA" CssClass="btn btn-toolbar" OnClick="Button1_Click" />
            
            <!-- GÜNCELLE butonu -->
            <asp:Button ID="Button2" runat="server" Text="GÜNCELLE" CssClass="btn btn-primary" OnClick="Button2_Click" />
        </div>

    </form>
</asp:Content>
