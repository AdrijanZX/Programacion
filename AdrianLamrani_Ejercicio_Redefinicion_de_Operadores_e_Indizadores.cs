#region Ejercicio1
/*
using System;
class Euro {
    public double valor { get; }
    public Euro(double valor) {
        this.valor = valor;
    }
    public override string ToString() => $"{valor} euro";
    public static explicit operator Peseta(Euro e) 
        => new Peseta(e.valor * 166386);
    public static explicit operator double(Euro e) => e.valor;

    public static Euro operator +(Euro e1, Euro e2)
        => new Euro(e1.valor + e2.valor);
    public static Euro operator -(Euro e1, Euro e2)
        => new Euro(e1.valor - e2.valor);

    public override int GetHashCode() => $"{valor:F2}".GetHashCode();
    public override bool Equals(object obj)
        => obj is Euro e && Math.Abs(valor - e.valor) < 1e-2;
    public static bool operator == (Euro e1, Euro e2) 
        => e1.Equals(e2);
    public static bool operator != (Euro e1, Euro e2) 
        => !e1.Equals(e2);

    public static bool operator ==(Euro e, Peseta pes) 
        => e == (Euro)pes;
    public static bool operator !=(Euro e, Peseta pes) 
        => e != (Euro)pes;

    public static bool operator ==(Peseta pes, Euro e) 
        => e == pes;
    public static bool operator !=(Peseta pes, Euro e) 
        => e != pes;
}
class Peseta {
    private double valor { get; }
    public Peseta(double valor) {
        this.valor = valor;
    }
    public override string ToString() 
        => $"{valor} pesetas";
    
    public static explicit operator Euro(Peseta pes) 
        => new Euro(pes.valor / 166386);
    public static explicit operator double(Peseta pes) 
        => pes.valor;

    public static Peseta operator +(Peseta pes1, Peseta pes2)
        => new Peseta(pes1.valor + pes2.valor);
    public static Peseta operator -(Peseta pes1, Peseta pes2)
        => new Peseta(pes1.valor - pes2.valor);

    public static Peseta operator +(Peseta pes, Euro e)
        => pes + (Peseta)e;
    public static Peseta operator -(Peseta pes, Euro e)
        => pes - (Peseta)e;

    public static Peseta operator +(Euro e, Peseta pes)
        => (Peseta)e + pes;
    public static Peseta operator -(Euro e, Peseta pes)
        => (Peseta)e - pes;

    public override int GetHashCode() => $"{valor:F2}".GetHashCode();
    public override bool Equals(object obj)
        => obj is Peseta pes && Math.Abs(valor - pes.valor) < 1e-2;
    public static bool operator ==(Peseta pes1, Peseta pes2) 
        => pes1.Equals(pes2);
    public static bool operator !=(Peseta pes1, Peseta pes2) 
        => !pes1.Equals(pes2);
}
class Program {
    private static void Main(string[] args) {
        var pes1 = new Peseta(166386);
        var pes2 = new Peseta(166386);
        var e = new Euro(1);
        Console.WriteLine($"{pes1} + {e} = {pes1 + e}");
        Console.WriteLine($"{e} + {pes1} = {e + pes1}");
        Console.WriteLine($"{e} == {pes1} = {e == pes1}");
        Console.WriteLine($"{e} == {pes2} = {e == pes2}");
        Console.WriteLine($"{e} != {pes2} = {e != pes2}");
        Console.WriteLine($"{e + pes1} == {pes2 + pes1} = {e + pes1 == pes2 + pes1}");
        Console.WriteLine($"{e} + {e} + {pes1} + {e} + {pes2} = {e + e + pes1 + e + pes2}");
        Console.WriteLine($"{e} = {(Euro)e}");
        Console.WriteLine($"{pes1} = {(Peseta)pes1}");
        Console.WriteLine($"{e} = {(double)e}");
        Console.WriteLine($"{pes1} = {(double)pes1}");
    }
}
*/
#endregion


