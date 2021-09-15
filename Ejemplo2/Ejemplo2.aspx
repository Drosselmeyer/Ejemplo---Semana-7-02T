<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejemplo2.aspx.cs" Inherits="Ejemplo_2.Ejemplo2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ejemplo 2</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 287px">
            
            <asp:Label ID="lblEjemplo" runat="server" Text="Este es un ejemplo que solicita 2 numeros y realiza la operacion solicitada"></asp:Label>
            
            <br />
            <br />
            <asp:Label ID="lblPrimerNumero" runat="server" Text="Primer Numero"></asp:Label>
            <br />
            <asp:TextBox ID="txtPrimerNumero" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblSegundoNumero" runat="server" Text="Segundo Numero"></asp:Label>
            <br />
            <asp:TextBox ID="txtSegundoNumero" runat="server"></asp:TextBox>
            <br />
            <br />
            
            <asp:CheckBox ID="chkSumar" runat="server" Text="Sumar" />
            <br />
            <asp:CheckBox ID="chkRestar" runat="server" Text="Restar" />
            <br />
            <asp:CheckBox ID="chkMultiplicar" runat="server" Text="Multiplicar" />
            <br />
            <asp:CheckBox ID="chkDividir" runat="server" Text="Dividir" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblRespuesta" runat="server"></asp:Label>

            <p>
                <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" Text="¡Click aqui!" />
            </p>
            
        </div>
        
    </form>
</body>
</html>
