using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        #region Variáveis
        private string operacao = String.Empty;
        private double acumulado = 0;
        #endregion

        #region Botões Numéricos e vírgula
        private void BtnZero_Click(object sender, EventArgs e)
        {
            display.Text += 0;
            RedefinirFonte();
        }

        private void BtnUm_Click(object sender, EventArgs e)
        {
            display.Text += 1;
            RedefinirFonte();
        }

        private void BtnDois_Click(object sender, EventArgs e)
        {
            display.Text += 2;
            RedefinirFonte();
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            display.Text += 3;
            RedefinirFonte();
        }

        private void BtnQuatro_Click(object sender, EventArgs e)
        {
            display.Text += 4;
            RedefinirFonte();
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            display.Text += 5;
            RedefinirFonte();
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            display.Text += 6;
            RedefinirFonte();
        }

        private void BtnSete_Click(object sender, EventArgs e)
        {
            display.Text += 7;
            RedefinirFonte();
        }

        private void BtnOito_Click(object sender, EventArgs e)
        {
            display.Text += 8;
            RedefinirFonte();
        }

        private void BtnNove_Click(object sender, EventArgs e)
        {
            display.Text += 9;
            RedefinirFonte();
        }

        private void BtnVirgula_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains(","))
            {
                display.Text += ",";
                RedefinirFonte();
            }
        }
        #endregion

        #region Operações
        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "-" || operacao == "+")
            {
                operacao = "/";
            }
            else
            {
                try
                {
                    acumulado = Double.Parse(display.Text);
                    display.Text = String.Empty;
                    operacao = "/";
                }
                catch
                {
                    acumulado = 0;
                    display.Text = String.Empty;
                    operacao = "/";
                }
            }
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (operacao == "/" || operacao == "-" || operacao == "+")
            {
                operacao = "*";
            }
            else
            {
                try
                {
                    acumulado = Double.Parse(display.Text);
                    display.Text = String.Empty;
                    operacao = "*";
                }
                catch
                {
                    acumulado = 0;
                    display.Text = String.Empty;
                    operacao = "*";
                }
            }
        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "/" || operacao == "+")
            {
                operacao = "-";
            }
            else
            {
                try
                {
                    acumulado = Double.Parse(display.Text);
                    display.Text = String.Empty;
                    operacao = "-";
                }
                catch
                {
                    acumulado = 0;
                    display.Text = String.Empty;
                    operacao = "-";
                }
            }
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";
            }
            else
            {
                try
                {
                    operacao = "+";
                    acumulado += Double.Parse(display.Text);
                    valorAcumulado.Text += display.Text + operacao;
                    display.Text = String.Empty;
                }
                catch
                {
                    acumulado = 0;
                    display.Text = String.Empty;
                    operacao = "+";
                    valorAcumulado.Text += acumulado + operacao;
                }
            }
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            if (operacao == "/")
            {
                if (Double.Parse(display.Text) != 0)
                {
                    try
                    {
                        acumulado /= Double.Parse(display.Text);
                        display.Text = acumulado.ToString();
                        RedefinirFonte();
                    }
                    catch
                    {
                        acumulado = 0;
                        display.Text = String.Empty;
                        operacao = "/";
                    }
                }
                else
                {
                    display.Text = "Não é possível dividir por zero";
                    RedefinirFonte();
                }
            }
            else if (operacao == "*")
            {
                acumulado *= double.Parse(display.Text);
                display.Text = acumulado.ToString();
                RedefinirFonte();
            }
            else if (operacao == "-")
            {
                acumulado -= Double.Parse(display.Text);
                display.Text = acumulado.ToString();
                RedefinirFonte();
            }
            else if (operacao == "+")
            {
                acumulado += double.Parse(display.Text);
                display.Text = acumulado.ToString();
                RedefinirFonte();
            }
        }
        #endregion

        #region Ações
        private void BtnBackspace_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparVariaveis();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (acumulado != 0 && !String.IsNullOrEmpty(operacao))
            {
                display.Text = String.Empty;
                RedefinirFonte();
            }
            else
            {
                display.Text = String.Empty;
                RedefinirFonte();
            }
        }
        #endregion

        #region Funções Auxiliares
        private void RedefinirFonte()
        {
            if (display.Text.Length >= 16)
            {
                display.Font = new Font(display.Font.FontFamily, 15);
            }
            else
            {
                display.Font = new Font(display.Font.FontFamily, 28);
            }
        }

        private void LimparVariaveis()
        {
            operacao = String.Empty;
            acumulado = 0;
            display.Text = String.Empty;
        }
        #endregion
    }
}
