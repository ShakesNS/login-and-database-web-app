<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="hafta_15_ders_2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td>Kullanıcı Adı: </td>
                    <td> <asp:TextBox ID="tbKullaniciAdi" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td>Parola: </td>
                    <td> <asp:TextBox ID="tbParola" runat="server" ></asp:TextBox> </td>
                </tr>
                <tr>
                    
                    <td> <asp:Button ID="Button1" runat="server" Text="Giriş" OnClick="Button1_Click" /> </td>
                </tr>

                <tr>
                    <td> <asp:Label ID="Label1" runat="server" Text=""></asp:Label> </td>
                </tr>

            </table>
            <br /><br />
            
    </form>
</body>
</html>
