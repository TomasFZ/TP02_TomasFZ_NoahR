namespace TP02_CensoNacional;
class Program
{
    static void Main(string[] args)
    {
        int dni = 0;
        string apellido = "";
        string nombre = "";
        int numMenu = 0;
        DateTime fechaNacimiento = new DateTime();
        string email = "";
        List<Persona> listaPersonas = new List<Persona>();
        do{
        numMenu = IngresarInt("Ingrese un numero para seleccionar una opción. 1. Cargar nueva persona. 2. Obtener características del censo. 3. Buscar persona. 4. Modificar mail de una persona. 5. Salir");
        switch(numMenu){
            case 1: 
            Persona p = new Persona();
            dni = IngresarInt("Ingrese el dni de la persona: ");
            apellido = IngresarString("Ingrese el apellido: ");
            nombre = IngresarString("Ingrese el nombre: ");
            fechaNacimiento = IngresarDateTime("Ingrese su fecha de nacimiento de la siguiente forma: x/xx/xx");
            email = IngresarString("Ingrese su Email: ");
            Console.WriteLine(fechaNacimiento);
            p.PersonaMetodo(dni,apellido,nombre,fechaNacimiento, email);
            p.ObtenerEdad();
            p.PuedeVotar();
            listaPersonas.Add(p);
            foreach(Persona y in listaPersonas){
                Console.WriteLine(y);
            }
            break;

            case 2: 
            break;

            case 3: 
            break;

            case 4: 
            break;

            case 5: 
            break;
        }
            }while(numMenu != 5);
    }


    static int IngresarInt(string mensaje){
        int num = 0;
        Console.WriteLine(mensaje);
        num = int.Parse(Console.ReadLine());
        return num;
    }
    static string IngresarString(string mensaje){
        string palabra; 
        Console.WriteLine(mensaje);
        palabra = Console.ReadLine();
        return palabra;
    }
    static DateTime IngresarDateTime(string mensaje){
        Console.WriteLine(mensaje);
        DateTime fechaIngresada = DateTime.Parse(Console.ReadLine());
        return fechaIngresada;
    }
}
