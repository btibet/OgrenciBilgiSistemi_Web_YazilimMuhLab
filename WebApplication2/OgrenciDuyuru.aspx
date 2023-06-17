<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.Master" AutoEventWireup="true" CodeBehind="OgrenciDuyuru.aspx.cs" Inherits="WebApplication2.OgrenciDuyuru" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">

        <tr>
            <!-- Tablo başlıkları eklenecek. -->
            <th scope="col">ID</th>
            <th scope="col">BAŞLIK</th>
            <th scope="col">İÇERİK</th>
            <th scope="col">ÖĞRETMEN</th>

        </tr>

        <tbody>
            <!-- Duyuru tablosunu döngüyle doldurmak için bir Repeater kontrolü kullanılacak. -->
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <!-- Her bir döngü elemanı için bir tablo satırı oluşturulacak. -->
                    <tr>
                        <!-- Duyuru bilgileri tablo hücrelerine yazdırılacak. -->
                        <td><%#Eval("DUYURUID")%></td>
                        <td><%#Eval("DUYURUBASLIK")%></td>
                        <td><%#Eval("DUYURUICERIK")%></td>
                        <td><%#Eval("DUYURUOGRT")%></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
