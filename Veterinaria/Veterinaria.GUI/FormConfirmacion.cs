using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria.GUI
{
    public partial class FormConfirmacion : Form
    {
        private string _leyenda;
        private bool _confirmacion;

        public bool Confirmacion { get => _confirmacion; }

        public FormConfirmacion(Form form, string leyenda)
        {
            this.Owner = form;
            _leyenda = leyenda;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLeyenda.Text = _leyenda;
            _confirmacion = false;
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            _confirmacion = true;
            this.Owner.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _confirmacion = false;
            this.Owner.Show();
            this.Close();
        }
    }
}
