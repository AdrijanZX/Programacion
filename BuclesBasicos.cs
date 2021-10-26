#region Ejercicio1
/*
Programa que calcula y muestra la suma y el producto de los 10 primeros números
naturales.
Nota: Se deben usar acumuladores para resolverlo.

    static void Main(string[] args)
    {
        int acumuladorSuma = 0;
        int acumuladorProducto = 1;

        for (int i = 1; i < 11; i++) {
            acumuladorSuma = acumuladorSuma += i;
            System.Console.WriteLine($"Acumulador suma: {acumuladorSuma}");
        }
        System.Console.WriteLine("----------------------------------------------------");
        for (int i = 1; i < 11; i++) {
            acumuladorProducto = acumuladorProducto *= i;
            System.Console.WriteLine($"Acumulador producto: {acumuladorProducto}");
        }
    }
*/
#endregion

#region Ejercicio2
/*
Programa que lee 100 números y cuenta cuántos de ellos son positivos (n > 0).
Nota: Se deben usar contadores para resolverlo.

    static void Main(string[] args)
    {
        int numPositivos = 0;
        int numNegativos = 0;

        Random random = new Random();
        int numerosRand;

        for (int i = 0; i < 100; i++) {
            numerosRand = random.Next(-100, 100);

            if(numerosRand > 0) {
                numPositivos++;
            } else {
                numNegativos++;
            }
            System.Console.WriteLine($"Contador de numeros: {numerosRand}");
        }
        System.Console.WriteLine($"Han habido {numPositivos} numeros positivos");
        System.Console.WriteLine($"Han habido {numNegativos} numeros negativos");
    }
*/
#endregion

#region Ejercicio3
/*
Programa que lea números hasta que se introduzca un cero y escriba la media de los
números leídos, sin incluir el 0 en el conteo de números.
Nota: Se deben usar contadores y acumuladores para resolverlo.
4 6 8 2 0 Media = 5

    static void Main(string[] args)
    {
        double nota;
        int contador = 0;
        double numSuma = 0;
        double media;
        do
        {
            Console.Write("Introduzca un valor: ");
            nota = int.Parse(Console.ReadLine());
            if (nota != 0)
            {
                numSuma = numSuma + nota;
                contador++;
            }
        } while (nota != 0);
        media = (numSuma / contador);
        Console.WriteLine($"La media será: {media:F2}");
    }
*/
#endregion

#region Ejercicio4
/*
Programa que lea notas y que termine con el valor -1.
Las notas deben estar incluidas en el rango que va de 0 al 10, descartando y avisando
del error si no es una nota permitida.
La salida nos mostrará la cantidad de dieces que se han introducido.

    static void Main(string[] args)
    {
        double nota;
        int contador = 0;
        int contadorDieces = 0;
        double numSuma = 0;
        double media;
        do
        {
            Console.Write("Introduzca un valor: ");
            nota = int.Parse(Console.ReadLine());
            if (nota >= 0 && nota <= 10)
            {
                numSuma = numSuma + nota;
                contador++;
                if(nota == 10) {
                    contadorDieces++;
                }
            } else if (nota < 0 || nota > 10) {
                System.Console.WriteLine($"Nota introducida invalida (Nota de error: {nota})");
            }
        } while (nota != -1);
        media = (numSuma / contador);
        Console.WriteLine($"La media será: {media:F2}");
        System.Console.WriteLine($"Han habido {contadorDieces} x 10");
    }
*/
#endregion

#region Ejercicio5
/*
Programa que lee una secuencia de 100 números y nos dice cuántos hay positivos, cuántos
negativos y cuantos ceros.
Nota: Para hacer las pruebas puedes reducir el número de entradas.

    static void Main(string[] args)
    {
        int numPositivos = 0;
        int numNegativos = 0;
        int numCeros = 0;

        Random random = new Random();
        int numerosRand;

        for (int i = 0; i < 100; i++) {
            numerosRand = random.Next(-100, 100);

            if(numerosRand > 0) {
                numPositivos++;
            } else if (numerosRand < 0){
                numNegativos++;
            } else if(numerosRand == 0) {
                numCeros++;
            }
            System.Console.WriteLine($"Contador de numeros: {numerosRand}");
        }
        System.Console.WriteLine($"Han habido {numPositivos} numeros positivos");
        System.Console.WriteLine($"Han habido {numNegativos} numeros negativos");
        System.Console.WriteLine($"Han habido {numCeros} ceros");
    }
*/
#endregion

