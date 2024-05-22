<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sua.aspx.cs" Inherits="TextTX2PT.Sua" %>

<asp:Content ID="Content1" ContentPlaceHolderID="tieude" runat="server">
    Cập nhât
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="noidung" runat="server">
    <h2>Cập nhật nhân viên</h2>

    <asp:Table ID="tblds" runat="server">
        <asp:TableRow>
            <asp:TableCell>Mã NV</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtmanv" runat="server" Enabled="false" />
            </asp:TableCell>
        </asp:TableRow>
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
    <asp:Button ID="btnSua" runat="server" Text="Sửa sinh viên" OnClick="btnSua_Click" />
    <p>
        <asp:Label ID="msg" runat="server" Font-Italic="true" />
    </p>
</asp:Content>
