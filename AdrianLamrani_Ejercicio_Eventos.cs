#region Ejercicio1
/*
class Program {
    private static void Main(string[] args) {
        using var watcher = new FileSystemWatcher("test");
        watcher.NotifyFilter = NotifyFilters.FileName;
        watcher.Renamed += OnRenamed;

        watcher.Filter = "*.txt";
        watcher.IncludeSubdirectories = true;
        watcher.EnableRaisingEvents = true;

        System.Console.WriteLine("Presiona enter para salir.");
        Console.ReadLine();
    }
    private static void OnRenamed(object sender, RenamedEventArgs e) {
        Console.WriteLine($"Renamed:");
        Console.WriteLine($"    Old: {e.OldFullPath}");
        Console.WriteLine($"    New: {e.FullPath}");
    }
}
*/
#endregion


#region Ejercicio2
/*
class Cajero {
    public int numCajero { get; }
    public event EventHandler<RetiradaEfectivoEventArgs> RetiradaDeEfectivo;

    public Cajero(int numCajero) {
        this.numCajero = numCajero;
    }

    public void RetiraEfectivo(string dni, int cantidad) {
        System.Console.WriteLine("Realizando operacion...");
        Thread.Sleep(2000);
        System.Console.WriteLine("Operacion realizada con éxito.");

        RetiradaDeEfectivo?.Invoke(this, new RetiradaEfectivoEventArgs(dni, cantidad));
    }
}

class RetiradaEfectivoEventArgs : EventArgs {
    public string dni { get; set; }
    public int cantidad { get; set; }
    public DateTime fecha { get; set; }

    public RetiradaEfectivoEventArgs(string dni, int cantidad) {
        this.dni = dni;
        this.cantidad = cantidad;
        fecha = DateTime.Now;
    }
}

class EnvioEmail {
    public void EnviarAvisoRetiradaDeEfectivo(object sender, RetiradaEfectivoEventArgs e) {
        Console.WriteLine($"Buscando datos usuario {e.dni}...");
        Console.WriteLine($"Enviando email al usuario {e.dni} de retirada de {e.cantidad} el día {e.fecha.ToShortDateString()} a las {e.fecha.ToShortTimeString()} horas.");
    }
}

class EnvioSMS {
    public void EnviarAvisoRetiradaDeEfectivo(object sender, RetiradaEfectivoEventArgs e) {
        Console.WriteLine($"Buscando datos usuario {e.dni}...");
        Console.WriteLine($"Enviando SMS al usuario {e.dni} de retirada de {e.cantidad} el día {e.fecha.ToShortDateString()} a las {e.fecha.ToShortTimeString()} horas.");
    }
}

class Program {
    private static void Main(string[] args) {
        Console.Clear();
        Cajero cajero = new Cajero(1);

        EnvioEmail envioEmail = new EnvioEmail();
        EnvioSMS envioSMS = new EnvioSMS();

        cajero.RetiradaDeEfectivo += envioEmail.EnviarAvisoRetiradaDeEfectivo;
        cajero.RetiradaDeEfectivo += envioSMS.EnviarAvisoRetiradaDeEfectivo;

        cajero.RetiraEfectivo("12345678A", 50);

        Console.ReadKey();
    }
}
*/
#endregion


