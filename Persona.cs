class Persona{
    public int DNI{get;set;}
    public string Apellido {get;set;}
    public string Nombre {get; set;}
    public DateTime FechaNacimiento {get; set;}
    public string Email {get; set;}

    public void PersonaMetodo(int dni, string apellido, string nombre, DateTime fechaNacimiento, string email){
        DNI = dni;
        Apellido = apellido;
        Nombre = nombre;
        FechaNacimiento = fechaNacimiento;
        Email = email;
    }

    // public bool PuedeVotar(){
    //     if(FechaNacimiento.Year >= DateTime.Today.Year){

    //     }
    // }

}