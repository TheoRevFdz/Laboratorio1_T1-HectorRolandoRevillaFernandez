namespace Laboratorio1_T1_HectorRolandoRevillaFernandez.Models
{
    public class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public Persona(int edad, string nombre) {
            this.Edad = edad;
            this.Nombre = nombre;
        }
    }
}
