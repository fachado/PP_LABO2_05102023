
using System.Text;


namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones = new List<string>();
        private Numeración primerOperando;
        private Numeración segundoOperando;
        private Numeración resultado;
        private Esistema sistema;

        public string NombreAlumno
        {
            get { return nombreAlumno; }
            set { nombreAlumno = value; }
        }

        public List<string> Operaciones
        {
            get { return operaciones; }
        }

        public Numeración PrimerOperando
        {
            get { return primerOperando; }
            set { primerOperando = value; }
        }

        public Numeración Resultado
        {
            get { return resultado; }
        }

        public Numeración SegundoOperando
        {
            get { return segundoOperando; }
            set { segundoOperando = value; }
        }


        public Esistema Sistema
        {
            get { return sistema; }
            set { sistema = value; }
        }

        public string Calcular(char operador)
        {
            if (primerOperando.GetType() != segundoOperando.GetType())
            {
                resultado = new SistemaDecimal(double.MinValue.ToString()); 
            }
            else
            {
                double valor1 = primerOperando.ValorNumerico;
                double valor2 = segundoOperando.ValorNumerico;

                double resultadoNumerico = 0.0;

                switch (operador)
                {
                    case '+':
                        resultadoNumerico = valor1 + valor2;
                        break;
                    case '-':
                        resultadoNumerico = valor1 - valor2;
                        break;
                    case '*':
                        resultadoNumerico = valor1 * valor2;
                        break;
                    case '/':
                        if (valor2 != 0)
                        {
                            resultadoNumerico = valor1 / valor2;
                        }
                        else
                        {
                            resultadoNumerico = double.MinValue; // División por cero
                        }
                        break;
                    // Agregar más operadores según sea necesario
                    default:
                        resultadoNumerico = valor1 + valor2; // Suma por defecto
                        break;
                }

                resultado = MapeaResultado(resultadoNumerico);
            }

            return resultado.Valor;
        }

        private Numeración MapeaResultado(double resultadoNumerico)
        {
            switch (sistema)
            {
                case Esistema.Decimal:
                    return new SistemaDecimal(resultadoNumerico.ToString());
                case Esistema.Binario:
                    return new SistemaBinario(resultadoNumerico.ToString());
                default:
                    return new SistemaDecimal(resultadoNumerico.ToString()); // Sistema Decimal por defecto
            }

        }
        public string ActualizaHistorialDeOperaciones(char operador)
        {
            StringBuilder historial = new StringBuilder();

            historial.Append($"Sistema: {sistema}\n");
            historial.Append($"Primer Operando: {primerOperando.Valor}\n");
            historial.Append($"Segundo Operando: {segundoOperando.Valor}\n");
            historial.Append($"Operador: {operador}\n");

            operaciones.Add(historial.ToString());

            return historial.ToString();
        }

        public void EliminarHistorialDeOperaciones()
        {
            operaciones.Clear();
        }

    }
}
