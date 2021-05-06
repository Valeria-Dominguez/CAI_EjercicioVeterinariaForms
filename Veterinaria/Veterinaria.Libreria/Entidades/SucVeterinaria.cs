using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Libreria.Exceptions;

namespace Veterinaria.Libreria.Entidades
{
    public class SucVeterinaria
    {
        string _nombre;
        string _domicilio;
        string _telefono;
        string _encargado;
        List<Cliente> _clientes;
        List<Profesional> _profesionales;

        public string Nombre { get => _nombre; }
        public string Domicilio { get => _domicilio; }

        public SucVeterinaria(string nombre, string domicilio, string telefono, string encargado)
        {
            this._nombre = nombre;
            this._domicilio = domicilio;
            this._telefono = telefono;
            this._encargado = encargado;
            this._clientes = new List<Cliente>();
            this._profesionales = new List<Profesional>();
        }

        public void GuardarCliente(string idCliente, string nombre, string domicilio, string numeroTel, string email)
        {
            Cliente clienteAgre = new Cliente(idCliente, nombre, domicilio, numeroTel, email);
            GuardarCliente(clienteAgre);            
        }

        public void GuardarCliente(Cliente clienteAgre)
        {
            foreach (Cliente cliente in this._clientes)
            {
                if (cliente.Equals(clienteAgre)) 
                {
                    throw new ClienteExistenteException();
                }
            }
            this._clientes.Add(clienteAgre);
        }

        public void GuardarProfesional(string idProfesional, string nombre, string domicilio, string numeroTel, string email)
        {
            Profesional profesional = new Profesional (idProfesional, nombre, domicilio, numeroTel, email);
            GuardarProfesional(profesional);
        }

        void GuardarProfesional(Profesional profesional)
        {
            this._profesionales.Add(profesional);
        }

        public string BuscarHistoria (string idPaciente)
        {
            string valor = "";
            foreach (Cliente cliente in this._clientes)
            {
                foreach (Paciente mascota in cliente.Mascotas)
                {
                    if (mascota.IdPaciente == idPaciente)
                    {
                        valor = mascota.ListarHistoria();
                    }
                }
            }
            if (valor == "")
            {
                throw new PacienteInexistenteException();
            }
            return valor; 
        }

        public void GuardarPaciente(string idCliente, string idPaciente, string nombre, string fechaNacimiento, int peso)
        {
            Paciente paciente = new Paciente(idPaciente, nombre, fechaNacimiento, peso);
            GuardarPaciente(idCliente, paciente);
        }

        public void GuardarPaciente (string idCliente, Paciente paciente)
        {
            Cliente clienteBusc = null;
            foreach (Cliente cliente in this._clientes)
            {
                if (cliente.Id == idCliente)
                {
                    clienteBusc = cliente;
                }
                foreach (Paciente pacient in cliente.Mascotas)
                {
                    if (pacient.IdPaciente == paciente.IdPaciente)
                    {
                        throw new PacienteExistenteException();
                    }
                }
            }
            clienteBusc.GuardarPaciente(paciente);
            if (clienteBusc == null)
            {
                throw new ClienteInexistenteException();
            }
        }

        public void EliminarPaciente(string idPaciente)
        {
            Paciente pacienteBusc = null;
            Cliente clienteBusc = null;

            foreach (Cliente cliente in this._clientes)
            {
                foreach (Paciente mascota in cliente.Mascotas)
                {
                    if (mascota.IdPaciente == idPaciente)
                    {
                        clienteBusc = cliente;
                        pacienteBusc = mascota;
                    }
                }
            }
            if (pacienteBusc==null)
            {
                throw new PacienteInexistenteException("No puede eliminarse, el paciente no existe\n");
            }

            clienteBusc.EliminarPaciente(pacienteBusc);
        }
        
        public string ListarClientes()
        {
            string valor = "";
            if (_clientes.Count==0)
            {
                valor = "No hay clientes ingresados\n";
            }
            else
            {
                foreach (Cliente cliente in this._clientes)
                {
                    valor = valor + cliente.ListarClienteYMascotas();
                }
            }
            return valor;
        }

        public string ListarProfesionales()
        {
            string valor = "";
            if (_profesionales.Count == 0)
            {
                valor = "No hay profesionales ingresados\n";
            }
            else
            {
                foreach (Profesional profesional in this._profesionales)
                {
                    valor = valor + profesional.ListarPersona();
                }
            }
            return valor;
        }

        public void GuardarVisita(string idPaciente, string fechaVisita, string motivoConsulta, string diagnostico, string prescripciones, string observaciones, string nombreProfesional)
        {
            Visita visita = new Visita(fechaVisita, motivoConsulta, diagnostico, prescripciones, observaciones, nombreProfesional);
            GuardarVisita(idPaciente, visita);
        }

        public void GuardarVisita(string idPaciente, Visita visita)
        {
            Paciente pacienteBusc = null;

            foreach (Cliente cliente in this._clientes)
            {
                foreach (Paciente mascota in cliente.Mascotas)
                {
                    if (mascota.IdPaciente == idPaciente)
                    {
                        pacienteBusc = mascota;
                    }
                }
            }
            if (pacienteBusc == null)
            {
                throw new PacienteInexistenteException("No puede agregarse visita, el paciente no existe\n");
            }

            pacienteBusc.GuardarVisita(visita);
        }
    }
}
