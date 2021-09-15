<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejemplo1.aspx.cs" Inherits="Ejemplo_1.Ejemplo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ejemplo 1</title>
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
            
            <asp:RadioButton GroupName="Seleccion" ID="rdbSumar" runat="server" Checked="True" Text="Sumar" />
            <br />
            <asp:RadioButton GroupName="Seleccion" ID="rdbRestar" runat="server" Text="Restar" />
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
