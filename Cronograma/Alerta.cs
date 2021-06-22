using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cronograma
{
    public partial class Confirmacion : Form
    {
        public Confirmacion()
        {
            InitializeComponent();
        }       
        Informacion Archivo = new Informacion();
        Gestor gestor = new Gestor();

        private void Confirmacion_Load(object sender, EventArgs e)
        {
            lbl_confirmacion.Text = Gestor.confirmacion;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            switch (Gestor.tipo_confirmacion)
            {
                case 1:
                    for (int i = 1; i <= 20; i++)
                    {
                        if (Archivo.Leer("Posicion_Materia" + i) == Gestor.indicio_materia)
                        {
                            Archivo.Borrar("info", null, "Posicion_Materia" + i);
                        }
                    }
                    Archivo.Borrar("seccion", Gestor.indicio_materia.ToUpper(), null);//ToUpert() PASA LA CADENA A MAYUSCULA
                    gestor.Plantilla();
                    break;
                case 2:
                    Archivo.Borrar("todo", null, null);
                    Application.Restart();
                    break;
            }
            this.Close();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            string ruta = @"c:\";
            System.Diagnostics.Process.Start(ruta);
        } */      
    }
}
