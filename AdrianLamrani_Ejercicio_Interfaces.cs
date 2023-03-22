#region Ejercicio1
/*
using System;
interface IFigura {
    void Dibuja();
    float Area();
    float Perimetro();
}
class Cuadrado : IFigura {
    private float lado;

    public Cuadrado(float lado) {
        this.lado = lado;
    }

    public void Dibuja() {
        const int centroX = 39;
        const int centroY = 11;

        Console.SetCursorPosition(centroX - (int)lado / 2, centroY - (int)lado / 2);
        for (int i = 0; i < lado; i++) {
            for (int j = 0; j < lado; j++) {
                Console.Write("* ");
            }
            Console.SetCursorPosition(centroX - (int)lado / 2, Console.CursorTop + 1);
        }
        Console.SetCursorPosition(0, 0);
    }

    public float Perimetro() {
        return 4f * lado;
    }

    public float Area() {
        return lado * lado;
    }
}

class Rectangulo : IFigura {
    private float _base;
    private float altura;

    public Rectangulo(float _base, float altura) {
        this._base = _base;
        this.altura = altura;
    }

    public void Dibuja() {
        const int centroX = 39;
        const int centroY = 11;

        Console.SetCursorPosition(centroX - (int)_base / 2, centroY - (int)altura / 2);
        for (int i = 0; i < altura; i++) {
            for (int j = 0; j < _base; j++) {
                Console.Write("* ");
            }
            Console.SetCursorPosition(centroX - (int)_base / 2, Console.CursorTop + 1);
        }
        Console.SetCursorPosition(0, 0);
    }

    public float Area() {
        return _base * altura;
    }

    public float Perimetro() {
        return 2f * _base + 2f * altura;
    }
}

class Circulo : IFigura {
    private float radio;

    public Circulo(float radio) {
        this.radio = radio;
    }

    public void Dibuja() {
        const int centroX = 39;
        const int centroY = 11;

        for (double anguloProyeccion_rad = 0; anguloProyeccion_rad < 2 * Math.PI; anguloProyeccion_rad += Math.PI / 8) {
            int proyeccionEjeX = Convert.ToInt32(Math.Round(Math.Cos(anguloProyeccion_rad) * radio));
            int proyeccionEjeY = Convert.ToInt32(Math.Round(Math.Sin(anguloProyeccion_rad) * radio));
            Console.SetCursorPosition(centroX + proyeccionEjeX * 2, centroY + proyeccionEjeY);
            Console.Write("*");
        }
        Console.SetCursorPosition(0, 0);
    }

    public float Area() {
        return (float)Math.PI * radio * radio;
    }

    public float Perimetro() {
        return (float)Math.PI * radio * 2f;
    }
}

class Program {
    public static void MuestraMenuPrincipal() {
        Console.WriteLine(
            "[1] Círculo\n" +
            "[2] Cuadrado\n" +
            "[3] Rectángulo\n" +
            "[ESC] Salir");
    }

    public static void MuestraMenuFigura() {
        Console.WriteLine(
            "[1] Dibujar\n" +
            "[2] Área\n" +
            "[3] Perímetro\n" +
            "[ESC] Salir");
    }

    public static Circulo IntroduceCirculo() {
        Console.Write("Introduce longitud del radio (de 3 a 7): > ");
        float radio = float.Parse(Console.ReadLine());

        if (radio < 3 && radio > 7)
            throw new OverflowException();

        return new Circulo(radio);
    }

    public static Cuadrado IntroduceCuadrado() {
        Console.Write("Introduce longitud del lado (de 3 a 7): > ");
        float lado = float.Parse(Console.ReadLine());

        if (lado < 3 && lado > 7)
            throw new OverflowException();

        return new Cuadrado(lado);
    }

    public static Rectangulo IntropduceRectangulo() {
        Console.Write("Introduce longitud de la base (de 3 a 7): > ");
        float _base = float.Parse(Console.ReadLine());

        Console.Write("Introduce longitud de la altura (de 3 a 7): > ");
        float altura = float.Parse(Console.ReadLine());

        if (_base < 3 && _base > 7 || altura < 3 && altura > 7)
            throw new OverflowException();

        return new Rectangulo(_base, altura);
    }

    public static void GetionMenuFigura(IFigura figura) {
        ConsoleKeyInfo tecla = new ConsoleKeyInfo();

        do {
            MuestraMenuFigura();
            tecla = Console.ReadKey(true);
            Console.Clear();

            switch (tecla.KeyChar) {
                case '1':
                    figura.Dibuja();
                    break;
                case '2':
                    Console.WriteLine($"{figura.Area():F2} unidades\n");
                    break;
                case '3':
                    Console.WriteLine($"{figura.Perimetro():F2} unidades\n");
                    break;
                default:
                    break;
            }
        } while (tecla.Key != ConsoleKey.Escape);
    }

    static void Main(string[] args) {
        ConsoleKeyInfo tecla = new ConsoleKeyInfo();
        do {
            IFigura figura = null;
            MuestraMenuPrincipal();
            tecla = Console.ReadKey(true);
            Console.Clear();
            try {

                switch (tecla.KeyChar) {
                    case '1':
                        figura = IntroduceCirculo();
                        break;
                    case '2':
                        figura = IntroduceCuadrado();
                        break;
                    case '3':
                        figura = IntropduceRectangulo();
                        break;
                    default:
                        break;
                }
                if (figura != null && tecla.Key != ConsoleKey.Escape)
                    GetionMenuFigura(figura);
            }
            catch (FormatException) {
                Console.WriteLine("Parámetros no válidos");
            }
            catch (OverflowException) {
                Console.WriteLine("Parámetro no válido, introduce nñumeros positivos entre 3 y 7");
            }
            catch (ArgumentOutOfRangeException) {
                Console.WriteLine("No es posible dibuja la figura, se sale del cuadro. Elija una más pequeña");
            }
        } while (tecla.Key != ConsoleKey.Escape);
    }
}
*/
#endregion


