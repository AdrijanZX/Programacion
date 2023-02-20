#region Ejercicio1
/*
using System.Text;
using System.Linq;
class Silla : Muebles {
    public int longitudRespaldo;
    public Silla(string fabricante, colorMueble color, int peso, int precio, int ancho, int alto, int profundidad, int longitudRespaldo) 
    : base(fabricante, color, peso, precio, ancho, alto, profundidad) {
        this.longitudRespaldo = longitudRespaldo;
    } 
    public Silla(Silla s) : base(s) {
        this.longitudRespaldo = s.longitudRespaldo;
    }
    public Silla() {
        this.longitudRespaldo = 0;
    }
    public void SetLongitudRespaldo(int longitudRespaldo) {
        this.longitudRespaldo = longitudRespaldo;
    }
    public override string ACadena() {
        string mensaje = $"Longitud Respaldo: {longitudRespaldo}\n" + 
                            "----------------------------------------";
        return base.ACadena() + mensaje;
    }
}

class Mesa : Muebles {
    private string material;
    public Mesa(string fabricante, colorMueble color, int peso, int precio, int ancho, int alto, int profundidad, string material) 
    : base(fabricante, color, peso, precio, ancho, alto, profundidad) {
        this.material = material;
    } 
    public Mesa(Mesa m) : base (m) {
        this.material = m.material;
    }
    public Mesa() {
        this.material = "";
    }
    public void SetMaterial(string material) {
        this.material = material;
    }
    public override string ACadena() {
        string mensaje = $"Material: {material}\n" + 
                            "----------------------------------------";
        return base.ACadena() + mensaje ;
    }
}

class Sofa : Muebles {
    private bool abatible;
    private string tela;
    public Sofa(string fabricante, colorMueble color, int peso, int precio, int ancho, int alto, int profundidad, bool abatible, string tela) 
    : base(fabricante, color, peso, precio, ancho, alto, profundidad) {
        this.abatible = abatible;
        this.tela = tela;
        
    } 
    public Sofa(Sofa s) : base(s) {
        this.abatible = s.abatible;
        this.tela = s.tela;
    }
    public Sofa() {
        this.abatible = true;
        this.tela = "";
    }
    public void SetAbatible(bool abatible) {
        this.abatible = abatible;
    }
    public void SetTela(string tela) {
        this.tela = tela;
    }

    public override string ACadena() {
        string mensaje = $"Abatible = {abatible}\n" +
                            $"Tela = {tela}\n" + 
                            "----------------------------------------";
        return base.ACadena() + mensaje;
    }
}

public enum colorMueble{amarillo, verde, negro, azul, granate};
class Muebles {
    private colorMueble color;
    private int peso, precio;
    private string fabricante;
    public struct Dimensiones  {
        public int ancho;
        public int alto;
        public int profundidad;
    }
    public Dimensiones dimensiones;
    public Muebles() {
        this.fabricante = "";
        this.color = 0;
        this.peso = 0;
        this.precio = 0;
        this.dimensiones.ancho = 0;
        this.dimensiones.alto = 0;
        this.dimensiones.profundidad = 0;
    }
    public Muebles(string fabricante, colorMueble color, int peso, int precio, int alto, int ancho, int profundidad) {
        this.fabricante = fabricante;
        this.color = color;
        this.peso = peso;
        this.precio = precio;
        this.dimensiones.ancho = ancho;
        this.dimensiones.alto = alto;
        this.dimensiones.profundidad = profundidad;
    }
    public Muebles(Muebles m) {
        this.fabricante = m.fabricante;
        this.color = m.color;
        this.peso = m.peso;
        this.dimensiones.ancho = m.dimensiones.ancho;
        this.dimensiones.alto = m.dimensiones.alto;
        this.dimensiones.profundidad = m.dimensiones.profundidad;
    }
    public void SetFabricante(string fabricante) {
        this.fabricante = fabricante;
    }
    public string GetFabricante() {
        return this.fabricante;
    }
    public void SetColor(colorMueble color) {
        this.color = color;
    }
    public colorMueble GetColor() {
        return this.color;
    }
    public void SetPeso(int peso) {
        this.peso = peso;
    }
    public int GetPeso() {
        return this.peso;
    }
    public void SetPrecio(int precio) {
        this.precio = precio;
    }
    public int GetPrecio() {
        return this.precio;
    }
    public void SetDimensiones(int ancho, int alto, int profundidad) {
        this.dimensiones.ancho = ancho;
        this.dimensiones.alto = alto;
        this.dimensiones.profundidad = profundidad;
    }
    public int GetAncho() {
        return this.dimensiones.ancho;
    }
    public int GetAlto() {
        return this.dimensiones.alto;
    }
    public int GetProfundidad() {
        return this.dimensiones.profundidad;
    }
    public float PrecioTransporte() {
        int precioBase = 15;
        float precioTransporte = ((precioBase * GetPeso()) / 3) + (((GetAncho() * GetAlto()) + GetProfundidad()) / 3);
        return precioTransporte;
    }
    public virtual string ACadena() {
        string mensaje;
        mensaje = "----------------------------------------\n" + 
                    "        [Información del fabricante]\n" + 
                    "----------------------------------------\n" +
                    $"Tipo de fabricante: {this.fabricante}\n" +
                    $"Color del fabricante: {this.color}\n" + 
                    $"Peso del fabricante: {this.peso}kg\n" +
                    $"Precio: {this.precio}\n" +
                    $"Ancho: {this.dimensiones.ancho}\n" +
                    $"Alto: {this.dimensiones.alto}\n" +
                    $"Profundidad: {this.dimensiones.profundidad}\n" +
                    $"Precio Transporte: {PrecioTransporte()}\n";
        return mensaje;
    }
}

class Program
{
    static void Main(string[] args) {
        bool activo = true;
        int tipoMuebleOpcion = 0;
        Muebles muebles = new Muebles("IKEA", colorMueble.amarillo, 12, 0, 20, 20, 20);
        Silla silla = new Silla("CONFORT", muebles.GetColor(), muebles.GetPeso(), muebles.GetPrecio(), muebles.GetAncho(), muebles.GetAlto(), muebles.GetProfundidad(), 0);
        Mesa mesa = new Mesa("CONFORT", muebles.GetColor(), muebles.GetPeso(), muebles.GetPrecio(), muebles.GetAncho(), muebles.GetAlto(), muebles.GetProfundidad(), "");
        Sofa sofa = new Sofa("CONFORT", muebles.GetColor(), muebles.GetPeso(), muebles.GetPrecio(), muebles.GetAncho(), muebles.GetAlto(), muebles.GetProfundidad(), true, "");
        do {
            Console.Clear();
            System.Console.WriteLine("Introduce una opcion del menu\n" + 
                                        "  1. Cambiar informacion del fabricante.\n" + 
                                        "  2. Obtener información del fabricante.\n" +
                                        "  3. Salir del programa.\n");
            System.Console.Write("Opcion: ");
            int opcion = int.Parse(Console.ReadLine());
            switch(opcion) {
                case 1:
                    Console.Clear();
                    bool correcto = false;
                    System.Console.Write("Fabricante: ");
                    string fabricanteMueble = Console.ReadLine();
                    muebles.SetFabricante(fabricanteMueble);
                    correcto = false;
                    System.Console.Write("Tipo Mueble[Mesa(1), Silla(2), Sofa(3)]:");
                    tipoMuebleOpcion = int.Parse(Console.ReadLine());
                    switch(tipoMuebleOpcion) {
                        case 1:
                            System.Console.Write("Introduce el material de la mesa: ");
                            mesa.SetMaterial(Console.ReadLine());
                            break;
                        case 2:
                            System.Console.Write("Introduce la longitud del respaldo: ");
                            silla.SetLongitudRespaldo(int.Parse(Console.ReadLine()));
                            break;
                        case 3:
                            System.Console.Write("Introduce si es abatible o no(Y/N): ");
                            string abatibleOpcion = Console.ReadLine();
                            if(abatibleOpcion == "Y")
                                sofa.SetAbatible(true);
                            else if(abatibleOpcion == "N")
                                sofa.SetAbatible(false);
                            System.Console.Write("Introduce la tela del sofa: ");
                            sofa.SetTela(Console.ReadLine());
                            break;
                    }
                    do{
                        System.Console.Write("Color del fabricante[amarillo(1), verde(2), negro(3), azul(4), granate(5)]: ");
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
                    System.Console.Write("Precio producto(€): ");
                    muebles.SetPrecio(int.Parse(Console.ReadLine()));
                    System.Console.Write("Peso del fabricante(kg): ");
                    muebles.SetPeso(int.Parse(Console.ReadLine()));
                    System.Console.WriteLine("Dimensiones del fabricante(Ancho, Alto, Profundidad): ");
                    muebles.SetDimensiones(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

                    System.Console.WriteLine("\nCambio realizado con exito... [Presiona una tecla para volver al menú]");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    if(tipoMuebleOpcion == 0)
                        System.Console.WriteLine("Aun no hay muebles seleccionados...");
                    else if(tipoMuebleOpcion == 1)
                        System.Console.WriteLine(new Mesa(mesa).ACadena());
                    else if(tipoMuebleOpcion == 2)
                        System.Console.WriteLine(new Silla(silla).ACadena());
                    else if(tipoMuebleOpcion == 3)
                        System.Console.WriteLine(new Sofa(sofa).ACadena());
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


#region Ejercicio2
/*
using System.Text;
using System.Linq;
class Local {
    private string ciudad, calle;
    private int num_plants;
    private Dimensiones dim;
    private struct Dimensiones {
            public int alto;
            public int ancho;
            public int profundidad;
    }

    public Local(string ciudad, string calle, int num_plants, int alto, int ancho, int profundidad) {
        this.ciudad = ciudad;
        this.calle = calle;
        this.num_plants = num_plants;
        this.dim.alto = alto;
        this.dim.ancho = ancho;
        this.dim.profundidad = profundidad;
    }

    public int GetNumeroPlantas(int num_plants) {
        return num_plants;
    }

    public string ACadena() {
        string mensaje = $"Ciudad: {ciudad}\nCalle: {calle}\nNumero de plantas: {num_plants}\nDimensiones: {dim.alto}x{dim.ancho}x{dim.profundidad}";
        return mensaje;
    }
}

class LocalComercial : Local {
    private string razon_social;
    private int num_licencia;

    public LocalComercial(string ciudad, string calle, int num_plants, int alto, int ancho, int profundidad, string razon_social, int num_licencia)
        : base(ciudad, calle, num_plants, alto, ancho, profundidad) {
            this.razon_social = razon_social;
            this.num_licencia = num_licencia;
    }

    public string ACadena() {
        string mensaje = $"{base.ACadena()}\n" + $"Razon Social: {razon_social}\nNumero de licencia: {num_licencia}";
        return mensaje;
    }
}

class Cine : LocalComercial {
    private int aforo_sala;

    public Cine(string ciudad, string calle, int num_plants, int alto, int ancho, int profundidad, string razon_social, int num_licencia, int aforo_sala)
         : base(ciudad, calle, num_plants, alto, ancho, profundidad, razon_social, num_licencia) {
            this.aforo_sala = aforo_sala;
    }

    public string ACadena() {
        string mensaje = $"{base.ACadena()}\n" + $"Aforo sala: {aforo_sala}";  
        return mensaje;
    }
}

class Program {
    private static void Main(string[] args) {
        Console.Clear();
        Cine[] cine = new Cine[3];
        cine[0] = new Cine("Alicante", "Poeta Miguel Hernández, 18", 3, 10, 20, 30, "Maqueabélico", int.Parse("12345678"), 1000);
        cine[1] = new Cine("Barcelona", "El espanyol lider, 10", 5, 30, 50, 130, "Cines Agarraos", int.Parse("87654321"), 5000);
        cine[2] = new Cine("Valencia", "La mare que em va parir, 64", 2, 40, 45, 24, "Un dos tres", int.Parse("55789648"), 1000);

        for(int i = 0; i < cine.Length; i++) {
            System.Console.WriteLine($"{cine[i].ACadena()}\n");
        }
    } 
}
*/
#endregion


