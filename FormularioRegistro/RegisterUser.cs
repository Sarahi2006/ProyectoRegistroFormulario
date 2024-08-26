using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioRegistro
{
    public class RegisterUser
    {
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Genero { get; set; }
        private string Especialidad { get; set; }
        private int Edad { get; set; }
        private int Dui { get; set; }
        private string Observacion { get; set; }

        public RegisterUser(string nombre, string apellido, string genero, string especialidad, int edad, int dui, string observacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Genero = genero;
            Especialidad = especialidad;
            Edad = edad;
            Dui = dui;
            Observacion = observacion;

        }

        public string ObtenerNombre()
        {
            return this.Nombre;
        }

        public string ObtenerApellido()
        {
            return this.Apellido;
        }

        public string ObtenerGenero()
        { 
            return this.Genero; 
        }
        public string ObtenerEspecialidad()
        {
            return this.Especialidad;
        }
        public int ObtenerEdad() 
        {
            return this.Edad; 
        }
        public int ObtenerDui()
        { 
            return this.Dui; 
        }
        public string ObtenerObservacion()
        { 
            return this.Observacion; 
        }
    }
}
