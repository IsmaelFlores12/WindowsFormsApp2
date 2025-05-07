using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Alumno
    {
        public Alumno(string nombre, int edad, string carrera, int matricula, DateTime fechadenacimiento)
        {
            Nombre = nombre;
            Edad = edad;
            Carrera = carrera;
            Matricula = matricula;
            Fechadenacimiento = fechadenacimiento;
        }

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }
        public int Matricula { get; set; }
        public DateTime Fechadenacimiento { get; set; }
    }
}
