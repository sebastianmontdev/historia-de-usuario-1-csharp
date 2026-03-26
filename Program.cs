using ClinicaSalud.models;

// Iniciamos la lista y el servicio
List<Paciente> pacientes = new List<Paciente>();
PacienteService service = new PacienteService();
bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n--- Menu Clinica Salud ---");
    Console.WriteLine("1. Registrar paciente");
    Console.WriteLine("2. Listar pacientes");
    Console.WriteLine("3. Buscar paciente por nombre");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opcion: ");
    string opcion = Console.ReadLine() ?? string.Empty;
    
    switch (opcion)
    {
        case "1":
            service.RegistrarPaciente(pacientes);
            break;
        case "2":
            service.ListarPacientes(pacientes);
            break;
        case "3":
            Console.Write("Nombre a buscar: ");
            string busca = Console.ReadLine() ?? string.Empty;
            service.BuscarPacientePorNombre(pacientes, busca);
            break;
        case "4":
            continuar = false;
            break;
        default:
            Console.WriteLine("Opcion invalida. Intente nuevamente.");
            break;
    }
}