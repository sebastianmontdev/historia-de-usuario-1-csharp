using ClinicaSalud.models;

namespace ClinicaSalud.models;

public class PacienteService
{
    // 1. Registrar Paciente
    public void RegistrarPaciente(List<Paciente> lista)
    {
        try
        {
            Paciente nuevo = new Paciente();

            Console.Write("Ingrese ID: ");
            nuevo.Id = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Ingrese Nombre: ");
            nuevo.Nombre = Console.ReadLine() ?? string.Empty;

            Console.Write("Ingrese Edad: ");
            nuevo.Edad = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Ingrese Síntoma: ");
            nuevo.Sintoma = Console.ReadLine() ?? string.Empty;

            lista.Add(nuevo);
            Console.WriteLine("Paciente registrado con exito.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada invalida: ID y Edad deben ser numeros enteros.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Entrada fuera de rango: ingrese un numero entero mas pequeno.");
        }
    }

    // 2. Listar Pacientes
    public void ListarPacientes(List<Paciente> lista)
    {
        Console.WriteLine("\n--- Lista de Pacientes ---");
        foreach (var p in lista)
        {
            Console.WriteLine($"ID: {p.Id} | Nombre: {p.Nombre} | Síntoma: {p.Sintoma}");
        }
    }

    // 3. Buscar por Nombre
    public void BuscarPacientePorNombre(List<Paciente> lista, string nombre)
    {
        var encontrado = lista.Find(p => p.Nombre.ToLower().Contains(nombre.ToLower()));
        if (encontrado != null)
        {
            Console.WriteLine($"Encontrado: {encontrado.Nombre} - Edad: {encontrado.Edad} - Síntoma: {encontrado.Sintoma}");
        }
        else
        {
            Console.WriteLine("Paciente no encontrado.");
        }
    }
}