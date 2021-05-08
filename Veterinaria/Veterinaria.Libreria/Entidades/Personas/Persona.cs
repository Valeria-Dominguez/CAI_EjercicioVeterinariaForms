using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Libreria.Entidades
{
    public class Persona
    {
        string _id;
        string _nombre;
        string _domicilio;
        string _numeroTel;
        string _email;

        public string Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Domicilio { get => _domicilio; set => _domicilio = value; }
        public string NumeroTel { get => _numeroTel; set => _numeroTel = value; }
        public string Email { get => _email; set => _email = value; }

        public Persona(string id, string nombre, string domicilio, string numeroTel, string email)
        {
            _id = id;
            _nombre = nombre;
            _domicilio = domicilio;
            _email = email;
            _numeroTel = numeroTel;
        }
        public override string ToString()
        {
            return $" Id: {this._id}\n Nombre: {this._nombre}\n Domicilio: {this._domicilio}\n Teléfono: {this._numeroTel}\n Email: {this._email}\n\n";
        }
    }
}
