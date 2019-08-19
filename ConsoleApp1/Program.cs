using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            object[] parametros = { "Yo", 1 };
            funcion(2,5,"Marcelo");
            void funcion(int valor1, int valor2, string valor3)
            {
                Console.WriteLine($"Hola {valor1} {valor2} {valor3}");
                Console.WriteLine("Hola la fecha es {0} y mi nombre es {1}", DateTime.Now, "Marcelo") ;
                Console.ReadLine();
            }
        }

        public void metodo(string nombre, int cant)
        {
            Console.WriteLine(nombre);
            
            Console.ReadLine();
            

        }

        
    }
}
