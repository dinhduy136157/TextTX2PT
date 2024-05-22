<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="TextTX2PT.List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="tieude" runat="server">
    Danh sách
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="noidung" runat="server">
    <h2>Danh sách nhân viên</h2>
    <asp:GridView ID="grdDs" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="Mã NV" />
            <asp:BoundField DataField="name" HeaderText="Họ tên" />
            <asp:BoundField DataField="gender" HeaderText="Giới tính" />
            <asp:BoundField DataField="address" HeaderText="Địa chỉ" />
            <asp:BoundField DataField="email" HeaderText="Email" />
            <asp:BoundField DataField="title" HeaderText="Chức vụ" />

            <asp:TemplateField HeaderText="Xoá">
                <ItemTemplate>
                    <asp:Button ID="xoa" CommandName="xoa" CommandArgument='<%# Bind("id") %>'
                        Text="Xoá" runat="server" OnCommand="Xoa_Click"
                        OnClientClick="return confirm('Bạn có chắc xoá không ?')" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Sửa">
                <ItemTemplate>
                    <asp:Button ID="capnhat" CommandName="capnhat" CommandArgument='<%# Bind("id") %>'
                        Text="Cập nhật" runat="server" OnCommand="Sua_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
