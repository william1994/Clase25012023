using semana1.Entidades;
using semana1.Negocio;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Per es una variable/Objeto que va a ser utilizada para settear la informacion de la clase persona(Entidades).
Persona per = new Persona();
//clsPersona es una variable/Objeto que va a ser utilizada para invocar la logica de nuestra aplicacion
ClsTratamientoDePersonas clsPersona = new ClsTratamientoDePersonas();

//Console.ReadLine es utilizado para capturar la informacion del usuario

Console.ReadKey();
Console.WriteLine("Ingresa tu nombre");
String? VariableNombre = Console.ReadLine();
Console.WriteLine("Ingresa tu edad");
String? VariableEdad = Console.ReadLine();
int EdadConvert = Convert.ToInt32(VariableEdad);
per.Nombre = VariableNombre;
per.Edad = EdadConvert;



String Resultado =clsPersona.ObtenerNombrePersona(per);
String ResultadoEdad = clsPersona.MayorDeEdad(per);
Console.WriteLine(Resultado);
Console.WriteLine(ResultadoEdad);