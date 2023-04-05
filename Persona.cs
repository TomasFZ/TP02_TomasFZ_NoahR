class Persona{
    public int DNI{get;set;}
    public string Apellido {get;set;}
    public string Nombre {get; set;}
    public DateTime FechaNacimiento {get; set;}
    public string Email {get; set;}
    
    public Persona(int dni, string apellido, string nombre, DateTime fechaNacimiento, string email){
        DNI = dni;
        Apellido = apellido;
        Nombre = nombre;
        FechaNacimiento = fechaNacimiento;
        Email = email;
    }
    
    public bool PuedeVotar(){
        bool verdadero = false;
        int edad = ObtenerEdad();
        if(edad >= 16){
            verdadero = true;
        }
        return verdadero;
    }

    public int ObtenerEdad(){
        int edadPersona = DateTime.Today.Year - FechaNacimiento.Year;
        return edadPersona;
    }

}