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
            
            dni = IngresarInt("Ingrese el dni de la persona: ");
            apellido = IngresarString("Ingrese el apellido: ");
            nombre = IngresarString("Ingrese el nombre: ");
            fechaNacimiento = IngresarDateTime("Ingrese su fecha de nacimiento de la siguiente forma: x/xx/xx");
            email = IngresarString("Ingrese su Email: ");
            Persona p = new Persona(dni,apellido,nombre,fechaNacimiento, email);
            Console.WriteLine(fechaNacimiento);
            p.ObtenerEdad(); //se usan en el punto 2. 
            listaPersonas.Add(p);
            Console.WriteLine($"Se ha creado a la persona {p.Apellido} {p.Nombre} y se ha agregado a la lista.");

            foreach(Persona y in listaPersonas){ //despues se saca. 
                Console.WriteLine(y.Nombre);
            }
            break;

            case 2: 
            int numVotar=0;
            double promedioEdad = 0;
            int num1 = 0;
            int i = 0;
            Console.WriteLine("Estadisticas del censo:");
            Console.WriteLine("Cantidad de personas: " + listaPersonas.Count);
            bool siono = false;
            foreach(Persona x in listaPersonas){
                siono = x.PuedeVotar();
                if(siono == true){                                // pasarlo a funcion.
                    numVotar++;
                }
            }
            Console.WriteLine($"Cantidad de personas habilitadas para votar: {numVotar}");
            foreach(Persona b in listaPersonas){
                num1 += b.ObtenerEdad();              //PASARLO ESTO JUNTO A PUEDEVOTAR EN UNA FUNCION... 
                i++;
            }
            promedioEdad = num1/i;
            Console.WriteLine($"El promedio de la edad es: {promedioEdad}");
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
