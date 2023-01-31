#region Ejercicio1
/*
using System.Text;
using System.Linq;
class Program {
    private static double CalculaLogaritmo(double num) {
        return Math.Log(num);
    }

    private static void Main(string[] args) {
        System.Console.WriteLine("Introduce numero: ");
        double num = double.Parse(Console.ReadLine());
        System.Console.WriteLine($"Log: {CalculaLogaritmo(num):F2}");
    }
}
1----------------------------------------------------------------------
DA ERROR SI NO SE INTRODUCE NINGÚN VALOR.
{FormatException: Input string was not in a correct format.}
2----------------------------------------------------------------------
DA ERROR SI SE INTRODUCE UN VALOR NO NUMÉRICO.
{FormatException: Input string was not in a correct format.}
3----------------------------------------------------------------------
NO DA ERROR SI SE INTRODUCE UN VALOR NUMÉRICO.
-----------------------------------------------------------------------
using System.Text;
using System.Linq;
class Program {
    private static double CalculaLogaritmo(double num) {
        return Math.Log(num);
    }

    private static void Main(string[] args) {
        System.Console.WriteLine("Introduce numero: ");
        try {
            double num = double.Parse(Console.ReadLine());
            System.Console.WriteLine($"Log: {CalculaLogaritmo(num):F2}");
        } catch(Exception e) {
            System.Console.WriteLine("ERROR: " + e.Data);
        }
    }
}
AHORA EN CASO DE ERROR LANZA EL SIGUIENTE CODIGO DE ERROR:
{ERROR: System.Collections.ListDictionaryInternal}
*/
#endregion


#region Ejercicio2
/*
using System.Text;
using System.Linq;
class Program {
    private static double CalculaLogaritmo(double num) {
        return Math.Log(num);
    }

    private static void Main(string[] args) {
        System.Console.WriteLine("Introduce numero: ");
        try {
            double num = double.Parse(Console.ReadLine());
            if(num <= 0)
                throw new ArgumentException("Valor ilegal...");
            else
                System.Console.WriteLine($"Log: {CalculaLogaritmo(num):F2}");
        } catch(ArgumentException e1) {
            System.Console.WriteLine("ERROR: " + e1.Message);
        } catch(FormatException e2) {
            System.Console.WriteLine("ERROR: " + e2.Data);
        }
    }
}
*/
#endregion


#region Ejercicio3
/*
using System.Text;
using System.Linq;
class Program {
    class ParametroNoValidoException : ArgumentException {
        public ParametroNoValidoException(string message) : base(message) { }
    }

    private static double CalculaLogaritmo(double num) {
        return Math.Log(num);
    }

    private static void Main(string[] args) {
        System.Console.WriteLine("Introduce numero: ");
        try {
            double num = double.Parse(Console.ReadLine());
            if(num <= 0)
                throw new ParametroNoValidoException("Valor ilegal...");
            else
                System.Console.WriteLine($"Log: {CalculaLogaritmo(num):F2}");
        } catch(ParametroNoValidoException e1) {
            System.Console.WriteLine("ERROR: " + e1.Message);
        } catch(FormatException e2) {
            System.Console.WriteLine("ERROR: " + e2.Data);
        }
    }
}
*/
#endregion


