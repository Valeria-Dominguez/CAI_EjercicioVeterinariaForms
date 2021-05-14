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

        public string Nombre { get => _nombre; }
        public string Domicilio { get => _domicilio; }
        public List<Cliente> Clientes { get => _clientes; set => _clientes = value; }

        public SucVeterinaria(string nombre, string domicilio, string telefono, string encargado)
        {
            this._nombre = nombre;
            this._domicilio = domicilio;
            this._telefono = telefono;
            this._encargado = encargado;
            this._clientes = new List<Cliente>();
        }

        //
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
        
        public void ModificarCliente(Cliente clienteModificado, Cliente clienteAModificar)
        {
            clienteAModificar.Nombre = clienteModificado.Nombre;
            clienteAModificar.Domicilio = clienteModificado.Domicilio;
            clienteAModificar.NumeroTel = clienteModificado.NumeroTel;
            clienteAModificar.Email = clienteModificado.Email;
        }

        public string ListarHistoria (string idPaciente)
        {
            Paciente paciente = BuscarPaciente(idPaciente);
            return paciente.ListarHistoria();
        }

        public void EliminarCliente(Cliente cliente)
        {
            if (cliente.Mascotas.Count != 0)
            {
                throw new PacientesIngresadosException("No puede eliminarse, existen mascotas ingresadas");
            }
            this._clientes.Remove(cliente);
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

        public Cliente BuscarCliente(string idCliente)
        {
            Cliente clienteEncontrado = null;
            foreach (Cliente cliente in this._clientes)
            {
                if (cliente.Id==idCliente)
                {
                    clienteEncontrado = cliente;
                }
            }
            if (clienteEncontrado == null)
            {
                throw new ClienteInexistenteException("El cliente no existe\n");
            }
            return clienteEncontrado;
        }

        public Paciente BuscarPaciente(string idPaciente)
        {
            Paciente pacienteEncontrado = null;
            foreach (Cliente cliente in this._clientes)
            {
                foreach (Paciente paciente in cliente.Mascotas)
                {
                    if (paciente.IdPaciente == idPaciente)
                    {
                        pacienteEncontrado = paciente;
                    }
                }
            }
            if (pacienteEncontrado == null)
            {
                throw new PacienteInexistenteException("El paciente no existe\n");
            }
            return pacienteEncontrado;
        }
    }
}
