using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            string Titulo = "";
            string Genero = "";
            int    Ano;
            string Avaliacao = "";

            Titulo = textBox_Titulo.Text;
            Genero = textBox_Genero.Text;
            Ano = int.Parse(textBox_Ano.Text);
            Avaliacao = textBox_Avaliacao.Text;

            label_Titulo.Text = Titulo;
            label_Avaliacao.Text = Avaliacao;
        }
    }
}