#region Ejercicio3
/*
using System.Text;
using System.Linq;
class ElNoCalculador {
    protected short numero;

    public ElNoCalculador(short numero) {
        this.numero = numero;
    }

    public virtual double Factorial() {
        return 0;
    }

    public virtual bool Primo() {
        return false;
    }
}

class ElCalculador : ElNoCalculador {
    
    public ElCalculador(short numero) : base(numero) {}

    public override double Factorial() {
            int factorial = 1;

                for (int i = numero; i > 0; i--) {
                    factorial = factorial * i;
                }
            return factorial;
    }

    public override bool Primo() {
        int contador = 2;
        bool primo = true;

        while (primo && (contador != numero)) {
            if (numero % contador == 0)
                primo = false;
            contador++;
        }

        if (primo) return true;
        else return false;
    }
}

class Program {
    private static void Main(string[] args) {
        Console.Write("Introduzca valor: ");
        short numero = short.Parse(Console.ReadLine());
        ElNoCalculador obj = new ElCalculador(numero);
        System.Console.WriteLine($"Factorial: {obj.Factorial()}\nPrimo: {obj.Primo()}");
    }
}
*/
#endregion


#region Ejercicio4
/*
using System.Text;
using System.Linq;
public enum tipoLibroHechizos{Fuego, Agua, Hielo, Tierra, Metal, Luz};
public enum tipoTunica{Roja, Negra, Azul, Blanca, Morada, Dorada};
class Mago:Humano {
    private tipoLibroHechizos libroHechizos;
    private tipoTunica tunica;
    public Mago(string nombre, int edad, int peso, sexoHumano sexo, 
                inteligenciaHumano inteligencia, int fuerza, destrezaHumano destreza, int energia, faccionHumano faccion, tipoLibroHechizos libroHechizos, tipoTunica tunica)
                : base(nombre, edad, peso, sexo, inteligencia, fuerza, destreza, energia, faccion) {
        this.libroHechizos = libroHechizos;
        this.tunica = tunica;
    }

    public void SetLibroHechizos(tipoLibroHechizos libroHechizos) {
        this.libroHechizos = libroHechizos;
    }
    public void SetTunica(tipoTunica tunica) {
        this.tunica = tunica;
    }
    public string ACadenaM() {
        string mensaje = "        [Magia del humano]\n" +
                            "----------------------------------\n" +
                            $"Libro de Hechizos: {libroHechizos}\n" +
                            $"Tunica: {tunica}\n" +
                        "----------------------------------";
        return mensaje;
    }
            
}
public enum tipoArma{Espada, Arco, Hacha, AK47, Panther};
public enum tipoArmadura{Cuero, Hierro, Oro, Diamante, Netherite, Esmeralda};
class Guerrero:Humano {
    private tipoArma arma;
    private tipoArmadura armadura;
    public Guerrero(string nombre, int edad, int peso, sexoHumano sexo, 
                    inteligenciaHumano inteligencia, int fuerza, destrezaHumano destreza, int energia, faccionHumano faccion, tipoArma arma, tipoArmadura armadura)
                    : base(nombre, edad, peso, sexo, inteligencia, fuerza, destreza, energia, faccion) {
        this.arma = arma;
        this.armadura = armadura;
    }
    public void SetTipoArma(tipoArma arma) {
        this.arma = arma;
    }
    public void SetTipoArmadura(tipoArmadura armadura) {
        this.armadura = armadura;

    }
    public string ACadenaG() {
        string mensaje = "        [Armas del humano]\n" +
                            "----------------------------------\n" +
                            $"Arma: {arma}\n" +
                            $"Armadura: {armadura}\n" +
                        "----------------------------------";
        return mensaje;
    }
}
public enum faccionHumano {Mago, Guerrero};
public enum sexoHumano {Masculino, Femenino, HelicopteroApache};
public enum inteligenciaHumano {Retrasado, Normal, Inteligente, Superdotado};
public enum destrezaHumano {Baja, Media, Alta, Excelente, Perfecta};
class Humano {
    private sexoHumano sexo;
    private inteligenciaHumano inteligencia;
    private destrezaHumano destreza;
    private faccionHumano faccion;
    private string nombre;
    private int edad, peso, fuerza, energia;
    public Guerrero guerrero;
    public Humano(string nombre, int edad, int peso, sexoHumano sexo, inteligenciaHumano inteligencia, int fuerza, destrezaHumano destreza, int energia, faccionHumano faccion) {
        this.nombre = nombre;
        this.peso = peso;
        this.edad = edad;
        this.sexo = sexo;
        this.inteligencia = inteligencia;
        this.fuerza = fuerza;
        this.destreza = destreza;
        this.energia = energia;
        this.faccion = faccion;
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
    public void SetFaccion(faccionHumano faccion) {
        this.faccion = faccion;
    }
    public void SetDestreza(destrezaHumano destreza) {
        this.destreza = destreza;
    }
    public void SetEnergia(int energia) {
        this.energia = energia;
    }
    public faccionHumano GetFaccionHumano() {
        return faccion;
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
                    $"Facción: {faccion}\n" +
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
        Humano humano = new Humano("Paco", 64, 85, sexoHumano.Masculino, inteligenciaHumano.Retrasado, 100, destrezaHumano.Media, 50, faccionHumano.Guerrero);
        Guerrero guerrero = new Guerrero("Paco", 64, 85, sexoHumano.Masculino, inteligenciaHumano.Retrasado, 100, destrezaHumano.Media, 50, faccionHumano.Guerrero, tipoArma.Espada, tipoArmadura.Cuero);
        Mago mago = new Mago("Paco", 64, 85, sexoHumano.Masculino, inteligenciaHumano.Retrasado, 100, destrezaHumano.Media, 50, faccionHumano.Guerrero, tipoLibroHechizos.Fuego, tipoTunica.Azul);
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
                    Console.Write("Nuevo sexo[Masculino(1), Femenino(2), HelicopteroHapache(3)]: ");
                    int sexoOpcion = int.Parse(Console.ReadLine());
                    do {
                        switch(sexoOpcion) {
                            case 1: humano.SetSexo(sexoHumano.Masculino);
                                break;
                            case 2: humano.SetSexo(sexoHumano.Femenino);
                                break;
                            case 3: humano.SetSexo(sexoHumano.HelicopteroApache);
                                break;
                            default: System.Console.WriteLine("Opcion erronea... [Presione una tecla para volver a intentarlo]");
                                Console.ReadLine();
                                break;
                        }
                        if(sexoOpcion >= 1 && sexoOpcion <= 3)
                            correcto = true;
                    }while(correcto != true);
                    do {
                        correcto = false;
                        Console.Write("Nueva inteligencia[Retrasado(1), Normal(2), Inteligente(3), Superdotado(4)]: ");
                        int inteligenciaOpcion = int.Parse(Console.ReadLine());
                        switch(inteligenciaOpcion) {
                            case 1: humano.SetInteligencia(inteligenciaHumano.Retrasado);
                                break;
                            case 2: humano.SetInteligencia(inteligenciaHumano.Normal);
                                break;
                            case 3: humano.SetInteligencia(inteligenciaHumano.Inteligente);
                                break;
                            case 4: humano.SetInteligencia(inteligenciaHumano.Superdotado);
                                break;
                            default: System.Console.WriteLine("Opcion erronea... [Presione una tecla para volver a intentarlo]");
                                Console.ReadLine();
                                break;
                        }
                        if(sexoOpcion >= 1 && sexoOpcion <= 4)
                            correcto = true;
                    }while(correcto != true);
                    do {
                        correcto = false;
                        Console.Write("Nueva faccion[Guerrero(1), Mago(2)]: ");
                        int faccionOpcion = int.Parse(Console.ReadLine());
                        switch(faccionOpcion) {
                            case 1: humano.SetFaccion(faccionHumano.Guerrero);
                                Console.Write("Introduce el tipo de arma[Espada(1), Arco(2), Hacha(3), AK47(4), Panther(5)]: ");
                                int armaOpcion = int.Parse(Console.ReadLine());
                                switch(armaOpcion) {
                                    case 1: guerrero.SetTipoArma(tipoArma.Espada);
                                        break;
                                    case 2: guerrero.SetTipoArma(tipoArma.Arco);
                                        break;
                                    case 3: guerrero.SetTipoArma(tipoArma.Hacha);
                                        break;
                                    case 4: guerrero.SetTipoArma(tipoArma.AK47);
                                        break;
                                    case 5: guerrero.SetTipoArma(tipoArma.Panther);
                                        break;
                                }
                                Console.Write("Introduce el tipo de armadura[Cuero(1), Hierro(2), Oro(3), Diamante(4), Netherite(5), Esmeralda(6)]: ");
                                int armaduraOpcion = int.Parse(Console.ReadLine());
                                switch(armaduraOpcion) {
                                    case 1: guerrero.SetTipoArmadura(tipoArmadura.Cuero);
                                        break;
                                    case 2: guerrero.SetTipoArmadura(tipoArmadura.Hierro);
                                        break;
                                    case 3: guerrero.SetTipoArmadura(tipoArmadura.Oro);
                                        break;
                                    case 4: guerrero.SetTipoArmadura(tipoArmadura.Diamante);
                                        break;
                                    case 5: guerrero.SetTipoArmadura(tipoArmadura.Netherite);
                                        break;
                                    case 6: guerrero.SetTipoArmadura(tipoArmadura.Esmeralda);
                                        break;
                                }
                                break;
                            case 2: humano.SetFaccion(faccionHumano.Mago);
                                System.Console.Write("Introduce el libro de hechizos[Fuego(1), Agua(2), Hielo(3), Tierra(4), Metal(5), Luz(6)]");
                                int libroHechizosOpcion = int.Parse(Console.ReadLine());
                                switch(libroHechizosOpcion) {
                                    case 1: mago.SetLibroHechizos(tipoLibroHechizos.Fuego);
                                        break;
                                    case 2: mago.SetLibroHechizos(tipoLibroHechizos.Agua);
                                        break;
                                    case 3: mago.SetLibroHechizos(tipoLibroHechizos.Hielo);
                                        break;
                                    case 4: mago.SetLibroHechizos(tipoLibroHechizos.Tierra);
                                        break;
                                    case 5: mago.SetLibroHechizos(tipoLibroHechizos.Metal);
                                        break;
                                    case 6: mago.SetLibroHechizos(tipoLibroHechizos.Luz);
                                        break;
                                }
                                System.Console.Write("Introduce la túnica[Roja(1), Negra(2), Azul(3), Blanca(4), Morada(5), Dorada(6)]");
                                int tunicaOpcion = int.Parse(Console.ReadLine());
                                switch(tunicaOpcion) {
                                    case 1: mago.SetTunica(tipoTunica.Roja);
                                        break;
                                    case 2: mago.SetTunica(tipoTunica.Negra);
                                        break;
                                    case 3: mago.SetTunica(tipoTunica.Azul);
                                        break;
                                    case 4: mago.SetTunica(tipoTunica.Blanca);
                                        break;
                                    case 5: mago.SetTunica(tipoTunica.Morada);
                                        break;
                                    case 6: mago.SetTunica(tipoTunica.Dorada);
                                        break;
                                }
                                break;
                        }
                        correcto = true;
                    } while(correcto != true);
                    Console.Write("Nueva fuerza: ");
                    humano.SetFuerza(int.Parse(Console.ReadLine()));
                    do {
                        Console.Write("Nueva destreza[Baja(1), Media(2), Alta(3), Excelente(4), Perfecta(5)]: ");
                        int destrezaOpcion = int.Parse(Console.ReadLine());
                        switch(destrezaOpcion) {
                            case 1: humano.SetDestreza(destrezaHumano.Baja);
                                break;
                            case 2: humano.SetDestreza(destrezaHumano.Media);
                                break;
                            case 3: humano.SetDestreza(destrezaHumano.Alta);
                                break;
                            case 4: humano.SetDestreza(destrezaHumano.Excelente);
                                break;
                            case 5: humano.SetDestreza(destrezaHumano.Perfecta);
                                break;
                            default: System.Console.WriteLine("Opcion erronea... [Presione una tecla para volver a intentarlo]");
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
                case 2: Console.Clear();
                    System.Console.WriteLine(humano.ACadena());
                    if(humano.GetFaccionHumano() == faccionHumano.Guerrero) {
                        System.Console.WriteLine(guerrero.ACadenaG());
                    } else if(humano.GetFaccionHumano() == faccionHumano.Mago){
                        System.Console.WriteLine(mago.ACadenaM());
                    }
                    System.Console.WriteLine("\n[Presiona una tecla para volver al menú]");
                    Console.ReadLine();
                    break;
                case 3: Console.Clear();
                    System.Console.WriteLine("¡Nos vemos!       [Presiona una tecla para cerrar]");
                    Console.ReadLine();
                    activo = false;
                    break;
                default: System.Console.WriteLine("\nOpcion erronea o inexistente... [Presiona una tecla para volver al selector]");
                    Console.ReadLine();
                    break;
            }
        }while(activo != false);
    }
}
*/
#endregion


