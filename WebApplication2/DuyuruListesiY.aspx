﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici.Master" AutoEventWireup="true" CodeBehind="DuyuruListesiY.aspx.cs" Inherits="WebApplication2.DuyuruListesiY" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">

        <tr>
            <th scope="col">ID</th>
            <th scope="col">BAŞLIK</th>
            <th scope="col">İÇERİK</th>
            <th scope="col">ÖĞRETMEN</th>

        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("DUYURUID")%></td>
                        <td><%#Eval("DUYURUBASLIK")%></td>
                        <td><%#Eval("DUYURUICERIK")%></td>
                        <td><%#Eval("DUYURUOGRT")%></td>

                        <td>
                            <!-- Duyurunun silme işlemi için HyperLink1 kontrolü kullanılır -->
                            <!-- NavigateUrl özelliği ile DuyuruSilY.aspx sayfasına DuyuruID parametresi eklenir -->
                            <!-- Parametre, Eval() metodu ile DUYURUID değeri olarak belirlenir -->
                            <!-- SİL butonu olarak görüntülenir -->
                            <asp:HyperLink NavigateUrl='<%# "DuyuruSilY.aspx?DuyuruID="+ Eval("DUYURUID")%>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>

                            <!-- Duyurunun güncelleme işlemi için HyperLink2 kontrolü kullanılır -->
                            <!-- NavigateUrl özelliği ile DuyuruGuncelleY.aspx sayfasına DuyuruID parametresi eklenir -->
                            <!-- Parametre, Eval() metodu ile DUYURUID değeri olarak belirlenir -->
                            <!-- GÜNCELLE butonu olarak görüntülenir -->
                            <asp:HyperLink NavigateUrl='<%# "DuyuruGuncelleY.aspx?DuyuruID="+ Eval("DUYURUID")%>' ID="HyperLink2" runat="server" CssClass="btn btn-success">GÜNCELLE</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
