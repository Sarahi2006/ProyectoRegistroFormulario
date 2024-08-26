using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioRegistro
{
    public partial class Registro : Form
    {
        private RegisterUser _register;
        public Registro(RegisterUser register)
        {
            InitializeComponent();
            _register = register;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            labelName.Text = _register.ObtenerNombre();
            labelApellido.Text = _register.ObtenerApellido();
            labelEdad.Text = _register.ObtenerEdad().ToString();
            Especialistalabel.Text = _register.ObtenerEspecialidad();
            Generolabel.Text = _register.ObtenerGenero();
        }
    }
}
