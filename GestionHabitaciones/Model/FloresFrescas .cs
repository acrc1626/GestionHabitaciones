namespace GestionHabitaciones.Model
{
    public class FloresFrescas: HabitacionDecorator
    {
        public FloresFrescas(Habitacion habitacion) : base(habitacion) { }

        public override string Descripcion => _habitacion.Descripcion + ", Flores Frescas";
        public override double Precio => _habitacion.Precio + 200.0; // adicional
    }
}
