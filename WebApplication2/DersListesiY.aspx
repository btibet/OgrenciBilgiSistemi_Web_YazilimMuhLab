﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici.Master" AutoEventWireup="true" CodeBehind="DersListesiY.aspx.cs" Inherits="WebApplication2.DersListesiY" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!-- Ders listesini görüntülemek için bir HTML tablosu oluşturuluyor -->
    <table class="table table-bordered table-hover">

        <tr>
            <!-- Tablo başlıkları -->
            <th scope="col">DERS ID</th>
            <th scope="col">DERS AD</th>
            <th scope="col">İŞLEMLER</th>
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

                        <!-- İŞLEMLER alanı -->
                        <td>
                            <!-- Dersin silme işlemi için bir HyperLink oluşturuluyor -->
                            <asp:HyperLink NavigateUrl='<%# "DersSil.aspx?DERSID="+ Eval("DERSID")%>' ID="HyperLink1"   runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>
                            
                            <!-- Dersin güncelleme işlemi için bir HyperLink oluşturuluyor -->
                            <asp:HyperLink NavigateUrl='<%# "DersGuncelle.aspx?DERSID="+ Eval("DERSID")%>' ID="HyperLink2" runat="server" CssClass="btn btn-success">GÜNCELLE</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            
        </tbody>
    </table>
    
    <!-- Ders ekleme işlemi için bir HyperLink oluşturuluyor -->
    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/DersEkle.aspx" CssClass="btn btn-info">DERS EKLE</asp:HyperLink>
</asp:Content>