#region Ejercicio5
/*
using System.Text;
using System.Linq;
class Persona {
    private string nombre;
    private ushort edad;
    private string nif;

    public Persona(string nombre, ushort edad, string nif) {
        this.nombre = nombre;
        this.edad = edad;
        this.nif = nif;
    }

    public virtual string GetDatos() {
        return
        $"Nombre = {nombre}\n" +
        $"Edad = {edad}\n" +
        $"NIF = {nif}";
    }
}

abstract class Legislador : Persona {
    private string provinciaQueRepresenta;

    public Legislador(string nombre, ushort edad, string nif, string provinciaQueRepresenta) : base(nombre, edad, nif) {
        this.provinciaQueRepresenta = provinciaQueRepresenta;
    }

    public abstract string GetCamaraEnQueTrabaja();

    public override string GetDatos() {
        string texto = base.GetDatos();
        texto +=
        $"\nProvincia = {provinciaQueRepresenta}\n" +
        $"Camara = {GetCamaraEnQueTrabaja()}\n";

        return texto;
    }
}

class Diputado : Legislador {
    public Diputado(string nombre, ushort edad, string nif, string provinciaQueRepresenta) : base(nombre, edad, nif, provinciaQueRepresenta) {
        ;
    }

    public override string GetCamaraEnQueTrabaja() {
        return "Congreso de los diputados";
    }
}

class Senador : Legislador {
    public Senador(string nombre, ushort edad, string nif, string provinciaQueRepresenta) : base(nombre, edad, nif, provinciaQueRepresenta) {
        ;
    }

    public override string GetCamaraEnQueTrabaja() {
        return "Senado";
    }
}

class Program {
    static void Main() {
        Legislador[] legisladores = {
            new Diputado("Adrian", 20, "48771692P", "Alicante"),
            new Senador("Paco", 37, "88776635M", "Valencia")
        };

        foreach (Legislador legislador in legisladores) {
            Console.WriteLine(legislador.GetDatos());
        }
    }
}
*/
#endregion


