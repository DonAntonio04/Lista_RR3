using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RU1yU2
{
    public class Lista_Producto
    {
        Nodo cabeza;

       public Lista_Producto()
       {
            cabeza = null;
       }
       public bool ListaVacia()
       {
            return cabeza == null;
       }
       public void InsertarProducto(Producto nuevoProducto)
       {
         Nodo nodocabeza = new Nodo(nuevoProducto);
            if(ListaVacia())
            {
                cabeza = nodocabeza;
                return;
            }

            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            actual.Siguiente = nodocabeza;
        }
       public void buscarPrecio(int buscarPrecio)
       {
            int posicion = 0;
            bool encontrado = false;
            Nodo actual = cabeza;
            while (actual != null)
            {
                 if(actual.Valor.Precio == buscarPrecio)
                 {
                    Console.WriteLine($"La precio {buscarPrecio} se ha encontrado");
                    encontrado= true;
                    break;
                 }
                 actual= actual.Siguiente;
                posicion++;
            }
            if(!encontrado)
            {
                Console.WriteLine("El precio no se encuentra");
            }
       }

        public void ordenarDecedente()
        {
            if (ListaVacia() || cabeza.Siguiente == null)
            {
                return;
            }

            bool ordenar;
            do
            {
                ordenar = false;
                Nodo Actual = cabeza;
                Nodo siguiente = cabeza.Siguiente;

                while (siguiente != null)
                {
                    if (Actual.Valor.Precio > siguiente.Valor.Precio)
                    {
                        Producto temp = Actual.Valor;
                        Actual.Valor = siguiente.Valor;
                        siguiente.Valor = temp;

                        ordenar = true;
                    }

                    Actual = siguiente;
                    siguiente = siguiente.Siguiente;
                }
            } while (ordenar);
        }

        public void Mostar()
        {
            Nodo actual = cabeza;
            if(actual == null)
            {
                Console.WriteLine("Tu lista esta vacía");
            }


            
            while(actual != null)
            {
                Console.WriteLine($"El nombre del producto {actual.Valor.Nombre}, el precio es {actual.Valor.Precio}");
                actual= actual.Siguiente;
            }
        }

    }
}
