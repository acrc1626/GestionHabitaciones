namespace GestionHabitaciones.Model
{
    public class VinoAltaCalidad : HabitacionDecorator
    {
        public VinoAltaCalidad(Habitacion habitacion) : base(habitacion) { }

        public override string Descripcion => _habitacion.Descripcion + ", Vino de Alta Calidad";
        public override double Precio => _habitacion.Precio + 400.0;

    }

}
