#region Ejercicio1
/*
class Program {
    private static void Main(string[] args) {
        List<int> l1 = new List<int>();
        List<int> l2 = new List<int>();
        List<int> l3 = new List<int>();

        for (int i = 1; i < 11; i++) {
            l1.Add(i);
            l2.Add(i);
        }

        l1 = BorraEnteros(l1, 8);
        l3 = Mezcla(l1, l2);

        foreach(int num in l3) {
            System.Console.WriteLine(num);
        }

        List<string> lp = new List<string>();

        lp.Add("Alejandro");
        lp.Add("Paco");
        lp.Add("Nicolas");
        lp.Add("Jose");
        lp.Add("Francisco");
        lp.Add("Miguel");

        ImprimeInverso(lp, 3);

        List<string> lc = new List<string>();

        lc.Add("Corona");
        lc.Add("Arbol");
        lc.Add("Cielo");
        lc.Add("Mina");
        lc.Add("Barco");
        lc.Add("Oficina");

        lc = OrdenaCadena(lc);
        
        foreach(string palabras in lc) {
            System.Console.WriteLine(palabras);
        }
    }
    public static List<string> OrdenaCadena(List<string> lc) {
        List<string> lcAux = lc;
        lcAux.Sort();
        return lcAux;
    }
    public static void ImprimeInverso(List<string> lp, int pos) {
        List<string> lpAux = Enumerable.Reverse(lp).ToList();
        int posAux = 0;
        foreach(string persona in lpAux) {
            if(posAux >= pos)
                System.Console.WriteLine(lpAux[posAux].ToString());
            posAux++;
        }
    }
    public static List<int> Mezcla(List<int> l1, List<int> l2) {
        if(l1 == null)
            return l2;
        if(l2 == null) 
            return l1;
        List<int> listAux = l1.Concat(l2).ToList();;
        listAux.Sort();
        return listAux;
    }
    public static List<int> BorraEnteros(List<int> list, int i) {
        List<int> listAux = list;
        listAux.Remove(i);
        return listAux;
    }
}
*/
#endregion


#region Ejercicio2
/*
class Automovil {
    public string marca { get; }
    public string modelo { get; }
    public int cv { get; }
    public string añoFabricacion { get; }
    public string color { get; }

    public Automovil(string marca, string modelo, string añoFabricacion, string color, int cv) {
        this.marca = marca;
        this.modelo = modelo;
        this.añoFabricacion = añoFabricacion;
        this.color = color;
        this.cv = cv;
    }

    public override string ToString() => $"{marca} - {modelo} [{cv}cv] // {añoFabricacion} // {color}";
}

class Program {
    private static void Main(string[] args) {
        var automoviles = new List<Automovil>();
        var lAutoAño = new List<Automovil>();
        var lAutoAñoYColor = new List<Automovil>();

        automoviles.Add(new Automovil("Honda", "Civic", "1998", "black", 180));
        automoviles.Add(new Automovil("Honda", "Coupe", "1995", "red", 200));
        automoviles.Add(new Automovil("Honda", "Jazz", "2020", "white", 114));
        automoviles.Add(new Automovil("VolksWagen", "Golf", "2010", "dark-blue", 140));
        automoviles.Add(new Automovil("VolksWagen", "Polo", "2005", "red", 125));
        automoviles.Add(new Automovil("VolksWagen", "Sirocco", "2020", "white", 240));
        automoviles.Add(new Automovil("Ford", "Mustang GT", "1998", "black", 450));
        automoviles.Add(new Automovil("Ford", "GT40", "1969", "white-blue", 345));
        automoviles.Add(new Automovil("Ford", "Fiesta Freestyle", "1998", "grey", 73));
        automoviles.Add(new Automovil("BMW", "M3", "2002", "grey", 275));
        automoviles.Add(new Automovil("BMW", "X5", "2022", "dark-blue", 179));
        automoviles.Add(new Automovil("BMW", "XM", "2022", "dark-blue", 156));

        automoviles = AñadeAutomovil(automoviles);
        automoviles = EliminaAutomovil(automoviles, 3);
        lAutoAño = AutomovilesPorAñoFabricacion(automoviles, "1998");
        lAutoAñoYColor = AutomovilesPorAñoFabricacionYColor(automoviles, "1998", "black");

        System.Console.WriteLine($"\nAutomoviles: ");
        foreach(var automovil in automoviles) {
            System.Console.WriteLine(automovil);
        }

        System.Console.WriteLine($"\nAutomovil por año: ");
        foreach(var automovil in lAutoAño) {
            System.Console.WriteLine(automovil);
        }

        System.Console.WriteLine($"\nAutomovil por año y color: ");
        foreach(var automovil in lAutoAñoYColor) {
            System.Console.WriteLine(automovil);
        }
    }
    public static List<Automovil> AutomovilesPorAñoFabricacionYColor(List<Automovil> lAutomovil, string año, string color) {
        List<Automovil> listAux = new List<Automovil>();
        foreach(var automovil in lAutomovil) {
            if(automovil.añoFabricacion == año && automovil.color == color) {
                listAux.Add(new Automovil(automovil.marca, automovil.modelo, automovil.añoFabricacion, automovil.color, automovil.cv));
            }
        }
        return listAux;
    }
    public static List<Automovil> AutomovilesPorAñoFabricacion(List<Automovil> lAutomovil, string año) {
        List<Automovil> listAux = new List<Automovil>();
        foreach(var automovil in lAutomovil) {
            if(automovil.añoFabricacion == año) {
                listAux.Add(new Automovil(automovil.marca, automovil.modelo, automovil.añoFabricacion, automovil.color, automovil.cv));
            }
        }
        return listAux;
    }
    public static List<Automovil> EliminaAutomovil(List<Automovil> lAutomovil, int i) {
        List<Automovil> listAux = lAutomovil;
        listAux.RemoveAt(i);
        return listAux;
    }
    public static List<Automovil> AñadeAutomovil(List<Automovil> lAutomoviles) {
        List<Automovil> listAux = lAutomoviles;

        System.Console.Write("Introduce marca: ");
        string marca = Console.ReadLine();
        System.Console.Write("Introduce modelo: ");
        string modelo = Console.ReadLine();
        System.Console.Write("Introduce año de fabricacion: ");
        string añoFabricacion = Console.ReadLine();
        System.Console.Write("Introduce cv's: ");
        int cv = int.Parse(Console.ReadLine());
        System.Console.Write("Introduce color: ");
        string color = Console.ReadLine();

        listAux.Add(new Automovil(marca, modelo, añoFabricacion, color, cv));

        return listAux;
    }
    public static void ImprimeInverso(List<string> lp, int pos) {
        List<string> lpAux = Enumerable.Reverse(lp).ToList();
        int posAux = 0;
        foreach(string persona in lpAux) {
            if(posAux >= pos)
                System.Console.WriteLine(lpAux[posAux].ToString());
            posAux++;
        }
    }
    public static List<int> Mezcla(List<int> l1, List<int> l2) {
        if(l1 == null)
            return l2;
        if(l2 == null) 
            return l1;
        List<int> listAux = l1.Concat(l2).ToList();;
        listAux.Sort();
        return listAux;
    }
}
*/
#endregion


