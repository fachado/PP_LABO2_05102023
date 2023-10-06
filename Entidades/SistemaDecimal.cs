using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeración
    {
        public SistemaDecimal(string valor) : base(valor)
        {
        }

        internal override double ValorNumerico
        {
            get { return EsSistemaDecimalValido(valor) ? double.Parse(valor) : 0.0; }
        }

        public override Numeración CambiarSistemaDeNumeracion(Esistema sistema)
        {
            switch (sistema)
            {
                case Esistema.Binario:
                    if (ValorNumerico > 0)
                    {
                        Numeración valorBinario = DecimalABinario();
                        return valorBinario;
                    }
                    else
                    {
                        return new SistemaBinario(msgError);
                    }
                case Esistema.Decimal:
                    return this;
                default:
                    return this;
            }
        }

        protected bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && EsSistemaDecimalValido(valor);
        }

        private bool EsSistemaDecimalValido(string valor)
        {
            double resultado;
            return double.TryParse(valor, out resultado);
        }

        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }

        private Numeración DecimalABinario()
        {
            double valorDecimal = ValorNumerico;
            if (valorDecimal == 0)
            {
                return new SistemaBinario(msgError);
            }

            long valorAbsoluto = (long)Math.Abs(valorDecimal);
            string valorBinario = "";

            while (valorAbsoluto > 0)
            {
                long reducido = valorAbsoluto % 2;
                valorBinario = reducido + valorBinario;
                valorAbsoluto = valorAbsoluto / 2;
            }

            if (valorDecimal < 0)
            {
                valorBinario = "-" + valorBinario;
            }

            return new SistemaBinario(valorBinario);
        }
    }
}
