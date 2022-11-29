#region Ejercicio1
/*
using System.Text;
using System.Linq;
class Program {
        static void Main(string[] args) {
        string mensaje = "";
        int[][] numeros = new int[10][] {
            new int[10] {0,0,0,0,0,0,0,0,0,0},
            new int[10] {0,0,0,0,0,0,0,0,0,0},
            new int[10] {0,0,0,0,0,0,0,0,0,0},
            new int[10] {0,0,0,0,0,0,0,0,0,0},
            new int[10] {0,0,0,0,0,0,0,0,0,0},
            new int[10] {0,0,0,0,0,0,0,0,0,0},
            new int[10] {0,0,0,0,0,0,0,0,0,0},
            new int[10] {0,0,0,0,0,0,0,0,0,0},
            new int[10] {0,0,0,0,0,0,0,0,0,0},
            new int[10] {0,0,0,0,0,0,0,0,0,0}
        }; 
        for(int i = 0; i < numeros.Length; i++) {
            for(int j = 1; j < numeros[i].Length; j++) {
                if(j % 2 == 0) {
                    numeros[i][j] = j;
                } else {
                    numeros[i][j] = 0;
                }
                mensaje += $"{numeros[i][j]} ";
            }
            mensaje += "\n";
        }
        System.Console.WriteLine(mensaje);
    }
}
*/
#endregion


#region Ejercicio2
/*
using System.Text;
using System.Linq;
class Program {
        static void Main(string[] args) {
        string mensaje = "";
        int[][] numeros = new int[5][] {
            new int[5] {0,0,0,0,0},
            new int[5] {0,0,0,0,0},
            new int[5] {0,0,0,0,0},
            new int[5] {0,0,0,0,0},
            new int[5] {0,0,0,0,0}
        }; 
        for(int i = 0; i < numeros.Length; i++) {
            for(int j = 0; j < numeros[i].Length; j++) {
                if(i == j) {
                    numeros[i][j] = 1;
                    mensaje += $"{numeros[i][j]} ";
                } else {
                    numeros[i][j] = 0;
                    mensaje += $"{numeros[i][j]} ";
                }
            }
            mensaje += "\n";
        }
        System.Console.WriteLine(mensaje);
    }
}
*/
#endregion


#region Ejercicio3
/*
using System.Text;
using System.Linq;
class Program {
        static void Main(string[] args) {
        const int N = 3;
        int i, j, temp;
        int[,] matriz = new int [N, N] {
            {1, 2, 1},
            {3, 3, 5},
            {1, 2, 1}
        };
        System.Console.WriteLine("Original: \n");
        for(i = 0; i < N; i++) {
            for(j = 0; j < N; j++) {
                System.Console.Write($"{matriz[i, j]} ");;
            }
            System.Console.Write("\n");
        }

        for(i = 1; i < N; i++) {
            for(j = 0; j < i; j++) {
                temp = matriz[i, j];
                matriz[i, j] = matriz[j, i];
                matriz[j, i] = temp;
            }
        }
        System.Console.WriteLine("\nPermutado: \n");
        for(i = 0; i < N; i++) {
            for(j = 0; j < N; j++) {
                System.Console.Write($"{matriz[i, j]} ");;
            }
            System.Console.Write("\n");
        }
    }
}
*/
#endregion


#region Ejercicio4
/*
using System.Text;
using System.Linq;
class Program {
        static void Main(string[] args) {
        Console.Clear();
        
        char[][] paises = new char[][] {
            new char[]{'M','A','R','R','U','E','C','O','S'},
            "ESPAÑA".ToCharArray(),
            "FRANCIA".ToCharArray(),
            "ITALIA".ToCharArray(),
            "ARGENTINA".ToCharArray(),
            "ALEMANIA".ToCharArray(),
            "COLOMBIA".ToCharArray(),
            "VENEZUELA".ToCharArray(),
            "ECUADOR".ToCharArray(),
            "SUECIA".ToCharArray(),
            "NORUEGA".ToCharArray(),
            "MEXICO".ToCharArray(),
            "ESTADOS UNIDOS".ToCharArray(),
            "CHILE".ToCharArray(),
            "ARGELIA".ToCharArray(),
            "FILIPINAS".ToCharArray(),
            "POLONIA".ToCharArray(),
            "LITUANIA".ToCharArray(),
            "NICARAGUA".ToCharArray(),
            "IRLANDA".ToCharArray(),
            "URUGUAY".ToCharArray(),
        };
        string test = new string(paises[1]);
        System.Console.WriteLine("Seleccione la opcion:\n\n1. Buscar País.\n2. Mostrar Pais.\n3. Ordenar País.\n4. Añadir Prefijo al País.");
        int opcionMenu = int.Parse(Console.ReadLine());
        switch(opcionMenu) {
            case 1:
                Console.Clear();
                System.Console.WriteLine("¿Que país quieres buscar?");
                string paisABuscar = Console.ReadLine();
                for(int i = 0; i < paises.Length; i++) {
                    if(new String(paises[i]) == paisABuscar.ToUpper()) {
                        System.Console.WriteLine($"El país {paisABuscar.ToUpper()} se encuentra en la posicion nº [{i}] del array");
                    }
                }
                break;
            case 2:
                Console.Clear();
                System.Console.WriteLine("----------------------\n" +
                                        "Listado de países:\n" +
                                        "----------------------");
                for(int i = 0; i < paises.Length; i++) {
                    System.Console.WriteLine(new String(paises[i]));
                }
                System.Console.WriteLine("----------------------");
                break;
            case 3:
                Console.Clear();
                System.Console.WriteLine("-----------------------------------\n" +
                                        "Listado ordenado alfabeticamente:\n" +
                                        "-----------------------------------");
                for(int i = 0; i < paises.Length; i++) {
                    Comparison<char> comparador = new Comparison<char>((cadena1, cadena2) => cadena1.CompareTo(cadena2));
                    Array.Sort<char>(paises[i], comparador);
                    foreach(char arraySOrdenado in paises[i]) {
                        System.Console.WriteLine(arraySOrdenado);
                    }
                }
                System.Console.WriteLine("-----------------------------------");
                break;
            case 4:
                break;
        }
    }
}
*/
#endregion


