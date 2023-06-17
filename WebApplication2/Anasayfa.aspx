<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="WebApplication2.Anasayfa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">

        <!-- Tablo başlığı -->
        <tr>
            <th scope="col">ID</th>
            <th scope="col">NUMARA</th>
            <th scope="col">AD</th>
            <th scope="col">SOYAD</th>
            <th scope="col">TELEFON</th>
            <th scope="col">MAİL</th>
            <th scope="col">ŞİFRE</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <!-- Verilerle birlikte tablo satırı -->
                    <tr>
                        <td><%#Eval("OGRID")%></td>
                        <td><%#Eval("NUMARA")%></td>
                        <td><%#Eval("OGRAD")%></td>
                        <td><%#Eval("OGRSOYAD")%></td>
                        <td><%#Eval("OGRTEL")%></td>
                        <td><%#Eval("OGRMAIL")%></td>
                        <td><%#Eval("OGRSIFRE")%></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>