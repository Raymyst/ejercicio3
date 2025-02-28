using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    public class Persona
    {
        // Atributos privados de la clase
        private string nombre;
        private int edad;
        private string dni;

        // Métodos para obtener y establecer el nombre
        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        // Métodos para obtener y establecer la edad
        public int GetEdad()
        {
            return edad;
        }

        public void SetEdad(int edad)
        {
            if (edad >= 0)
            {
                this.edad = edad;
            }
            else
            {
                Console.WriteLine("La edad no puede ser negativa.");
            }
        }

        // Métodos para obtener y establecer el DNI
        public string GetDni()
        {
            return dni;
        }

        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        // Método para ingresar los datos
        public void IngresarDatos()
        {
            Console.Write("Ingresa el nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingresa la edad: ");
            if (int.TryParse(Console.ReadLine(), out int edadIngresada))
            {
                SetEdad(edadIngresada);
            }
            else
            {
                Console.WriteLine("Edad no válida. Se establecerá en 0.");
                SetEdad(0);
            }

            Console.Write("Ingresa el DNI: ");
            dni = Console.ReadLine();
        }

        // Método para modificar datos
        public void ModificarDatos()
        {
            Console.Write("\n¿Deseas modificar los datos? (si/no): ");// se le pregunta al usuario si quiere modificar algun dato
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta == "si")
            {
                Console.WriteLine("\n¿Qué dato deseas modificar?");
                Console.WriteLine("1. Nombre");
                Console.WriteLine("2. Edad");
                Console.WriteLine("3. DNI");
                Console.Write("Ingresa el número de la opción: ");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingresa el nuevo nombre: ");
                            SetNombre(Console.ReadLine());
                            break;
                        case 2:
                            Console.Write("Ingresa la nueva edad: ");
                            if (int.TryParse(Console.ReadLine(), out int nuevaEdad))
                            {
                                SetEdad(nuevaEdad);
                            }
                            else
                            {
                                Console.WriteLine("Edad no válida.");
                            }
                            break;
                        case 3:
                            Console.Write("Ingresa el nuevo DNI: ");
                            SetDni(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }
            }
            else if (respuesta == "no")
            {
                Console.WriteLine("No se modificarán los datos.");
            }
            else
            {
                Console.WriteLine("Respuesta no válida.");
            } 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();

            // Ingresar datos por teclado
            persona1.IngresarDatos();

            // Mostrar los datos ingresados
            Console.WriteLine("\nDatos de la persona:");
            Console.WriteLine("Nombre: " + persona1.GetNombre());
            Console.WriteLine("Edad: " + persona1.GetEdad());
            Console.WriteLine("DNI: " + persona1.GetDni());

            // Modificar datos
            persona1.ModificarDatos();

            // Mostrar los datos modificados
            Console.WriteLine("\nDatos de la persona después de la modificación:");
            Console.WriteLine("Nombre: " + persona1.GetNombre());
            Console.WriteLine("Edad: " + persona1.GetEdad());
            Console.WriteLine("DNI: " + persona1.GetDni());
        }
    }
}

