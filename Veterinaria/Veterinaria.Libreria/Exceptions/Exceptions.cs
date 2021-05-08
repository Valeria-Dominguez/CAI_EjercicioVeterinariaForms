using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Libreria.Exceptions
{
    public class SinPacientesIngresadosException : Exception
    {
        public SinPacientesIngresadosException (string message): base (message)
        {

        }
        public SinPacientesIngresadosException(): base ("No hay pacientes ingresados\n")
        {

        }
    }
    public class PacientesIngresadosException : Exception
    {
        public PacientesIngresadosException(string message) : base(message)
        {

        }
        public PacientesIngresadosException() : base("Hay pacientes ingresados\n")
        {

        }
    }

    public class PacienteInexistenteException : Exception
    {
        public PacienteInexistenteException (string message) : base (message)
        {

        }
        public PacienteInexistenteException (): base ("El paciente no existe\n")
        {

        }
    }

    public class ClienteInexistenteException : Exception
    {
        public ClienteInexistenteException(string message) : base(message)
        {

        }
        public ClienteInexistenteException() : base("El cliente no existe\n")
        {

        }
    }
    public class ClienteExistenteException : Exception
    {
        public ClienteExistenteException(string message) : base(message)
        {

        }
        public ClienteExistenteException() : base("El cliente ya existe\n")
        {

        }
    }

    public class PacienteExistenteException : Exception
    {
        public PacienteExistenteException(string message) : base(message)
        {

        }
        public PacienteExistenteException() : base("El paciente ya existe\n")
        {

        }
    }
}
