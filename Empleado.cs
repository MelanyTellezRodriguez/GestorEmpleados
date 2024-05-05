using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEmpleados
{
    internal class Empleado
    {
        //Variables miembro de la clase Empleado
        private string Nombre;
        private int NumeroEmpleado;
        private decimal Salario;
        private bool Activo; //Estado del empleado(activo o inactivo)

        public Empleado(string nombre, int numeroEmpleado, decimal salario, bool activo = true)
        {
            this.Nombre = nombre;
            this.NumeroEmpleado = numeroEmpleado;
            this.Salario = salario;
            this.Activo = activo;


        }

        public Empleado()
        {
        }

        //Metodo para mostrar los detalles del empleado
        public void MostrarDetalles()
        {
            string estado = (Activo) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {Nombre}, Numero de empleado: {NumeroEmpleado}, Salario: {Salario:c}, Estado: {estado}");

        }

        //Metodo para obtener el numero de empleados
        public int ObtenerNumeroEmpleado()
        {
            return this.NumeroEmpleado;
        }

        //Metodo para cambiar el estado del empleado
        public void CambiarEstado(int nuevoEstado)
        {
            if (nuevoEstado == 1)
            {
                Activo = true;//Activar Empleado
                Console.WriteLine("Empleado activo.");

            }
            else if (nuevoEstado == 0)
            {
                Activo = false;//Desactivar Empleado
                Console.WriteLine("Empleado desactivado.");
            }
            else
            {
                Console.WriteLine("Estado no valido.");
            }
        }

        //Metodo para aumentarle el salario al empleado considerando su numero de empleado
        public void AumentarSalario()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("***El porcentaje que se le aumentara al empleado sera del 10%***");
            Console.WriteLine();
            Console.WriteLine("Ingrese el numero de empleado:");
            int NumeroEmpleado = Convert.ToInt32(Console.ReadLine());

            if(NumeroEmpleado == 101)
            {
                double aumento = 30000 * 0.1;
                double resultadoFinal = 30000 + aumento;
                Console.WriteLine($"El salario del empleado luego del aumento es de {resultadoFinal}");
            }
            else if(NumeroEmpleado == 102)
            {
                double aumento = 35000 * 0.1;
                double resultadoFinal = 35000 + aumento;
                Console.WriteLine($"El salario del empleado luego del aumento es de {resultadoFinal}");

            }
            else if(NumeroEmpleado == 103)
            {
                double aumento = 32000 * 0.1;
                double resultadoFinal = 32000 + aumento;
                Console.WriteLine($"El salario del empleado luego del aumento es de {resultadoFinal}");
            }
            else
            {
                Console.WriteLine("¡ERROR! el numero de empleado que ha ingresado no se encuentra en el sistema");
            }
        }
    }
}
