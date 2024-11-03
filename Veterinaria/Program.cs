using VeterinariaPichichus.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Actividad_Duenio actividad_Duenio = new Actividad_Duenio();

        main();
        void main()
        {
            menu();
        }
        void menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Agregar Dueño");
            Console.WriteLine("2 - Buscar Dueño");
            Console.WriteLine("3 - Listar Dueño");

            Console.Write("Ingrese:");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    GrabarDuenio();
                    break;
                case 2:
                    BuscarDuenioPorDNI();
                    break;
                case 3:
                    ObtengoTodosLosDuenios();
                    break;
            }

            void GrabarDuenio()
            {
                Duenio duenio = new Duenio();
                Console.WriteLine("Ingrese el DNI");
                duenio.DNI = Console.ReadLine();
                Console.WriteLine("Ingrese el Nombre");
                duenio.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el Apellido");
                duenio.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese el mail");
                duenio.Email =Console.ReadLine();
                Console.WriteLine("Ingrese el telefono");
                duenio.Telefono = int.Parse(Console.ReadLine());

                bool estado = actividad_Duenio.GrabarDuenio(duenio);
                if (estado)
                {
                    Console.WriteLine("El dueño fué agregado");
                }
                else
                {
                    Console.WriteLine("El dueño no fué agregado");
                }

                Console.ReadKey();
                menu();
            }

            void BuscarDuenioPorDNI()
            {
                Console.Clear();
                Console.WriteLine("Ingrese el DNI");
                String DNI = Console.ReadLine();
                Duenio? duenioBuscado = actividad_Duenio.BuscarDuenioPorDNI(DNI);

                Console.WriteLine("DNI: " + duenioBuscado.DNI);
                Console.WriteLine("NOMBRE: " + duenioBuscado.Nombre);
                Console.WriteLine("APELLIDO: " + duenioBuscado.Apellido);

                Console.ReadKey();
                menu();
            }

            void ObtengoTodosLosDuenios()
            {
                Console.Clear();
                List<Duenio> duenios= actividad_Duenio.ObtengoTodosLosDuenios();
                foreach (Duenio d in duenios)
                {
                    Console.WriteLine("DNI: " + d.DNI);
                    Console.WriteLine("NOMBRE: " + d.Nombre);
                    Console.WriteLine("APELLIDO: " + d.Apellido);
                    Console.WriteLine("---------------------------");
                }

                Console.ReadKey();
                menu();

            }
        }
    }
}