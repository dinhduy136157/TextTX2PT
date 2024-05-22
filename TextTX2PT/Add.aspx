<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="TextTX2PT.Add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="tieude" runat="server">
    Thêm nhân viên
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="noidung" runat="server">
    <h2>Thêm nhân viên</h2>
    <asp:Table ID="tblds" runat="server">
        <asp:TableRow>
            <asp:TableCell>Họ tên</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtht" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Giới tính</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtgt" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Địa chỉ</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtdc" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Email</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtemail" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Chức vụ</asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="ddl" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Button ID="btnThem" runat="server" Text="Thêm sinh viên" OnClick="btnThem_Click" />
    <p>
        <asp:Label ID="msg" runat="server" Font-Italic="true" />
    </p>
</asp:Content>
