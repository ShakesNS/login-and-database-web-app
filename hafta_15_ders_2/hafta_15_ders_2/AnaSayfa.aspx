<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="hafta_15_ders_2.AnaSayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


                <asp:ListView ID="ListView1" runat="server">  
        <itemtemplate>  
       <table >  
           <tr>  
                        <td style =" width : 100px">  
                            <b>Ad</b>  <br />
                            <%#Eval("Ad") %>  
                        </td>  
                        <td style =" width : 200px">  
                            <b>Soyad</b>  <br />
                            <%#Eval("Soyad") %>  
                        </td>  
                        <td style =" width : 200px">  
                            <b>TcKimlik</b>  <br />
                            <%#Eval("TcKimlik") %>  
                        </td >  
                        <td style =" width : 250px">  
                            <b>Adres</b>  <br />
                            <%#Eval("Adres") %>  
                        </td>  

            </tr>  
       </table>  
       </itemtemplate>  
    </asp:ListView> 








    </form>
</body>
</html>
