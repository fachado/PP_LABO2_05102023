

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

        }

       

        private bool EsNumeroValido(string valor)
        {
            double resultado;
            return double.TryParse(valor, out resultado);
        }
        /*
                private void Decima_MouseClick(object sender, EventArgs e)
                {


                    if (!string.IsNullOrEmpty(label1.Text))
                    {
                        setResultado();
                    }
        
                }
        
                private void Binario_MouseClick(object sender, EventArgs e)
                {


                    if (!string.IsNullOrEmpty(label1.Text))
                    {
                        setResultado();
                    }

                }
        */

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("/");
            comboBox1.Items.Add("*");


            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();


            label1.Text = "";
        }

        private void cerrar_click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Desea cerrar la calculadora?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}