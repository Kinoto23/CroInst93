using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Cronograma
{
    public  class Gestor
    {
        Informacion Archivo = new Informacion();

        //DIRECCION DE CARPETA PARA GOOGLE DRIVE
        public static string direccion = "https://drive.google.com/drive/folders/1i9CWQKXZlzYi2aRAmsMUV4XDVSmQA8Nz?usp=sharing";

        //Variable de evento mover Mouse en Form1
        public static bool move = false;

        // Variables de forms abiertos.
        public static bool form_configuracion = false;
        public static bool form_materia = false;

        //Variables del timer
        public static int contar = 0;
        public static int segundos = 5;

        //Variables del form "Configuracion" y el form "Menu_Materias".
        public static bool editar = false;
        public static string materia;
        public static string indicio_materia;

        //Variables de confirmacion!
        public static string confirmacion;
        public static int tipo_confirmacion;

        // Varriable del form materia y recuadro de lbl's.
        public static string titulo;
        public static int posicion;

        //SECCION DE PLANTILLA.
        public void Plantilla()
        {
            int nro_inicios = 0;
            try
            {
                nro_inicios = Convert.ToInt32(Archivo.Leer("Nro_Inicios"));
            }
            catch { }
            Archivo.Crear("INICIO", "Nro_Inicios");
            Archivo.Crear("INICIO", "Nombre");
            Archivo.Editar_informacion("Nro_Inicios", Convert.ToString(nro_inicios + 1));
            int i = 1;
            do
            {
                Archivo.Crear("INICIO", "Posicion_Materia" + i);
                Archivo.Crear("MATERIA" + i, "Materia" + i);
                Archivo.Crear("MATERIA" + i, "URL" + i);
                Archivo.Crear("MATERIA" + i, "Carpeta" + i);
                Archivo.Crear("MATERIA" + i, "Nota" + i);
                Archivo.Crear("MATERIA" + i, "Actividades_x_Hacer" + i);
                Archivo.Crear("MATERIA" + i, "Actividades_Hechas" + i);
                i++;
            } while (i < 21);
            Archivo.Crear("INICIO", "Estado");
            Archivo.Crear("IINICIO", "Seguro");
        }
      
    }


    public class Informacion //CLASE DE GUARDADO DE INFORMACION AUTOMATICA
    {
        //SECCION DE PROPIEDADES.
        public string directorio = "c:\\Cronograma"; //DIRECTORIO DE GUARDADO.
        public string ruta_archivo = @"c:\\Cronograma\\CroInst93.txt"; //Ruta de guardado del archivo.


        int indice_seccion_inicio, indice_seccion_final, indice_indicio_inicio, indice_indicio_final;

        List<string> lista_datos;

        //ESTRACCION DE DATOS.

        public string Leer(string indicio)
        {
            Cargar();
            Cargar_Indices(null, indicio);

            if (lista_datos[indice_indicio_inicio + 1] != "]" + indicio & indice_indicio_inicio != -1) return lista_datos[indice_indicio_inicio + 1];
            else return null;
        }

        public string[] Leer_Area(string indicio)
        {
            Cargar();
            Cargar_Indices(null, indicio);

            if (lista_datos[indice_indicio_inicio + 1] != "]" + indicio & indice_indicio_inicio != -1)
            {
                string[] lineas = lista_datos.GetRange(indice_indicio_inicio + 1, (indice_indicio_final - indice_indicio_inicio) - 1).ToArray();
                return lineas;
            }
            else return null;
        }

        //EDICION DE PARAMETROS.

        public void Crear(string seccion, string indicio)
        {
            Cargar();
            bool operacion = false;
            if (seccion != null)
                if (seccion.TrimEnd().Length != 0 & !(lista_datos.Contains(seccion + "{")))
                {
                    lista_datos.Add(seccion + "{"); //seccion{contenido}seccion
                    lista_datos.Add("}" + seccion);
                    operacion = true;
                }

            if (indicio != null)
                if (indicio.TrimEnd().Length != 0 & lista_datos.Contains(seccion + "{") & !(lista_datos.Contains(indicio + "[")))
                {
                    int indice = 0;
                    indice = lista_datos.IndexOf("}" + seccion);
                    lista_datos.Insert(indice, "]" + indicio);
                    lista_datos.Insert(indice, indicio + "[");
                    operacion = true;
                }

            if (operacion == true ) Guardar();
        }

        public void Editar_Seccion(string seccion, string nueva_seccion)
        {
            Cargar();
            Cargar_Indices(seccion, null);
            if (indice_seccion_inicio != -1)
            {
                lista_datos[indice_seccion_inicio] = nueva_seccion + "{";
                lista_datos[indice_seccion_final] = "}" + nueva_seccion;
            }
            Guardar();
        }

        public void Editar_indicio(string indicio, string nuevo_indicio)
        {
            Cargar();
            Cargar_Indices(null, indicio);
            if (indice_indicio_inicio != -1)
            {
                lista_datos[indice_indicio_inicio] = nuevo_indicio + "[";
                lista_datos[indice_indicio_final] = "]" + nuevo_indicio;
                Guardar();
            }
        }

        public void Editar_informacion(string indicio, string nueva_informacion)
        {
            Cargar();
            Cargar_Indices(null, indicio);
            if (indice_indicio_inicio != -1)
            {

                if (indice_indicio_final - indice_indicio_inicio > 1)
                {
                    lista_datos.RemoveRange(indice_indicio_inicio + 1, (indice_indicio_final - indice_indicio_inicio) - 1);                    
                }
                lista_datos.Insert((indice_indicio_inicio + 1), nueva_informacion);
                Guardar();
            }
        }

        //BORRA ARCHIVO - BORRA SECCION - BORRA INDICIOS.

        public void Borrar(string tipo, string seccion, string indicio)
        {
            Cargar();
            Cargar_Indices(seccion, indicio);

            switch (tipo) // tipo: todo (borra el documento) - seccion (borra la seccion, el indicio y la informacion) - indicio  (borra el indicio y la informacion) - info (borra toda la informacion)
            {
                case "todo":
                    if (File.Exists(ruta_archivo)) File.Delete(ruta_archivo);
                    Nuevo_Archivo();
                    break;
                case "seccion":
                    if (indice_seccion_inicio != -1 & seccion != null)
                    {
                        lista_datos.RemoveRange(indice_seccion_inicio + 1, (indice_seccion_final - indice_seccion_inicio)-1);
                        Guardar();
                    }
                    break;
                case "indicio":
                    if (indice_indicio_inicio != -1 & indicio != null)
                    {
                        int rango_indicio = (indice_indicio_final - indice_indicio_inicio) + 1;
                        lista_datos.RemoveRange(indice_indicio_inicio, rango_indicio);
                        Guardar();
                    }

                    break;
                case "info":
                    {
                        if (indice_indicio_inicio != -1 & indicio != null & lista_datos[indice_indicio_inicio + 1] != "]" + indicio)
                        {
                            lista_datos.RemoveRange(indice_indicio_inicio + 1, (indice_indicio_final - indice_indicio_inicio) - 1);
                            Guardar();
                        }
                    }
                    break;
            }
        }

        //ACCIONES SOBRE EL ARCHIVO.

        private void Nuevo_Archivo()
        {
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
                Console.WriteLine(directorio);

            }
            if (!File.Exists(ruta_archivo))
            {
                StreamWriter op_archivo = File.AppendText(ruta_archivo);
                File.SetAttributes(ruta_archivo, FileAttributes.Archive | FileAttributes.Hidden);
                op_archivo.Close();
            }
        }

        private void Guardar() // GUARDA LOS DATOS EN EL ARCHIVO
        {
            File.Delete(ruta_archivo);
            StreamWriter op_archivo = File.AppendText(ruta_archivo);
            File.SetAttributes(ruta_archivo, FileAttributes.Archive | FileAttributes.Hidden);
            foreach (string i in lista_datos)
            {
                op_archivo.WriteLine(i);
            }
            op_archivo.Close();
        }

        private void Cargar() //CARGA LA LISTA.
        {
            Nuevo_Archivo();
            string[] datos = File.ReadAllLines(ruta_archivo);
            lista_datos = new List<string>(datos);
        }

        private void Cargar_Indices(string seccion, string indicio) //CARGA LOS INDICES INICIO Y FIN DE LA SECCION Y DE DEL INDICIO
        {
            if (seccion != null)
            {
                indice_seccion_inicio = lista_datos.IndexOf(seccion + "{");
                indice_seccion_final = lista_datos.IndexOf("}" + seccion);
            }
            if (indicio != null)
            {
                indice_indicio_inicio = lista_datos.IndexOf(indicio + "[");
                indice_indicio_final = lista_datos.IndexOf("]" + indicio);
            }
        }
    }

    public class Adap //HACE UN SALTO DE LINEA DESPUES DE CIERTA CANTIDAD DE CARACTERES.
    {
        public static int Max_Char;
        public string Tador(string dato)
        {
            int n_caracteres = Max_Char;
            string armado = null;
            bool vuelta = false;
            if (dato.Length > n_caracteres)
            {
                int i = 0;
                do
                {
                    if (i < n_caracteres)
                    {
                        armado += dato.Substring(i, 1);
                        
                    }
                    else 
                    {
                        if (vuelta == false)
                        {
                        vuelta = true;
                        armado += "\n";
                        }
                        armado += dato.Substring(i, 1);                        
                    }
                    i++;
                } while (i < dato.Length);
                return armado;
            }
            else return dato;                
        }
    }
}
