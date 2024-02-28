<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <asp:TextBox runat="server" TextMode="Email" placeholder="mail" required=""></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" ToolTip="pd"/>
    <input id="Button2" type="url" value="button" />

    
</asp:Content>

