<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="DersListesi.aspx.cs" Inherits="WebApplication2.DersListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!-- Ders listesi için bir HTML tablosu oluşturuluyor -->
    <table class="table table-bordered table-hover">

        <tr>
            <!-- Tablo başlıkları -->
            <th scope="col">DERS ID</th>
            <th scope="col">DERS AD</th>
        </tr>

        <tbody>
            <!-- Derslerin listelendiği bir tekrarlayıcı (Repeater) kontrolü -->
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <!-- Her ders için bir tablo satırı oluşturuluyor -->
                    <tr>
                        <!-- DERSID alanı -->
                        <td><%#Eval("DERSID")%></td>
                        <!-- DERSAD alanı -->
                        <td><%#Eval("DERSAD")%></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
