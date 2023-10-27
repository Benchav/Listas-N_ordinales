using System;

namespace JB_Listas
{
    public class Lista
    {
 
        //se Declara de apuntero/punteros del nodo
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        // declaracion del constructor de la lista

        public Lista()
        {
            Primero = null;
            Ultimo = null;
        }

        //Metodo public para insertar los nodos a la lista
  

        public void Insertnodo()
        {
            //se crea el nuevo nodo
            Nodo Nuevo = new Nodo();
            Console.WriteLine("Ingrese la Informacion del Nodo:");
            Nuevo.Dato = int.Parse(Console.ReadLine());
            if (Primero == null)
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Nuevo;

            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;

            }
            Console.WriteLine("Nodo Insertado");

        }

        public void PrintList()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            if (Primero != null)
            {
                //Recorrido de la lista
                while (Actual != null)
                {
                    Console.Write("{0}  ", Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("La lista esta Vacia!!!");
            }
        }
    }
}
