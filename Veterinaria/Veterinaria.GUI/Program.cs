using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.Libreria.Entidades;

namespace Veterinaria.GUI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SucVeterinaria sucursal1 = new SucVeterinaria("Sucursal1", "Domicilio Sucursal1", "Telefono Sucursal1", "Encargado Sucursal1");

            
            FormAltaCliente formularioAltaCliente = new FormAltaCliente();
            FormAltaPaciente formularioAltaPaciente = new FormAltaPaciente();
            FormAltaProfesional formularioAltaProfesional = new FormAltaProfesional();
            FormAltaVisita formularioAltaVisita = new FormAltaVisita();

            Application.Run(formularioAltaVisita);
        }
    }
}
