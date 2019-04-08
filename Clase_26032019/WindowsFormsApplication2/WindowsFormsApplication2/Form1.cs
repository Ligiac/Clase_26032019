using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Operaciones ingreso;
        Resta ingresar;
        Multi proceso;
        Divi procces;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ingreso = new Operaciones();
            ingreso.V1 = double.Parse(textBox1.Text);
            ingreso.V2 = double.Parse(textBox2.Text);
            label3.Text = ingreso.Calcular().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingresar = new Resta();
            ingresar.R1 = double.Parse(textBox1.Text);
            ingresar.R2 = double.Parse(textBox2.Text);
            label3.Text = ingresar.Calcular().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            proceso = new Multi();
            proceso.M1 = double.Parse(textBox1.Text);
            proceso.M2 = double.Parse(textBox2.Text);
            label3.Text = proceso.Calcular().ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            procces = new Divi();
            procces.D1 = double.Parse(textBox1.Text);
            procces.D2 = double.Parse(textBox2.Text);
            label3.Text = procces.Calcular().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
