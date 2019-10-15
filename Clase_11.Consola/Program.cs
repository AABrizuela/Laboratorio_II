using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


/*
 * Hacer una aplicacion de windows forms
 * a la que le ponga el nombre del archivo con un txtBox
 * Y le elija la ubicacion de una SpecialFolder con un cmbBox
 * y abajo un texto en el que pueda escribir texto a guardar usando un boton
 * y que tambien me sirva para levantar el contenido del archivo usando otro boton
 */
namespace Clase_11.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            ///*ARCHIVOS: System.IO
            //**streamWriter (PATH)
            //FUNCIONA COMO EN C. SI EL ARCHIVO EXISTE LO SOBREESCRIBE Y SI NO LO CREA.          
            //Puedo usar write y writeline como  en consola.      
            //*/

            ////StreamWriter streamWriter = new StreamWriter(@"C:\miCarpeta\miArchivo.txt");

            ///* el TRUE permite que se pueda agregar informacion a los datos ay cargados
            // en el archivo. */
            ////Directory.CreateDirectory(path);

            ////Usamos la palabra reservada 'using' para crear el objeto
            ////en este bloque de codigo y una vez que salimos de este
            ////el objeto es destruido con EXPLOSIONES

            //try
            //{
            //    using (StreamWriter streamWriter = new StreamWriter(@"C:\UTN\Programacion y labo 2\miCarpeta2\miArchivo.txt", true))
            //    {
            //        streamWriter.WriteLine("Hola Mundo!");
            //        streamWriter.WriteLine(DateTime.Now);
            //    }
            //}
            ////Excepcion por error de path invalido
            //catch (DirectoryNotFoundException eVar)
            //{
            //    Console.WriteLine(eVar.ToString());
            //}
            ////Excepcion por caracteres invalidos en el path
            //catch (ArgumentException eVar)
            //{
            //    Console.WriteLine(eVar.ToString());
            //}
            ////Excepcion 'pura' que va a levantar cualquier tipo de excepcion
            ////Se pone al final para que agarre cualquier excepcion que no sea alguna
            ////de las especificadas arriba como si fuese el 'default' de un switch            
            //catch (Exception eVar)
            //{
            //    Console.WriteLine(eVar.ToString());
            //}

            ////El bloque 'finally' va a estar siempre asociado al bloque 'try'
            ////En este caso este bloque me asegura que se haya ejecutado correctamente            
            ////Haya o no haya una excepcion, siempre se va a a pasar por el bloque 'finally'
            ////Por lo general se usa para liberar los ultimos recursos de la aplicacion            

            ////Tambien puedo generar mis propias excepciones a partir de la clase 'Exception'
            ////Voy a poder lanzar excepciones en forma de error, pero la va a lanzar directamente el framework
            ////O la voy a poder lanzar yo cuando se me ocurra, ya sea una propia o una que ya exista utilizando
            ////la palabra reservada 'throw'. Solo se pueden lanzar objetos de la clase 'Exception' o derivados            

            ////streamWriter.WriteLine("Hola Mundo!");
            ////streamWriter.WriteLine(DateTime.Now);


            ///*streamReader, tambien requiere el path del archivo fisico  donde quiero escribir.
            //* Tiene que existir el archivo, NO LO CREA. */

            //using (StreamReader streamReader = new StreamReader(@"C:\UTN\Programacion y labo 2\miCarpeta\miArchivo.txt"))
            //{
            //    //READTOEND me devuelve todo el contenido del archivo
            //    /* string str = streamReader.ReadToEnd();
            //     Console.WriteLine(str);*/

            //    string str = streamReader.ReadLine();
            //    do
            //    {
            //        Console.WriteLine(str);
            //    } while ((str = streamReader.ReadLine()) != null);
            //}

            ///*Los bloques 'try' y 'catch' sirven para capturar errores en tiempo de ejecucion (excepciones)
            // * y tratar de subsanarlo lo mejor que se pueda. De acuerdo al tipo de error o donde estoy parado
            // *puedo escribirlo en un log o seguir ejecutando sin que pase nada, o simplemente le muestro
            // * un mensaje al usuario avisandole que se pudrio la momia.
            // * 
            // * Dentro del bloque 'try' van a estar las lineas de codigo que son propensas a tener errores.
            // * El bloque 'try' siempre tiene que estar acompañado de un 'catch' y viceversa.
            // * 
            // * Y dentro del bloque 'catch' voy a recoger los erroes. Dentro de los parentesis de este bloque
            // * voy a pasarle como parametros objetos del tipo 'Exception' o derivadas.
            // */

            
            try
            {
                Program.Metodo1();
            }
            catch (Exception e)
            {
                if (e != null)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("\n******Inner exception******");
                    Console.WriteLine(e.InnerException.Message);
                    Console.WriteLine(e.InnerException.InnerException.Message);
                    Console.WriteLine("\n******Stack Trace******");
                    try
                    {
                        using (StreamWriter streamWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Incidencias.txt", true))
                        {
                            streamWriter.WriteLine(e.StackTrace);
                        }

                        using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Log.txt", true))
                        {
                            streamWriter.WriteLine(e.Message);
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    
                    Console.WriteLine(e.StackTrace);

                }                              
            }

            Console.ReadKey();
        }

        public static void Metodo1()
        {
            try
            {
                Program.Metodo2();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Esto es una excepcion en el metodo 1", e);
            }            
        }

        public static void Metodo2()
        {
            try
            {
                Program.Metodo4();
            }
            catch (Exception e)
            {
                Console.WriteLine("Estoy en el metodo 2");
                Console.WriteLine(e.Message);
                throw new Exception("Esto es una excepcion en el metodo 2", e);
            }            
        }

        public static void Metodo3()
        {
            //try
            //{
            //    Program.Metodo4();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Estoy en el metodo 3" + " - " + e.Message);
            //    throw;
            //}
            
        }

        public static void Metodo4()
        {
            Console.WriteLine("Estoy en el Metodo 4");
            throw new Metodo4_Exception("Me rompi");

        }
    }
}
