namespace GestionHabitaciones.Model
{
    public class ChocolateGourmet : HabitacionDecorator
    {
        public ChocolateGourmet(Habitacion habitacion) : base(habitacion) { }

        public override string Descripcion => _habitacion.Descripcion + ", Chocolate Gourmet";
        public override double Precio => _habitacion.Precio + 300.0; 
    }

}
