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
    public partial class Materia : Form
    {
        public Materia()
        {
            InitializeComponent();
        }
        bool actualizar = false;
        bool agrega;
        Informacion Archivo = new Informacion();
        int[] materia = new int[21];
        int indice;
        private void Materia_Load(object sender, EventArgs e)
        {
            Dia_Hora(); 
            cmb_materia.Items.Add("Ninguna Materia Asignada");
            if (Gestor.titulo == null)
            {
                cmb_materia.Text = "Ninguna Materia Asignada";
                Habilitar(false);
            }

            actualizar = true;
            indice = 1;
            for (int i = 1; i <= 21; i++)
            {
                if (Archivo.Leer("Materia" + i) != null) 
                {
                    if (Archivo.Leer("Materia" + i) != Gestor.titulo)
                    {
                        materia[indice] = i;
                        indice++;
                        cmb_materia.Items.Add(Archivo.Leer("Materia" + i));
                    }
                    else
                    {
                        materia[indice] = i;
                        indice++;
                        cmb_materia.Items.Add(Gestor.titulo);
                        cmb_materia.Text = Gestor.titulo;
                    }
                }
            }
        }

        //CIERRE DE FORMULARIO
        private void Materia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Gestor.form_materia = false;
            Gestor.titulo = null;
            Gestor.move = true;
        }

        //BOTON EDITAR MATERIA
        private void button1_Click(object sender, EventArgs e)
        {
            cmb_materia.Enabled = true;           
        }

        //METODO CAMBIO DE MATERIA
        private void cmb_materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizar = true;
            cmb_materia.Enabled = false;
            picb_confirmado.Visible = false;
            Limpiar();
            if (cmb_materia.SelectedIndex < 1) Habilitar(false);
            else Habilitar(true);
        }

        private void Habilitar(bool estado)
        {
            lts_hechas.Enabled = estado;
            lts_x_hacer.Enabled = estado;
            btn_terminada.Enabled = estado;
            btn_no_terminada.Enabled = estado;
            txt_notas.Enabled = estado;
            pic_videollamada.Enabled = estado;
            pic_carpeta.Enabled = estado;
            btn_editar_carpeta.Enabled = estado;
            btn_editar_videollamada.Enabled = estado;
            btn_agregar.Enabled = estado;
        }
        private void Limpiar()
        {
            lts_hechas.Items.Clear();
            lts_x_hacer.Items.Clear();
            txt_notas.Clear();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON GUARDAR
        private void pic_guardar_Click(object sender, EventArgs e)
        {            
                if (cmb_materia.SelectedIndex != -1 & cmb_materia.Text != Gestor.titulo)
                {
                    if (cmb_materia.SelectedIndex != 0)
                    {
                        Habilitar(true);
                        Archivo.Editar_informacion("Posicion_Materia" + Gestor.posicion, "Materia" + materia[cmb_materia.SelectedIndex]);                        
                    }
                    else
                    {
                        Archivo.Borrar("info", null, "Posicion_Materia" + Gestor.posicion);
                        Habilitar(false);
                    }
                }

                if (cmb_materia.SelectedIndex > 0)
                {
                    Archivo.Editar_informacion("Nota" + materia[cmb_materia.SelectedIndex], txt_notas.Text);
                    string linea = "", linea1 = "";
                    bool vuelta = false, vuelta1 = false;
                    if (lts_x_hacer.Items.Count > 0)
                    {
                        for (int i = 0; i < lts_x_hacer.Items.Count; i++)
                            if (vuelta == false)
                            {
                                linea += lts_x_hacer.Items[i];
                                vuelta = true;
                            }
                            else linea += "\r\n" + lts_x_hacer.Items[i];
                        Archivo.Editar_informacion("Actividades_x_Hacer" + materia[cmb_materia.SelectedIndex], linea);
                    }
                    else Archivo.Borrar("info", null, "Actividades_x_Hacer" + materia[cmb_materia.SelectedIndex]);

                    if (lts_hechas.Items.Count > 0)
                    {
                        for (int i = 0; i < lts_hechas.Items.Count; i++)
                            if (vuelta1 == false)
                            {
                                linea1 += lts_hechas.Items[i];
                                vuelta1 = true;
                            }
                            else linea1 += "\r\n" + lts_hechas.Items[i];
                        Archivo.Editar_informacion("Actividades_Hechas" + materia[cmb_materia.SelectedIndex], linea1);
                    }
                    else Archivo.Borrar("info", null, "Actividades_Hechas" + materia[cmb_materia.SelectedIndex]);
                }
            picb_confirmado.Visible = true;
        }       

        private void btn_editar_videollamada_Click(object sender, EventArgs e)
        {
            picb_confirmado.Visible = false;
            Editar_URL_Videollamada();           
        }

        private void btn_ok_videollamada_Click(object sender, EventArgs e)
        {
            btn_editar.Enabled = true;
            pic_guardar.Enabled = true;
            Archivo.Editar_informacion("URL" + materia[cmb_materia.SelectedIndex], txt_url_videollamada.Text);
            txt_url_videollamada.Visible = false;
            btn_ok_videollamada.Visible = false;
            lbl_notificacion_videollamada.Visible = false;
        }
        private void Editar_URL_Videollamada()
        {
            if (cmb_materia.SelectedIndex > 0)
            {
                txt_url_videollamada.Text = Archivo.Leer("URL" + materia[cmb_materia.SelectedIndex]);
                txt_url_videollamada.Visible = true;
                btn_ok_videollamada.Visible = true;
                btn_editar.Enabled = false;
                pic_guardar.Enabled = false;                
            }
        }

        private void pic_videollamada_Click(object sender, EventArgs e)
        {
            if (Archivo.Leer("URL" + materia[cmb_materia.SelectedIndex]) != "" & Archivo.Leer("URL" + materia[cmb_materia.SelectedIndex]) != null)
                try
                {
                    System.Diagnostics.Process.Start(Archivo.Leer("URL" + materia[cmb_materia.SelectedIndex]));
                }
                catch
                {
                    MessageBox.Show("Error o URL Incorrecta");
                }
            else lbl_notificacion_videollamada.Visible = true;
        }

        private void btn_editar_carpeta_Click(object sender, EventArgs e)
        {
            picb_confirmado.Visible = false;
            lbl_notificacion_carpeta.Visible = false;
            if (cmb_materia.SelectedIndex > 0)
            {
                txt_carpeta.Text = Archivo.Leer("Carpeta" + materia[cmb_materia.SelectedIndex]);
                txt_carpeta.Visible = true;
                btn_ok_carpeta.Visible = true;
                btn_editar.Enabled = false;
                pic_guardar.Enabled = false;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                   txt_carpeta.Text = folderBrowserDialog1.SelectedPath;                   
                }
            }
        }

        private void pic_carpeta_Click(object sender, EventArgs e)
        {
            if (cmb_materia.SelectedIndex > 0 & Archivo.Leer("Carpeta" + materia[cmb_materia.SelectedIndex]) != null & Archivo.Leer("Carpeta" + materia[cmb_materia.SelectedIndex]) != "")
            {
                try
                {
                    System.Diagnostics.Process.Start(Archivo.Leer("Carpeta" + materia[cmb_materia.SelectedIndex]));
                }
                catch
                {
                    MessageBox.Show("Error al abrir la carpeta o no existe");
                }
            }
            else lbl_notificacion_carpeta.Visible = true;
        }

        private void lbl_ok_carpeta_Click(object sender, EventArgs e)
        {
            txt_carpeta.Visible = false;
            btn_ok_carpeta.Visible = false;
            btn_editar.Enabled = true;
            pic_guardar.Enabled = true;
            Archivo.Editar_informacion("Carpeta" + materia[cmb_materia.SelectedIndex], txt_carpeta.Text);
        }

        //MUESTRA DIA Y HORA EN EL FORM
        private void Dia_Hora()
        {
            int dato = Gestor.posicion;
            if(dato < 5)
                lbl_dia_hora.Text = dato + "° HORA - Lunes";
            else if (dato > 4 & dato < 9)
                lbl_dia_hora.Text = dato - 4 + "° HORA - Martes";
            else if (dato > 8 & dato < 13)
                lbl_dia_hora.Text = dato - 8 + "° HORA - Miercoles";
            else if (dato > 12 & dato < 17)
                lbl_dia_hora.Text = dato - 12 + "° HORA - Jueves";
            else
                lbl_dia_hora.Text = dato - 16 + "° HORA - Viernes";
        }

        //CARGA DE NOTAS

        private void Cargar_Notas()
        {
            string lineas = "";
            if (Archivo.Leer_Area("Nota" + materia[cmb_materia.SelectedIndex]) != null & cmb_materia.SelectedIndex > 0)
            {
                foreach (string linea in Archivo.Leer_Area("Nota" + materia[cmb_materia.SelectedIndex]))
                {
                    lineas += linea + "\r\n";
                }
                txt_notas.Text = lineas;
            }
        }

        private void Materia_MouseMove(object sender, MouseEventArgs e)
        {             
            if (actualizar == true)
            {
                bool vuelta = false;
                txt_notas.Clear();
                string lineas = "";
                if (Archivo.Leer_Area("Nota" + materia[cmb_materia.SelectedIndex]) != null & cmb_materia.SelectedIndex > 0)
                {
                    foreach (string linea in Archivo.Leer_Area("Nota" + materia[cmb_materia.SelectedIndex]))
                    {
                        if (vuelta == false)
                        {
                            lineas = linea;
                            vuelta = true;
                        }
                        else lineas += "\r\n" + linea;
                    }
                    txt_notas.Text = lineas;
                }
                if (Archivo.Leer_Area("Actividades_x_Hacer" + materia[cmb_materia.SelectedIndex]) != null)
                {
                    foreach (string linea in Archivo.Leer_Area("Actividades_x_Hacer" + materia[cmb_materia.SelectedIndex]))
                    {
                        lts_x_hacer.Items.Add(linea);
                    }
                }
                if (Archivo.Leer_Area("Actividades_Hechas" + materia[cmb_materia.SelectedIndex]) != null)
                {
                    foreach (string linea in Archivo.Leer_Area("Actividades_Hechas" + materia[cmb_materia.SelectedIndex]))
                    {
                        lts_hechas.Items.Add(linea);
                    }
                }
                actualizar = false;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            picb_confirmado.Visible = false;
            agrega = true;
            Agregar_Editar();
        }

        private void btn_ok_agregar_lista_Click(object sender, EventArgs e)
        {
            btn_agregar.Enabled = true;
            if (txt_items_lista.Text.TrimEnd().Length != 0)
            {
                if (agrega == true) lts_x_hacer.Items.Add(txt_items_lista.Text);
                else if (lts_x_hacer.SelectedIndex != -1)
                {
                    lts_x_hacer.Items.Insert(lts_x_hacer.SelectedIndex, txt_items_lista.Text);
                    lts_x_hacer.Items.RemoveAt(lts_x_hacer.SelectedIndex);
                }
            }
            txt_items_lista.Visible = false;
            btn_ok_agregar_lista.Visible = false;
        }

        private void btn_terminada_Click(object sender, EventArgs e)
        {
            picb_confirmado.Visible = false;
            if (lts_x_hacer.SelectedIndex != -1)
            {
                int indice = lts_x_hacer.SelectedIndex;
                lts_hechas.Items.Add(lts_x_hacer.Items[indice].ToString());
                lts_x_hacer.Items.RemoveAt(indice);
            }
        }

        private void btn_no_terminada_Click(object sender, EventArgs e)
        {
            picb_confirmado.Visible = false;
            if (lts_hechas.SelectedIndex != -1)
            {
                int indice = lts_hechas.SelectedIndex;
                lts_x_hacer.Items.Add(lts_hechas.Items[indice].ToString());
                lts_hechas.Items.RemoveAt(indice);
            }
        }

        private void lts_x_hacer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lts_x_hacer.SelectedIndex == -1)
            {
                btn_editar_lista.Visible = false;
                btn_eliminar_lista.Visible = false;
            }
            else
            {
                btn_editar_lista.Visible = true;
                btn_eliminar_lista.Visible = true;
            }
        }

        private void btn_eliminar_lista_Click(object sender, EventArgs e)
        {
            if (lts_x_hacer.SelectedIndex != -1)
            {
                lts_x_hacer.Items.RemoveAt(lts_x_hacer.SelectedIndex);
            }
        }

        private void btn_editar_lista_Click(object sender, EventArgs e)
        {
            agrega = false;
            Agregar_Editar();
        }
        private void Agregar_Editar()
        {
            txt_items_lista.Clear();
            txt_items_lista.Visible = true;
            btn_ok_agregar_lista.Visible = true;
            btn_agregar.Enabled = false;
            if(agrega == false) txt_items_lista.Text = lts_x_hacer.Items[lts_x_hacer.SelectedIndex].ToString();
        }

        private void txt_notas_TextChanged(object sender, EventArgs e)
        {
            picb_confirmado.Visible = false;
        }
    }
}
