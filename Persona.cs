using System;

public class Persona
{
	public Persona()
	{
		private string nombre;
		private int edad;
		private string direccion;
		private string CorreoElectronico;

	public Persona(string nombre, int edad, string direccion, string CorreoElectronico)
	{
		this.nombre = nombre;
		this.edad = edad;
		this.direccion = direccion;
		this.CorreoElectronico = CorreoElectronico;
	}
	public void ImprimirDatos()
	{
        Console.WriteLine($"NOMBRE: {nombre}");
        Console.WriteLine($"EDAD: {edad}");
        Console.WriteLine($"DIRECCIÓN: {direccion}");
        Console.WriteLine($"CORREO ELECTRÓNICO: {correoElectronico}");
        Console.WriteLine("\n");
        Console.WriteLine("-----------------------------------------------------");
    }
	public string CorreoElectronico
	{ get { return CorreoElectronico; }
	}
}
public class CorreoElectronico
{
	public void EnviarCorreo (string destinario, string mensaje)
	{
        // Lógica para enviar correo electrónico
        Console.WriteLine($"CORREO ENVIADO A:  {destinatario}");
        Console.WriteLine("MENSAJE:\n");
        Console.WriteLine($"{mensaje}");
        Console.WriteLine("--------------------------------------------------------");
    }
}
class Program
{
	static void Main()
	{
        // Solicitar datos al usuario
        Console.WriteLine("NOMBRE:");
        string nombre = Console.ReadLine();

        Console.WriteLine("EDAD:");
        int edad = int.Parse(Console.ReadLine());

        Console.WriteLine("DIRECCIÓN:");
        string direccion = Console.ReadLine();

        Console.WriteLine("CORREO ELECTRÓNICO:");
        string correoElectronico = Console.ReadLine();
        Console.WriteLine("\n");
        Console.WriteLine("----------------------------------------------------------");

        // Crear la instancia de Persona
        Persona persona = new Persona(nombre, edad, direccion, correoElectronico);
        persona.ImprimirDatos();

        // Solicitar el mensaje al usuario
        Console.WriteLine("ASUNTO:");
        string mensaje = Console.ReadLine();
        Console.WriteLine("\n");
        Console.WriteLine("-----------------------------------------------------------");

        // Enviar el correo electrónico
        CorreoElectronico correo = new CorreoElectronico();
        correo.EnviarCorreo(persona.CorreoElectronico, mensaje);
    }
}
