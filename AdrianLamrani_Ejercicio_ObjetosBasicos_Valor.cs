#region Ejercicio1 
/*
using System.Text;
using System.Linq;
enum Categoria {
    Subalterno = 10, Administrativo = 20, JefeDepartamento = 40, Gerente = 60
}

class Empleado {
    private readonly string dni = default;
    private readonly string nombre = default;
    private readonly int anyNacimiento = default;
    public Categoria categoria;

    public Empleado(string dni, string nombre, int nacimiento) {
        this.dni = dni;
        this.nombre = nombre;
        this.anyNacimiento = nacimiento;
    }
    public Empleado(Empleado e) {
        this.dni = e.GetDni();
        this.nombre = e.GetNombre();
        this.anyNacimiento = e.GetAnyNacimiento();
    }
    
    public string GetNombre() {
        return nombre;
    }
    public int GetAnyNacimiento() {
        return anyNacimiento;
    }
    public string GetDni() {
        return dni;
    }
    public void SetCategoria(Categoria categoria) {
        this.categoria = categoria;
    }
    public double Salario() {
        int salarioBase = 1200;
        return salarioBase+(((double)categoria/100)*salarioBase);
    }
    public string Acadena() {
        return $"El empleado {GetNombre()} con dni: {GetDni()} tiene un salario {Salario()} y su categoria es: {categoria}";
    }
    public string datotest() {
        return $"{(int) categoria}";
    }
}

class Program {
    private static void Main(string[] args) {
        Empleado empleado1 = new Empleado("23453456L", "María Soto del Rio", 1920);
        Empleado empleado2 = new Empleado("14568712G", "Juanma Perez Ortiz", 1920);
        Empleado empleado3 = new Empleado("12346123K", "Pedro Martinez Sancho", 1920);

        empleado1.SetCategoria(Categoria.Gerente);
        empleado2.SetCategoria(Categoria.Administrativo);
        empleado3.SetCategoria(Categoria.Administrativo);

        System.Console.WriteLine(empleado1.Acadena());
        System.Console.WriteLine(empleado2.Acadena());
        System.Console.WriteLine(empleado3.Acadena());
    }
}
*/
#endregion


#region Ejercicio2
/*
using System.Text;
using System.Linq;
class EquipoInformatico {
    private readonly short pulgadas = default;
    private short numColores = default;
    private string contrGraphic = default;
    private int pX = default;
    private int pY = default;

    public EquipoInformatico(short pulgadas, short numColores, string contrGraphic, int pX, int pY) {
        this.pulgadas = pulgadas;
        this.numColores = numColores;
        this.contrGraphic = contrGraphic;
        this.pX = pX;
        this.pY = pY;
    }
    public EquipoInformatico(EquipoInformatico ei) {
        this.pulgadas = ei.pulgadas;
        this.numColores = ei.numColores;
        this.contrGraphic = ei.contrGraphic;
        this.pX = ei.pX;
        this.pY = ei.pY;
    }

    public void SetNumColores(short numColores) {
        this.numColores = numColores;
    }
    public void SetResolucion(int pX, int pY) {
        this.pX = pX;
        this.pY = pY;
    }
    public void SetContrGraphics(string contrGraphic) {
        this.contrGraphic = contrGraphic;
    }
    public string ACadena() {
        return $"Pulgadas: {pulgadas}\nNumero de colores: {numColores}\nResolucion: {pX}x{pY}\nControlador Grafico: {contrGraphic}";
    }
}

class Program {
    private static void Main(string[] args) {
        Console.Clear();
        EquipoInformatico ei = new EquipoInformatico(27, 128, "2023.03.9872.12", 1920, 1080);
        System.Console.WriteLine(ei.ACadena());
    }
}
*/
#endregion


