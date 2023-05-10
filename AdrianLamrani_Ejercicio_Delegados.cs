#region Ejercicio1
/*
using System;

delegate int Operacion(int numero);

static class Calculos {
    public static int Cuadrado(int numero) {
        return numero * numero;
    }

    public static int Cubo(int numero) {
        return numero * numero * numero;
    }
}

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Selecciona una operación:");
        Console.WriteLine("1. Cuadrado");
        Console.WriteLine("2. Cubo");

        int opcion = int.Parse(Console.ReadLine());

        Operacion operacion;

        switch (opcion) {
            case 1:
                operacion = Calculos.Cuadrado;
                break;
            case 2:
                operacion = Calculos.Cubo;
                break;
            default:
                Console.WriteLine("Opción inválida");
                return;
        }
        Console.WriteLine("Introduce un número:");
        int numero = int.Parse(Console.ReadLine());

        int resultado = operacion(numero);

        Console.WriteLine("El resultado es: " + resultado);
    }
}
*/
#endregion


#region Ejercicio2
/*
using System;

delegate void Infinitivo();

class Program {
    static void Main(string[] args) {
        Infinitivo verbos = null;

        verbos += Ser;
        verbos += Correr;
        verbos += Ver;

        Console.WriteLine("Llamando a los métodos Ser, Correr y Ver:");
        verbos();

        verbos -= Ser;
        verbos -= Ver;
        verbos += Pensar;
        verbos += Comer;

        Console.WriteLine("\nLlamando a los métodos Pensar y Comer:");
        verbos();

        Console.ReadKey();
    }

    static void Ser() {
        Console.WriteLine("To be");
    }

    static void Correr() {
        Console.WriteLine("To run");
    }

    static void Ver() {
        Console.WriteLine("To see");
    }

    static void Pensar() {
        Console.WriteLine("To think");
    }

    static void Comer() {
        Console.WriteLine("To eat");
    }
}
*/
#endregion


#region Ejercicio3
/*
using System;

class Program {
    static void Main(string[] args) {
        int[,] matrizInt = { { 3, 4, 5 }, { 2, 4, 5 } };
        float[,] matrizFloat = { { 3.0f, 4.0f, 5.0f }, { 2.4f, 4.4f, 5.0f } };
        string[,] matrizString = { { "SAL", "AGUA", "AZUCAR", "VINO" }, { "COLA", "CAFE", "ZUMO", "LECHE" } };

        Mostrar(matrizInt);
        Mostrar(matrizFloat);
        Mostrar(matrizString);

        Action<string[,]> mostrarDelegate = Mostrar;
        mostrarDelegate(matrizString);

        Console.ReadKey();
    }

    static void Mostrar<T>(T[,] matriz) {
        for (int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; j < matriz.GetLength(1); j++) {
                Console.Write(matriz[i, j].ToString().PadRight(10));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
*/
#endregion


#region Ejercicio4
/*
using System;

class Program {
    static void Main(string[] args) {
        Func<int, int, int> suma = new Func<int, int, int>(Suma);
        Console.WriteLine(suma(5, 7)); // Output: 12
        
        Func<int, int> cuadrado = new Func<int, int>(CuadradoDe);
        Console.WriteLine(cuadrado(4)); // Output: 16
        
        Func<double> getVelocidad = new Func<double>(GetVelocidadParada);
        Console.WriteLine(getVelocidad()); // Output: 108.4
        
        Func<int, bool> esMultiplo = new Func<int, bool>(EsMultiploDeCinco);
        Console.WriteLine(esMultiplo(20)); // Output: True
        
        Func<string, string, string, double> calcula = new Func<string, string, string, double>(Calcula);
        Console.WriteLine(calcula("Division", "dividendo", "divisor")); // Input: 10, 2. Output: 5
        
        Action<double[,], int[], string> procedimiento = new Action<double[,], int[], string>(ProcedimientoDesconocido);
        double[,] array2d = { { 1.0, 2.0 }, { 3.0, 4.0 } };
        int[] array1d = { 1, 2 };
        string s = "Resultados: ";
        procedimiento(array2d, array1d, s);
        // Output: Resultados: 2 4 4 6
    }

    static int Suma(int n1, int n2) => n1 + n2;
    static int CuadradoDe(int number) => number * number;
    static double GetVelocidadParada() => 108.4;
    static bool EsMultiploDeCinco(int n) => n % 5 == 0;
    static double Calcula(string tipo, string nom1, string nom2) {
        Console.WriteLine($"Introduce {nom1}");
        string temp1 = Console.ReadLine();
        int var1 = Int32.Parse(temp1);
        Console.WriteLine($"Introduce {nom2}");
        string temp2 = Console.ReadLine();
        int var2 = Int32.Parse(temp2);
        return tipo == "Potencia" ? var1*var2 : var1 / var2;
    }
    static void ProcedimientoDesconocido(double[,] x, int[] y, String z) {
        if(x.Length==y.Length) {
            int p=0;
            foreach (double c in x) {
                z += (c + y[p]);
                z += " ";
                p++;
            }
        }
        Console.WriteLine(z);
    }
}
*/
#endregion


