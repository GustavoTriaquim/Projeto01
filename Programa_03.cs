using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Projeto01
{
    public partial class Programa_03 : Form
    {
        public Programa_03()
        {
            InitializeComponent();
        }

        Point MoverCursor;
        Point MoverForms;
        bool Movendo;

        private void AbrirForms(Type formType)
        {
            this.Hide();
            Form instancia = (Form)Activator.CreateInstance(formType);
            instancia.ShowDialog();
            this.Close();
        }
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            AbrirForms(typeof(Menu));
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangePlaceholderOff(TextBox textbox, string text)
        {
            if (textbox.Text == text)
            {
                textbox.Text = "";
            }
        }

        private void ChangePlaceholderOn(TextBox textbox, string text)
        {
            if (textbox.Text == "")
            {
                textbox.Text = text;
            }
        }

        private void textBruto_Enter(object sender, EventArgs e)
        {
            ChangePlaceholderOff(textBruto, "Valor Bruto");
        }

        private void textBruto_Leave(object sender, EventArgs e)
        {
            ChangePlaceholderOn(textBruto, "Valor Bruto");
        }

        private void buttonDP_Click(object sender, EventArgs e)
        {
            if (textBruto.Text == "Valor Bruto")
            {
                MessageBox.Show("O valor bruto está vazio!", "VALOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            double valorBruto = Convert.ToDouble(textBruto.Text);
            double desconto = 5;
            double porcentagem = desconto / 100;
            double valorFinal = valorBruto -  (valorBruto * porcentagem); 

            textFinal.Text = valorFinal.ToString();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (textBruto.Text == "Valor Bruto")
            {
                MessageBox.Show("O valor bruto está vazio!", "VALOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            double valorBruto = Convert.ToDouble(textBruto.Text);
            double desconto = 7;
            double porcentagem = desconto / 100;
            double valorFinal = valorBruto - (valorBruto * porcentagem);

            textFinal.Text = valorFinal.ToString();
        }

        private void buttonSJ_Click(object sender, EventArgs e)
        {
            if (textBruto.Text == "Valor Bruto")
            {
                MessageBox.Show("O valor bruto está vazio!", "VALOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            double valorBruto = Convert.ToDouble(textBruto.Text);
            double parcelas = valorBruto / 2;

            textFinal.Text = parcelas.ToString() + " por parcela";
        }

        private void buttonCJ_Click(object sender, EventArgs e)
        {
            if (textBruto.Text == "Valor Bruto")
            {
                MessageBox.Show("O valor bruto está vazio!", "VALOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string quantidade = Interaction.InputBox("Quantidade de parcelas: ", "InputBox");
                double valorBruto = Convert.ToDouble(textBruto.Text);
                double parcelas = Convert.ToDouble(quantidade);
                double valorParcelas = valorBruto / parcelas;

                double juros = 3;
                double porcentagem = juros / 100;
                double valorFinal = valorParcelas + (valorParcelas * porcentagem);

                textFinal.Text = valorFinal.ToString("N2") + " por parcela";
            }

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBruto.Text = "Valor Bruto";
            textFinal.Text = "Valor Final";
        }
    }
}
