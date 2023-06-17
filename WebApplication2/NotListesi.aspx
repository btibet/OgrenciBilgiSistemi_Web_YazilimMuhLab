<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="NotListesi.aspx.cs" Inherits="WebApplication2.NotListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">

        <tr>
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
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("OGRENCIID")%></td> <!-- Öğrenci ID'si -->
                        <td><%#Eval("OGRENCIADSOYAD")%></td> <!-- Öğrenci adı soyadı -->
                        <td><%#Eval("DERSAD")%></td> <!-- Ders adı -->
                        <td><%#Eval("SINAV1")%></td> <!-- Sınav 1 notu -->
                        <td><%#Eval("SINAV2")%></td> <!-- Sınav 2 notu -->
                        <td><%#Eval("SINAV3")%></td> <!-- Sınav 3 notu -->
                        <td><%#Eval("ORTALAMA")%></td> <!-- Notların ortalaması -->
                        <td><%#Eval("DURUM")%></td> <!-- Durum (Geçti, Kaldı) -->
                        
                        <td>
                            <asp:HyperLink NavigateUrl='<%#"NotGuncelle.aspx?NOTID="+Eval( "NOTID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-success">GÜNCELLE</asp:HyperLink>
                        </td> <!-- Güncelleme linki -->
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