#region Ejercicio4
/*
using System.Text.RegularExpressions;
class NumeroCuenta {
    class NumeroCuentaIncorrectoException : Exception {
        public NumeroCuentaIncorrectoException(string mensaje) : base(mensaje) { }
    }
    private string entidad, sucursal, dcEntSuc, dcNum, cuenta;
    public NumeroCuenta(string num) {
        bool cuentaValida = formatoCorrecto(num);

            if(cuentaValida)
                cuentaValida = dcCorrecto(dcEntSuc, entidad + sucursal, new int[]{4, 8, 5, 10, 9, 7, 3, 6});
            if(cuentaValida)
                cuentaValida = dcCorrecto(dcNum, cuenta, new int[]{1, 2, 4, 8, 5, 10, 9, 7, 3, 6});
            if(!cuentaValida)
                throw new NumeroCuentaIncorrectoException("ERROR: NUMERO DE CUENTA INVALIDO");
    }
    private bool formatoCorrecto(string numero) {
        Regex regex = new Regex(@"(?<Entidad>\d{4})[\s-_](?<Sucursal>\d{4})[\s-_](?<DCEntSuc>\d)(?<DCNumero>\d)[\s-_](?<Numero>\d{10})");
        Match match = regex.Match(numero);
        if (match.Success) {
            entidad = match.Groups["Entidad"].Value;
            sucursal = match.Groups["Sucursal"].Value;
            dcEntSuc = match.Groups["DCEntSuc"].Value;
            dcNum = match.Groups["DCNumero"].Value;
            cuenta = match.Groups["Numero"].Value;
        }
        return match.Success;
    }
    private bool dcCorrecto(string dc, string digitos, int[] ponderaciones) {
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
    public string ToString() {
        string mensaje = "------------------------------------------------------" + 
                        $"[Numero de cuenta]: {cuenta}" + 
                        $"------------------------------------------------------" + 
                        $"[Entidad]: {entidad}" + 
                        $"[Sucursal]: {sucursal}" + 
                        $"[Digito Control Entidad/Sucursal]: {dcEntSuc}" + 
                        $"[Digito Control Numero]: {dcNum}" + 
                        $"------------------------------------------------------";
        return mensaje;
    }
}
class Cuenta {
    class SaldoInsuficienteException : Exception {
        public SaldoInsuficienteException(string mensaje) : base(mensaje) { }
    }
    private string titular;
    private double saldo;
    private NumeroCuenta numero;
    public Cuenta(string numero, string titular) {
        this.numero = new NumeroCuenta(numero);
        this.titular = titular;
        saldo = 0;
    }
    public void Ingreso(double cantidad) {
        saldo += cantidad;
    }
    public void Reintegro(double cantidad) {
        try {
            if((this.saldo - cantidad) < saldo)
                throw new SaldoInsuficienteException("ERROR: SALDO INSUFICIENTE EN LA CUENTA");
            else
                this.saldo -= cantidad;
        } catch(SaldoInsuficienteException e) {
            System.Console.WriteLine("----------------------------------------------------\n" +
                                    $"Codigo de error: {e.GetType().Name}\n" + 
                                     "----------------------------------------------------");
            System.Console.WriteLine("Reintegro superior al saldo disponible...");
        }
    }
    public string ToString() {
        string mensaje = "------------------------------------------------------" + 
                        $"[Numero Cuenta]: {numero}" + 
                        $"------------------------------------------------------" + 
                        $"[Titular]: {titular}" + 
                        $"[Saldo]: {saldo}" + 
                        $"------------------------------------------------------";
        return mensaje;
    }
}
class Program {
    private static void Main(string[] args) {
        try {
            Cuenta cuenta = new Cuenta("2100-0721-09-0200601249", "Jose Antonio");
            cuenta.Ingreso(15400);
            System.Console.WriteLine(cuenta);
            cuenta.Reintegro(16000);
            System.Console.WriteLine(cuenta);
        }catch(Exception e) {
            System.Console.WriteLine($"ERROR: {e}");
        }
    }
}
*/
#endregion


#region Ejercicio5
/*
using System.Text.RegularExpressions;
static class Patron {
    class NotFoundException : Exception {
        public NotFoundException(string mensaje) : base(mensaje) {}
        public NotFoundException(string message, Exception innerException) : base(message, innerException){}
    }
    private static Match Obten(string cadenaDeConsumo, string patron) {
        Match m = Regex.Match(cadenaDeConsumo, patron);
        if (!m.Success)
            throw new NotFoundException("No se han obtenido coincidencias.");
        return m;
    }
    private static string PatronDNI() {
        return @"(?<numero>\d{8})(?<separador>[\s-]?)(?<letra>[A-Za-z])";
    }
    public static string ObtenDNI(string cadenaDeConsumo) {
        try {
            return Obten(cadenaDeConsumo, PatronDNI()).Value;
        }
        catch(Exception e) {
            throw new NotFoundException($"Imposible de obtener un DNI.", e);
        }
    }
    public static string CambiarFormatoDNI(string cadenaDeConsumo) {
        try {
            Match m = Obten(cadenaDeConsumo, PatronDNI());
            string dniFormateado = $"{m.Groups["numero"].Value}{m.Groups["letra"].Value.ToUpper()}";
            return Regex.Replace(cadenaDeConsumo, PatronDNI(), dniFormateado);
        } catch (Exception e) {
            throw new NotFoundException($"No se ha podido cambiar el formato del DNI.", e);
        }
    }
}
class Program {
    private static void Main(string[] args) {
        Console.Clear();
        ConsoleKeyInfo opcion;
        string texto = null;
        do {
            Console.Write(Menu());
            opcion = Console.ReadKey(true);
            try {
                switch (opcion.Key) {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Write("Introduce texto: ");
                        texto = Console.ReadLine();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine(texto);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.WriteLine($"El DNI encontrado es {Patron.ObtenDNI(texto)}");
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        texto = Patron.CambiarFormatoDNI(texto);
                        Console.WriteLine($"El DNI se ha formateado con éxito.");
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine($"Adios");
                        break;
                    default:
                        Console.WriteLine($"Opción o válida");
                        break;
                }
            } catch (Exception e) {
                string mensaje = "";

                while (e != null) {
                    mensaje += $"{e.Message}\n";
                    e = e.InnerException;
                }
                Console.WriteLine(mensaje);
            }
            Console.WriteLine("Pulsa una tecla.");
            Console.ReadKey(true);
            Console.Clear();
        } while (opcion.Key != ConsoleKey.Escape);
    }
    private static string Menu() {
        return  "1- Introduce texto.\n" +
                "2- Muestra texto.\n" +
                "3- Obten DNI.\n" +
                "4- Cambia formato DNI.\n" +
                "ESC- Salir.\n" +
                "Selecciona una opción: ";

    }
}
*/
#endregion