#region Ejercicio3
/*
using System;
using System.Collections.Generic;
using System.IO;
class ConsoleKeyLog {
    private List<string> teclasPulsadas = new List<string>();

    public event Action<List<string>> GestionTeclasPulsadasTrasFinalizar;

    public void BucleLogConsola() {
        Console.CancelKeyPress += Console_CancelKeyPress;

        while (true) {
            ConsoleKeyInfo tecla = Console.ReadKey(true);
            string textoTecla = TextoTecla(tecla.Modifiers, tecla.Key);
            teclasPulsadas.Add(textoTecla);
            Console.Write(textoTecla);
        }
    }

    private void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e) {
        GestionTeclasPulsadasTrasFinalizar?.Invoke(teclasPulsadas);

        Console.WriteLine("Programa finalizado.");
        Environment.Exit(0);
    }

    private static string TextoTecla(ConsoleModifiers m, ConsoleKey t) {
        string txt = "";
        if ((m & ConsoleModifiers.Alt) == ConsoleModifiers.Alt) txt += "Alt + ";
        if ((m & ConsoleModifiers.Control) == ConsoleModifiers.Control) txt += "Control + ";
        if ((m & ConsoleModifiers.Shift) == ConsoleModifiers.Shift) txt += "Shift + ";
        txt += t.ToString();
        return txt;
    }
}

class Program {
    static void Main(string[] args) {
        ConsoleKeyLog consoleKeyLog = new ConsoleKeyLog();
        consoleKeyLog.GestionTeclasPulsadasTrasFinalizar += ConsoleKeyLog_GestionTeclasPulsadasTrasFinalizar;
        consoleKeyLog.BucleLogConsola();
    }

    private static void ConsoleKeyLog_GestionTeclasPulsadasTrasFinalizar(List<string> teclasPulsadas) {
        using (StreamWriter sw = new StreamWriter("teclas.log")) {
            foreach (string tecla in teclasPulsadas) {
                sw.WriteLine(tecla);
            }
        }
    }
}
*/
#endregion


#region Ejercicio4
/*
class Cajero {
    public int numCajero { get; }
    public event EventHandler<RetiradaEfectivoEventArgs> RetiradaDeEfectivo;

    public Cajero(int numCajero) {
        this.numCajero = numCajero;
    }

    public void RetiraEfectivo(string dni, int cantidad) {
        System.Console.WriteLine("Realizando operacion...");
        Thread.Sleep(2000);
        System.Console.WriteLine("Operacion realizada con éxito.");

        RetiradaDeEfectivo?.Invoke(this, new RetiradaEfectivoEventArgs(dni, cantidad));
    }
}

class RetiradaEfectivoEventArgs : EventArgs {
    public string dni { get; set; }
    public int cantidad { get; set; }
    public DateTime fecha { get; set; }

    public RetiradaEfectivoEventArgs(string dni, int cantidad) {
        this.dni = dni;
        this.cantidad = cantidad;
        fecha = DateTime.Now;
    }
}

class EnvioEmail {
    public void EnviarAvisoRetiradaDeEfectivo(object sender, RetiradaEfectivoEventArgs e) {
        Console.WriteLine($"Buscando datos usuario {e.dni}...");
        Console.WriteLine($"Enviando email al usuario {e.dni} de retirada de {e.cantidad} el día {e.fecha.ToShortDateString()} a las {e.fecha.ToShortTimeString()} horas.");
    }
}

class EnvioSMS {
    public void EnviarAvisoRetiradaDeEfectivo(object sender, RetiradaEfectivoEventArgs e) {
        Console.WriteLine($"Buscando datos usuario {e.dni}...");
        Console.WriteLine($"Enviando SMS al usuario {e.dni} de retirada de {e.cantidad} el día {e.fecha.ToShortDateString()} a las {e.fecha.ToShortTimeString()} horas.");
    }
}

class BaseDeDatos {
    public void RegistrarRetirada(object sender, RetiradaEfectivoEventArgs e) {
        Console.WriteLine($"Registrando operación en la base de datos: usuario {e.dni}, cantidad {e.cantidad}");
    }
}

class Program {
    static void Main(string[] args) {
        Console.Clear();
        Cajero cajero = new Cajero(1);

        EnvioEmail envioEmail = new EnvioEmail();
        EnvioSMS envioSMS = new EnvioSMS();
        BaseDeDatos bd = new BaseDeDatos();

        cajero.RetiradaDeEfectivo += envioEmail.EnviarAvisoRetiradaDeEfectivo;
        cajero.RetiradaDeEfectivo += envioSMS.EnviarAvisoRetiradaDeEfectivo;
        cajero.RetiradaDeEfectivo += bd.RegistrarRetirada;

        cajero.RetiraEfectivo("12345678A", 50);

        Console.ReadKey();
    }
}
*/
#endregion