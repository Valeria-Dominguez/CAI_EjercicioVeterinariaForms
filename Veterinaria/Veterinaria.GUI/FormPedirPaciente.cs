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
    public partial class FormPedirPaciente : Form
    {
        private SucVeterinaria _sucVeterinaria;
        private Paciente _pacienteEncontrado;

        public Paciente PacienteEncontrado { get => _pacienteEncontrado; set => _pacienteEncontrado = value; }

        public FormPedirPaciente(Form form, SucVeterinaria sucVeterinaria)
        {
            _sucVeterinaria = sucVeterinaria;
            _pacienteEncontrado = null;
            this.Owner = form;
            InitializeComponent();
        }

        private void PedirPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdPaciente.Text == string.Empty) { throw new Exception("El campo no puede estar vacío"); }
                Paciente paciente = _sucVeterinaria.BuscarPaciente(txtIdPaciente.Text);
                _pacienteEncontrado = paciente;
                txtIdPaciente.Text = string.Empty;
            }
            catch (PacienteInexistenteException pacienteInexistExcep)
            {
                MessageBox.Show(pacienteInexistExcep.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
