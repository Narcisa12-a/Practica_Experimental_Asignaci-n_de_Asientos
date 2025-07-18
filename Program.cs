using System;
namespace ParqueDiversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            AsignadorAsientos asignador = new AsignadorAsientos(30);
            bool salir = false;
            Console.WriteLine("🎡 Bienvenido al Parque de Diversiones");
            Console.WriteLine("🎟 Sistema de asignación de 30 asientos\n");
            while (!salir)
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Agregar persona a la cola");
                Console.WriteLine("2. Asignar asiento");
                Console.WriteLine("3. Mostrar estado de la cola");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();
                Console.WriteLine();
                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el nombre de la persona: ");
                        string nombre = Console.ReadLine();
                        asignador.AgregarPersona(nombre);
                        break;

                    case "2":
                        asignador.AsignarAsiento();
                        break;

                    case "3":
                        asignador.MostrarCola();
                        break;

                    case "4":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("⚠ Opción inválida. Intente de nuevo.");
                        break;
                }
                if (asignador.TodosAsientosAsignados())
                {
                    Console.WriteLine("\n✅ Todos los asientos han sido asignados. ¡Fin de la simulación!");
                    salir = true;
                }
            }
        }
    }
}
