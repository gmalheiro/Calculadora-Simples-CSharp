using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calculadora
{
    public class Calculadora2
    {
        public double soma(double num1, double num2 )
        {
            return num1 + num2;

        }
        public double subtracao(double num1, double num2)
        {
            return num1 - num2;

        }
        public double multiplicacao(double num1, double num2)
        {
            return num1 * num2;

        }
        public double divicao(double num1, double num2)
        {
            double div;

            if(num2 != 0)
            {

                div = 0;
            }
            else
            {
                MessageBox.Show("NÃO É POSSÍVEL DIVIDIR POR 0", "ERRO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                div = num1 / num2;
            }
            
            return div;

        }
        public double media(double num1, double num2)
        {
            return (num1 + num2) / 2;


        }

        public void limpar(Form formLimpar)
        {
            foreach (Control item in formLimpar.Controls) {
                    
                if(item is TextBox)
                {
                    (item as TextBox).Clear();  
                }
            }
        }

    }
}
