using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Libreria.Exceptions;

namespace Veterinaria.Libreria.Entidades
{
    public class Cliente:Persona
    {
        List<Paciente> _mascotas;

        public Cliente(string id, string nombre, string domicilio, string numeroTel, string email) : base(id, nombre, domicilio, numeroTel, email)
        {
            this._mascotas = new List<Paciente>();
        }
        public List<Paciente> Mascotas { get => _mascotas; set => _mascotas = value; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (!(obj is Cliente))
            {
                return false;
            }
            else
            {
                Cliente cliente = (Cliente)obj;
                return cliente.Id == this.Id;
            }
        }

        public void GuardarPaciente(Paciente paciente)
        {
            this._mascotas.Add(paciente);
        }

        public void EliminarPaciente (Paciente paciente)
        {
            this._mascotas.Remove(paciente);
        }
        
        internal string ListarClienteYMascotas()
        {
            string datosCliente = "";
            datosCliente = $"{this.ToString()} Mascotas:\n ";

            string mascotas = "";
            if (this._mascotas.Count==0)
            {
                mascotas = "No hay mascotas ingresadas\n";
            }
            else
            {
                mascotas = ListarMascotas();
            }
            
            string valor = datosCliente + mascotas;
            return valor.ToString();
        }

        private string ListarMascotas()
        {
            string valor = "";
            foreach(Paciente mascota in this._mascotas)
            {
                valor = valor + $"{mascota.Nombre}\n";
            }
            return valor;
        }

        public void ModificarPaciente(Paciente pacienteModificado)
        {
            Paciente pacienteBuscado = null;
            foreach (Paciente paciente in this._mascotas)
            {
                if (paciente.IdPaciente==pacienteModificado.IdPaciente)
                {
                    pacienteBuscado = paciente;
                }
            }
            if (pacienteBuscado == null) { throw new PacienteInexistenteException(); }


            pacienteBuscado.IdPaciente = pacienteModificado.IdPaciente;
            pacienteBuscado.Nombre = pacienteModificado.Nombre;
            pacienteBuscado.FechaNacimiento = pacienteModificado.FechaNacimiento;
            pacienteBuscado.Peso = pacienteModificado.Peso;
        }
    }
}
