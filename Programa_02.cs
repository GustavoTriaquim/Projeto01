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
    }
}
