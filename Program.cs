namespace RU1yU2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista_Producto lista= new Lista_Producto();

            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine($"Ingrese el nombre del producto y el precio del producto {i}:");
                Console.WriteLine("Producto:");
                string producto = Console.ReadLine();
                Console.WriteLine("El precio");
                int precio = Convert.ToInt32(Console.ReadLine());

                Producto nuevoProducto = new Producto(producto,precio);
                lista.InsertarProducto(nuevoProducto);

                Console.Write("\nIngrese el precio a buscar: ");
                int precio1 = Convert.ToInt32(Console.ReadLine());
                lista.buscarPrecio(precio1);

               
            }
            lista.ordenarDecedente();

            Console.WriteLine("Esta es la lista de precio ordenada de manera descendente:");
            lista.Mostar();
        }
    }
}