#region Ejercicio6
/*
Programa que lee una secuencia de números no nulos, terminada con la introducción de un 0,
y muestra el mayor de la secuencia.

    static void Main(string[] args)
    {
        int numMayor = 0;

        Random random = new Random();
        int numerosRand;

        for (int i = 0; i < 100; i++) {
            numerosRand = random.Next(-1, 101);

            if(numMayor < numerosRand) {
                numMayor = numerosRand;
            } else if(numerosRand == 0) {
                i = 100;
                System.Console.WriteLine("Salió el 0 con lo cual se paró el programa");
            }
            System.Console.WriteLine($"Contador de numeros: {numerosRand}");
        }
        System.Console.WriteLine($"El numero {numMayor} ha sido el mas alto");
    }
*/
#endregion

#region Ejercicio7
/*
Programa que obtenga el producto de dos números enteros positivos mediante sumas
sucesivas. Esto es, para calcular 2 * 5 haga 2 + 2 + 2 + 2 + 2.

    static void Main(string[] args)
    {
        int numPrinc, numPrincSuma, numMult = 0;

        System.Console.WriteLine("Introduce el numero a multiplicar: ");
        numPrinc = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Introduce el numero por el que lo vas a multiplicar: ");
        numMult = int.Parse(Console.ReadLine());
        numPrincSuma = numMult;
        
        string mensaje = $"{numPrinc}";

        for (int i = 1; i < numMult; i++) {
            numPrincSuma = numPrincSuma + numPrinc;
            mensaje = mensaje + $" + {numPrinc}";
        }
        System.Console.WriteLine($"{mensaje} = {numPrincSuma}");
    }
*/
#endregion

#region Ejercicio8
/*
Programa que obtenga el cociente y el resto de dos números enteros positivos mediante
restas. Esto es, para calcular n / 2 haga n -= 2 mientras n >= 2 y cuente el número de
restas.

    static void Main(string[] args)
    {
        int num1, num2, cociente = 0, resto;
        string resultado="";

        System.Console.WriteLine("Introduce el numero 1");
        numero1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Introduce el numero 2");
        numero2 = int.Parse(Console.ReadLine());

        do
        {
            resto = numero1-numero2;
            numero1 = resto;
            cociente = cociente + 1;
            resultado=$"El resto de la division es {resto}, el cociente es {cociente}";
        }
        while (numero1>=numero2);
        Console.WriteLine(resultado);
    }
*/
#endregion

#region Ejercicio9
/*
Haz un programa que muestre en pantalla la tabla de códigos UTF-8.
HEX     DEC     CAR
0x20    32
0x22    34      "
0x24    36      $
0x26    38      &
0x28    40      (
0x2a    42      *
… Así hasta 255 (256 caracteres).
Nota: Se parará la pantalla cuando sea necesario para que se puedan ver todos los
caracteres, para ello podemos usar un Console.ReadKey().

    static void Main(string[] args)
    {
        int contador = 0;
        System.Console.WriteLine("HEX     DEC     CAR");
        
            for(int i = 1; i < 21; i++) {
                contador++;
                System.Console.WriteLine($"{contador:X2}      {contador}        {(char)contador}");
                if(i == 20) {
                    System.Console.WriteLine("Ya van 20 caracteres, presiona una tecla para continuar.");
                    i = 0;
                    Console.ReadKey();
                } else if(contador == 255) {
                    break;
            }
        }
    }
*/
#endregion

#region Ejercicio10
/*
Programa que determina si dos números enteros positivos son amigos
Dos números son amigos si la suma de los divisores del primer número excepto él mismo, es
igual al segundo numero, y viceversa.

    static void Main(string[] args)
    {
        int num1, num2, divisoresNum1 = 0, divisoresNum2 = 0;
        string resultado = "";

        Console.WriteLine("Introduzca el número 1");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduzca el número 2");
        num2 = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num1/2; i++) {
            if (num1 % i == 0) {
                divisoresNum1 += i;
            } 
        }
        for (int i = 1; i <= num2/2; i++){
            if (num2 % i == 0) {
                divisoresNum2 += i;
            }
        }
        if (num1 == divisoresNum2 && num2 == divisoresNum1) {
        resultado = $"Los numeros {num1} y {num2} son amigos";
        }
        else {
            resultado = $"Los numeros {num1} y {num2} no son amigos";
        }
        Console.WriteLine(resultado);
    }
*/
#endregion

