#region Ejercicio1
/*
Mostrar un tablero de ajedrez y sobre él, marcar con * las celdas a las que se puede mover
un alfil desde una posición dada por el usuario.
Ten en cuenta que en ajedrez las filas son numéricas del 1 al 8 y las columnas letras de la A a
la H.
💡 Tips: Aunque no es necesario, si quieres imprimir colores en el terminal puedes usar las
propiedades de consola:
Console.BackgroundColor = ConsoleColor.Color;
Console.ForegroundColor = ConsoleColor.Color;
Además, puedes imprimir en una posición específica en pantalla con.
Console.SetCursorPosition(Columna, Fila);
Para más información sobre la clase Console
Un ejemplo de salida por pantalla puede ser el siguiente:
Introduce fila: 4
Introduce columna: D
ABCDEFGH
1*     *
2 *   *
3  * *
4   A
5  * *
6 *   *
7*     *
8       *

    protected static int origRow;
    protected static int origCol;
    protected static void WriteAt(string s, int x, int y) {
        try {
            Console.SetCursorPosition(origCol+x, origRow+y);
            Console.Write(s);
            } catch (ArgumentOutOfRangeException e) {
            Console.Clear();
            Console.WriteLine(e.Message);
            }
        }
    static void Main(string[] args)
    {
        Console.Clear();
        origRow = Console.CursorTop;
        origCol = Console.CursorLeft;

        System.Console.WriteLine("Inserta la columna '1-8': ");
        int columna = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Inserta la fila '1-8': ");
        int fila = int.Parse(Console.ReadLine());

        //Tablero
        System.Console.WriteLine(" 12345678");
        System.Console.WriteLine("A");
        System.Console.WriteLine("B");
        System.Console.WriteLine("C");
        System.Console.WriteLine("D");
        System.Console.WriteLine("E");
        System.Console.WriteLine("F");
        System.Console.WriteLine("G");
        System.Console.WriteLine("H");
        
        //Alfiler
        WriteAt("A", columna, fila);
        //ARRIBA DERECHA
        WriteAt("*", columna + 1, fila - 1);
        WriteAt("*", columna + 2, fila - 2);
        WriteAt("*", columna + 3, fila - 3);
        //ARRIBA IZQUIERDA
        WriteAt("*", columna - 1, fila - 1);
        WriteAt("*", columna - 2, fila - 2);
        WriteAt("*", columna - 3, fila - 3);
        //ABAJO DERECHA
        WriteAt("*", columna + 1, fila + 1);
        WriteAt("*", columna + 2, fila + 2);
        WriteAt("*", columna + 3, fila + 3);
        //ABAJO IZQUIERDA
        WriteAt("*", columna - 1, fila + 1);
        WriteAt("*", columna - 2, fila + 2);
        WriteAt("*", columna - 3, fila + 3);
    }

    static void Main(string[] args)
    {
    Console.Clear();

    int tamaño, contador = 0;

    Console.WriteLine("Escriba el tamaño: ");
    tamaño = int.Parse(Console.ReadLine());

        for(int i = 0; i < tamaño; i++) {
            if(contador == tamaño) {
                i = tamaño;
            } else {
                for(int j = 0; j < tamaño; j++) {
                    System.Console.Write(" ");
                    if(j == i) {
                        contador++;
                        Console.Write("*");
                        System.Console.WriteLine();
                        j = 0;
                    }
                }
            }
        }
    }
*/
#endregion

#region Ejercicio2
/*
Muestra un tablero de ajedrez y sobre él marcar con * las celdas a las que se puede mover
un caballo desde una posición dada por el usuario.
Un ejemplo de salida por pantalla puede ser el siguiente:
Introduce fila: 4
Introduce columna: D
ABCDEFGH
1
2  * *
3 *   *
4   C
5 *   *
6  * *
7
8

*/
#endregion

