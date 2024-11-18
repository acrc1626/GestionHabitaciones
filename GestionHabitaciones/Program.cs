// See https://aka.ms/new-console-template for more information


using GestionHabitaciones.Model;

public class Program
{
    public static void Main()
    {

        Habitacion habitacion = new HabitacionBasica();
        Console.WriteLine($"{habitacion.Descripcion} - Precio: ${habitacion.Precio}");

        habitacion = new FloresFrescas(habitacion);
        Console.WriteLine($"{habitacion.Descripcion} - Precio: ${habitacion.Precio}");

     
        habitacion = new ChocolateGourmet(habitacion);
        Console.WriteLine($"{habitacion.Descripcion} - Precio: ${habitacion.Precio}");

        habitacion = new VinoAltaCalidad(habitacion);
        Console.WriteLine($"{habitacion.Descripcion} - Precio: ${habitacion.Precio}");
    }

}
