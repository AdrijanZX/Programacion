#region Ejercicio1
/*
static void Valida(string patron, string textoEntrada) {            
    Console.WriteLine(textoEntrada);
    string cadena=Console.ReadLine();
    Regex regex = new Regex(patron);
    if (regex.IsMatch(cadena)) Console.WriteLine("Formato correcto");
    else Console.WriteLine("Formato incorrecto");
}
static void Main(string[] args) {
    Valida(@"^[+-]?\d+$","\n INTRODUCE UN NÚMERO ENTERO: ");
    Valida( @"^[+-]?(\d+)|(\d*[.,]\d+)$","\n INTRODUCE UN NUMERO DECIMAL: ");
    Valida(@"[+-]?((\d+)|(\d*[.,]\d+))([eE][+-]?\d+)?" ,"\n INTRODUCE UN NUMERO REAL: ");
    string patronMatriculaAnti = @"([a-zA-Z]{2}[\s-]\d{4}[\s-][a-zA-Z])";
    string patronMatriculaEU = @"(\d{4}[\s-][a-zA-Z]{3})";
    string patronMatricula = "^" + patronMatriculaAnti + "|" + patronMatriculaEU + "$";
    Valida(patronMatricula,"\n INTRODUCE UNA MATRÍCULA: ");
    Valida(@"^\d{4}[\s-]\d{4}[\s-]\d\d[\s-]\d{10}$","\n INTRODUCE NUMERO DE CUENTA (EEEE-SSSS-CC-NNNNNNNNNN): ");
    Console.ReadKey();
}
*/
#endregion


#region Ejercicio2
/*
static void ValidaCuenta(string cuenta, string textoError) {
    string patronCuenta = @"^(?<Entidad>\d{4})[\s-](?<Sucursal>\d{4})[\s-](?<DC1>\d{1})(?<DC2>\d{1})[\s-](?<Cuenta>\d{10})$";
    Regex patron = new Regex(patronCuenta);
    Match coincidencia = patron.Match(cuenta);
    if (coincidencia.Success) {
        Console.WriteLine("\n");
        Console.WriteLine(" Entidad: {0}", int.Parse(coincidencia.Groups["Entidad"].Value));
        Console.WriteLine(" Sucursal: {0}", int.Parse(coincidencia.Groups["Sucursal"].Value));
        Console.WriteLine(" DC1: {0}", int.Parse(coincidencia.Groups["DC1"].Value));
        Console.WriteLine(" DC2: {0}", int.Parse(coincidencia.Groups["DC2"].Value));
        Console.WriteLine(" Nº Cuenta: {0}", int.Parse(coincidencia.Groups["Cuenta"].Value));
    } else {
        Console.WriteLine(textoError + "\n " + patronCuenta);
    }
}
static void Main(string[] args) {
    Console.Write("\n INTRODUCE UN Nº DE CUENTA: (EEEE-SSSS-CC-NNNNNNNNNN)\n ");
    ValidaCuenta(Console.ReadLine(), @"Error: formato incorrecto.");
    Console.WriteLine("\n");
    Console.ReadKey(true);
}
*/
#endregion


#region Ejercicio3
/*
static bool ValidaExpresion(string cadenaValidar, string cadenaPatron) {
    Regex patron = new Regex(cadenaPatron);
    if (patron.IsMatch(cadenaValidar)) return true;
    else return false;
}
static string ValidaCIF(string cif, string textoError) {
    string patronFecha = @"^[A-HK-NPQSa-hk-npqs][\s-]?\d{2}\d{5}[\s-]?([A-Ja-j]|\d)$";
    if (ValidaExpresion(cif, patronFecha)) return cif;
    else return textoError + "\n " + patronFecha;
}
static void Main(string[] args) {
    Console.Write("\n INTRODUCE CIF: ");
    Console.WriteLine("\n " + ValidaCIF(Console.ReadLine(), @"Error: formato incorrecto."));
}
*/
#endregion


#region Ejercicio4
/*
static void ValidarCIF(string cif, string textoError) {
    string patronFecha = @"^(?<ORG>[A-HK-NPQSa-hk-npqs])[\s-]?(?<CP>\d{2})(?<NP>\d{5})[\s-]?(?<DC>([A-Ja-j]|\d))$";
    Regex patron = new Regex(patronFecha);
    Match coincidencia = patron.Match(cif);
    if (coincidencia.Success) {
        Console.WriteLine("\n");
        Console.WriteLine(" Letra de tipo de Organización: {0}", coincidencia.Groups["ORG"].Value.ToUpper());
        Console.WriteLine(" Código Provincial numérico: {0}", coincidencia.Groups["CP"].Value);
        Console.WriteLine(" Numeración secuencial dentro de la provincia: {0}", coincidencia.Groups["NP"].Value);
        Console.WriteLine(" Dígito de control: {0}", coincidencia.Groups["DC"].Value.ToUpper());
    } else {
        Console.WriteLine(textoError + "\n " + patronFecha);
    }
}
static void Main(string[] args) {
    Console.Write("\n INTRODUCE UN CIF: (T-PPNNNNN-C)\n ");
    ValidarCIF(Console.ReadLine(), @"Error: formato incorrecto.");
    Console.WriteLine("\n");
    Console.ReadKey(true);
}
*/
#endregion


#region Ejercicio7
/*
static bool ValidaExpresion(string cadenaValidar, string cadenaPatron) {
    Regex patron = new Regex(cadenaPatron);
    if (patron.IsMatch(cadenaValidar)) return true;
    else return false;
}
static string ValidaDefinicionEnum(string defEnum, string textoError) {
    string patronDefEnum = @"^enum [A-Z]\w* {([A-Z][a-z0-9]*[,])*([A-Z][a-z0-9]*)}$";
    if (ValidaExpresion(defEnum, patronDefEnum)) return defEnum;
    else return textoError + "\n " + patronDefEnum;
}
static void Main(string[] args) {
    Console.Write("\n ESCRIBE LA DEFINICIÓN DE UN ENUM: ");
    Console.WriteLine(ValidaDefinicionEnum(Console.ReadLine(), @"ERROR: formato incorrecto."));
}
*/
#endregion