#region Ejercicio3
/*
Construir un triángulo de N filas con números.
Un ejemplo de salida por pantalla puede ser el siguiente:
1
23
345
4567
56789
678901

    static void Main(string[] args)
    {
        string num = "";
        int numeros = 0, limite = 0, variableJ = 1, tamaño;

        System.Console.WriteLine("Insrte el tamaño que desea del triangulo: ");
        tamaño = int.Parse(Console.ReadLine());

        for(int i = 0; i < tamaño; i++) {
            if(limite !> tamaño) {
            } else {
                for(int j = 0; j < variableJ; j++) {
                    numeros++;
                    if(numeros < 10) {
                        num = num + numeros;
                    } else {
                        numeros = 0;
                        num = num + numeros;
                    }
                }
            }
        variableJ++;
        limite++;
        System.Console.WriteLine(num);
        num = "";
        }
    }
*/
#endregion

#region Ejercicio4
/*
Igual que el anterior pero para este otro triángulo.
Un ejemplo de salida por pantalla puede ser el siguiente:
3
58
703
9258

    static void Main(string[] args)
    {
        string num = "";
        int numeros = 0, limite = 0, variableJ = 1, tamaño;

        Random random = new Random();
        int numerosRand;

        System.Console.WriteLine("Insrte el tamaño que desea del triangulo: ");
        tamaño = int.Parse(Console.ReadLine());

        for(int i = 0; i < tamaño; i++) {
            
            if(limite !> tamaño) {
            } else {
                for(int j = 0; j < variableJ; j++) {
                    numerosRand = random.Next(1, 9);
                    if(numeros < 10) {
                        num = num + numerosRand;
                    } else {
                        numeros = 0;
                        num = num + numerosRand;
                    }
                }
            }
        variableJ++;
        limite++;
        System.Console.WriteLine(num);
        num = "";
        }
    }
*/
#endregion

#region Ejercicio5
/*
Una progresión aritmética tiene el siguiente término general an = 3 * n - 2 . Se desea un
programa que pida un número k y calcule los k primeros términos.
Un ejemplo de salida por pantalla puede ser el siguiente:
k: 5
Progresión a1=1, a2=4, a3=7, a4=10, a5=13.

    static void Main(string[] args)
    {
        int k, n = 0, an;
        System.Console.WriteLine("Inserta el valor de k: ");
        k = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("k: " + k);
        for (int i = 0; i < k; i++) {
            n = i;
            an = i + 1;
            n = 3 * n - 2;
            Console.Write($"a{an}={n}    ");
        }
    }
*/
#endregion

#region Ejercicio6
/*
Programa la generación de una tabla de verdad con unos y ceros con un bucle for anidado.
Las operaciones que mostrará la tabla serán por tanto operaciones de bit.
Para ello el usuario deberá introducir por teclado un carácter con el cual nos indicará la
tabla a generar (&, |, ^).
La decisión de la tabla a mostrar, debe ser mediante una instrucción switch con el
carácter.
En el caso de tratarse de una operación no válida avisaremos de tal hecho y
finalizaremos la ejecución.
Un ejemplo de salida por pantalla puede ser el siguiente:
Introduce una operación de bit (&, |, ^): &
0 & 0 = 0
0 & 1 = 0
1 & 0 = 0
1 & 1 = 1

    static void Main(string[] args)
    {
        string caracterIntr;

        System.Console.WriteLine("introduce el caracter '&', '|' o '^'");
        caracterIntr = Console.ReadLine();

        switch(caracterIntr) {
            case "&":
                for(int i = 0; i <= 1; i++) {
                    for(int j = 0; j <= 1; j++) {
                        Console.Write(i);
                        Console.Write(" ");
                        Console.Write(caracterIntr);
                        Console.Write(" ");
                        Console.Write(j);
                        Console.Write(" = ");

                        if (i == 1 && j == 1) {
                            Console.Write("1");
                        } else {
                            Console.Write("0");
                        }
                        Console.Write("\n");
                    }
                }
                break;

            case "|":
                for (int i = 0; i <= 1; i++) {
                    for (int j = 0; j <= 1; j++) {
                        Console.Write(i);
                        Console.Write(" ");
                        Console.Write(caracterIntr);
                        Console.Write(" ");
                        Console.Write(j);
                        Console.Write(" = ");

                        if (i == 0 && j == 0) {
                            Console.Write("0");
                        } else {
                            Console.Write("1");
                        }
                        Console.Write("\n");
                    }
                }
                break;
            
            case "^":
                for (int i = 0; i <= 1; i++) {
                    for (int j = 0; j <= 1; j++) {
                        Console.Write(i);
                        Console.Write(" ");
                        Console.Write(caracterIntr);
                        Console.Write(" ");
                        Console.Write(j);
                        Console.Write(" = ");

                        if (i==j) {
                            Console.Write(0);
                        } else {
                            Console.Write(1);
                        }
                        Console.Write("\n");
                    }
                }
                break;

            default:
                Console.Write("Operación no valida debido a que el caracter introducido no es de los proporcionados");
                break;
        }
    }
*/
#endregion

