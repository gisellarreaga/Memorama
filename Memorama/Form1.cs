using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Levicapacover_Click(object sender, EventArgs e)
        {
            Levicapacover.Visible = false;
            Levicapa.Visible = true;

        }

        private void Exploracioncover_Click(object sender, EventArgs e)
        {
            Exploracioncover.Visible = false;
            Exploracion.Visible = true; 
        }

        private void Caballocover_Click(object sender, EventArgs e)
        {
            Caballocover.Visible = false;
            Caballo.Visible = true;
        }

        private void Espadascover_Click(object sender, EventArgs e)
        {
            Espadascover.Visible = false;
            Espadas.Visible = true;
        }

        private void Espadas1cover_Click(object sender, EventArgs e)
        {
            Espadas1cover.Visible = false;
            Espadas1.Visible = true;
        }

        private void Caballo1cover_Click(object sender, EventArgs e)
        {
            Caballo1cover.Visible = false;
            Caballo1.Visible = true;
        }

        private void Rosascover_Click(object sender, EventArgs e)
        {
            Rosascover.Visible = false;
            Rosas.Visible = true;
        }

        private void Rosas1cover_Click(object sender, EventArgs e)
        {
            Rosas1cover.Visible = false;
            Rosas1.Visible = true;
        }

        private void Levicover_Click(object sender, EventArgs e)
        {
            Levicover.Visible = false;
            Levi.Visible = true;
        }

        private void Exploracion1cover_Click(object sender, EventArgs e)
        {
            Exploracion1cover.Visible = false;
            Exploracion1.Visible = true;
        }

        private void Levicapa1cover_Click(object sender, EventArgs e)
        {
            Levicapa1cover.Visible = false;
            Levicapa1.Visible = true;
        }

        private void Levi1cover_Click(object sender, EventArgs e)
        {
            Levi1cover.Visible = false;
            Levi1.Visible = true;
        }
    }
}
