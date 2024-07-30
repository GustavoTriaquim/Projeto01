using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01
{
    public partial class Programa_02 : Form
    {
        public Programa_02()
        {
            InitializeComponent();
        }

        Point MoverCursor;
        Point MoverForms;
        bool Movendo;

        private void Programa_02_MouseUp(object sender, MouseEventArgs e)
        {
            Movendo = false;
        }

        private void Programa_02_MouseDown(object sender, MouseEventArgs e)
        {
            Movendo = true;
            MoverCursor = Cursor.Position;
            MoverForms = this.Location;
        }

        private void Programa_02_MouseMove(object sender, MouseEventArgs e)
        {
            if (Movendo == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(MoverCursor));
                this.Location = Point.Add(MoverForms, new Size(dif));
            }
        }

        private void ChangePlaceholderOff(TextBox textbox, string text)
        {
            if (textbox.Text == text)
            {
                textbox.Text = "";
            }
        }

        private void ChangePlaceHolderOn(TextBox textbox, string text)
        {
            if (textbox.Text == "")
            {
                textbox.Text = text;
            }
        }

        private void textSalario_Enter(object sender, EventArgs e)
        {
            ChangePlaceholderOff(textSalario, "Salário");
        }

        private void textSalario_Leave(object sender, EventArgs e)
        {
            ChangePlaceHolderOn(textSalario, "Salário");
        }

        private void textReajuste_Enter(object sender, EventArgs e)
        {
            ChangePlaceholderOff(textReajuste, "Reajuste(%)");
        }

        private void textReajuste_Leave(object sender, EventArgs e)
        {
            ChangePlaceHolderOn(textReajuste, "Reajuste(%)");
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textSalario.Text == "")
            {
                MessageBox.Show("Existe(m) campo(s) vazio(s)", "SALARIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (textReajuste.Text == "")
            {
                MessageBox.Show("Existe(m) campo(s) vazio(s)", "Reajuste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            double salario = Convert.ToDouble(textSalario.Text);
            double reajuste = Convert.ToDouble(textReajuste.Text);
            double porcentagem = reajuste / 100;
            double salarioReajustado = (salario * porcentagem) + salario;

            textResultado.Text = salarioReajustado.ToString();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textSalario.Text = "Salário";
            textSalario.Text = "Reajuste(%)";
            textResultado.Text = "Salário Final";
        }
    }
}