#region Ejercicio11
/*
Simulación de una calculadora
Realiza un programa que sea capaz de sumar, restar, multiplicar y dividir.
El programa presentará un menú con las cuatro operaciones que puede realizar.
Saldrá del programa con la tecla ESC, para ello se podrá usar Console.ReadKey().

    static void Main(string[] args)
    {
        ConsoleKeyInfo tecla;
        int estados = 0, resultado = 0;
        
        do {
            if(estados == 0) {
                System.Console.WriteLine("Selecciona si quieres sumar(1), restar(2), multiplicar(3) o dividir(4): ");
                try {
                    estados = int.Parse(Console.ReadLine());
                } catch {
                }
            } else if (estados == 1) {
                System.Console.WriteLine("Inserta el 1º numero: ");
                int numero1 = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Inserta el 2º numero: ");
                int numero2 = int.Parse(Console.ReadLine());

                resultado = numero1 + numero2;
                System.Console.WriteLine($"El resultado de la suma entre {numero1} y {numero2} es: {resultado}");
                estados = 0;
            } else if (estados == 2) {
                System.Console.WriteLine("Inserta el 1º numero: ");
                int numero1 = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Inserta el 2º numero: ");
                int numero2 = int.Parse(Console.ReadLine());

                resultado = numero1 - numero2;
                System.Console.WriteLine($"El resultado de la suma entre {numero1} y {numero2} es: {resultado}");
                estados = 0;
            } else if (estados == 3) {
                System.Console.WriteLine("Inserta el 1º numero: ");
                int numero1 = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Inserta el 2º numero: ");
                int numero2 = int.Parse(Console.ReadLine());

                resultado = numero1 * numero2;
                System.Console.WriteLine($"El resultado de la suma entre {numero1} y {numero2} es: {resultado}");
                estados = 0;
            } else if (estados == 4) {
                System.Console.WriteLine("Inserta el 1º numero: ");
                int numero1 = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Inserta el 2º numero: ");
                int numero2 = int.Parse(Console.ReadLine());

                resultado = numero1 / numero2;
                System.Console.WriteLine($"El resultado de la suma entre {numero1} y {numero2} es: {resultado}");
                estados = 0;
            }
        tecla = Console.ReadKey();
        } while(tecla.Key != ConsoleKey.Escape);
    }
*/
#endregion

#region Ejercicio12
/*
Mostrar los múltiplos de 7 que hay entre 7 y 112.

    static void Main(string[] args)
    {
        int numMult7 = 7;
        int numMult7Fijo = 0;
        int numAcumulado = 1;

        do {
            numMult7Fijo++;
            numAcumulado = numMult7 * numMult7Fijo;
            System.Console.WriteLine($"Multiplo de 7: {numAcumulado}");
        } while(numAcumulado != 112); 
    }
*/
#endregion

#region Ejercicio13
/*
Pide un número, por ejemplo el 4, y saca en pantalla 1223334444.
Nota: Deber usar bucles for para hacerlo.

    static void Main(string[] args)
    {
        int num;
        Console.Clear();

        Console.WriteLine("Introduce un número");
        num=int.Parse(Console.ReadLine());

        for (int i = 1 ; i <= num ; i++) {
            for (int j = 0; j < i; j++) {
                    Console.Write(i);
            }
        }
    }
*/
#endregion

#region Ejercicio14
/*
Lee un número y escribe la suma de sus dígitos.
Nota: No puedes usar arrays porque aún no los hemos visto.

[ASI SE HARIA COMO SE PIDE EN EL ENUNCIADO]
    static void Main(string[] args)
    {
        int num, digito, suma;

        System.Console.WriteLine("Inserte el valor de un número entero:");
        num = Convert.ToInt32(Console.ReadLine());

        if(num == 0) {
            System.Console.WriteLine("El numero insertado es cero.");
        } else if(num < 0) {
            num = num * (-1);
        }

        digito = num - (num/10) * 10;
        suma = digito;

        do {
            num = (num - digito) / 10;
            digito = num - (num / 10) * 10;
            suma = suma + digito;
        } while(num !> 0);

        System.Console.WriteLine($"La suma de los digitos del numero entero es de: {suma}");
        Console.ReadLine();
    }

[ASI SE HARIA USANDO UN ARRAY QUE FACILITA TODO MAS]
    static void Main(string[] args)
    {        
        String numeros = "";
        char[] arrayNumeros;
        int suma = 0;

        System.Console.WriteLine("Introduce el numero: ");
        numeros = Console.ReadLine();
        arrayNumeros = numeros.ToCharArray();

        foreach (char numero in arrayNumeros) {
            Console.WriteLine("numero: " + numero);
            suma += int.Parse(numero.ToString());
        }
        Console.WriteLine("suma: " + suma);
    }
*/
#endregion