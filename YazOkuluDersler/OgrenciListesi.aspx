<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="YazOkuluDersler.OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci ID</th>
            <th>Öğrenci Ad</th>
            <th>Öğrenci Soyad</th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Öğrenci Bakiye</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Id") %></td>
                        <td><%# Eval("Name") %></td>
                        <td><%# Eval("Surname") %></td>
                        <td><%# Eval("Number") %></td>
                        <td><%# Eval("Password") %></td>
                        <td><%# Eval("Photo") %></td>
                        <td><%# Eval("Balance") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciSil.aspx?OGRID="+Eval("Id") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">SİL</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciGuncelle.aspx?OGRID="+Eval("Id") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">GÜNCELLE</asp:HyperLink>

                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