#region Ejercicio3
/*
class Program {
    private static void Main(string[] args) {
        Dictionary<string, int> nombres = new Dictionary<string, int>();
        System.Console.WriteLine("Introduce un nombre: ");
        string nombre = Console.ReadLine();
        while(nombre != "fin") {
            if(!nombres.ContainsKey(nombre)) 
                nombres[nombre] = 0;
            nombres[nombre]++;
            nombre = Console.ReadLine();
        }
        System.Console.WriteLine("Nombres introducidos: ");
        foreach(string key in nombres.Keys) {
            System.Console.WriteLine($"{key}: {nombres[key]} veces");
        }
    }
}
*/
#endregion


#region Ejercicio4
/*
class Polinomio {
    private SortedDictionary<int, int> Monomios { get; set; }

    public Polinomio(string polinomio) {
        Monomios = new SortedDictionary<int, int>();

        // Verificar el formato de la entrada
        if (!Regex.IsMatch(polinomio, @"^([+-]?\d*x\d*)+([+-]\d+)?$")) {
            throw new FormatException("Formato de entrada inválido");
        }

        // Parsear la cadena de entrada
        string[] terminos = polinomio.Split('+', '-');

        foreach (string termino in terminos) {
            string[] monomio = termino.Split('x');
            int coeficiente, exponente;

            if (monomio.Length == 1) { // término constante
                coeficiente = int.Parse(monomio[0]);
                exponente = 0;
            } else { // término con exponente
                coeficiente = monomio[0] == "" ? 1 : int.Parse(monomio[0]);
                exponente = int.Parse(monomio[1]);
            }

            if (termino[0] == '-') {
                coeficiente = -coeficiente;
            }

            if (Monomios.ContainsKey(exponente)) {
                Monomios[exponente] += coeficiente;
            } else {
                Monomios.Add(exponente, coeficiente);
            }
        }
    }
    public static Polinomio Suma(Polinomio pol1, Polinomio pol2) {
        SortedDictionary<int, int> monomios = new SortedDictionary<int, int>();
        foreach (int exponente in pol1.Monomios.Keys.Concat(pol2.Monomios.Keys).Distinct()) {
            int coeficiente = 0;
            if (pol1.Monomios.ContainsKey(exponente)) {
                coeficiente += pol1.Monomios[exponente];
            }
            if (pol2.Monomios.ContainsKey(exponente)) {
                coeficiente += pol2.Monomios[exponente];
            }
            if (coeficiente != 0) {
                monomios[exponente] = coeficiente;
            }
        }
        Polinomio resultado = new Polinomio("");
        resultado.Monomios = monomios;
        return resultado;
    }

    public override string ToString() {
        string polinomioString = "";
        foreach (var monomio in Monomios.Reverse()) {
            int exp = monomio.Key;
            int coef = monomio.Value;

            // Agregar el signo + si el coeficiente es positivo y no es el primer monomio
            if (coef > 0 && polinomioString.Length > 0)
                polinomioString += "+";

            // Agregar el coeficiente solo si es diferente de 1 o si el exponente es 0
            if (coef != 1 || exp == 0)
                polinomioString += coef.ToString();

            // Agregar la variable x si el exponente es mayor o igual a 1
            if (exp >= 1)
                polinomioString += "x";

            // Agregar el exponente solo si es mayor o igual a 2
            if (exp >= 2)
                polinomioString += "^" + exp.ToString();
        }
        return polinomioString;
    }
}
class Program {
    static void Main() {
        Polinomio p1 = new Polinomio("9x7-3x3-7x+5");
        Console.WriteLine("p1 = " + p1);

        Polinomio p2 = new Polinomio("4x2-1");
        Console.WriteLine("p2 = " + p2);

        Polinomio suma = Polinomio.Suma(p1, p2);
        Console.WriteLine("suma = " + suma);

        Console.ReadLine();
    }
}
*/
#endregion


