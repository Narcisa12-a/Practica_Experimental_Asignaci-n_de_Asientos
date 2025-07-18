namespace ParqueDiversiones
{
    /// <summary>
    /// Clase que representa a una persona en la cola de la atracción.
    /// </summary>
    public class Persona
    {
        /// <summary>
        /// Nombre de la persona.
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Número de ticket asignado a la persona.
        /// </summary>
        public int NumeroTicket { get; set; }
        /// <summary>
        /// Constructor de la clase Persona.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="numeroTicket">Número de ticket asignado.</param>
        public Persona(string nombre, int numeroTicket)
        {
            Nombre = nombre;
            NumeroTicket = numeroTicket;
        }
    }
}