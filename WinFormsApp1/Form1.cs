using Entidades;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Calculadora calculadora;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char operador = (char)this.cmbOperacion.SelectedItem;
            this.calculadora.PrimerOperando = this.GetOperador(this.txtPrimerOperando.Text);
            this.calculadora.SegundoOperando = this.GetOperador(this.txtSegundoOperando.Text);
            this.calculadora.Calcular(operador);
            this.calculadora.ActualizaHistorialDeOperaciones(operador);
            this.lblResultado.Text = $"Resultado: {calculadora.Resultado.Valor}";
            this.MostrarHistorial();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            calculadora.Sistema = Esistema.Binario;
        }

        private Numeración GetOperador(string texto)
        {
  
            switch (calculadora.Sistema)
            {
                case Esistema.Binario:

                    return new SistemaBinario(texto);
                case Esistema.Decimal:

                    return new SistemaDecimal(texto);

                default:

                    return new SistemaDecimal("Número Inválido");
            }
        }
        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            calculadora.Sistema = Esistema.Decimal;
            
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
            this.lstHistorial.DataSource =
            this.calculadora.Operaciones;
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

        private void lstHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.calculadora = new Calculadora();
            this.cmbOperacion.DataSource = new char[] { '+', '-', '*', '/' };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}