#region Ejercicio3 
/*
using System.Text;
using System.Linq;
public enum sexoHumano {Masculino, Femenino, HelicopteroApache}
public enum inteligenciaHumano {Retrasado, Normal, Inteligente, Superdotado};
public enum destrezaHumano {Baja, Media, Alta, Excelente, Perfecta};
class Humano {
    private sexoHumano sexo;
    private inteligenciaHumano inteligencia;
    private destrezaHumano destreza;
    private string nombre;
    private int edad, peso, fuerza, energia;
    public Humano(string nombre, int edad, int peso, sexoHumano sexo, inteligenciaHumano inteligencia, int fuerza, destrezaHumano destreza, int energia) {
        this.nombre = nombre;
        this.peso = peso;
        this.edad = edad;
        this.sexo = sexo;
        this.inteligencia = inteligencia;
        this.fuerza = fuerza;
        this.destreza = destreza;
        this.energia = energia;
    }
    public void SetNombre(string nombre) {
        this.nombre = nombre;
    }
    public void SetEdad(int edad) {
        this.edad = edad;
    }
    public void SetPeso(int peso) {
        this.peso = peso;
    }
    public void SetSexo(sexoHumano sexo) {
        this.sexo = sexo;
    }
    public void SetInteligencia(inteligenciaHumano inteligencia) {
        this.inteligencia = inteligencia;
    }
    public void SetFuerza(int fuerza) {
        this.fuerza = fuerza;
    }
    public void SetDestreza(destrezaHumano destreza) {
        this.destreza = destreza;
    }
    public void SetEnergia(int energia) {
        this.energia = energia;
    }
    public string ACadena() {
        string mensaje;
        mensaje = "----------------------------------\n" +
                    "     [Información del Humano]\n" +
                    "----------------------------------\n" +
                    $"Nombre: {nombre}\n" +
                    $"Edad: {edad}\n" +
                    $"Peso: {peso}\n" +
                    $"Sexo: {sexo}\n" +
                    $"Inteligencia: {inteligencia}\n" +
                    $"Fuerza: {fuerza}\n" +
                    $"Destreza: {destreza}\n" +
                    $"Energía: {energia}\n" +
                    "----------------------------------";
        return mensaje;
    }
}
class Program
{
    static void Main(string[] args) {
        bool activo = true;
        Humano humano = new Humano("Paco", 64, 85, sexoHumano.Masculino, inteligenciaHumano.Retrasado, 100, destrezaHumano.Media, 50);
        do {
            Console.Clear();
            System.Console.WriteLine("Introduce una opcion del menu\n" + 
                                        "  1. Cambiar informacion del humano.\n" + 
                                        "  2. Obtener información del humano.\n" +
                                        "  3. Salir del programa.\n");
            int opcion = int.Parse(Console.ReadLine());
            switch(opcion) {
                case 1:
                    Console.Clear();
                    bool correcto = false;
                    System.Console.WriteLine("----------------------------------\n" + 
                                                "  [Nueva informacion del humano]\n" + 
                                                "----------------------------------");
                    Console.Write("Nuevo nombre: ");
                    humano.SetNombre(Console.ReadLine());
                    Console.Write("Nueva edad: ");
                    humano.SetEdad(int.Parse(Console.ReadLine()));
                    Console.Write("Nuevo peso: ");
                    humano.SetPeso(int.Parse(Console.ReadLine()));
                    Console.Write("Nuevo sexo[Masculino(1), Femenino(2)]: ");
                    int sexoOpcion = int.Parse(Console.ReadLine());
                    do {
                        switch(sexoOpcion) {
                            case 1:
                                humano.SetSexo(sexoHumano.Masculino);
                                break;
                            case 2:
                                humano.SetSexo(sexoHumano.Femenino);
                                break;
                            case 3:
                                humano.SetSexo(sexoHumano.HelicopteroApache);
                                break;
                            default:
                                System.Console.WriteLine("Opcion erronea... [Presione una tecla para volver a intentarlo]");
                                Console.ReadLine();
                                break;
                        }
                        if(sexoOpcion >= 1 && sexoOpcion <= 3)
                            correcto = true;
                    }while(correcto != true);
                    correcto = false;
                    Console.Write("Nueva inteligencia[Retrasado(1), Normal(2), Inteligente(3), Superdotado(4)]: ");
                    int inteligenciaOpcion = int.Parse(Console.ReadLine());
                    do {
                        switch(inteligenciaOpcion) {
                            case 1:
                                humano.SetInteligencia(inteligenciaHumano.Retrasado);
                                break;
                            case 2:
                                humano.SetInteligencia(inteligenciaHumano.Normal);
                                break;
                            case 3:
                                humano.SetInteligencia(inteligenciaHumano.Inteligente);
                                break;
                            case 4:
                                humano.SetInteligencia(inteligenciaHumano.Superdotado);
                                break;
                            default:
                                System.Console.WriteLine("Opcion erronea... [Presione una tecla para volver a intentarlo]");
                                Console.ReadLine();
                                break;
                        }
                        if(sexoOpcion >= 1 && sexoOpcion <= 4)
                            correcto = true;
                    }while(correcto != true);
                    Console.Write("Nueva fuerza: ");
                    humano.SetFuerza(int.Parse(Console.ReadLine()));
                    Console.Write("Nueva destreza[Baja(1), Media(2), Alta(3), Excelente(4), Perfecta(5)]: ");
                    int destrezaOpcion = int.Parse(Console.ReadLine());
                    do {
                        switch(destrezaOpcion) {
                            case 1:
                                humano.SetDestreza(destrezaHumano.Baja);
                                break;
                            case 2:
                                humano.SetDestreza(destrezaHumano.Media);
                                break;
                            case 3:
                                humano.SetDestreza(destrezaHumano.Alta);
                                break;
                            case 4:
                                humano.SetDestreza(destrezaHumano.Excelente);
                                break;
                            case 5:
                                humano.SetDestreza(destrezaHumano.Perfecta);
                                break;
                            default:
                                System.Console.WriteLine("Opcion erronea... [Presione una tecla para volver a intentarlo]");
                                Console.ReadLine();
                                break;
                        }
                        if(sexoOpcion >= 1 && sexoOpcion <= 5)
                            correcto = true;
                    }while(correcto != true);
                    Console.Write("Nueva energía: ");
                    humano.SetEnergia(int.Parse(Console.ReadLine()));
                    System.Console.WriteLine("----------------------------------" + 
                                                "\n\n[Presiona una tecla para volver al menú]");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    System.Console.WriteLine(humano.ACadena());
                    System.Console.WriteLine("\n[Presiona una tecla para volver al menú]");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    System.Console.WriteLine("¡Nos vemos!       [Presiona una tecla para cerrar]");
                    Console.ReadLine();
                    activo = false;
                    break;
                default:
                    System.Console.WriteLine("\nOpcion erronea o inexistente... [Presiona una tecla para volver al selector]");
                    Console.ReadLine();
                    break;
            }
        }while(activo != false);
    }
}
*/
#endregion


