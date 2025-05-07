using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace WindowsFormsApp2
{
    internal class Acciones
    {
        private List<Alumno> alumnoList = new List<Alumno>
        {
            
        };
        public List<Alumno>Mostrar()
        {
            return alumnoList;
        }
        public bool ExportarExcel()
        {
            try
            {
                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("Alumnos");

                // Encabezados
                ws.Cell(1, 1).Value = "Nombre";
                ws.Cell(1, 2).Value = "Edad";
                ws.Cell(1, 3).Value = "Carrera";
                ws.Cell(1, 4).Value = "Matricula";
                ws.Cell(1, 5).Value = "Fecha Ingreso";

                // Llenar datos
                for (int i = 0; i < alumnoList.Count; i++)
                {
                    var alumno = alumnoList[i];
                    ws.Cell(i + 2, 1).Value = alumno.Nombre;
                    ws.Cell(i + 2, 2).Value = alumno.Edad;
                    ws.Cell(i + 2, 3).Value = alumno.Carrera;
                    ws.Cell(i + 2, 4).Value = alumno.Matricula;
                    ws.Cell(i + 2, 5).Value = alumno.Fechadenacimiento.ToShortDateString();
                }

                // Guardar archivo en escritorio
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "Alumnos.xlsx");
                wb.SaveAs(filePath);

                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
        public bool importarExcel()
        {

        }

    }
}
