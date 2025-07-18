//Elabore un programa que simule un Asignador de 30 asientos en una atracción de un parque de diversiones
//donde los usuarios llegan y se forman en una cola para obtener su asiento en el orden de llegada.
using System;
using System.Collections.Generic;

namespace ParqueDiversiones
{
    //Clase que gestiona la cola y la asignación de asientos
    public class AsignadorAsientos
    {
        private Queue<Persona> cola;
        private int asientosDisponibles;
        private int contadorTickets;
        public AsignadorAsientos(int totalAsientos)
        {
            cola = new Queue<Persona>();
            asientosDisponibles = totalAsientos;
            contadorTickets = 1;
        }
        //Agrega una persona a la cola
        public void AgregarPersona(string nombre)
        {
            if (contadorTickets <= asientosDisponibles)
            {
                var persona = new Persona(nombre, contadorTickets++);
                cola.Enqueue(persona);
                Console.WriteLine($"✅ Agregado: {nombre} (Ticket #{persona.NumeroTicket})");
            }
            else
            {
                Console.WriteLine("⚠ No hay asientos disponibles. Todos los tickets han sido vendidos.");
            }
        }
        //Asigna un asiento a la siguiente persona en la cola
        public void AsignarAsiento()
        {
            if (cola.Count > 0)
            {
                var persona = cola.Dequeue();
                Console.WriteLine($"🎢 Asiento asignado a: {persona.Nombre} (Ticket #{persona.NumeroTicket})");
            }
            else
            {
                Console.WriteLine("⚠ No hay personas en la cola.");
            }
        }
        //Muestra el estado actual de la cola
        public void MostrarCola()
        {
            Console.WriteLine($"\n🎟 Tickets vendidos: {contadorTickets - 1}");
            Console.WriteLine($"🪑 Asientos pendientes de asignar: {cola.Count}\n");

            if (cola.Count > 0)
            {
                Console.WriteLine("👥 Personas en la cola:");
                foreach (var persona in cola)
                {
                    Console.WriteLine($"- {persona.Nombre} (Ticket #{persona.NumeroTicket})");
                }
            }
            else
            {
                Console.WriteLine("📭 La cola está vacía.");
            }
        }
        //Verifica si todos los asientos ya fueron asignados
        public bool TodosAsientosAsignados()
        {
            return contadorTickets > asientosDisponibles && cola.Count == 0;
        }
    }
}