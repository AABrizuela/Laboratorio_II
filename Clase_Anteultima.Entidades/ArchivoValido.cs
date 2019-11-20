using Clase_Anteultima.Entidades;

namespace Clase_Anteultima.Entidades
{
    ///Definicion del delegado

    ///Al delegado no le importa si el metodo es estatico o no, o si esta declarado en otra clase
    ///Le agrego la firma del metodo que necesito que almacene, puede devolver cualquier tipo de retorno
    
    ///[modificador] delegate [retorno] nombreMetodo();

    public delegate void limiteSueldoDelegado(double sueldo, Empleado empleado);

    public delegate void limiteSueldoMejoradoDelegado(Empleado emp, EmpleadoEventArgs eventArgs);

    public enum TipoManejador
    {
        limiteSueldo,
        limiteSueldoMejorado,
        Todos
    }
}

