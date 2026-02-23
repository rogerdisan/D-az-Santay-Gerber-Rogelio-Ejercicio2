Console.WriteLine("=== Control de Acceso Laboratorio ===");
Console.WriteLine("1. Estudiante");
Console.WriteLine("2. Docente");
Console.WriteLine("3. Tecnico IT");
Console.WriteLine("4. Visitante");
Console.Write("Seleccione rol: ");

int rol = int.Parse(Console.ReadLine());

switch (rol)
{
    case 1: // Estudiante
        Console.Write("Hora (0-23): ");
        int hora1 = int.Parse(Console.ReadLine());
        if (hora1 < 0 || hora1 > 23)
        {
            Console.WriteLine("Hora no valida");
            break;
        }

        if (hora1 < 7 || hora1 > 18)
        {
            Console.WriteLine("Fuera de horario");
            break;
        }

        Console.Write("Dia (1-7): ");
        int dia1 = int.Parse(Console.ReadLine());
        if (dia1 < 1 || dia1 > 7)
        {
            Console.WriteLine("Dia no valido");
            break;
        }

        if (dia1 < 1 || dia1 > 5)
        {
            Console.WriteLine("Solo Lunes a Viernes");
            break;
        }

        Console.Write("Carnet vigente (S/N): ");
        char carnet1 = char.Parse(Console.ReadLine().ToUpper());
        if (carnet1 != 'S')
        {
            Console.WriteLine("Necesita carnet vigente");
            break;
        }

        Console.Write("Trae USB (S/N): ");
        char usb1 = char.Parse(Console.ReadLine().ToUpper());

        if (usb1 == 'S')
        {
            Console.WriteLine("Acceso: Permitido - Nivel: Basico con USB");
        }
        else
        {
            Console.WriteLine("Acceso: Permitido - Nivel: Basico");
        }
        break;
