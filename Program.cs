using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pregunta Uno:");
            PreguntaUno(5, "Hola", "Mundo"); 
            PreguntaUno(5, "Hola", 5634);
            PreguntaUno(5, "Hola", 4.4); 

            Dictionary<int, string> pruebaDic_ = new Dictionary<int, string>()
        {
            {1, "Esto es impar ALFA"},
            {2, "Esto es par ALFA"},
            {3, "Esto es impar BETA"},
            {4, "Esto es par BETA"},
            {5, "Esto es impar GAMA"},
            {6, "Esto es par GAMA"}
        };
            PreguntaDos(pruebaDic_);
            PreguntaTres();

            Console.ReadKey();
        }

        //Pregunta #1
        //Escriba una función en C# que reciba tres variables, una de tipo int, una de tipo string, y una de tipo object.
        //Dentro de la función, hacer lo siguiente:
        //• Si la variable de tipo object es un número, sumarla a la variable de tipo int y escriba el resultado en la consola.
        //• Si la variable de tipo object es una cadena de caracteres, adjúntela a la variable de tipo string y escriba el resultado en la consola
        //• Si la variable de tipo object no cumple con los requisitos anteriores, arroje una excepción.


        public static void PreguntaUno(int entero_, string string_, object objeto_)
        {
            try { 

            if (objeto_ is int)
            {
                double resultado = (int)objeto_ + entero_; 
                Console.WriteLine("Suma: " + resultado);
            }
            else if (objeto_ is string)
            {
                string resultado = string_+" "+objeto_ ;
                Console.WriteLine("Concatenación: " + resultado);
            }
            else
            {
                throw new ArgumentException("El valor de tipo object no es válido.");
            }
            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        //Pregunta #2
        //Escriba una función en C# que reciba como parámetro un Dictionary cuya llave sea un int y valor sea un string.
        //Dentro de la función, recorrer el Dictionary y separar sus registros en dos listas,
        //una lista se debe llenar con todos los valores del Dictionary cuya llave sea un numero par
        //y la otra se debe llenar con todos los valores del Dictionary cuya llave sea un numero impar.


        public static void PreguntaDos(Dictionary<int,string>diccionario_)
        {
            List<string> valoresPares = new List<string>();
            List<string> valoresImpares = new List<string>();

            foreach (var par in diccionario_)
            {
                if (par.Key % 2 == 0)
                {
                    valoresPares.Add(par.Value);

                }
                else
                {
                    valoresImpares.Add(par.Value);
                }
            }
            Console.WriteLine("Valores con llaves pares:");
            foreach (var valor in valoresPares)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine("Valores con llaves impares:");
            foreach (var valor in valoresImpares)
            {
                Console.WriteLine(valor);
            }

        }

        public static void PreguntaTres()
        {
            Console.WriteLine("Primera consulta:");
            Console.WriteLine("SELECT Producto.CODIGO,Producto.DESCRIPCION FROM Producto JOIN Descuento on Descuento.ID_PRODUCTO=Producto.ID where Descuento.PORCENTAJE>60 AND (FECHA_INICIO>GETDATE() OR Descuento.FECHA_FIN<GETDATE());\r\n");
            Console.WriteLine("Segunda consulta:");
            Console.WriteLine("SELECT Producto.CODIGO,Producto.DESCRIPCION,Descuento.PORCENTAJE,Descuento.FECHA_INICIO,Descuento.FECHA_FIN FROM Producto JOIN Descuento ON Descuento.ID_PRODUCTO=Producto.ID WHERE (FECHA_INICIO<'2021-03-01' AND FECHA_INICIO>'2021-01-01') OR (Descuento.FECHA_FIN>'2021-01-01' AND Descuento.FECHA_FIN<'2021-03-01');\r\n");
            Console.WriteLine("Tercera consulta:");
            Console.WriteLine("SELECT Producto.CODIGO,Producto.DESCRIPCION,Descuento.PORCENTAJE,Descuento.FECHA_INICIO,Descuento.FECHA_FIN FROM Producto JOIN Descuento ON Producto.ID = Descuento.ID_PRODUCTO WHERE Producto.CODIGO IN ('ADF32','POP79','LLE51');");
        }
    }
}

