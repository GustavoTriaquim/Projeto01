using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01
{
    public partial class Programa_01 : Form
    {
        public Programa_01()
        {
            InitializeComponent();
        }

        Point MoverCursor;
        Point MoverForms;
        bool Movendo;

        private void Programa_01_MouseUp(object sender, MouseEventArgs e)
        {
            Movendo = false;
        }

        private void Programa_01_MouseDown(object sender, MouseEventArgs e)
        {
            Movendo = true;
            MoverCursor = Cursor.Position;
            MoverForms = this.Location;
        }

        private void Programa_01_MouseMove(object sender, MouseEventArgs e)
        {
            if (Movendo == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(MoverCursor));
                this.Location = Point.Add(MoverForms, new Size(dif));
            }
        }

        private void ChangePlaceholderOff(TextBox textBox, string text)
        {
            if (textBox.Text == text)
            {
                textBox.Text = "";
            }
        }

        private void ChangePlaceholderOn(TextBox textBox, string text)
        {
            if (textBox.Text == "")
            {
                textBox.Text = text;
            }
        }

        private void textNota1_Enter(object sender, EventArgs e)
        {
            ChangePlaceholderOff(textNota1, "Nota 1");
        }

        private void textNota1_Leave(object sender, EventArgs e)
        {
            ChangePlaceholderOn(textNota1, "Nota 1");
        }

        private void textNota2_Enter(object sender, EventArgs e)
        {
            ChangePlaceholderOff(textNota2, "Nota 2");
        }

        private void textNota2_Leave(object sender, EventArgs e)
        {
            ChangePlaceholderOn(textNota2, "Nota 2");
        }

        private void textNota3_Enter(object sender, EventArgs e)
        {
            ChangePlaceholderOff(textNota3, "Nota 3");
        }

        private void textNota3_Leave(object sender, EventArgs e)
        {
            ChangePlaceholderOn(textNota3, "Nota 3");
        }

        private void textNota4_Enter(object sender, EventArgs e)
        {
            ChangePlaceholderOff(textNota4, "Nota 4");
        }

        private void textNota4_Leave(object sender, EventArgs e)
        {
            ChangePlaceholderOn(textNota4, "Nota 4");
        }

        private void AbrirForm(Type formtype)
        {
            this.Hide();
            Form instancia = (Form)Activator.CreateInstance(formtype);
            instancia.ShowDialog();
            this.Close();
        }
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (textNota1.Text == "")
            {
                MessageBox.Show("Existe(m) nota(s) vazia(s)!", "NOTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textNota1.Focus();
                return;
            }

            if (textNota2.Text == "")
            {
                MessageBox.Show("Existe(m) nota(s) vazia(s)!", "NOTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textNota2.Focus();
                return;
            }

            if (textNota3.Text == "")
            {
                MessageBox.Show("Existe(m) nota(s) vazia(s)!", "NOTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textNota3.Focus();
                return;
            }

            if (textNota4.Text == "")
            {
                MessageBox.Show("Existe(m) nota(s) vazia(s)!", "NOTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textNota4.Focus();
                return;
            }

            double n1 = Convert.ToDouble(textNota1.Text);
            double n2 = Convert.ToDouble(textNota2.Text);
            double n3 = Convert.ToDouble(textNota3.Text);
            double n4 = Convert.ToDouble(textNota4.Text);

            double media = (n1 + n2 + n3 + n4) / 4;

            textResultado.Text = media.ToString("N2");

            if (media >= 7)
            {
                textAprovado.Text = ("Aprovado(a)");
            } 
            else
            {
                textAprovado.Text = ("Reprovado(a)");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textNota1.Text = "Nota 1";
            textNota2.Text = "Nota 2";
            textNota3.Text = "Nota 3";
            textNota4.Text = "Nota 4";

            textResultado.Text = "Nota Final";
            textAprovado.Text = "Estado";
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            AbrirForm(typeof(Menu));
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