#region Ejercicio2
/*
using System;
using System.Text.RegularExpressions;

namespace Ejercicios {
    class SaldoInsuficException : Exception {
        public SaldoInsuficException(string mensaje) : base(mensaje) { ; }
    }

    class NumeroCuentaIncorrecto : Exception {
        public NumeroCuentaIncorrecto(string mensaje) : base(mensaje) { ; }
    }

    class Cuenta {
        private NumeroCuenta numero;
        private string titular;
        private double saldo;

        public Cuenta(string numero, string titular) {
            this.numero = new NumeroCuenta(numero);
            this.titular = titular;
            saldo = 0;
        }

        public void Ingreso(double cantidad) {
            saldo = saldo + cantidad;
        }

        public void Reintegro(double cantidad) {
            if (saldo - cantidad > 0)
                saldo = saldo - cantidad;
            else
                throw new SaldoInsuficException($"Saldo {saldo:C} insuficiente para reintegro de {cantidad:C}.\nEn cuenta: {numero}.");
        }
        public override bool Equals(object obj) {
            Cuenta c=obj as Cuenta ?? throw new FormatException("No es un número de cuenta");
            return titular == c.titular &&
                   saldo == c.saldo &&
                   numero == c.numero;
        }
        
		
        public static bool operator ==(Cuenta c1, Cuenta c2) {
           return c1.Equals(c2);
        }

        public static bool operator !=(Cuenta c1, Cuenta c2) {
            return !(c1 == c2);
        }
		

        public override string ToString() {
            string texto = $"Numero de cuenta: {numero} ";
            texto += $"Titular: {titular} ";
            texto += $"Saldo: {saldo:C}";
            return texto;
        }
    }

    class NumeroCuenta {
        private string entidad;
        private string sucursal;
        private string dCEntSuc;
        private string dCNumero;
        private string cuenta;

        public NumeroCuenta(string numero) {
            bool cuentaValida = formatoCorrecto(numero);

            if (cuentaValida)
                cuentaValida = dcCorrecto(dCEntSuc, entidad + sucursal, new int[] { 4, 8, 5, 10, 9, 7, 3, 6 });
            if (cuentaValida)
                cuentaValida = dcCorrecto(dCNumero, cuenta, new int[] { 1, 2, 4, 8, 5, 10, 9, 7, 3, 6 });
            if (!cuentaValida)
                throw new NumeroCuentaIncorrecto($"Número de cuenta {numero} incorrecto.");
        }

        static private bool dcCorrecto(string dc, string digitos, int[] ponderaciones) {
            int valor = 0;

            for (int i = 0; i < digitos.Length; ++i)
                valor += (int)char.GetNumericValue(digitos, i) * ponderaciones[i];

            int dcAux = 11 - valor % 11;

            dcAux = (dcAux == 10) ? 1 : dcAux;
            dcAux = (dcAux == 11) ? 0 : dcAux;

            if (dcAux == Convert.ToInt32(dc))
                return true;
            else
                return false;
        }

        private bool formatoCorrecto(string numero) {
            Regex regex = new Regex(@"(?<Entidad>\d{4})[\s-_](?<Sucursal>\d{4})[\s-_](?<DCEntSuc>\d)(?<DCNumero>\d)[\s-_](?<Numero>\d{10})");
            Match match = regex.Match(numero);
            if (match.Success) {
                entidad = match.Groups["Entidad"].Value;
                sucursal = match.Groups["Sucursal"].Value;
                dCEntSuc = match.Groups["DCEntSuc"].Value;
                dCNumero = match.Groups["DCNumero"].Value;
                cuenta = match.Groups["Numero"].Value;
            }

            return match.Success;
        }
      
        public override bool Equals(object obj) {
            NumeroCuenta n= obj as NumeroCuenta??throw new FormatException("No es un número de cuenta.");
           return n.entidad == entidad &&
                   n.sucursal == sucursal &&
                   n.dCEntSuc == dCEntSuc &&
                   n.dCNumero == dCNumero &&
                   n.cuenta == cuenta;
        }

        public static bool operator ==(NumeroCuenta numero_cuenta_uno, NumeroCuenta numero_cuenta_dos) {
            return numero_cuenta_uno.Equals(numero_cuenta_dos);
        }

        public static bool operator !=(NumeroCuenta numero_cuenta_uno, NumeroCuenta numero_cuenta_dos) {
            return !(numero_cuenta_uno == numero_cuenta_dos);
        }

        public override string ToString() {
            return $"{entidad}-{sucursal}-{dCEntSuc}{dCNumero}-{cuenta}";
        }
    }

    class Program {
        static void Main(string[] args) {
            try {
                Cuenta cuenta_uno = new Cuenta("9382 6473 53 6473825478", "Adrian Lamrani");
                Cuenta cuenta_dos = new Cuenta("9382 6473 53 6473825478", "Adrian Lamrani");
                string texto = (cuenta_uno == cuenta_dos) ? "iguales" : "distintas";
                System.Console.WriteLine($"{cuenta_uno}\ny...\n{cuenta_dos}\nson {texto}.");
            }
            catch (NumeroCuentaIncorrecto e) {
                Console.WriteLine(e);
            }
            catch (SaldoInsuficException e) {
                Console.WriteLine(e);
            }
        }
    }
}
*/
#endregion


#region Ejercicio3
/*

*/
#endregion


#region Ejercicio4
/*

*/
#endregion


