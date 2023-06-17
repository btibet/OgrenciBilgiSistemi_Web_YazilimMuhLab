<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici.Master" AutoEventWireup="true" CodeBehind="YoneticiDefault.aspx.cs" Inherits="WebApplication2.YöneticiDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <!-- Öğrenci Listesi Tablosu -->
    <table class="table table-bordered table-hover">
        <tr>
            <th scope="col">ID</th> <!-- Öğrenci ID -->
            <th scope="col">NUMARA</th> <!-- Öğrenci Numarası -->
            <th scope="col">AD</th> <!-- Öğrenci Adı -->
            <th scope="col">SOYAD</th> <!-- Öğrenci Soyadı -->
            <th scope="col">TELEFON</th> <!-- Öğrenci Telefonu -->
            <th scope="col">MAİL</th> <!-- Öğrenci E-Posta Adresi -->
            <th scope="col">ŞİFRE</th> <!-- Öğrenci Şifresi -->
            <th scope="col">İŞLEMLER</th> <!-- İşlem Sütunu -->
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("OGRID")%></td> <!-- Öğrenci ID -->
                        <td><%#Eval("NUMARA")%></td> <!-- Öğrenci Numarası -->
                        <td><%#Eval("OGRAD")%></td> <!-- Öğrenci Adı -->
                        <td><%#Eval("OGRSOYAD")%></td> <!-- Öğrenci Soyadı -->
                        <td><%#Eval("OGRTEL")%></td> <!-- Öğrenci Telefonu -->
                        <td><%#Eval("OGRMAIL")%></td> <!-- Öğrenci E-Posta Adresi -->
                        <td><%#Eval("OGRSIFRE")%></td> <!-- Öğrenci Şifresi -->
                        <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/OgrenciSilY.aspx?OGRID="+Eval("OGRID")%>' runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink> <!-- Silme İşlemi -->
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/OgrenciGuncelleY.aspx?OGRID="+Eval("OGRID")%>' runat="server" CssClass="btn btn-success">GÜNCELLE</asp:HyperLink> <!-- Güncelleme İşlemi -->
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
