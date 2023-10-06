namespace Entidades
{


    public enum Esistema
    {
        Binario,
        Decimal,
    }

    public abstract class Numeración
    {
        protected string valor;
        protected static string msgError = "Número Inválido";

        protected Numeración(string valor)
        {
            InicializaValor(valor);
        }

        public string Valor
        {
            get { return valor; }
        }

        internal abstract double ValorNumerico { get; }

        public abstract Numeración CambiarSistemaDeNumeracion(Esistema sistema);

        protected bool EsNumeracionValida(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        private void InicializaValor(string nuevoValor)
        {
            if (EsNumeracionValida(nuevoValor))
            {
                valor = nuevoValor;
            }
            else
            {
                valor = msgError;
            }
        }

        public static explicit operator double(Numeración numeracion)
        {
            return numeracion.ValorNumerico;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Numeración otraNumeracion = (Numeración)obj;
            return valor == otraNumeracion.valor && GetType() == otraNumeracion.GetType();
        }

        public override int GetHashCode()
        {
            return valor.GetHashCode();
        }

        public static bool operator ==(Numeración numeracion1, Numeración numeracion2)
        {
            if (ReferenceEquals(numeracion1, numeracion2))
            {
                return true;
            }

            if (numeracion1 is null || numeracion2 is null)
            {
                return false;
            }

            return numeracion1.Equals(numeracion2);
        }

        public static bool operator !=(Numeración numeracion1, Numeración numeracion2)
        {
            return !(numeracion1 == numeracion2);
        }
    }

}