#region Ejercicio4 
/*
using System.Text;
using System.Linq;
class Compas {
    public Compas() {

    }
    public Circulo DibujaCirculo(float diametro) {
        return null;
    }
}
class Circulo {
    int areaCirculo;
    public Circulo() {

    }
    public int Area() {
        return areaCirculo;
    }
}
class Rotulador {
    public Rotulador() {

    }
}
class Estuche {
    public const int NUMERO_ROTULADORES = 24;
    public Estuche() {

    }

    public Rotulador[] GetRotuladores() {
        Rotulador rotulador = new Rotulador();
        rotulador.;
        return null;
    }
}
class Pincel {
    public Pincel() {

    }
}
class Program {
    static void Main(string[] args) {
        Compas compas = new Compas();
        Circulo circulo = compas.DibujaCirculo(3.5f);
        Rotulador rotulador = Estuche.GetRotuladores()[new Random().Next(0, Estuche.NUMERO_ROTULADORES)];

        rotulador.Rotula(circulo.Perimetro());
        Pincel pincel=new Pincel();
        pincel.SetColor(Color.Verde);
        pincel.Pinta(circulo.Area());
    }
}
*/
#endregion


#region Ejercicio5 
/*
using System.Text;
using System.Linq;
public enum colorMueble{amarillo, verde, negro, azul, granate};
class Muebles {
    private colorMueble color;
    private int peso;
    private string dimensiones, mueble;
    public Muebles(string mueble, colorMueble color, int peso, string dimensiones) {
        this.mueble = mueble;
        this.color = color;
        this.peso = peso;
        this.dimensiones = dimensiones;
    }
    public void SetMueble(string mueble) {
        this.mueble = mueble;
    }
    public void SetColor(colorMueble color) {
        this.color = color;
    }
    public void SetPeso(int peso) {
        this.peso = peso;
    }
    public void SetDimensiones(string dimensiones) {
        this.dimensiones = dimensiones;
    }
    public string ACadena() {
        string mensaje;
        mensaje = "----------------------------------------\n" + 
                    "        [Información del mueble]\n" + 
                    "----------------------------------------\n" +
                    $"Tipo de mueble: {mueble}\n" +
                    $"Color del mueble: {color}\n" + 
                    $"Peso del mueble: {peso}kg\n" +
                    $"Dimensiones del mueble: {dimensiones}\n" +
                    "----------------------------------------";
        return mensaje;
    }
}
class Program
{
    static void Main(string[] args) {
        bool activo = true;
        Muebles muebles = new Muebles("sofa", colorMueble.amarillo, 12, "120x40");
        do {
            Console.Clear();
            System.Console.WriteLine("Introduce una opcion del menu\n" + 
                                        "  1. Cambiar informacion del mueble.\n" + 
                                        "  2. Obtener información del mueble.\n" +
                                        "  3. Salir del programa.\n");
            System.Console.Write("Opcion: ");
            int opcion = int.Parse(Console.ReadLine());
            switch(opcion) {
                case 1:
                    Console.Clear();
                    bool correcto = false;
                    string tipoMueble = default;
                    do {
                        System.Console.WriteLine("Tipo de mueble[Sofa(1), Silla(2), Mesa(3)]: ");
                        int tipoMuebleOpcion = int.Parse(Console.ReadLine());
                        switch(tipoMuebleOpcion) {
                            case 1:
                                tipoMueble = "Sofá";
                                correcto = true;
                                break;
                            case 2:
                                tipoMueble = "Silla";
                                correcto = true;
                                break;
                            case 3:
                                tipoMueble = "Mesa";
                                correcto = true;
                                break;
                            default:
                                System.Console.WriteLine("Opcion erronea... [Presione una tecla para volver a intentarlo]");
                                break;
                        }
                        if(tipoMuebleOpcion >= 1 && tipoMuebleOpcion <= 3)
                            correcto = true;
                    }while(correcto != true);
                    muebles.SetMueble(tipoMueble);
                    correcto = false;
                    do{
                        System.Console.WriteLine("Color del mueble[amarillo(1), verde(2), negro(3), azul(4), granate(5)]: ");
                        int colorOpcion = int.Parse(Console.ReadLine());
                        switch(colorOpcion) {
                            case 1:
                                muebles.SetColor(colorMueble.amarillo);
                                break;
                            case 2:
                                muebles.SetColor(colorMueble.verde);
                                break;
                            case 3:
                                muebles.SetColor(colorMueble.negro);
                                break;
                            case 4:
                                muebles.SetColor(colorMueble.azul);
                                break;
                            case 5:
                                muebles.SetColor(colorMueble.granate);
                                break;
                            default:
                                System.Console.WriteLine("Opcion erronea... [Presione una tecla para volver a intentarlo]");
                                Console.ReadLine();
                                break;
                        }
                        if(colorOpcion >= 1 && colorOpcion <= 5)
                            correcto = true;
                    }while(correcto != true);
                    System.Console.WriteLine("Peso del mueble(kg): ");
                    muebles.SetPeso(int.Parse(Console.ReadLine()));
                    System.Console.WriteLine("Dimensiones del mueble: ");
                    muebles.SetDimensiones(Console.ReadLine());
                    System.Console.WriteLine("\nCambio realizado con exito... [Presiona una tecla para volver al menú]");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    System.Console.WriteLine(muebles.ACadena());
                    System.Console.WriteLine("\n[Presiona una tecla para volver al menú]");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    System.Console.WriteLine("¡Nos vemos!       [Presiona una tecla para cerrar]");
                    Console.ReadLine();
                    activo = false;
                    break;
                default:
                    System.Console.WriteLine("\nOpcion erronea o inexistente... [Presiona una tecla para volver al selector]");
                    Console.ReadLine();
                    break;
            }
        } while(activo != false);
    }
}
*/
#endregion


