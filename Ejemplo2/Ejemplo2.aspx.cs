using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo_2
{
    public partial class Ejemplo2 : System.Web.UI.Page
    {
        int num1, num2 = 0;
        string respuesta = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblEjemplo.Text += " Y hoy es el dia " + DateTime.Today.ToString("d");
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            if (txtPrimerNumero.Text == "" && txtSegundoNumero.Text == "")
            {
                lblRespuesta.Text = "No dejar los campos vacios, favor ingresar los numeros";
            }
            else
            {
                num1 = int.Parse(txtPrimerNumero.Text);
                num2 = int.Parse(txtSegundoNumero.Text);

                if (chkSumar.Checked)
                {
                    respuesta += "La suma de los numeros es: " + Convert.ToString(sumarNumeros(num1, num2)) + "\n";
                }
                if (chkRestar.Checked)
                {
                    respuesta += "La resta de los numeros es: " + Convert.ToString(restarNumeros(num1, num2)) + "\n";
                }
                if (chkMultiplicar.Checked)
                {
                    respuesta += "La multiplicación de los numeros es: " + Convert.ToString(multiplicarNumeros(num1, num2)) + "\n";
                }
                if (chkDividir.Checked)
                {
                    respuesta += "La división de los numeros es: " + Convert.ToString(dividirNumeros(num1, num2)) + "\n";
                }
                               

                lblRespuesta.Text =  respuesta;
            }
        }

        protected double sumarNumeros(int n1, int n2)
        {
            return (n1 + n2);
        }

        protected double restarNumeros(int n1, int n2)
        {
            return (n1 - n2);
        }

        protected double multiplicarNumeros(int n1, int n2)
        {
            return (n1 * n2);
        }

        protected double dividirNumeros(int n1, int n2)
        {
            return (Convert.ToDouble(n1) / Convert.ToDouble(n2));
        }

    }
}