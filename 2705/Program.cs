    namespace ProyectoEnClase27_05
    {
        class Program
        {
            static void Main(string[] args)
            {
                string databasePath = @"C:\Users\Eduardo\Documents\Tareas tercer semestre\Progra 1\Nueva carpeta\2705\2705\bin\Debug\net7.0\database.sqlite";
                GestorDeEmpleados gestorDeEmpleados = new GestorDeEmpleados(databasePath);
                gestorDeEmpleados.CrearTabla();




                //agregando empelados a la base de datos 

                Empleado nuevoEmpleado1 = new Empleado(1, "Eduardo", "Garcia", 19, "Analista");
                gestorDeEmpleados.AgregarEmpleado(nuevoEmpleado1);

                Empleado nuevoEmpleado2 = new Empleado(2, "Hector", "Palma", 25, "Gerente");
                gestorDeEmpleados.AgregarEmpleado(nuevoEmpleado2);

                Empleado nuevoEmpleado3 = new Empleado(3, "Leonardo", "Zepeda", 20, "Programador");
                gestorDeEmpleados.AgregarEmpleado(nuevoEmpleado3);

                Empleado nuevoEmpleado4 = new Empleado(4, "Maria", "Mendez", 28, "Secretaria");
                gestorDeEmpleados.AgregarEmpleado(nuevoEmpleado4);

                Empleado nuevoEmpleado5 = new Empleado(5, "Jose", "Perez", 44, "Gerente");
                gestorDeEmpleados.AgregarEmpleado(nuevoEmpleado5);

                Empleado nuevoEmpleado6 = new Empleado(6, "Rodrigo", "Maldodnado", 52, "Teniente");
                gestorDeEmpleados.AgregarEmpleado(nuevoEmpleado6);

                // Obtener la lista de empleados
                List<Empleado> empleados = gestorDeEmpleados.ObtenerEmpleados();

                // Mostrar el nombre, cargo y edad de cada empleado
                empleados.ForEach(e => Console.WriteLine($"Nombre: {e.Nombre}, Cargo: {e.Cargo}, Edad: {e.Edad}"));

                // Pausa para ver los resultados antes de que finalice el programa
                Console.WriteLine("Presiona cualquier tecla para salir...");
                Console.ReadKey();


            }
        }
    }