<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="YazOkuluDersler.OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div class="container pt-5">
                <h1>Öğrenci Güncelleme Sayfası</h1>
            </div>
            <br />
            <div class="container pt-5">
                <strong>
                    <asp:Label for="TxtID" runat="server" Text="Öğrenci ID"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtID" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div class="container pt-5">
                <strong>
                    <asp:Label for="TxtOgrAd" runat="server" Text="Öğrenci Adı"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtOgrAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="container pt-5">
                <strong>
                    <asp:Label for="TxtOgrSoyad" runat="server" Text="Öğrenci Soyadı"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtOgrSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="container pt-5">
                <strong>
                    <asp:Label for="TxtOgrNo" runat="server" Text="Öğrenci Numara"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtOgrNo" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="container pt-5">
                <strong>
                    <asp:Label for="TxtOgrFoto" runat="server" Text="Öğrenci Fotoğraf"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtOgrFoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="container pt-5">
                <strong>
                    <asp:Label for="TxtOgrSifre" runat="server" Text="Öğrenci Şifre"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtOgrSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />
            <div class="container pt-5">
                <strong>
                    <asp:Button ID="BtnGuncelle" runat="server" Text="GÜNCELLE" class="btn btn-warning" Style="font-weight: bold" OnClick="BtnGuncelle_Click" />
                </strong>
            </div>

        </div>



    </form>
</asp:Content>
