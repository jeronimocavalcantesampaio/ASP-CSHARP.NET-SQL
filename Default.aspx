<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Conectando a base de dados MSSQL com asp.net core 2</title>
</head>
<body bgcolor="#ccffff">
    <form id="form1" runat="server">
    <div>
        Codigo &nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" BackColor="#FFFFC0" Width="118px"></asp:TextBox><br />
        Nome&nbsp; &nbsp; &nbsp;
        <asp:TextBox ID="TextBox2" runat="server" BackColor="#FFFFC0" Width="438px"></asp:TextBox>
        <br />
        Endereço
        <asp:TextBox ID="TextBox3" runat="server" BackColor="#FFFFC0" Width="438px"></asp:TextBox><br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Label ID="Label1" runat="server"></asp:Label><br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Button ID="Button1" runat="server" BackColor="Yellow" OnClick="Button1_Click"
            Text="Adicionar" />
        <asp:Button ID="Button2" runat="server" BackColor="Red" OnClick="Button2_Click" Text="Deletar Tudo" /><br />
        <br />
        Ja Cadastrados:<br />
        <asp:DataGrid ID="Grid" runat="server" BackColor="#C0C000" Height="127px" Width="579px">
        </asp:DataGrid>
    
    </div>
        <br />
        <br />
        <br />
        By Jerônimo Cavalcante Sampaio<br />
        jeronimocavalcantesampaio@gmail.com<br />
    </form>
</body>
</html>
