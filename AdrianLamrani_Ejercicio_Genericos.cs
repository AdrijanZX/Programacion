#region Ejercicio1
/*
using System;
class Fraccion<T> {
    public readonly T numerador, denominador;

    public Fraccion(T numerador, T denominador) {
        this.numerador = numerador;
        this.denominador = denominador;
    }
}
class Program {
    private static void Main(string[] args) {
        Fraccion<int> fraccionEnteros = new Fraccion<int>(4, 5);
        Console.WriteLine($"La fracción es: {fraccionEnteros.numerador / fraccionEnteros.denominador:D1}");
        Fraccion<long> fraccionDecimales = new Fraccion<long>(4, 3);
        Console.WriteLine($"La fracción es: {fraccionDecimales.numerador / fraccionDecimales.denominador:F2}");
    } 
}
*/
#endregion


#region Ejercicio2
/*
using System;
class A<T, U> {
    private T clave;
    private U valor;
    public A(T clave, U valor) {
        this.clave = clave;
        this.valor = valor;
    }
    public T DevuelveClave() {
        return clave;
    }
    public U DevuelveValor() {
        return valor;
    }
}
class Program {
    private static void Main(string[] args) {
        A<int, string> a = new A<int, string>(10, "Hola Mundo!");
        System.Console.WriteLine($"Clave<T>: {a.DevuelveClave()} // Valor<U>: {a.DevuelveValor()}");
    } 
}
*/
#endregion


#region Ejercicio3
/*
using System;
static class Comparador<T> where T : IComparable {
    public static bool Mayor(T mayor, T menor) {
        return mayor.CompareTo(menor) > 0;
    }
    public static bool Menor(T mayor, T menor) {
        return menor.CompareTo(mayor) < 0;
    }
}
class Program {
    private static void Main(string[] args) {
        System.Console.WriteLine(Comparador<string>.Menor("Hola", "Adios"));
        System.Console.WriteLine(Comparador<float>.Menor((float)5.3, (float)2.3));
        System.Console.WriteLine(Comparador<int>.Menor(4, 3));
    } 
}
*/
#endregion


#region Ejercicio4
/*
using System;
static class Comparador<T> where T : IComparable<T> {
    public static bool Mayor(T mayor, T menor) {
        return mayor.CompareTo(menor) > 0;
    }
    public static bool Menor(T mayor, T menor) {
        return menor.CompareTo(mayor) < 0;
    }
}
class Persona : IComparable<Persona>, ICloneable {
    public string nombre { get; set;}
    public int edad { get; set; }
    public int CompareTo(Persona otraPersona) {
        return this.edad.CompareTo(otraPersona.edad);
    }
    public object Clone() {
        return new Persona { nombre = this.nombre, edad = this.edad };
        }

        public override string ToString() {
            return $"Nombre: {nombre}, Edad: {edad}";
        }
}
class Program {
    private static void Main(string[] args) {
        Persona persona1 = new Persona { nombre = "Juan", edad = 25 };
        Persona persona2 = new Persona { nombre = "Pedro", edad = 30 };
        Console.WriteLine(Comparador<Persona>.Mayor(persona1, persona2));
        Console.WriteLine(Comparador<Persona>.Menor(persona1, persona2));

        Persona persona3 = (Persona)persona1.Clone();
        Console.WriteLine(Comparador<Persona>.Menor(persona1, persona3));
        
        //System.Console.WriteLine(Comparador<string>.Menor("Hola", "Adios"));
        //System.Console.WriteLine(Comparador<float>.Menor((float)5.3, (float)2.3));
        //System.Console.WriteLine(Comparador<int>.Menor(4, 3));
    } 
}
*/
#endregion


#region Ejercicio5
/*
using System;
class Program {
    static void Main(string[] args) {
        var provincias = RecogeTemperaturasPorProvincia();
        var obtenTempMaxMin = new ObtenTemperaturaMaxMin();
        foreach (var provincia in provincias) {
            Console.WriteLine($"Provincia: {provincia.Provincia}, Temperatura máxima o mínima: {obtenTempMaxMin.ObtenTemperatura(provincia)}");
        }
        var temperatura1 = obtenTempMaxMin.ObtenTemperatura(provincias[0]);
        var temperatura2 = obtenTempMaxMin.ObtenTemperatura(provincias[1]);
        if (obtenTempMaxMin.CumplePredicado(temperatura1, temperatura2)) {
            Console.WriteLine($"La temperatura de la provincia {provincias[0].Provincia} es mayor que la de la provincia {provincias[1].Provincia}");
        }
        else {
            Console.WriteLine($"La temperatura de la provincia {provincias[1].Provincia} es mayor que la de la provincia {provincias[0].Provincia}");
        }
    }
    static TemperaturasXProvincia[] RecogeTemperaturasPorProvincia() {
        Console.Write("De cuantas provincias quieres recoger la temperatura: ");
        var temperaturasPorProvincia = new TemperaturasXProvincia[int.Parse(Console.ReadLine())];
        Random seed = new Random();

        for (int i = 0; i < temperaturasPorProvincia.Length; i++)
        {
            Console.Write($"Introduce la provincia nº{i + 1}: ");
            string provincia = Console.ReadLine();
            float temperaturaMaxima = seed.Next(17, 25);
            float temperaturaMinima = seed.Next(-5, 17);
            Console.Write("\n\n");
            temperaturasPorProvincia[i] = new TemperaturasXProvincia(provincia, 
                                                                        temperaturaMaxima, 
                                                                        temperaturaMinima);
        }
        return temperaturasPorProvincia;
    }
}
class ObtenTemperaturaMaxMin : IObtenTemperatura, ICumplePredicado<float> {
    public ObtenTemperaturaMaxMin() {}
    public float ObtenTemperatura(TemperaturasXProvincia provincias) {
        return Math.Max(provincias.TemperaturaMaxima, provincias.TemperaturaMinima);
    }
    public bool CumplePredicado(float o1, float o2) {
        return o1 > o2;
    }
}
class TemperaturasXProvincia {
    public string Provincia { get; }
    public float TemperaturaMaxima { get; }
    public float TemperaturaMinima { get; }

    public TemperaturasXProvincia(string provincia, float temperaturaMaxima, float temperaturaMinima) {
        Provincia = provincia;
        TemperaturaMaxima = temperaturaMaxima;
        TemperaturaMinima = temperaturaMinima;
    }
}
interface IObtenTemperatura {
    float ObtenTemperatura(TemperaturasXProvincia provincia);
}
interface ICumplePredicado<T> {
    bool CumplePredicado(T o1, T o2);
}
*/
#endregion


#region Ejercicio6
/*
using System;
class Lista<T> {
    private T[] list;
    public Lista() { 
        list = new T[0];
     }
    public void Add(T adicion) {
        try {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = adicion;
        } catch(Exception e) {
            System.Console.WriteLine("ERROR: " + e.Message);
        }
    }
    public T this[int i] {
        set {
            list[i] = value;
        }
        get {
            return list[i];
        }
    }
}
class Program {
    static void Main(string[] args) {        
        Lista<int> lista=new Lista<int>();
        lista.Add(5);
        Console.WriteLine(lista[0]);
        lista.Add(8);
        Console.WriteLine(lista[1]);
        lista[1]=10;
        Console.WriteLine(lista[1]);
        //Prueba la lista con string
    }
}
*/
#endregion