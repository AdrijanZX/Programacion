/*
Ejercicio: Arrays
Alumno: Adrián Lamrani Castellanos
Curso: 1º DAM
Grupo: A
*/

#region Ejercicio1
/*
using System.Text;
class Program {
    public static void Main(string[] args) {
        int n = 0;
        System.Console.Write("Introduce el tamaño del array: ");
        n = int.Parse(Console.ReadLine());
        Random random = new Random();
        string[] arrayNums = new string [n];
        for(int i = 0; i < arrayNums.Length; i++) {
            int numero = random.Next(0, 100+1);
            arrayNums[i] = numero.ToString();
        }
        foreach(string mensaje in arrayNums) {
            System.Console.WriteLine($"{mensaje}");
        }
    }
}
*/
#endregion


#region Ejercicio2
/*
using System.Text;
class Program {
    public static void Main(string[] args) {
        int n = 10;
        string parImpar = "";
        Random random=new Random();
        string[] arrayNums = new string [n];
        for(int i = 0; i < arrayNums.Length; i++) {
            double numero=random.NextDouble() * 100d;
            arrayNums[i] = numero.ToString();
            if((int)numero % 2 == 0) {
                parImpar = "par";
            } else {
                parImpar = "impar";
            }
            if((int)numero % 4 == 0) {
                System.Console.WriteLine($"numArray: {arrayNums[i]} // Es {parImpar} y múltiplo de 4");
            }
        }
    }
}
*/
#endregion


#region Ejercicio3
/*
using System.Text;
class Program {
    public static void Main(string[] args) {
        int[] numeros = new int[10];
        for(int i = 0; i < numeros.Length; i++) {
            System.Console.Write("Introduce numero: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine($"Total: {numeros.Sum()}");
    }
}
*/
#endregion


#region Ejercicio4
/*
using System.Text;
class Program {
    public static void Main(string[] args) {
        Random random = new Random();
        char[] v = new char[10];
        for(int j = 0; j < v.Length; j++) {
            v[j] = (char)random.Next(65, 123);
            if(char.IsLower(v[j])) {
                char.ToUpper(v[j]);
            } else if(char.IsUpper(v[j])) {
                char.ToLower(v[j]);
            }
        }
        foreach(char datos in v) {
            System.Console.Write($"{datos} ");
        }
    }
}
*/
#endregion


#region Ejercicio5
/*
using System.Text;
class Program {
    public static void Main(string[] args) {
        Random random = new Random();
        int[] v = new int[10], p = new int[10];
        for(int j = 0; j < v.Length; j++) {
            v[j] = random.Next(0, 11);
            if(v[j] % 2 == 0)
                p[j] = v[j];
        }
        Array.Sort(p);
        foreach(int datos in p) {
            System.Console.Write($"{datos} ");
        }
    }
}
*/
#endregion


#region Ejercicio6
/*
using System.Text;
class Program {
    public static void Main(string[] args) {
        int[] array = new int[7];
        string mensaje = "", mensajeUpValue = "";
        int upperValue = 0;
        for(int i = 0; i < array.Length; i++) {
            System.Console.Write($"Introduce el valor que irá en la posición nº {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine()); /*El enunciado te indica números aleatorios*/
            mensaje += $"{array[i]}, ";
        }
        System.Console.WriteLine("Tenemos dentro del array los valores: " + mensaje);
        for(int i = 0; i < array.Length; i++) {
            if(upperValue < array[i]) {
                upperValue = array[i];
                mensajeUpValue = $"El valor mas alto se encuentra en la posición {i + 1} con el valor: {upperValue}";
            }
        }
        System.Console.WriteLine(mensajeUpValue);
    }
}
*/
#endregion


#region Ejercicio7
/*
using System.Text;
class Program {
    public static void Main(string[] args) {
        Random random = new Random();
        int[] v = new int[10], i = new int[10], p = new int[10];
        for(int j = 0; j < v.Length; j++) {
            v[j] = random.Next(0, 11);
            if(v[j] % 2 != 0)
                i[j] = v[j];
            else
                p[j] = v[j];
        }
        Array.Sort(p);
        Array.Sort(i);
        Array.Reverse(i);
        System.Console.WriteLine($"Pares: {String.Join(" - ", p)}\nImpares: {String.Join(" - ", i)}");
    }
}
*/
#endregion


#region Ejercicio8
/*
using System.Text;
class Program {
    public static void Main(string[] args) {
        string mensaje = default;
        int contador;
        System.Console.Write("Introduce numero para saber si es capicúa: ");
        char[] numero = Console.ReadLine().ToCharArray();
        contador = numero.Length;
        for(int i = 0; i < numero.Length; i++) {
            if(numero[i] == numero[contador - 1]) {
                mensaje = "Es capicúa.";
            } else {
                mensaje = "No es capicúa.";
                break;
            }
            contador--;
        }
        System.Console.WriteLine(mensaje);
    }
}
*/
#endregion