#region Ejercicio6
/*
using System.Text;
using System.Linq;
abstract class TablaEnteros {
    protected int[] Tabla;
    public TablaEnteros() {}
    public TablaEnteros(int tamaño) {
        Tabla = new int[tamaño];
    }
    public virtual void MostrarTabla() { /*virtual??*/
        for(int i = 0; i < Tabla.Length; i++) {
            System.Console.Write(Tabla[i] + " ");
        }
    }
    public int SumaPropia() {
        int positivos = 0;
        int negativos = 0;
        int sumaPositivos = 0;
        int sumaNegativos = 0;

        for(int i = 0; i < Tabla.Length; i++) {
            if(Tabla[i] < 0) {
                negativos++;
                sumaNegativos += Tabla[i];
            }
            else if(Tabla[i] > 0) {
                positivos++;
                sumaPositivos += Tabla[i];
            }                
        }

        if(positivos > negativos){
            return  sumaPositivos;
        } else {
            return sumaNegativos;
        }
    }
    public abstract void GuardarNumerosEnTabla();
}
class TablaImpares : TablaEnteros {
    public TablaImpares(int tamaño):base(tamaño) {}
    public override void GuardarNumerosEnTabla() {
        int numero;
        for (int i = 0; i < Tabla.Length; i++) {
            Console.Write("\nIntroduzca valor: ");
            numero=int.Parse(Console.ReadLine());
            if(numero %2 != 0) {
                Tabla[i] = numero;
                i++;
            }
        }
    }
}

class TablaPares : TablaEnteros {
    public TablaPares(int tamaño):base(tamaño) {}
    public override void GuardarNumerosEnTabla() {
        int numero;
        for (int i = 0; i < Tabla.Length;){
            Console.Write("\nIntroduzca valor: ");
            numero=int.Parse(Console.ReadLine());
            if(numero %2 == 0) {
                Tabla[i] = numero;
                i++;
            }
        }
    }
}
class Program {
    static void Main(string[] args) {
        TablaEnteros impares = new TablaImpares(5);
        impares.GuardarNumerosEnTabla();
        Console.WriteLine("La tabla de Impares es: ");
        impares.MostrarTabla();
        Console.WriteLine("La suma propia de los números es {0}", impares.SumaPropia());

        TablaEnteros pares = new TablaPares(5);
        pares.GuardarNumerosEnTabla();
            Console.WriteLine("La tabla de Pares es: ");
        pares.MostrarTabla();
        Console.WriteLine("La suma propia de los números es {0}", pares.SumaPropia());
    }
}
*/
#endregion
