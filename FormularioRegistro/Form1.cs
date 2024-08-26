using CustomEventLibrary;
using FormularioRegistro.Events;

namespace FormularioRegistro
{
    public partial class Form1 : Form
    {
        private ChangeColor colorChanger;
        private DocumentNumberValidator documentValidator;
        public Form1()
        {
            InitializeComponent();
            colorChanger = new ChangeColor();
            colorChanger.ColorChanged += ColorChanger_ColorChanged;
            documentValidator = new DocumentNumberValidator();
            documentValidator.ValidationFailed += DocumentValidator_ValidationFailed;
        }

        private void ColorChanger_ColorChanged(object sender, Color e)
        {
            this.BackColor = e;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMasculino.Checked)
            {
                colorChanger.ColorChange(Color.LightBlue);
            }
        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDui.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            comboBoxEspecialidad.SelectedIndex = 0;
            labelEdad.Value = 18;
            txtobservaciones.Clear();
        }

        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemenino.Checked)
            {
                colorChanger.ColorChange(Color.FromArgb(192, 192, 255));
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string documentNumber = txtDui.Text;
            //documentValidator.ValidateDocumentNumber(documentNumber);

            if (!documentValidator.ValidateDocumentNumber(documentNumber))
            {
                return;
            }else if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }else if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                MessageBox.Show("El campo Apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidos.Focus();
                return;
            }else if (!rbMasculino.Checked && !rbFemenino.Checked)
            {
                MessageBox.Show("Debe seleccionar un género.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if (comboBoxEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una especialidad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxEspecialidad.Focus();
                return;
            }else
            {
                if (!int.TryParse(labelEdad.Text, out int edad) || !int.TryParse(txtDui.Text, out int dui))
                {
                    MessageBox.Show("Edad y DUI deben ser números válidos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    labelEdad.Focus(); // Enfoca en edad ya que es el primer campo relevante
                    return;
                }

                RegisterUser register = new RegisterUser(
                    txtNombre.Text,
                    txtApellidos.Text,
                    rbMasculino.Checked ? "Masculino" : "Femenino",
                    comboBoxEspecialidad.Text,
                    edad,
                    dui,
                    txtobservaciones.Text
                 );

                Registro nuevoFormulario = new Registro(register);
                nuevoFormulario.Show();
                this.Hide();
            }

            
        }

        private void DocumentValidator_ValidationFailed(object sender, string documentNumber)
        {
            MessageBox.Show($"El número de documento '{documentNumber}' no es válido. Debe tener exactamente 7 dígitos.", "Validación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtDui.Focus();
        }
    }
}
