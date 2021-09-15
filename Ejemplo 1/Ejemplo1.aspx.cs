using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo_1
{
    public partial class Ejemplo1 : System.Web.UI.Page
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

                if (rdbSumar.Checked)
                {
                    respuesta = Convert.ToString(sumarNumeros(num1, num2));
                }
                else if (rdbRestar.Checked)
                {
                    respuesta = Convert.ToString(restarNumeros(num1, num2));
                }
                else
                {
                    respuesta = "Seleccione una opción";
                }

                
                lblRespuesta.Text = "La respuesta es: " + respuesta;
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

  

    }
}