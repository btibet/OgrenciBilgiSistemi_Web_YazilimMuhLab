<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici.Master" AutoEventWireup="true" CodeBehind="NotListesiY.aspx.cs" Inherits="WebApplication2.NotListesiY" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">

        <tr>
            <!-- Tablo başlık satırı -->
            <th scope="col">ÖĞRENCİ ID</th>
            <th scope="col">AD SOYAD</th>
            <th scope="col">DERS ADI</th>
            <th scope="col">SINAV1</th>
            <th scope="col">SINAV2</th>
            <th scope="col">SINAV3</th>
            <th scope="col">ORTALAMA</th>
            <th scope="col">DURUM</th>
            <th scope="col">GÜNCELLE</th>
        </tr>

        <tbody>
            <!-- Verilerin tekrarlanması için Repeater kullanılıyor -->
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <!-- Veri tablosu hücreleri -->
                        <td><%#Eval("OGRENCIID")%></td>
                        <td><%#Eval("OGRENCIADSOYAD")%></td>
                        <td><%#Eval("DERSAD")%></td>
                        <td><%#Eval("SINAV1")%></td>
                        <td><%#Eval("SINAV2")%></td>
                        <td><%#Eval("SINAV3")%></td>
                        <td><%#Eval("ORTALAMA")%></td>
                        <td><%#Eval("DURUM")%></td>

                        <td>
                            <!-- GÜNCELLE butonu -->
                            <asp:HyperLink NavigateUrl='<%#"NotGuncelleY.aspx?NOTID="+Eval( "NOTID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-success">GÜNCELLE</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
