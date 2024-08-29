using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
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

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = tbnombre.Text;
            String apellido = tbapellido.Text;
            String edad = tbedad.Text;
            String estatura = tbestatura.Text;
            String telefono = tbtelefono.Text;

            String genero = "";
            if (rdhombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rdmujer.Checked)
            {
                genero = "Mujer";
            }

            String datos = $"Nombre: {nombre}\r\nApellido: {apellido}\r\nEdad: {edad}\r\nEstatura: {estatura}\r\nTelefono: {telefono}\r\nGenero: {genero}";

            String rutaArchivo = "C:/Users/yisua/Documents/datos.txt";
            bool archivoExiste = File.Exists(rutaArchivo);
            using (StreamWriter writer = new StreamWriter(rutaArchivo,true))
            {
                if (archivoExiste)
                {
                    writer.WriteLine();
                }
                
                else 
                {
                    writer.WriteLine(datos);
                }

                MessageBox.Show("Datos guardados con exito:\n\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbnombre.Clear();
            tbapellido.Clear();
            tbedad.Clear();
            tbestatura.Clear();
            tbtelefono.Clear();
            rdhombre.Checked = false;
            rdmujer.Checked = false;
        }
    }
}