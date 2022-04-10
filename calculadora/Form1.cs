using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class frmcalculadora : Form
    {
        public frmcalculadora()
        {
            InitializeComponent();
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            Calculadora2 calc = new Calculadora2();
            lbloperacao.Text = "+";
            txtresult.Text = calc.soma(Convert.ToDouble(txtnum1.Text), Convert.ToDouble(txtnum2.Text)).ToString();
            
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            Calculadora2 calc = new Calculadora2();
            lbloperacao.Text = "-";
            txtresult.Text = calc.subtracao(Convert.ToDouble(txtnum1.Text), Convert.ToDouble(txtnum2.Text)).ToString();
            
        }

        private void bntmulti_Click(object sender, EventArgs e)
        {
            Calculadora2 calc = new Calculadora2();
            lbloperacao.Text = "*";
            txtresult.Text = calc.multiplicacao(Convert.ToDouble(txtnum1.Text), Convert.ToDouble(txtnum2.Text)).ToString();

        }

        private void bntdivisao_Click(object sender, EventArgs e)
        {
            Calculadora2 calc = new Calculadora2();
            lbloperacao.Text = "÷";
            txtresult.Text = calc.divicao(Convert.ToDouble(txtnum1.Text), Convert.ToDouble(txtnum2.Text)).ToString();
        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
            Calculadora2 calc = new Calculadora2();
            lbloperacao.Text = "media";
            txtresult.Text = calc.media(Convert.ToDouble(txtnum1.Text), Convert.ToDouble(txtnum2.Text)).ToString();
        }

        private void frmcalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Calculadora2 calc = new Calculadora2();
            calc.limpar(this);
        }

        private void nblnum1_Click(object sender, EventArgs e)
        {

        }

        private void lblEqual_Click(object sender, EventArgs e)
        {

        }
    }
    
}
