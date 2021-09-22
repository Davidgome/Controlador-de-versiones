using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_2_Crear_el_area_de_un_triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int b, h;
            double a;
            b = Convert.ToInt16(textbase.Text);
            h = Convert.ToInt16(textaltura.Text);
            a = (b * h) / 2;
            textarea.Text = Convert.ToString(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textaltura.Text = "";
            textbase.Text = "";
            textarea.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}