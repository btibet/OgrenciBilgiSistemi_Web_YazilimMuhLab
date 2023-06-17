<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="GelenMesaj.aspx.cs" Inherits="WebApplication2.GelenMesaj" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">

          <%-- Tablo Başlıkları --%>
        <tr>
            <th scope="col">ID</th>
            <th scope="col">GÖNDEREN</th>
            <th scope="col">BAŞLIK</th>
            <th scope="col">İÇERİK</th>
            <th scope="col">TARİH</th>
        </tr>

        <tbody>
            <%-- Veritabanından gelen mesajları listeleyen repeater kontrolleri --%>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("MESAJID")%></td>  <%-- MESAJID alanını gösterir --%>
                        <td><%#Eval("GONDEREN")%></td>  <%-- GONDEREN alanını gösterir --%>
                        <td><%#Eval("BASLIK")%></td>  <%-- BASLIK alanını gösterir --%>
                        <td><%#Eval("ICERIK")%></td>  <%-- ICERIK alanını gösterir --%>
                        <td><%#Eval("TARIH")%></td>  <%-- TARIH alanını gösterir -->
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
