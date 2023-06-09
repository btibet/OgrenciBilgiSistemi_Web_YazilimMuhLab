﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.Master" AutoEventWireup="true" CodeBehind="OgrenciGiden.aspx.cs" Inherits="WebApplication2.OgrenciGiden" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th scope="col">ALICI</th>
            <th scope="col">BAŞLIK</th>
            <th scope="col">İÇERİK</th>
            <th scope="col">TARİH</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("OGRADSOYAD")%></td> <!-- OGRADSOYAD alanını ekrana yazdırır -->
                        <td><%#Eval("BASLIK")%></td> <!-- BASLIK alanını ekrana yazdırır -->
                        <td><%#Eval("ICERIK")%></td> <!-- ICERIK alanını ekrana yazdırır -->
                        <td><%#Eval("TARIH")%></td> <!-- TARIH alanını ekrana yazdırır -->
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