#region Ejercicio5
/*
using System.Text;
using System.Linq;
class Program {
    
}
*/
#endregion


#region Ejercicio6
/*
using System.Text;
using System.Linq;
class Program {
    
}
*/
#endregion


#region Ejercicio7
/*
using System.Text;
using System.Linq;
class Program {
        static void Main(string[] args) {
        Console.Clear();
        ConsoleKeyInfo teclaSalir = default;
        int salaSeleccionadaInt = 0;
        string aux = "";
        string[] salas = new string[] {
            "A",
            "B",
            "C"
        };

        int[][] aforoSalas = new int[][] {
            //1ª Sesión -- Sala A.
            new int[] {200, 200, 200},
            //2ª Sesión -- Sala B.
            new int[] {150, 150, 150},
            //3ª Sesión -- Sala C.
            new int[] {125, 125, 125}
        };
        do {
            Console.Clear();
            System.Console.WriteLine("-----------------------------\n" +
                                    "Seleccione la opcción:\n" + 
                                    "-----------------------------\n" + 
                                    "1. Venta de entradas.\n" + 
                                    "2. Estadística de aforo.\n" + 
                                    "-----------------------------");
            int opcionMenu = int.Parse(Console.ReadLine());
            switch(opcionMenu) {
                case 1:
                    Console.Clear();
                    System.Console.WriteLine("---------------------------------------------------------------------------------------------------\n" +
                                            "Venta de entradas:\n" + 
                                            "---------------------------------------------------------------------------------------------------");
                    System.Console.WriteLine("Indique en que sala (A-C) y en que sesión (1-3) quiere ver la película: ");
                    System.Console.Write("Sala: ");
                    string salaSeleccion = Console.ReadLine();
                    System.Console.Write("Sesión: ");
                    int sesionSeleccion = int.Parse(Console.ReadLine());
                    System.Console.Write("Cantidad de sitios: ");
                    int cantidadEntradas = int.Parse(Console.ReadLine());
                    switch(salaSeleccion) {
                        case "A": salaSeleccionadaInt = 0;
                            break;
                        case "B": salaSeleccionadaInt = 1;
                            break;
                        case "C": salaSeleccionadaInt = 2;
                            break;
                    }
                    if(aforoSalas[salaSeleccionadaInt][sesionSeleccion - 1] - cantidadEntradas >= 0) {
                        System.Console.WriteLine("Compra realizada con éxito...");
                        aforoSalas[salaSeleccionadaInt][sesionSeleccion - 1] -= cantidadEntradas;
                    } else {
                        System.Console.WriteLine("No se pueden comprar, sobrepasas el aforo...");
                    }
                    System.Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    break;
                case 2:
                    Console.Clear();
                    System.Console.WriteLine("---------------------------------------------------------------------------------------------------\n" +
                                            "Estadística de aforo:\n" + 
                                            "---------------------------------------------------------------------------------------------------");
                    for(int i = 0; i < salas.Length; i++) {
                        System.Console.WriteLine($"--[Sala: {salas[i].ToString()}]--");
                        for(int j = 0; j < aforoSalas.Length; j++) {
                            aux += "Sesión: " + (j+1) + "ª // " + "Aforo libre: " + aforoSalas[i][j] + "    ";
                        }
                        System.Console.WriteLine(aux);
                        aux = "";
                    }
                    System.Console.WriteLine("---------------------------------------------------------------------------------------------------");
                    break;
            }
        System.Console.WriteLine("Si desea salir presione la tecla [ESC], si desea seguir presione [Enter]");
        teclaSalir = Console.ReadKey();
        } while(teclaSalir.Key != ConsoleKey.Escape);
    }
}
*/
#endregion


#region Ejercicio8
/*
using System.Text;
using System.Linq;
class Program {
        static void Main(string[] args) {
        Console.Clear();
        Random semilla = new Random();
        int numSum = 1;
        string mensaje = "";
        int[][][] m = new int[2][][] {
            new int[3][] {
                new int[4] {0,0,0,0},
                new int[3] {0,0,0},
                new int[4] {0,0,0,0}
            },
            new int[3][] {
                new int[4] {0,0,0,0},
                new int[4] {0,0,0,0},
                new int[2] {0,0}
            }
        };
        for(int i = 0; i < m.Length; i++) {
            for(int j = 0; j < m[i].Length; j++) {
                for(int k = 0; k < m[i][j].Length; k++) {
                    int numRand = semilla.Next(1,100);
                    m[i][j][k] = numSum; //Para numeros ordenados.
                    //m[i][j][k] = numRand; //Para numero random.
                    if(k == m[i][j].Length) {
                        mensaje += $"{m[i][j][k]}\n";
                    } else {
                        mensaje += $"{m[i][j][k]},";
                    }
                    numSum++;
                }
                mensaje += "\n";
            }
            mensaje += "\n";
        }
        System.Console.WriteLine(mensaje);
    }
}
*/
#endregion


#region Ejercicio9
/*
using System.Text;
using System.Linq;
class Program {
    
}
*/
#endregion


