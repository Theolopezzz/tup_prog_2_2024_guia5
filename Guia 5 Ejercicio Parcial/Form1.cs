using Guia_5_Ejercicio_Parcial.Models;
using System;
using System.Windows.Forms;

namespace Guia_5_Ejercicio_Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Presupuesto pedido;
        private void btAgregar_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(tbPrecio.Text);
            double largo = Convert.ToDouble(tbLargo.Text);
            int codigo = Convert.ToInt32(tbCodigo.Text);
            Producto nuevo = null; 
            if (rbBanco.Checked)
            {
                nuevo = new Banco(precio, largo);
                nuevo.Codigo = codigo;
            }
            else if (rbMesa.Checked)
            {
                double ancho = Convert.ToDouble(tbAncho.Text);
                double grosor= Convert.ToDouble(tbGrosor.Text);
                nuevo = new Mesa(precio, largo, ancho, grosor);
                nuevo.Codigo = codigo;
            }
            if (pedido != null)
            {
                if (nuevo != null)
                {
                    pedido.AgregarProducto(nuevo);
                    cbLista.Items.Add(nuevo);
                    //cbLista.Items.Add(codigo);
                }
                else
                {
                    MessageBox.Show("Seleccione un tipo");
                }
            }
            else
            {
                MessageBox.Show("Cree el presupuesto");
            }

        }

        private void bIniciarPresu_Click(object sender, EventArgs e)
        {
            string nombre=tbNombre.Text;
            string direc=tbDireccion.Text;
            pedido = new Presupuesto(nombre, direc);  
        }

        private void bBorrar(object sender, EventArgs e)
        {
            Producto producto = cbLista.SelectedItem as Producto;
            if (producto != null)
            {
                //int codigo = Convert.ToInt32(cbLista.SelectedItem);
                //cbLista.Items.Remove(codigo);
                //pedido.QuitarProducto(codigo);
                //cbLista.Items.Remove(codigo);
                pedido.QuitarProducto(producto.Codigo);
                cbLista.Items.Remove(producto);
                cbLista.Text = "";

            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void btCerrarPresu_Click(object sender, EventArgs e)
        {
            Form2 VMod = new Form2();
            VMod.lbResumen.Items.AddRange(pedido.Resumen());
            VMod.ShowDialog();
            cbLista.Items.Clear();
            pedido = null;

        }
    }
}
