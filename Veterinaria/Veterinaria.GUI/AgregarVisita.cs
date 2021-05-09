using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.Libreria.Entidades;
using Veterinaria.Libreria.Exceptions;

namespace Veterinaria.GUI
{
    public partial class AgregarVisita : Form
    {
        public AgregarVisita(Form form, SucVeterinaria sucVeterinaria, Paciente paciente)
        {
            InitializeComponent();
        }

        private void AgregarVisita_Load(object sender, EventArgs e)
        {

        }
    }
}