#region Ejercicio9
/*
using System.Text;
class Program {
    public static void Main(string[] args) {
        int opcion;
        bool activo = true;
        char[] contraseña = default;
        do {
            Console.Clear();
            opcion = Menu();
            switch(opcion) {
            case 1:
                contraseña = RegistroSistema();
                break;
            case 2:
                EntrarSistema(contraseña);
                break;
            case 3: activo = false;
                break;
            }
        } while(activo != false);
    }
    public static void EntrarSistema(char[] contraseñaN) {
        Console.Clear();
        System.Console.Write($"----------------------------------------\n" +
                             $"Entrar:\n\n" +
                             $"     Introduce la contraseña: ");
        char[] contraseña = Console.ReadLine().ToCharArray();
        if(contraseña.SequenceEqual(contraseñaN)) { /*Debes comprobar carácter a carácter*/
            System.Console.WriteLine("      La contraseña es correcta.");
        } else {
            System.Console.WriteLine("      La contraseña es incorrecta.");
        }
        System.Console.WriteLine($"\n----------------------------------------");
        Console.ReadLine();
    }
    public static char[] RegistroSistema() {
        Console.Clear();
        System.Console.Write($"----------------------------------------\n" +
                             $"Registrarse:\n\n" +
                             $"     Contraseña: ");
        string contraseña = Console.ReadLine();
        System.Console.Write($"     Comprobar contraseña: ");
        string repiteContraseña = Console.ReadLine(); /*Tienes que ir sustituyendo por * cada carácter*/
        System.Console.WriteLine($"\n----------------------------------------");

        if(contraseña.Length <= 20 && contraseña == repiteContraseña) { 
            return contraseña.ToCharArray();
        } else {
            return null;
        }
    }
    public static int Menu() {
        System.Console.Write($"1. Registrarse en el sistema.\n" +
                             $"2. Entrar al sistema.\n" +
                             $"3. Salir del programa.\n\n" +
                             $"Introduce una opción: ");
        return int.Parse(Console.ReadLine());
    }
}
*/
#endregion


#region Ejercicio10
/*
using System.Text;
class Program {
    public static void Main(string[] args) {
        Console.Clear();
        int[] notas = IntroducirNotas();
        System.Console.WriteLine(FrecuenciaNotas(notas));
    }
    public static string FrecuenciaNotas(int[] notas) {
        int contador = 0;
        string mensaje = "";
        for(int i = 0; i < notas.Length; i++) {
            contador = 0;
            for(int j = 0; j < notas.Length; j++) {
                if(i == (int)notas[j]) /*Este cast?? Pero si ya es int*/
                    contador++;
            }
            mensaje += $"[{contador}] ";
        }
        return mensaje;
    }
    public static int[] IntroducirNotas() {
        bool activo = true;
        int i = 0;
        int[] notas = new int[10];
        do {
            System.Console.Write("Introduce nota: ");
            notas[i] = int.Parse(Console.ReadLine());
            if(i == notas.Length - 1) {
                activo = false;   
            } else if(notas[i] > 10 || notas[i] < 0) {
                activo = false;
            }
            i++;
        } while(activo != false);
        return notas;
    }
}
*/
#endregion


#region Ejercicio11
/*
using System.Text;
class Program {
    public static void Main(string[] args) {
        int posInicial = 3;
        int posFinal = 7;
        int[] arrayInicial = {20,5,7,4,32,9,2,14,11,6};
        int[] arrayFinal = desplazamiento(arrayInicial,posInicial,posFinal);
        System.Console.WriteLine("Resultado: ");
        for (int i = 0; i < arrayFinal.Length; i++) {
            System.Console.WriteLine($"{i}) {arrayFinal[i]}");
        }
    }
    private static int[] desplazamiento(int[] arrayInicial, int posInicial, int posFinal){
        int[] arrayFinal = new int[10];
        for (int i = 0; i < arrayInicial.Length; i++) {
            arrayFinal[i] = arrayInicial[i];
        }
        if(posInicial >=0 && posFinal <10 && posInicial < posFinal){
            int numInicial = arrayInicial[posInicial];
            for (int i = posFinal; i < arrayInicial.Length-1; i++) {
                arrayFinal[i+1] = arrayInicial[i];
            }
            arrayFinal[0] = arrayInicial[arrayInicial.Length-1];
            for (int i = 1; i <= posInicial; i++) {
                arrayFinal[i] = arrayInicial[i - 1];
            }
        }
        return arrayFinal;
    }
}
*/
#endregion


#region Ejercicio12
/*
using System.Text;
class Program {
    public static void Main(string[] args) {
        int[] pol1 = new int[]{5, -7, -3, 0, 9};
        int[] pol2 = new int[]{-1, 0, 4};
        string mensaje = Conversion(pol2);
        
        System.Console.WriteLine(mensaje);
    }
    public static string Conversion(int[] pol) {
        string mensaje = "";
        int contador = pol.Length - 1;
        for(int i = pol.Length - 1; i > -1; i--) {
            if(i == 0 && pol[i] > 0) {
                mensaje += $"+{pol[i]}";
            } else if(i == 0 && pol[i] < 0) {
                mensaje += $"{pol[i]}";
            } else if(i == 1 && pol[i] > 0) {
                mensaje += $"+{pol[i]}x";
            } else if(i == 1 && pol[i] < 0) {
                mensaje += $"{pol[i]}x";
            } else if(i == pol.Length - 1) {
                mensaje += $"{pol[i]}x{contador}";
                contador--;
            } else {
                switch(pol[i]) {
                case 0:
                    contador--;
                    break;
                case > 0:
                    mensaje += $"+{pol[i]}x{contador}";
                    contador--;
                    break;
                default:
                    mensaje += $"{pol[i]}x{contador}";
                    contador--;
                    break;
                }
            }
        }
        return mensaje;
    }
}
*/
#endregion


