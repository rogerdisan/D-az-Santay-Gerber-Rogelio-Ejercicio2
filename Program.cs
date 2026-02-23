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

    case 2: // Docente
        Console.Write("Hora (0-23): ");
        int hora2 = int.Parse(Console.ReadLine());
        if (hora2 < 0 || hora2 > 23)
        {
            Console.WriteLine("Hora no valida");
            break;
        }

        Console.Write("Carnet vigente (S/N): ");
        char carnet2 = char.Parse(Console.ReadLine().ToUpper());
        if (carnet2 != 'S')
        {
            Console.WriteLine("Necesita carnet vigente");
            break;
        }

        Console.WriteLine("Acceso: Permitido - Nivel: Completo");
        break;

    case 3: // Tecnico IT
        Console.Write("Hora (0-23): ");
        int hora3 = int.Parse(Console.ReadLine());
        if (hora3 < 0 || hora3 > 23)
        {
            Console.WriteLine("Hora no valida");
            break;
        }

        Console.Write("Carnet vigente (S/N): ");
        char carnet3 = char.Parse(Console.ReadLine().ToUpper());
        if (carnet3 != 'S')
        {
            Console.WriteLine("Necesita carnet vigente");
            break;
        }

        if (hora3 >= 7 && hora3 <= 18)
        {
            Console.WriteLine("Acceso: Permitido - Nivel: Tecnico");
        }
        else
        {
            Console.Write("Autorizacion escrita (S/N): ");
            char aut3 = char.Parse(Console.ReadLine().ToUpper());
            if (aut3 == 'S')
            {
                Console.WriteLine("Acceso: Permitido - Nivel: Tecnico fuera de horario");
            }
            else
            {
                Console.WriteLine("Necesita autorizacion para fuera de horario");
            }
        }
        break;

    case 4: // Visitante
        Console.Write("Autorizacion escrita (S/N): ");
        char aut4 = char.Parse(Console.ReadLine().ToUpper());
        if (aut4 != 'S')
        {
            Console.WriteLine("Necesita autorizacion escrita");
            break;
        }

        Console.Write("Esta acompañado (S/N): ");
        char acom4 = char.Parse(Console.ReadLine().ToUpper());
        if (acom4 != 'S')
        {
            Console.WriteLine("Necesita acompañamiento");
            break;
        }

        Console.Write("Trae USB (S/N): ");
        char usb4 = char.Parse(Console.ReadLine().ToUpper());
        if (usb4 == 'S')
        {
            Console.WriteLine("Visitante no puede ingresar con USB");
        }
        else
        {
            Console.WriteLine("Acceso: Permitido - Nivel: Visitante");
        }
        break;

    default:
        Console.WriteLine("Rol no valido");
        break;
}
