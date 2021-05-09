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

        public string IdPaciente { get => _idPaciente; set => _idPaciente = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public double Peso { get => _peso; set => _peso = value; }

        public Paciente(string idPaciente, string nombre, string fechaNacimiento, double peso)
        {
            this._idPaciente = idPaciente;
            this._nombre = nombre;
            this._fechaNacimiento = fechaNacimiento;
            this._peso = peso;
            this._visitas = new List<Visita>();
        }

        public override string ToString()
        {
            return $"ID: {this._idPaciente}\nNombre: {this._nombre}\nFecha de nacimiento: {this._fechaNacimiento}\nPeso: {this._peso}\n";
        }

        public string ListarHistoria()
        {
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
            return ToString() + historialVisitas;
        }

        public void GuardarVisita(Visita visita)
        {
            this._visitas.Add(visita);
        }
    }
}