#region Ejercicio6 
/*
using System.Text;
using System.Linq;
enum Categoria {
    Subalterno = 10, Administrativo = 20, JefeDepartamento = 40, Gerente = 60
}

class Empleado {
    private readonly string dni = default;
    private readonly string nombre = default;
    private readonly int anyNacimiento = default;
    public Categoria categoria;

    public Empleado(string dni, string nombre, int nacimiento) {
        this.dni = dni;
        this.nombre = nombre;
        this.anyNacimiento = nacimiento;
    }
    public Empleado(Empleado e) {
        this.dni = e.GetDni();
        this.nombre = e.GetNombre();
        this.anyNacimiento = e.GetAnyNacimiento();
    }
    
    public string GetNombre() {
        return nombre;
    }
    public int GetAnyNacimiento() {
        return anyNacimiento;
    }
    public string GetDni() {
        return dni;
    }
    public void SetCategoria(Categoria categoria) {
        this.categoria = categoria;
    }
    public double Salario() {
        int salarioBase = 1200;
        return salarioBase+(((double)categoria/100)*salarioBase);
    }
    public string Acadena() {
        return $"El empleado {GetNombre()} con dni: {GetDni()} tiene un salario {Salario()} y su categoria es: {categoria}";
    }
}

class Empresa {
    private readonly string cif = default;
    private readonly string razonSocial = default;
    private string direccion = default;
    private Empleado[] empleados;

    public Empresa(string cif, string razonSocial, string direccion, string dni, string nombre, int anyNacimiento) {
        this.cif = cif;
        this.razonSocial = razonSocial;
        this.direccion = direccion;
        empleados = new Empleado[1];
        AddGerente(dni, nombre, anyNacimiento);
    }
    public Empresa(Empresa e) {
        this.cif = e.cif;
        this.razonSocial = e.razonSocial;
        this.direccion = e.direccion;
        this.empleados = e.empleados;
    }

    public string NombreGerente() {
        return empleados[0].GetNombre();
    }
    public string GetRazonSocial() {
        return razonSocial;
    }
    public string GetDireccion() {
        return direccion;
    }
    public string GetCif() {
        return cif;
    }
    public void AddGerente(string dni, string nombre, int anyNaciminto) {
        empleados[0] = new Empleado(dni, nombre, anyNaciminto);
        empleados[0].SetCategoria(Categoria.Gerente);
    }
    public void SetDireccion(string direccion) {
        this.direccion = direccion;
    }
    public string DatosEmpresa() {
        return $"{cif}\n{razonSocial}\n{direccion}";
    }
    public Empleado[] GetEmpleados() {
        return empleados;
    }
    public void Contrata(string dni, string nombre, int anyNacimiento, Categoria categoria) {
        Array.Resize(ref empleados, empleados.Length + 1);
        empleados[empleados.Length - 1] = new Empleado(dni, nombre, anyNacimiento);
        empleados[empleados.Length - 1].SetCategoria(categoria);
    }
    public string Acadena() {
        string mensaje = default;
        for(int i = 0; i < empleados.Length; i++) {
            mensaje += $"{empleados[i].Acadena()}\n";
        }
        return mensaje;
    }
}

class Program {
    private static void Main(string[] args) {
        Console.Clear();
        Empresa empresa = new Empresa("La Empresa S.L", "María Soto del Rio", "Calle el Pozo, 34 Bajo", "23453456L", "María Soto del Rio", 1920);
        empresa.Contrata("14568712G", "Juanma Perez Ortiz", 1920, Categoria.Administrativo);
        empresa.Contrata("12346123K", "Pedro Martinez Sancho", 1920, Categoria.Administrativo);

        System.Console.WriteLine($"{empresa.DatosEmpresa()}\n{empresa.Acadena()}");
    }
}
*/
#endregion


