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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //Mover Janela
        Point MoverCursor;
        Point MoverForms;
        bool Movendo;

        private void Menu_MouseUp(object sender, MouseEventArgs e)
        {
            Movendo = false;
        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            Movendo = true;
            MoverCursor = Cursor.Position;
            MoverForms = this.Location;
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (Movendo == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(MoverCursor));
                this.Location = Point.Add(MoverForms, new Size(dif));
            }
        }
        
        //Navegacao de formularios
        private void AbrirForm(Type formType)
        {
            this.Hide();
            Form instancia = (Form)Activator.CreateInstance(formType);
            instancia.ShowDialog();
            this.Close();
        }
        
        private void Prog01_Click(object sender, EventArgs e)
        {
            AbrirForm(typeof(Programa_01));
        }

        private void Prog02_Click(object sender, EventArgs e)
        {
            AbrirForm(typeof(Programa_02));
        }

        private void Prog03_Click(object sender, EventArgs e)
        {
            AbrirForm(typeof(Programa_03));
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
