using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Libreria.Entidades
{
    public class Paciente
    {
        string _idPaciente;
        string _nombre;
        string _fechaNacimiento;
        double _peso;
        List<Visita> _visitas;

        public string IdPaciente { get => _idPaciente; }
        public string Nombre { get => _nombre; }

        public Paciente(string idPaciente, string nombre, string fechaNacimiento, double peso)
        {
            this._idPaciente = idPaciente;
            this._nombre = nombre;
            this._fechaNacimiento = fechaNacimiento;
            this._peso = peso;
            this._visitas = new List<Visita>();
        }

        public string ListarHistoria()
        {
            string datosPaciente = "ID: " + _idPaciente
                + "\nNombre: " + _nombre
                + "\nFecha de nacimiento: " + _fechaNacimiento
                + "\n";

            string historialVisitas = "";
            if (this._visitas.Count==0)
            {
                historialVisitas = "No hay visitas ingresadas\n";
            }
            else
            {
                historialVisitas = "Historial de visistas: \n";
                foreach (Visita visita in this._visitas)
                {
                    historialVisitas = historialVisitas + visita.ListarVisita() + "\n\n";
                }
            }
            return datosPaciente + historialVisitas;
        }

        public void GuardarVisita(Visita visita)
        {
            this._visitas.Add(visita);
        }

    }
}