#region Ejercicio7 
/*
using System.Text;
using System.Linq;
enum Palo {
    Oros, Copas, Bastos, Espada
}

class Naipe {
    public readonly int valor;
    public readonly Palo palo;

    public Naipe(int valor, Palo palo) {
        this.valor = valor;
        this.palo = palo;
    }

    public static Naipe[,] CreaBaraja() {
        Naipe[,] baraja = new Naipe[4,12];
        for(int i = 0; i < baraja.GetLength(0); i++) {
            for(int j = 0; j < baraja.GetLength(1); j++) {
                baraja[i, j] = new Naipe(j + 1, (Palo)i);
            }
        }
        return baraja;
    }
    public static void MuestraBaraja(Naipe[,] baraja) {
        int contador = default;
        foreach(Naipe naipe in baraja) {
            System.Console.WriteLine($"[{naipe.valor,2},{naipe.palo.ToString()[0]}] ");
            if(++contador % 12 == 0)
                Console.Write("\n");
        }
    }
    public static void MezclaBaraja(Naipe[,] baraja) {
        int fila, columna, filaIntercambio, columnaIntercambio;
        Naipe intercambio;
        Random seed = new Random();
        for (int i = 0; i < baraja.Length; i++) {
            fila = seed.Next(0, baraja.GetLength(0));
            columna = seed.Next(0, baraja.GetLength(1));
            intercambio = baraja[fila, columna];
            filaIntercambio = seed.Next(0, baraja.GetLength(0));
            columnaIntercambio = seed.Next(0, baraja.GetLength(1));
            baraja[fila, columna] = baraja[filaIntercambio, columnaIntercambio];
            baraja[filaIntercambio, columnaIntercambio] = intercambio;
        }
    }
    private static void Main(string[] args) {
        Console.Clear();
        Naipe[,] baraja = CreaBaraja();
        MuestraBaraja(baraja);
        MezclaBaraja(baraja);
        MuestraBaraja(baraja);
    }
}
*/
#endregion


