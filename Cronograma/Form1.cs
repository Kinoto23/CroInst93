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

    public partial class Form1 : Form // Cuerpo principal del programa.
    {
        public Form1()
        {
            InitializeComponent();            
        }

        Informacion Archivo = new Informacion();
        Gestor gestor = new Gestor();
        Adap adap = new Adap();
        bool cartel = false;
        //CARGA FORM 1

        private void Form1_Load(object sender, EventArgs e) 
        { 
            lbl_hora_1.Text = "18:30\na\n19:30";
            lbl_hora_2.Text = "19:30\na\n20:30";
            lbl_hora_3.Text = "20:30\na\n21:30";
            lbl_hora_4.Text = "21:30\na\n22:30";
            gestor.Plantilla();
            Carga();
            Inicio();            
        }

        //COMPORTAMIENTO DEL PROGRAMA

        private void Inicio() //Primer Inicio!!
        {            
            if (Archivo.Leer("Nombre") == null & Archivo.Leer("Nro_Inicios") == "1")
            {
                Notificaciones(0);
                tmr_principal.Enabled = true;
            }
            else if (Archivo.Leer("Nombre") == null & Archivo.Leer("Nro_Inicios") != "1")
            {
                Notificaciones(15);
                btn_nombre.Visible = true;
            }
            else Notificaciones(1);
        }

        private void timer1_Tick(object sender, EventArgs e) //Contador principal cada 1 seg
        {
            Gestor.contar++;
            if (Gestor.contar == Gestor.segundos)
            {
                Solicitud_Nombre solicitud = new Solicitud_Nombre();
                solicitud.ShowDialog();
                tmr_principal.Enabled = false;
                if (Archivo.Leer("Nombre") == null) btn_nombre.Visible = true;
                Gestor.contar = 0;
            }           
        }

        //SECCION DE BOTONES

        private void btn_salir_Click(object sender, EventArgs e) //Boton Salir.
        {
            Application.Exit();
        }

        private void btn_menu_Click(object sender, EventArgs e) //Boton que habre el formulacio de Menu.
        {
            if (Archivo.Leer("Nombre") == null) Notificaciones(3);
            else if (Gestor.form_configuracion == false)
            {
                if (Gestor.form_materia == false)
                {
                    Notificaciones(9);
                    Configuracion menu = new Configuracion();
                    menu.Show();
                    Gestor.form_configuracion = true;
                }
                else Notificaciones(18);
            }
            else Notificaciones(4);
        }         

        private void btn_nombre_Click(object sender, EventArgs e)
        {
            if (Archivo.Leer("Nombre") == null)
            {
                Solicitud_Nombre solicitud = new Solicitud_Nombre();
                solicitud.ShowDialog();
            }
            else
            {
                Notificaciones(2);
                btn_nombre.Visible = false;
            }
        }        

        //EVENTOS DE LOS lbl DEL RECUADRO.

        private void lbl_hora_1_Click(object sender, EventArgs e) //Desede aca Notificaciones de lbl hora y dias.
        {
            Notificaciones(5);
        } 

        private void lbl_hora_2_Click(object sender, EventArgs e)
        {
            Notificaciones(6);
        }

        private void lbl_hora_3_Click(object sender, EventArgs e)
        {
            Notificaciones(7);
        }

        private void lbl_hora_4_Click(object sender, EventArgs e)
        {
            Notificaciones(8);
        }

        private void lbl_lunes_Click(object sender, EventArgs e)
        {
            Notificaciones(10);
        }

        private void lbl_martes_Click(object sender, EventArgs e)
        {
            Notificaciones(11);
        }

        private void lbl_miercoles_Click(object sender, EventArgs e)
        {
            Notificaciones(12);
        }

        private void lbl_jueves_Click(object sender, EventArgs e)
        {
            Notificaciones(13);
        }

        private void lbl_Viernes_Click(object sender, EventArgs e) // Hasta aca notificaciones de lbl hora y dias.
        {
            Notificaciones(14);
        }   

        //SECCION DE NOTIFICACIONES this

        private void Notificaciones(int tipo)
        {
            switch (tipo)
            {

                case 0:
                    lbl_notificaciones.ForeColor = Color.Green;
                    lbl_notificaciones.Text = (">>> Hola, veo que inicias por\n>>> primera vez...");
                    break;
                case 1:
                    lbl_notificaciones.ForeColor = Color.Green;
                    lbl_notificaciones.Text = (">>> ¡¡ Hola " + Archivo.Leer("Nombre") + " !!" + "\n>>> que bueno verte de nuevo!!");
                    break;
                case 2:
                    lbl_notificaciones.ForeColor = Color.Orange;
                    lbl_notificaciones.Text = (">>> :(\n>>> " + Archivo.Leer("Nombre") + " Ya habia guardado\n>>> tu nombre, quitaré el boton!");
                    break;
                case 3:
                    lbl_notificaciones.ForeColor = Color.Orange;
                    lbl_notificaciones.Text = (">>> :( Ingresa tu nombre\n>>> Para estudiar juntos! :)");
                    break;
                case 4:
                    lbl_notificaciones.ForeColor = Color.Yellow;
                    lbl_notificaciones.Text = (">>> ! El menu de configuracion\n>>> ya se encuentra abierto!");
                    break;
                case 5:
                    lbl_notificaciones.ForeColor = Color.Magenta;
                    lbl_notificaciones.Text = (">>> 1ra Hora de la Cursada.");
                    break;
                case 6:
                    lbl_notificaciones.ForeColor = Color.Magenta;
                    lbl_notificaciones.Text = (">>> 2da Hora de la Cursada.");
                    break;
                case 7:
                    lbl_notificaciones.ForeColor = Color.Magenta;
                    lbl_notificaciones.Text = (">>> 3ra Hora de la Cursada.");
                    break;
                case 8:
                    lbl_notificaciones.ForeColor = Color.Magenta;
                    lbl_notificaciones.Text = (">>> 4ta Hora de la Cursada.");
                    break;
                case 9:
                    lbl_notificaciones.ForeColor = Color.Magenta;
                    lbl_notificaciones.Text = (">>> Configuracion...\n>>> acá podes agregar materias\n>>> tambien personalizar tu estudio");
                    break;
                case 10:
                    lbl_notificaciones.ForeColor = Color.Magenta;
                    lbl_notificaciones.Text = (">>> Lunes");
                    break;
                case 11:
                    lbl_notificaciones.ForeColor = Color.Magenta;
                    lbl_notificaciones.Text = (">>> Martes");
                    break;
                case 12:
                    lbl_notificaciones.ForeColor = Color.Magenta;
                    lbl_notificaciones.Text = (">>> Miercoles");
                    break;
                case 13:
                    lbl_notificaciones.ForeColor = Color.Magenta;
                    lbl_notificaciones.Text = (">>> Jueves");
                    break;
                case 14:
                    lbl_notificaciones.ForeColor = Color.Magenta;
                    lbl_notificaciones.Text = (">>> Viernes");
                    break;
                case 15:
                    lbl_notificaciones.ForeColor = Color.Green;
                    lbl_notificaciones.Text = (">>> Que bueno que volviste!!\n>>> No olvides ingresar tu nombre\n>>> Toca el boton verde ;)");
                    break;
                case 16:
                    lbl_notificaciones.ForeColor = Color.Yellow;
                    lbl_notificaciones.Text = (">>> Ya has abrierto el Menu de Materia!!");
                    break;
                case 17:
                    lbl_notificaciones.ForeColor = Color.Green;
                    lbl_notificaciones.Text = (">>> "+ Archivo.Leer("Nombre") + " acá podras cargar\n>>> y ver todo respecto a tu materia");
                    break;
                case 18:
                    lbl_notificaciones.ForeColor = Color.Yellow;
                    lbl_notificaciones.Text = (">>> No puedes abrir 2 Menus simultaneos!\n>>> Cierra el menu y podras abrir otro");
                    break;
                case 19:
                    lbl_notificaciones.ForeColor = Color.White;
                    lbl_notificaciones.Text = (">>> " + Archivo.Leer("Nombre") + " en el Menu Configuracion.\n>>> entrá en contenidos extra.\n>>> ahí podes descargar la ultima version.");
                    break;
                case 20:
                    MessageBox.Show("! El programa ya se encuentra abierto");
                    break;
            }
        }

        // MENU MATERIA

        private void Menu_Materias(int cual)
        {
            if (Archivo.Leer("Nombre") != null)
            {
                if (Gestor.form_materia == false)
                {
                    if (Gestor.form_configuracion == false)
                    {
                        Materia form_materia = new Materia();
                        if (Archivo.Leer("Posicion_Materia" + cual) != null)
                        {
                            Gestor.form_materia = true;
                            Gestor.titulo = Archivo.Leer(Archivo.Leer("Posicion_Materia" + cual));
                            form_materia.Show();
                        }
                        else
                        {
                            form_materia.Show();
                            Gestor.form_materia = true;
                        }
                    }
                    else Notificaciones(18);
                }
                else Notificaciones(16);
            }
            else Notificaciones(3);
        }

        //lbl's DE MATERIAS

        private void lbl_materia_1_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 1;
            Menu_Materias(1);            
        }

        private void lbl_materia_2_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 2;
            Menu_Materias(2);
        }

        private void lbl_materia_3_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 3;
            Menu_Materias(3);
        }

        private void lbl_materia_4_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 4;
            Menu_Materias(4);
        }

        private void lbl_materia_5_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 5;
            Menu_Materias(5);
        }

        private void lbl_materia_6_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 6;
            Menu_Materias(6);
        }

        private void lbl_materia_7_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 7;
            Menu_Materias(7);
        }

        private void lbl_materia_8_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 8;
            Menu_Materias(8);
        }

        private void lbl_materia_9_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 9;
            Menu_Materias(9);
        }

        private void lbl_materia_10_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 10;
            Menu_Materias(10);
        }

        private void lbl_materia_11_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 11;
            Menu_Materias(11);
        }

        private void lbl_materia_12_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 12;
            Menu_Materias(12);
        }

        private void lbl_materia_13_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 13;
            Menu_Materias(13);
        }

        private void lbl_materia_14_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 14;
            Menu_Materias(14);
        }

        private void lbl_materia_15_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 15;
            Menu_Materias(15);
        }

        private void lbl_materia_16_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 16;
            Menu_Materias(16);
        }

        private void lbl_materia_17_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 17;
            Menu_Materias(17);
        }

        private void lbl_materia_18_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 18;
            Menu_Materias(18);
        }

        private void lbl_materia_19_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 19;
            Menu_Materias(19);
        }

        private void lbl_materia_20_Click(object sender, EventArgs e)
        {
            Gestor.posicion = 20;
            Menu_Materias(20);
        }

        public void Carga()
        {
            string dato;
            Adap.Max_Char = 14;
            int i = 1;
            do
            {
                int lista1 = 0;
                int lista2 = 0;

                if (Archivo.Leer("Posicion_Materia" + i) != null)
                {
                    string posicion = Archivo.Leer("Posicion_Materia" + i).Replace("Materia", null);

                    if (Archivo.Leer_Area("Actividades_x_Hacer" + posicion) != null)
                    {
                        lista1 = Archivo.Leer_Area("Actividades_x_Hacer" + posicion).Length;
                    }
                    else lista1 = 0;
                    if (Archivo.Leer_Area("Actividades_Hechas" + posicion) != null)
                    {
                        lista2 = Archivo.Leer_Area("Actividades_Hechas" + posicion).Length;
                    }
                    else lista2 = 0;
                }                
                if (Archivo.Leer("Posicion_Materia" + i) != null)
                {                    
                    dato = adap.Tador(Archivo.Leer(Archivo.Leer("Posicion_Materia" + i)));
                }                
                else dato = "    Ninguna";

                    switch (i)
                    {
                        case 1:
                             pb_1.Maximum = lista1 + lista2;
                             pb_1.Value = lista2;
                             lbl_materia_1.Text = dato;
                             if (lista1 == 0)
                             {
                                 lbl_num1.ForeColor = Color.Green;
                                 lbl_num1.Text = "Ok";
                             }
                             else
                             {
                                 lbl_num1.ForeColor = Color.Red;
                                 lbl_num1.Text = lista1.ToString();
                             }
                            break;
                        case 2:
                             pb_2.Maximum = lista1 + lista2;
                             pb_2.Value = lista2;
                            lbl_materia_2.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num2.ForeColor = Color.Green;
                                lbl_num2.Text = "Ok";
                            }
                            else
                            {
                                lbl_num2.ForeColor = Color.Red;
                                lbl_num2.Text = lista1.ToString();
                            }
                            break;
                        case 3:
                             pb_3.Maximum = lista1 + lista2;
                             pb_3.Value = lista2;
                            lbl_materia_3.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num3.ForeColor = Color.Green;
                                lbl_num3.Text = "Ok";
                            }
                            else
                            {
                                lbl_num3.ForeColor = Color.Red;
                                lbl_num3.Text = lista1.ToString();
                            }
                            break;
                        case 4:
                             pb_4.Maximum = lista1 + lista2;
                             pb_4.Value = lista2;
                            lbl_materia_4.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num4.ForeColor = Color.Green;
                                lbl_num4.Text = "Ok";
                            }
                            else
                            {
                                lbl_num4.ForeColor = Color.Red;
                                lbl_num4.Text = lista1.ToString();
                            }
                            break;
                        case 5:
                             pb_5.Maximum = lista1 + lista2;
                             pb_5.Value = lista2;
                            lbl_materia_5.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num5.ForeColor = Color.Green;
                                lbl_num5.Text = "Ok";
                            }
                            else
                            {
                                lbl_num5.ForeColor = Color.Red;
                                lbl_num5.Text = lista1.ToString();
                            }
                            break;
                        case 6:
                             pb_6.Maximum = lista1 + lista2;
                             pb_6.Value = lista2;
                            lbl_materia_6.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num6.ForeColor = Color.Green;
                                lbl_num6.Text = "Ok";
                            }
                            else
                            {
                                lbl_num6.ForeColor = Color.Red;
                                lbl_num6.Text = lista1.ToString();
                            }
                            break;
                        case 7:
                             pb_7.Maximum = lista1 + lista2;
                             pb_7.Value = lista2;
                            lbl_materia_7.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num7.ForeColor = Color.Green;
                                lbl_num7.Text = "Ok";
                            }
                            else
                            {
                                lbl_num7.ForeColor = Color.Red;
                                lbl_num7.Text = lista1.ToString();
                            }
                            break;
                        case 8:
                             pb_8.Maximum = lista1 + lista2;
                             pb_8.Value = lista2;
                            lbl_materia_8.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num8.ForeColor = Color.Green;
                                lbl_num8.Text = "Ok";
                            }
                            else
                            {
                                lbl_num8.ForeColor = Color.Red;
                                lbl_num8.Text = lista1.ToString();
                            }
                            break;
                        case 9:
                             pb_9.Maximum = lista1 + lista2;
                             pb_9.Value = lista2;
                            lbl_materia_9.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num9.ForeColor = Color.Green;
                                lbl_num9.Text = "Ok";
                            }
                            else
                            {
                                lbl_num9.ForeColor = Color.Red;
                                lbl_num9.Text = lista1.ToString();
                            }
                            break;
                        case 10:
                            pb_10.Maximum = lista1 + lista2;
                             pb_10.Value = lista2;
                            lbl_materia_10.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num10.ForeColor = Color.Green;
                                lbl_num10.Text = "Ok";
                            }
                            else
                            {
                                lbl_num10.ForeColor = Color.Red;
                                lbl_num10.Text = lista1.ToString();
                            }
                            break;
                        case 11:
                             pb_11.Maximum = lista1 + lista2;
                             pb_11.Value = lista2;
                            lbl_materia_11.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num11.ForeColor = Color.Green;
                                lbl_num11.Text = "Ok";
                            }
                            else
                            {
                                lbl_num11.ForeColor = Color.Red;
                                lbl_num11.Text = lista1.ToString();
                            }
                            break;
                        case 12:
                             pb_12.Maximum = lista1 + lista2;
                             pb_12.Value = lista2;
                            lbl_materia_12.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num12.ForeColor = Color.Green;
                                lbl_num12.Text = "Ok";
                            }
                            else
                            {
                                lbl_num12.ForeColor = Color.Red;
                                lbl_num12.Text = lista1.ToString();
                            }
                            break;
                        case 13:
                             pb_13.Maximum = lista1 + lista2;
                             pb_13.Value = lista2;
                            lbl_materia_13.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num13.ForeColor = Color.Green;
                                lbl_num13.Text = "Ok";
                            }
                            else
                            {
                                lbl_num13.ForeColor = Color.Red;
                                lbl_num13.Text = lista1.ToString();
                            }
                            break;
                        case 14:
                             pb_14.Maximum = lista1 + lista2;
                             pb_14.Value = lista2;
                            lbl_materia_14.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num14.ForeColor = Color.Green;
                                lbl_num14.Text = "Ok";
                            }
                            else
                            {
                                lbl_num14.ForeColor = Color.Red;
                                lbl_num14.Text = lista1.ToString();
                            }
                            break;
                        case 15:
                             pb_15.Maximum = lista1 + lista2;
                             pb_15.Value = lista2;
                            lbl_materia_15.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num15.ForeColor = Color.Green;
                                lbl_num15.Text = "Ok";
                            }
                            else
                            {
                                lbl_num15.ForeColor = Color.Red;
                                lbl_num15.Text = lista1.ToString();
                            }
                            break;
                        case 16:
                             pb_16.Maximum = lista1 + lista2;
                             pb_16.Value = lista2;
                            lbl_materia_16.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num16.ForeColor = Color.Green;
                                lbl_num16.Text = "Ok";
                            }
                            else
                            {
                                lbl_num16.ForeColor = Color.Red;
                                lbl_num16.Text = lista1.ToString();
                            }
                            break;
                        case 17:
                             pb_17.Maximum = lista1 + lista2;
                             pb_17.Value = lista2;
                            lbl_materia_17.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num17.ForeColor = Color.Green;
                                lbl_num17.Text = "Ok";
                            }
                            else
                            {
                                lbl_num17.ForeColor = Color.Red;
                                lbl_num17.Text = lista1.ToString();
                            }
                            break;
                        case 18:
                             pb_18.Maximum = lista1 + lista2;
                             pb_18.Value = lista2;
                            lbl_materia_18.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num18.ForeColor = Color.Green;
                                lbl_num18.Text = "Ok";
                            }
                            else
                            {
                                lbl_num18.ForeColor = Color.Red;
                                lbl_num18.Text = lista1.ToString();
                            }
                            break;
                        case 19:
                             pb_19.Maximum = lista1 + lista2;
                             pb_19.Value = lista2;
                            lbl_materia_19.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num19.ForeColor = Color.Green;
                                lbl_num19.Text = "Ok";
                            }
                            else
                            {
                                lbl_num19.ForeColor = Color.Red;
                                lbl_num19.Text = lista1.ToString();
                            }
                            break;
                        case 20:
                             pb_20.Maximum = lista1 + lista2;
                             pb_20.Value = lista2;
                            lbl_materia_20.Text = dato;
                            if (lista1 == 0)
                            {
                                lbl_num20.ForeColor = Color.Green;
                                lbl_num20.Text = "Ok";
                            }
                            else
                            {
                                lbl_num20.ForeColor = Color.Red;
                                lbl_num20.Text = lista1.ToString();
                            }
                            break;
                    }                
                i++;
            } while (i < 21);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Gestor.move == true)
            {
                Carga();
                if (cartel == false)
                {
                    Notificaciones(19);
                    cartel = true;
                }
                Gestor.move = false;
            }
        }
    }     
}
