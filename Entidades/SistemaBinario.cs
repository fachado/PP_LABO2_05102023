using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class SistemaBinario : Numeración
    {
        public SistemaBinario(string valor) : base(valor)
        {
        }

        internal override double ValorNumerico
        {
            get
            {
                if (!EsSistemaBinarioValido(valor))
                {
                    return double.MinValue;
                }

                double valorDecimal = Convert.ToInt64(valor, 2);
                return valorDecimal;
            }
        }

        public override Numeración CambiarSistemaDeNumeracion(Esistema sistema)
        {
            switch (sistema)
            {
                case Esistema.Binario:
                    return this;
                case Esistema.Decimal:
                    return new SistemaDecimal(valor);
                default:
                    return this;
            }
        }
        protected bool EsNumeracionValida(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        private bool EsSistemaBinarioValido(string valor)
        {
            foreach (char c in valor)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }

            return true;
        }

        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }
    }
}