#region Ejercicio7
/*
Escribe un programa que genere la secuencia de números:
1, 2, 1, 2, 3, 1, 2, 3, 4, 1, 2, 3, 4, 5, ..., 1, 2, 3, ... N

    static void Main(string[] args)
    {
        string mensaje = "0";
        int num = 0, tamaño = 1;

        for(int i = 0; i < tamaño; i++) {
            for(int j = 0; j !< i; j++) {
                num++;
                mensaje = $"{mensaje}, {num}";
            }
            num = 0;
            tamaño++;
            if(tamaño == 10) {
                i = tamaño;
            }
        }
        System.Console.WriteLine($"Secuencia: {mensaje}...");
    }
*/
#endregion

#region Ejercicio8
/*
Un número se dice que es capicúa si leído de derecha a izquierda da el mismo resultado que
leído de izquierda a derecha.
Por ejemplo, los números 22, 343, 5665 o 12321 son capicúas.
Elabora un programa que lea desde teclado un número entero mayor de 9 y devuelva si el
número es capicúa o no.

    static void Main(string[] args)
    {
        string numero;
        string j;
        j = "";
        string capcuaVF = "";

        Console.WriteLine("Introduce un numero");
        numero = Console.ReadLine();

        for (int i = 0; i < numero.Length; i++) {
            j = numero.Substring(i, 1) + j;
        }
        if (j == numero) {
            capcuaVF = "Verdadero";
        } else {
            capcuaVF = "Falso";
        }
        Console.WriteLine($"EL numero es capicua: {capcuaVF}");
    }
*/
#endregion

#region Ejercicio9
/*
Crea un programa que muestre en pantalla la siguiente pirámide:
     1
    232
   34543
  4567654
 567898765
67890109876
Se introducirá por teclado un número que indique la profundidad de la pirámide.
Nota: Para rellenar de blancos cada línea nos fijaremos en la profundidad de la pirámide. Si la
profundidad de la pirámide es n requeriremos n-1 blancos para la primera línea, n-2 para la
segunda, n-3 para la tercera y así sucesivamente.

    static void Main(string[] args)
    {
        int n, linActual, esp, aster, num = 0;

        Console.Write("Inserte la altura del triangulo: ");
        n = Convert.ToInt32(Console.ReadLine());

        for(linActual = 1; linActual <= n; linActual++) {
            for(esp = 0; esp < n - linActual; esp++) {
                Console.Write(" ");
            }
            for(aster = 0; aster < (linActual * 2) - 1; aster++) {
                num++;
                if(num < 10) {
                    Console.Write(num);
                } else {
                    num = 0;
                    Console.Write(num);
                }
            }
            Console.WriteLine();
        }
    }
*/
#endregion

#region Ejercicio10
/*
Haz un programa que usando algún tipo de bucle. Determine la ubicación de un número
mayor que cero (leído del teclado) en una lista de números mayores que cero leída del
teclado (lista creciente estrictamente y que finalizará con un 0).
Si suponemos la entrada de datos...
Entrada → (Número buscado) en (Lista)
Podemos obtener los siguientes ejemplos de solución...
2 en 3 5 6 7 8 0
Fuera de lista a la Izquierda
8 en 1 3 5 7 0
Fuera de lista a la Derecha
4 en 1 3 4 6 8 0
En la lista
5 en 1 3 4 7 0
Fuera de lista a la Intercalado

*/
#endregion