<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici.Master" AutoEventWireup="true" CodeBehind="OgretmenListesi.aspx.cs" Inherits="WebApplication2.OgretmenListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <!-- Öğretmenlerin listelendiği tablo -->
    <table class="table table-bordered table-hover">
        <tr>
            <th scope="col">ID</th>
            <th scope="col">AD SOYAD</th>
            <th scope="col">BRANŞ</th>
            <th scope="col">NUMARA</th>
            <th scope="col">ŞİFRE</th>
            <th scope="col">İŞLEMLER</th>
        </tr>
        <tbody>
            <!-- Öğretmenlerin tekrarlayan bir şekilde listelendiği Repeater kontrolü -->
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <!-- Öğretmen bilgilerinin sırasıyla ekrana yazdırılması -->
                        <td><%#Eval("OGRTID")%></td>
                        <td><%#Eval("OGRTADSOYAD")%></td>
                        <td><%#Eval("DERSAD")%></td>
                        <td><%#Eval("OGRNUMARA")%></td>
                        <td><%#Eval("OGRTSIFRE")%></td>
                        <td>
                            <!-- Öğretmenin silme işlemi için HyperLink kontrolü -->
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/OgretmenSil.aspx?OGRTID="+Eval("OGRTID")%>' runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>
                            <!-- Öğretmenin güncelleme işlemi için HyperLink kontrolü -->
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/OgretmenGuncelle.aspx?OGRTID="+Eval("OGRTID")%>' runat="server" CssClass="btn btn-success">GÜNCELLE</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
