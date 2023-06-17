<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="GidenMesajlar.aspx.cs" Inherits="WebApplication2.GidenMesajlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <table class="table table-bordered table-hover">
        <!-- Tablo başlıkları -->
        <tr>
            <th scope="col">ID</th>
            <th scope="col">ALICI</th>
            <th scope="col">BAŞLIK</th>
            <th scope="col">İÇERİK</th>
            <th scope="col">TARİH</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <!-- Verilerin görüntülendiği HTML satırları -->
                    <tr>
                        <td><%#Eval("MESAJID")%></td> <!-- MESAJID alanı -->
                        <td><%#Eval("ALICI")%></td> <!-- ALICI alanı -->
                        <td><%#Eval("BASLIK")%></td> <!-- BASLIK alanı -->
                        <td><%#Eval("ICERIK")%></td> <!-- ICERIK alanı -->
                        <td><%#Eval("TARIH")%></td> <!-- TARIH alanı -->
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