#region Ejercicio2
/*
using System;
interface IVisualizable {
    void Visualiza();
}

interface IEstudios {
    void MostrarEdadMinima();
}

abstract class Estudios : IEstudios, IVisualizable {
    private string nombre;
    private uint duracion;

    public Estudios(string nombre, uint duracion) {
        this.nombre = nombre;
        this.duracion = duracion;
    }
    
    public abstract void MostrarEdadMinima();

    public virtual void Visualiza() {
        Console.WriteLine($"Estudios: {nombre}");
        Console.WriteLine($"Duración: {duracion} semanas");
    }
}

class Elemental : Estudios {
    public Elemental(string nombre, uint duracion) : base(nombre, duracion) { ; }

    public override void MostrarEdadMinima() {
        Console.WriteLine("12 años");
    }
}

class Medio : Estudios {
    Superior accesoSuperior;

    public Medio(string nombre, uint duracion, Superior accesoSuperior) : base(nombre, duracion) {
        this.accesoSuperior = accesoSuperior;
    }

    public void AccesoSuperior() {
        Console.WriteLine($"Estos estudios dan acceso a:");
        accesoSuperior.Visualiza();
    }

    public override void MostrarEdadMinima() {
        Console.WriteLine("16 años");
    }
}

class Superior : Estudios {
    private string lugar;

    public Superior(string nombre, uint duracion, string lugar) : base(nombre, duracion) {
        this.lugar = lugar;
    }

    public override void MostrarEdadMinima() {
        Console.WriteLine("18 años");
    }

    public override void Visualiza() {
        base.Visualiza();
        Console.WriteLine($"Lugar: {lugar}");
    }
}

class Program {
    public static void MostrarEstudios(IVisualizable[] estudios) {
        for (int i = 0; i < estudios.Length; i++) {
            if (estudios[i] is IVisualizable == false)
                throw new ArgumentException();
            estudios[i].Visualiza();
        }
    }
    static void Main(string[] args) {
        Estudios[] estudios = new Estudios[3];

        estudios[0] = new Superior("DAM", 35, "IES Doctor Balmis");
        estudios[1] = new Medio("SMR", 35, new Superior("DAM", 35, "IES Doctor Balmis"));
        estudios[2] = new Elemental("3º ESO", 35);

        MostrarEstudios(estudios);

        Medio pruebaMedio = estudios[1] as Medio;
        pruebaMedio.Visualiza();
        pruebaMedio.AccesoSuperior();
    }
}
*/
#endregion


