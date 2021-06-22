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
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }
        Informacion Archivo = new Informacion();
        Solicitud_Nombre form1 = new Solicitud_Nombre();
        Form1 form = new Form1();
        bool actualizar = false;

        string[] Materias_Cargadas = new string[20];

        private void Menu_Load(object sender, EventArgs e)
        {            
            Cargar();
        }   
        private void cmb_materias_Click(object sender, EventArgs e)
        {            
            Cargar();
        }         

        private void btn_agregar_Click(object sender, EventArgs e)
        {            
            Menu_Materia menu = new Menu_Materia();
            menu.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (cmb_materias.SelectedIndex != -1)
            {
                if (Materias_Cargadas[cmb_materias.SelectedIndex] != null)
                {
                    Gestor.indicio_materia = Materias_Cargadas[cmb_materias.SelectedIndex];
                    Menu_Materia menu = new Menu_Materia();
                    Gestor.editar = true;
                    Gestor.materia = cmb_materias.SelectedItem.ToString();                    
                    menu.ShowDialog();
                    Cargar();
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if( cmb_materias.SelectedIndex != -1)
            {
                if (Materias_Cargadas[cmb_materias.SelectedIndex] != null)
                {
                    Gestor.indicio_materia = Materias_Cargadas[cmb_materias.SelectedIndex];
                    Gestor.confirmacion = "¿Esta seguro de eliminar esta materia?\n Se borrara toda la informacion que contenga...";
                    Gestor.tipo_confirmacion = 1;
                    Confirmacion form = new Confirmacion();
                    form.ShowDialog();
                    Cargar();
                }
            }
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Gestor.move = true;
            Gestor.form_configuracion = false;
        }     
        private void Cargar() //CARGA LAS MATERIAS Y LBLS
        {
            lbl_tu_nombre.Text = Archivo.Leer("Nombre");
            cmb_materias.Items.Clear();
            int i = 1, n_materias = 0;
            do
            {
                if (Archivo.Leer("Materia" + i) != null)
                {
                    Materias_Cargadas[i - 1] = "Materia" + i;
                    cmb_materias.Items.Add(Archivo.Leer("Materia" + i));
                    n_materias++;
                }
                i++;
            } while (i < 21);
            lbl_n_materias.Text = "(" + n_materias.ToString() + ")";
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Notificaciones()
        {
        }

        private void btn_eliminar_cuenta_Click(object sender, EventArgs e)
        {
            Gestor.confirmacion = "        ¿Esta seguro de eliminar su cuenta?\n         SE BORRARA \n        >> TODA LA INFORMACION <<";
            Gestor.tipo_confirmacion = 2;
            Confirmacion form = new Confirmacion();
            form.ShowDialog();            
        }

        private void btn_editar_nombre_Click(object sender, EventArgs e)
        {
            form1.ShowDialog();
            actualizar = true;
        }

        private void btn_drive_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Gestor.direccion);
        }

        private void Configuracion_MouseMove(object sender, MouseEventArgs e)
        {
            if (actualizar == true)
            {
                lbl_tu_nombre.Text = Archivo.Leer("Nombre");
                actualizar = false;
            }
        }
    }
}
