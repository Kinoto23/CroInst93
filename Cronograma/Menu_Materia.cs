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
    public partial class Menu_Materia : Form
    {
        public Menu_Materia()
        {
            InitializeComponent();           
        }

        Informacion Archivo = new Informacion();
        int contado;
        
        private void Menu_Materia_Load(object sender, EventArgs e)
        {
            txt_materia.MaxLength = 28;
            if (Gestor.editar == true)
            {
                txt_materia.Text = (Gestor.materia);
                Contador();
            }
        }
        
        private void txt_materia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Contador();
        }
        private void Menu_Materia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Gestor.editar = false;
        }       

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Gestor.editar = false;
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            contado = txt_materia.Text.TrimEnd().TrimStart().Length;
            if (contado == 0) Notificaciones(1);
            else if (Gestor.editar == true) Editar();
            else Agregar();
        }
        private void Contador()
        {
            contado = txt_materia.Text.Length;
            lbl_contador.Text = (contado + "/28");
            if (contado < 14) lbl_contador.ForeColor = Color.Green;
            else if (contado > 14 & contado < 20) lbl_contador.ForeColor = Color.Orange;
            else if (contado > 20) lbl_contador.ForeColor = Color.Red;
        }
        private void Notificaciones(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    MessageBox.Show("Error, Dejo el recuadro en blanco\nO superó el maximo de caracteres");
                    break;
                case 2:
                    MessageBox.Show("Llegó al maximo de materias cargadas\n puede probar editando sus nombres\no eliminando alguna materia.");
                    break;
            }
        }
        private void Agregar()
        {
            bool ciclo = false;
                for (int i = 1; i <= 20; i++)
                {
                    
                    if (Archivo.Leer("Materia" + i) == null)
                    {
                        Archivo.Editar_informacion("Materia" + i, txt_materia.Text.TrimStart().TrimEnd());
                        ciclo = true;
                        this.Close();
                        break;
                    }
                }
                if (ciclo == false)
                {
                    Notificaciones(2);
                    this.Close();
                }            
        }
        private void Editar()
        {
           Archivo.Editar_informacion(Gestor.indicio_materia, txt_materia.Text.TrimStart().TrimEnd());
           this.Close();
        }         
    }
}
