<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici.Master" AutoEventWireup="true" CodeBehind="MesajlarYonetici.aspx.cs" Inherits="WebApplication2.MesajlarYonetici" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!-- Tablo başlatılıyor -->
    <table class="table table-bordered table-hover">

        <tr>
            <!-- Sütun başlıkları -->
            <th scope="col">ID</th>
            <th scope="col">GÖNDEREN</th>
            <th scope="col">ALICI</th>
            <th scope="col">BAŞLIK</th>
            <th scope="col">İÇERİK</th>
            <th scope="col">TARİH</th>
        </tr>

        <tbody>
            <!-- Repeater kullanarak veriler listeleniyor -->
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <!-- Veritabanından gelen alanlar ile sütun değerleri eşleştiriliyor -->
                        <td><%#Eval("MESAJID")%></td>
                        <td><%#Eval("GONDEREN")%></td>
                        <td><%#Eval("ALICI")%></td>
                        <td><%#Eval("BASLIK")%></td>
                        <td><%#Eval("ICERIK")%></td>
                        <td><%#Eval("TARIH")%></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