#region Ejercicio8 
/*
using System.Text;
using System.Linq;
struct Estrella {
    public readonly Punto2D coordenadas;
    public readonly ConsoleColor color;
    public readonly char caracter;

    public Estrella(Random random) {
        coordenadas = new Punto2D(random.Next(0, Console.WindowWidth), random.Next(0, Console.WindowHeight));
        color = (ConsoleColor)random.Next(0, 12);
        caracter = '*';
    }
}

struct Punto2D {
    public readonly double x, y;
    public Punto2D(in double x, in double y) {
        this.x = x;
        this.y = y;
    }
}

class Program {
    public static Estrella[] GeneraEstrellas(int numeroEstrellas) {
        Estrella[] estrellas = new Estrella[numeroEstrellas];
        Random random = new Random();
        for(ushort i = 0; i < estrellas.Length; i++) {
            estrellas[i] = new Estrella(random);
        }
        return estrellas;
    }
    public static void MuestraEstrellas(Estrella[] estrellas) {
        Console.Clear();
        foreach(var estrella in estrellas) {
            Console.SetCursorPosition((int)estrella.coordenadas.x, (int)estrella.coordenadas.y);
            Console.ForegroundColor = estrella.color;
            Console.Write(estrella.caracter);
        }
    }
    public static void Main(string[] args) {
        Console.WriteLine($"Introduce el número de estrellas: ");
        int numeroEstrellas = int.Parse(Console.ReadLine());
        Estrella[] estrellas = GeneraEstrellas(numeroEstrellas);
        MuestraEstrellas(estrellas);
        Console.SetCursorPosition(0, Console.WindowHeight - 1);
    }
}
*/
#endregion