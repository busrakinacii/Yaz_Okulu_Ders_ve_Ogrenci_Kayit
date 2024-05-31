<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Dersler.aspx.cs" Inherits="YazOkuluDersler.Dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div class="container pt-5">
                <h1>Ders Listesi</h1>
            </div>
            <br />
            <div class="container pt-5">
                <strong>
                    <asp:Label for="DrpDers" runat="server" Text="Ders Listesi"></asp:Label>
                </strong>
                <asp:DropDownList ID="DrpDers" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <br />
            <div class="container pt-5">
                <strong>
                    <asp:Label for="TxtOgrID" runat="server" Text="Öğrenci ID"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtOgrID" runat="server" CssClass="form-control"></asp:TextBox>
            </div>


            <br />
            <div class="container pt-5">
                <strong>
                    <asp:Button ID="BtnDers" runat="server" Text="DERS TALEP OLUŞTUR" class="btn btn-warning" Style="font-weight: bold" OnClick="BtnDers_Click" />
                </strong>
            </div>

        </div>



    </form>
</asp:Content>
