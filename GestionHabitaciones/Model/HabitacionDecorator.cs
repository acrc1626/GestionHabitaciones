namespace GestionHabitaciones.Model
{
    public abstract class HabitacionDecorator : Habitacion
    {
        protected Habitacion _habitacion;
        public HabitacionDecorator(Habitacion habitacion)
        {
            _habitacion = habitacion;
        }

        public override string Descripcion => _habitacion.Descripcion;
        public override double Precio => _habitacion.Precio;
    }

}
