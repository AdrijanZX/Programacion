#region Ejercicio1
/*
using System.Text;
using System.Linq;
class Program {
    static void Main(string[] args) {
        string ruta = "ejercicio1.txt", solucion = default;
        bool activo = true;
        do {
            Console.Clear();
            System.Console.WriteLine("Menú opciones:\n" + 
                                    $"      1. Obtener extension.\n" +
                                    $"      2. Obtener el nombre del fichero.\n" + 
                                    $"      3. Obtener nombre del fichero sin extensión.\n" + 
                                    $"      4. Obtener directorio del fichero.\n" + 
                                    $"      5. Obtener directorio raíz.\n" + 
                                    $"      6. Cambiar extensión del fichero.\n" + 
                                    $"      7. Obtener ruta absoluta del fichero.\n" + 
                                    $"      8. Combinar ficheros.\n" + 
                                    $"      9. Salir.");
            System.Console.Write("Selecciona la opción: ");
            int opcion = int.Parse(Console.ReadLine());
            switch(opcion) {
                case 1:
                    solucion = Path.GetExtension(ruta);
                    break;
                case 2:
                    solucion = Path.GetFileName(ruta);
                    break;
                case 3:
                    solucion = Path.GetFileNameWithoutExtension(ruta);
                    break;
                case 4:
                    solucion = Path.GetDirectoryName(ruta);
                    break;
                case 5:
                    solucion = Path.GetPathRoot(ruta);
                    break;
                case 6:
                    solucion = Path.ChangeExtension(ruta, Console.ReadLine());
                    break;
                case 7:
                    solucion = Path.GetFullPath(ruta);
                    break;
                case 8:
                    solucion = Path.Combine(ruta, Console.ReadLine());
                    break;
                case 9:
                    System.Console.WriteLine("¡Nos vemos!");
                    activo = false;
                    break;
            }
            System.Console.WriteLine($"Obtenemos: {solucion}");
            Console.ReadLine();
        } while(activo != false);
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
        bool activo = true;
        do {
            Console.Clear();
            System.Console.WriteLine("Menú opciones:\n" + 
                                    $"      1. Crea arbol de directorios.\n" +
                                    $"      2. Elimina directorio.\n" + 
                                    $"      3. Elimina fichero.\n" + 
                                    $"      4. Muestra información.\n" + 
                                    $"      5. Muestra atributos.\n" +
                                    $"      6. Salir.");
            System.Console.Write("Selecciona la opción: ");
            int opcion = int.Parse(Console.ReadLine());
            switch(opcion) {
                case 1:
                    Directory.CreateDirectory("Arbol_Ejercicio2");
                    Directory.CreateDirectory("Arbol_Ejercicio2/nombres");
                    Directory.CreateDirectory("Arbol_Ejercicio2/nombres/pepe");
                    Directory.CreateDirectory("Arbol_Ejercicio2/nombres/pepe/datos");
                    File.Create("Arbol_Ejercicio2/nombres/pepe/documento.txt");
                    Directory.CreateDirectory("Arbol_Ejercicio2/nombres/juan");
                    System.Console.WriteLine("Creado correctamente el arbol de directorios.");
                    break;
                case 2:
                    System.Console.Write("Introduce el directorio que quieres eliminar: ");
                    Directory.Delete(Console.ReadLine());
                    break;
                case 3:
                    System.Console.Write("Introduce el fichero que quieres eliminar: ");
                    File.Delete(Console.ReadLine());
                    break;
                case 4:
                    System.Console.WriteLine($"Informacion del directorio: {Directory.GetFiles("Arbol_Ejercicio2")}");
                    break;
                case 5:
                    System.Console.Write("Introduce el fichero del que quieres ver los atributos: ");
                    File.GetAttributes(Console.ReadLine());
                    break;
                case 6:
                    System.Console.WriteLine("¡Nos vemos!");
                    activo = false;
                    break;
            }
            Console.ReadLine();
        } while(activo != false);
    }
}
*/
#endregion


#region Ejercicio3
/*
using System.Text;
using System.Linq;
class Program {
    static void listaCarpeta(string ruta) {
        try {
            System.Console.WriteLine($"Contenido: {Directory.GetDirectories(ruta)}");
        } catch(Exception e) {
            System.Console.WriteLine($"ERROR: {e}");
        }
    }
    static void creaDirectorio(string ruta) {
        try {
            Directory.CreateDirectory(ruta);
        } catch(Exception e) {
            System.Console.WriteLine($"ERROR: {e}");
        }
    }
    static void eliminaDirectorio(string ruta) {
        try {
            Directory.Delete(ruta);
        } catch(Exception e) {
            System.Console.WriteLine($"ERROR: {e}");
        }
    }
    static void eliminaFichero(string ruta) {
        try {
            File.Delete(ruta);
        } catch(Exception e) {
            System.Console.WriteLine($"ERROR: {e}");
        }
    }
    static void copiaFicheros(string rutaOrigen) {
        try {
            System.Console.Write("Introduce la ruta de destino: ");
            File.Copy(rutaOrigen, Console.ReadLine());
        } catch(Exception e) {
            System.Console.WriteLine($"ERROR: {e}");
        }
    }
    static void Main(string[] args) {
        bool activo = true;
        do {
            Console.Clear();
            System.Console.WriteLine("Menú opciones:\n" + 
                                    $"      1. Lista carpetas.\n" +
                                    $"      2. Crear directorios.\n" + 
                                    $"      3. Eliminar directorio.\n" + 
                                    $"      4. Eliminar ficheros.\n" + 
                                    $"      5. Copiar ficheros.\n" +
                                    $"      6. Salir.");
            System.Console.Write("Selecciona la opción: ");
            int opcion = int.Parse(Console.ReadLine());
            switch(opcion) {
                case 1:
                    System.Console.Write("Introduce la ruta: ");
                    listaCarpeta(Console.ReadLine());
                    break;
                case 2:
                    System.Console.Write("Introduce la ruta del nuevo directorio: ");
                    creaDirectorio(Console.ReadLine());
                    break;
                case 3:
                    System.Console.Write("Introduce la ruta del directorio a eliminar: ");
                    eliminaDirectorio(Console.ReadLine());
                    break;
                case 4:
                    System.Console.Write("Introduce la ruta del fichero a eliminar: ");
                    eliminaFichero(Console.ReadLine());
                    break;
                case 5:
                    System.Console.Write("Introduce la ruta del fichero a copiar: ");
                    copiaFicheros(Console.ReadLine());
                    break;
                case 6:
                    System.Console.WriteLine("¡Nos vemos!");
                    activo = false;
                    break;
            }
            Console.ReadLine();
        } while(activo != false);
    }
}
*/
#endregion


