using Entidades;


namespace TuProyecto
{
    public partial class CalculadoraForm : Form
    {
        private Calculadora calculadora;

        public CalculadoraForm()
        {
            InitializeComponent();
            this.calculadora = new Calculadora("Nombre y Apellido");
            this.cmbOperacion.DataSource = new char[] { '+', '-', '*', '/' };
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador = (char)this.cmbOperacion.SelectedItem;
            this.calculadora.PrimerOperando = this.GetOperador(this.txtPrimerOperando.Text);
            this.calculadora.SegundoOperando = this.GetOperador(this.txtSegundoOperando.Text);
            this.calculadora.Calcular(operador);
            this.calculadora.ActualizaHistorialDeOperaciones(operador);
            this.lblResultado.Text = $"Resultado: {calculadora.Resultado.Valor}";
            this.MostrarHistorial();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.calculadora.EliminarHistorialDeOperaciones();
            this.txtPrimerOperando.Text = string.Empty;
            this.txtSegundoOperando.Text = string.Empty;
            this.lblResultado.Text = "Resultado:";
            this.MostrarHistorial();
        }

        private void MostrarHistorial()
        {
            this.lstHistorial.DataSource = null;
            this.lstHistorial.DataSource = this.calculadora.Operaciones;
        }

        private Numeración GetOperador(string texto)
        {
            // Implementa la lógica para convertir el texto en una instancia de Numeración
            // Puede ser SistemaDecimal, SistemaBinario, u otro, según el sistema actual
            // de la calculadora.
            // Debes implementar esta lógica según tu definición de Numeración y sistemas.
            // Por ejemplo, podrías usar un switch para determinar el sistema y crear la instancia correcta.
            return null;
        }

        private void radioBtnBinario_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Binario;
        }

        private void radioBtnDecimal_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Decimal;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CalculadoraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}