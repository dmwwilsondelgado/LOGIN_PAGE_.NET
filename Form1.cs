using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Stack<Acarreos> pilaPedidos = new Stack<Acarreos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void nombreEnter(object sender, EventArgs e)
        {
            if (nombre.Text == "Ingrese su nombre")
            {
                nombre.Text = "";
                nombre.ForeColor = Color.Black;
            }
        }

        private void nombreLeave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(nombre.Text))
            {
                nombre.Text = "Ingrese su nombre";
                nombre.ForeColor = Color.Gray;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void direccionEnter(object sender, EventArgs e)
        {
            if (direccion.Text == "Ingrese su direccion")
            {
                direccion.Text = "";
                direccion.ForeColor = Color.Black;
            }
        }

        private void direccionLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(direccion.Text))
            {
                direccion.Text = "Ingrese su direccion";
                direccion.ForeColor = Color.Gray;
            }
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(direccion.Text) || string.IsNullOrWhiteSpace(nombre.Text) || string.IsNullOrWhiteSpace(pedido.Text) || direccion.Text.Equals("Ingrese su direccion") || nombre.Text.Equals("Ingrese su nombre") ||pedido.Text.Equals("Ingrese su pedido")))
            {
                pilaPedidos.Push(new Acarreos(nombre.Text, direccion.Text, pedido.Text));
            }
            else
            {
                MessageBox.Show("Complete los campos correctamente.", "ERROR");
            }
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void pedidoEnter(object sender, EventArgs e)
        {
            if (pedido.Text == "Ingrese su pedido")
            {
                pedido.Text = "";
                pedido.ForeColor = Color.Black;
            }
        }

        private void pedidoLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pedido.Text))
            {
                pedido.Text = "Ingrese su pedido";
                pedido.ForeColor = Color.Gray;
            }
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            if (pilaPedidos.Count > 0)
            {
                int i = 0;
                foreach (var p in pilaPedidos)
                {
                    i++;
                    MessageBox.Show($"{p} ELEMENTO{i}");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    class Acarreos
    {
        string Nombre, Direccion, Pedido;

        public Acarreos(string nombre, string direccion, string pedido)
        {
            Nombre = nombre;
            Direccion = direccion;
            Pedido = pedido;
        }
    }
}
