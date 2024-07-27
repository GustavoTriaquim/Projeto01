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

        private void AbrirForm(Type formtype)
        {
            this.Hide();
            Form instancia = (Form)Activator.CreateInstance(formtype);
            instancia.ShowDialog();
            this.Close();
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