#region Ejercicio5
/*
class DatosContacto {
    public string DNI { get; }
    public string nombreCompleto { get; }
    public string direccionCompleta { get; }
    public string telefono { get; }

    public DatosContacto(string DNI, string nombreCompleto, string direccionCompleta, string telefono) {
        this.DNI = DNI;
        this.nombreCompleto = nombreCompleto;
        this.direccionCompleta = direccionCompleta;
        this.telefono = telefono;
    }

    public override string ToString() => $"{nombreCompleto}\n{direccionCompleta}\n{telefono}";
}

class Program {
    private static void Main(string[] args) {
        Dictionary<string, DatosContacto> agendaContactos = new Dictionary<string, DatosContacto>();
        agendaContactos.Add("12345678X", new DatosContacto("12345678X", "Nombre Falso", "Direccion Falsa", "123456789"));
        DatosContacto contactoFalso = new DatosContacto("67538965K", "Paco Secreto Falso", "Calle Falsa 123", "765789543");

        agendaContactos = CreaContactos(agendaContactos);
        agendaContactos = BorraContacto(agendaContactos, "12345678X");
        agendaContactos = AñadeContacto(agendaContactos, contactoFalso);
        MuestraAgenda(agendaContactos);
    }
    private static void MuestraAgenda(Dictionary<string, DatosContacto> agendaContactos) {
        foreach(string key in agendaContactos.Keys) {
            System.Console.WriteLine($"{key}: {agendaContactos[key]}\n");
        }
    }
    private static Dictionary<string, DatosContacto> AñadeContacto(Dictionary<string, DatosContacto> agendaContactos, DatosContacto dc) {
        Dictionary<string, DatosContacto> agendaContactosAux = agendaContactos;
        agendaContactosAux.Add(dc.DNI, dc);
        return agendaContactosAux;
    }
    private static Dictionary<string, DatosContacto> BorraContacto(Dictionary<string, DatosContacto> agendaContactos, string DNI) {
        Dictionary<string, DatosContacto> agendaContactosAux = agendaContactos;
        agendaContactosAux.Remove(DNI);
        return agendaContactosAux;
    }
    private static Dictionary<string, DatosContacto> CreaContactos(Dictionary<string, DatosContacto> agendaContactos) {
        Dictionary<string, DatosContacto> agendaContactosAux = agendaContactos;
        bool activo = true, activoBucle = true;
        do {
            System.Console.WriteLine("Introduce DNI: ");
            string DNI = Console.ReadLine();
            foreach(string key in agendaContactosAux.Keys) {
                if(DNI == key) {
                    activo = false;
                    activoBucle = false;
                    break;
                }
                if(DNI == "") {
                    activo = false;
                    activoBucle = false;
                    break;
                }
            }
            if(activo == true) {
                System.Console.Write("Introduce nombre completo: ");
                string nombreCompleto = Console.ReadLine();
                System.Console.Write("Introduce direccion completa: ");
                string direccionCompleta = Console.ReadLine();
                System.Console.Write("Introduce telefono: ");
                string telefono = Console.ReadLine();

                agendaContactosAux.Add(DNI, new DatosContacto(DNI, nombreCompleto, direccionCompleta, telefono));
            }
        } while(activoBucle != false);
        return agendaContactosAux;
    }
}
*/
#endregion