#region Ejercicio5
/*
using System;
using System.Collections.Generic;

public class TemperaturasXProvincia {
    public string Provincia { get; set; }
    public float TemperaturaMaxima { get; set; }
    public float TemperaturaMinima { get; set; }
}

public static class CalculosTemperaturas {
    public static float ObtenTemperaturaMaxima(TemperaturasXProvincia txp)
        => txp.TemperaturaMaxima;

    public static float ObtenTemperaturaMinima(TemperaturasXProvincia txp)
        => txp.TemperaturaMinima;

    public static bool MayorQue(float t1, float t2) => t1 > t2;

    public static bool MenorQue(float t1, float t2) => t1 < t2;

    public static bool IgualQue(float t1, float t2) => t1 == t2;
}

class Program {
    static float MediaTemperaturas(List<TemperaturasXProvincia> temperaturas, 
        Func<TemperaturasXProvincia, float> selector) {
        float total = 0;

        foreach (var temperatura in temperaturas) {
            total += selector(temperatura);
        }

        return total / temperaturas.Count;
    }

    static void MuestraProvincias(List<TemperaturasXProvincia> temperaturas, 
        Func<float, float, bool> comparador, float temperatura) {
        foreach (var temperaturaProvincia in temperaturas) {
            if (comparador(temperaturaProvincia.TemperaturaMaxima, temperatura)) {
                Console.WriteLine($"{temperaturaProvincia.Provincia} tiene una temperatura máxima mayor que {temperatura}");
            }
        }
    }
    static void Main(string[] args) {
        List<TemperaturasXProvincia> listaTempPorProv = new List<TemperaturasXProvincia>() {
            new TemperaturasXProvincia("Madrid", 32.4f, 15.8f),
            new TemperaturasXProvincia("Barcelona", 30.1f, 17.2f),
            new TemperaturasXProvincia("Valencia", 34.2f, 18.5f),
            new TemperaturasXProvincia("Sevilla", 36.8f, 20.3f),
            new TemperaturasXProvincia("Zaragoza", 31.5f, 14.2f)
        };

        // Delegados
        Func<TemperaturasXProvincia, float> delObtenTemperaturaMaxima = ObtenTemperaturaMaxima;
        Func<TemperaturasXProvincia, float> delObtenTemperaturaMinima = ObtenTemperaturaMinima;
        Func<float, float, bool> delMayorQue = MayorQue;
        Func<float, float, bool> delMenorQue = MenorQue;
        Func<float, float, bool> delIgualQue = IgualQue;

        // Calcular media de temperaturas máximas y mostrar provincias con temperaturas mínimas por debajo de 16 grados
        MediaTemperaturas(listaTempPorProv, delObtenTemperaturaMaxima, delMayorQue, delIgualQue);
        MuestraProvincias(listaTempPorProv, delObtenTemperaturaMinima, delMenorQue, 16f);

        Console.ReadKey();
    }
}
*/
#endregion


