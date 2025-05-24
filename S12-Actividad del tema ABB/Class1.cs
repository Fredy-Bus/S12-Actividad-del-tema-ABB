using System;
namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            arbolbusquedabinaria.BinarySearchTree bst = new
           arbolbusquedabinaria.BinarySearchTree();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Buscar");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Recorridos");
                Console.WriteLine("5. Salir");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese el valor a insertar:");
                        int insertValue = Convert.ToInt32(Console.ReadLine());
                        bst.Insert(insertValue);
                        Console.WriteLine("Valor insertado.");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingrese el valor a buscar:");
                        int searchValue = Convert.ToInt32(Console.ReadLine());
                        bool found = bst.Search(searchValue);
                        if (found)
                            Console.WriteLine("Valor encontrado.");
                        else
                            Console.WriteLine("Valor no encontrado.");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ingrese el valor a eliminar:");
                        int deleteValue = Convert.ToInt32(Console.ReadLine());
                        bst.Delete(deleteValue);
                        Console.WriteLine("Valor eliminado.");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Seleccione el tipo de recorrido:");
                        Console.WriteLine("1. Preorden");
                        Console.WriteLine("2. En orden");
                        Console.WriteLine("3. Postorden");
                        int traverseOption =
                        Convert.ToInt32(Console.ReadLine());
                        switch (traverseOption)
                        {
                            case 1:
                                bst.PreOrder();
                                break;
                            case 2:
                                bst.InOrder();
                                break;
                            case 3:
                                bst.PostOrder();
                                break;
                        }
                        break;
                    case 5:
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine("Presione cualquier tecla para continuar...");

                Console.ReadKey();
            }
        }
    }
}