#region Ejercicio3
/*
using System;
enum MediaState {Stopped, Paused, Playing}
interface IMedia {
    string MessageToDisplay { get; }
    void Play();
    void Stop();
    void Pause();
    void Next();
    void Previous();
}
class DABRadioCD : IMedia {
    private IMedia ActiveDevice { get; set; }
    public Disc InsertCD { get; set; }
    public string MessageToDisplay { get; set; }
    private CDPlayer cd;
    private DABRadio radio;
    private Disc disc;
    private int num;

    public DABRadioCD(Disc disc) {
        radio = new DABRadio();
        cd = new CDPlayer();
        this.disc = new Disc(disc.Album, disc.Artist, disc.Songs);
        ActiveDevice = radio;
        num = disc.NumTracks;
        Stop();
    }
    public void ExtractCD() {}
    public void SwitchMode(bool modo) {
        if(modo == false) {
            ActiveDevice = radio;
        } else if(modo == true){
            ActiveDevice = cd;
        }
    }
    public void Play() { 
        if(ActiveDevice == radio) {
            MessageToDisplay = $"HEARING... FM - {radio.Frequency} MHz"; 
        } else {
            MessageToDisplay = $"PLAYING... Album: {disc.Album} Artist: {disc.Artist} Track {cd.track} - {disc.NombreCancion(cd.track)}"; 
        }
    }
    public void Stop(){
        if(ActiveDevice == radio) 
            MessageToDisplay = "RADIO OFF"; 
        else 
            MessageToDisplay = $"STOPPED... Album: {disc.Album} Artist: {disc.Artist}"; 
    }
    public void Pause(){
        if(ActiveDevice == radio) 
            MessageToDisplay = $"PAUSED - BUFFERING... FM - {radio.Frequency} MHz"; 
        else 
            MessageToDisplay = $"PAUSED... Album: {disc.Album} Artist: {disc.Artist} Track {cd.track} - {disc.NombreCancion(cd.track)}"; 
    }
    public void Next(){
        if(ActiveDevice == radio) {
            if(radio.Frequency > radio.MAX_FREQUENCY) {
                radio.Frequency -= radio.SEEK_STEP;
                MessageToDisplay = "Nivel Maximo Alcanzado";
            } else {
                radio.Frequency += radio.SEEK_STEP;
                MessageToDisplay = $"Frecuencia {radio.Frequency}";
            }
        } else {
            if(cd.track > disc.NumTracks) {
                cd.track -= 1;
                MessageToDisplay = "Ya estas reproduciendo el ultimo track";
            } else {
                cd.track += 1;
                MessageToDisplay = $"Track: {cd.track}";
            }    
        }
    }
    public void Previous(){
        if(ActiveDevice == radio) {
            if(radio.Frequency < radio.MIN_FREQUENCY) {
                radio.Frequency += radio.SEEK_STEP;
                MessageToDisplay = "Nivel mínimo Alcanzado";
            } else {
                radio.Frequency -= radio.SEEK_STEP;
                MessageToDisplay = $"Frecuencia {radio.Frequency}";
            }
        } else {
            if(cd.track <= 0) {
                cd.track += 1;
                MessageToDisplay = "Ya estas reproduciendo el primer track";
            } else {
                cd.track -= 1;
                MessageToDisplay = $"Track: {cd.track}";
            }
        }
    }
}
class CDPlayer : IMedia {
    public int track { get; set; }
    public MediaState State { get; set; }
    public bool MediaIn { get; set; }
    public string MessageToDisplay { get; set; }
    public Disc disc;

    public CDPlayer() {
        track = 1;
        State = MediaState.Stopped;
        MediaIn = default;
        disc = null;
        
    }
    public void InsertMedia(Disc media) {
        disc = media;
        MediaIn = true;
    }
    public bool ExtractMedia() {
        disc = null;
        MediaIn = false;

        return MediaIn;
    }
    public void Play() {} 
    public void Stop() {}
    public void Pause() {}
    public void Next() {}
    public void Previous() {}
}
class DABRadio : IMedia {
    public float SEEK_STEP = 0.5f;
    public float MAX_FREQUENCY = 108f;
    public float MIN_FREQUENCY = 87.5f;

    public float Frequency { get; set; }
    private MediaState State { get; set; }
    public string MessageToDisplay{ get; set; } 

    public DABRadio() {
        Frequency = MIN_FREQUENCY;
        State = MediaState.Stopped;
    }
    public void Play() {}
    public void Stop() {}
    public void Pause() {}
    public void Next() {}
    public void Previous() {}
}

class Disc : CDPlayer {
    public string Album { get; set; }
    public string Artist { get; set; }
    public string[] Songs { get; set; }
    public int NumTracks { get; set; }

    public Disc(string album, string artist, string[] songs) : base() {
        this.Album = album;
        this.Artist = artist;
        this.Songs = songs;
        NumTracks = Songs.Length;
    }
    public string NombreCancion(int song) {
        if(song > NumTracks || song <= 0) {
            throw new ArgumentOutOfRangeException("No hay ninguna canción con este número");
        }
        return Songs[song];
    }
    public override string ToString() {
        return base.ToString();
    }
}

class Program {
    private static void Main(string[] args) {
        bool modo = false;
        string modoRadio = "RADIO";
        string[] canciones = { "Wanna Be Startin' Somethin", "Baby Be Mine", "The Girl Is Mine", "Thriller", "Beat It",
        "Billie Jean", "Human Nature", "P.Y.T. (Pretty Young Thing)", "The Lady in My Life"};
        Disc thriller = new Disc("Thriller", "Michael Jackson", canciones);
        DABRadioCD radioCD = new DABRadioCD(thriller);
        ConsoleKeyInfo tecla = new ConsoleKeyInfo();
        do {
            try {
                Console.Clear();
                Console.WriteLine($"MODO: {modoRadio}\n" +
                                  $"{radioCD.MessageToDisplay}\n" + 
                                  $"[1]Play [2]Pause [3]Stop [4]Prev [5]Next [6]Switch [7]Insert CD [8]Extract CD, [ESC]Turn off");
                tecla = Console.ReadKey(true);
                Console.Clear();
                switch (tecla.KeyChar) {
                    case '1':
                        radioCD.Play();
                        break;
                    case '2':
                        radioCD.Pause();
                        break;
                    case '3':
                        radioCD.Stop();
                        break;
                    case '4':
                        radioCD.Previous();
                        break;
                    case '5':
                        radioCD.Next();
                        break;
                    case '6':
                        if(modo == false) {
                            modo = true;
                            modoRadio = "CD";
                        } else {
                            modo = false;
                            modoRadio = "RADIO";
                        }
                        radioCD.SwitchMode(modo);
                        break;
                    case '7':
                        radioCD.InsertCD = thriller;
                        break;
                    case '8':
                        radioCD.ExtractCD();
                        break;
                    default:
                        break;
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        } while (tecla.Key != ConsoleKey.Escape);
    }
}
*/
#endregion