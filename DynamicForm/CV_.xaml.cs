using Xamarin.Forms;

namespace DynamicForm
{
    public partial class CVPage : ContentPage
    {
        public CVPage(
            string nombre, string apellidos, string fechaNacimiento, string nacionalidad,
            string aptitudes, string habilidades, string lenguajes,
            string perfil, string experienciaLaboral, string educacion)
        {
            InitializeComponent();

            labelNombre.Text = $"Nombre: {nombre}";
            labelApellidos.Text = $"Apellidos: {apellidos}";
            labelFechaNacimiento.Text = $"Fecha de Nacimiento: {fechaNacimiento}";
            labelNacionalidad.Text = $"Nacionalidad: {nacionalidad}";
            labelAptitudes.Text = $"Aptitudes: {aptitudes}";
            labelHabilidades.Text = $"Habilidades: {habilidades}";
            labelLenguajes.Text = $"Lenguajes de Programación: {lenguajes}";
            labelPerfil.Text = $"Perfil: {perfil}";
            labelExperienciaLaboral.Text = $"Experiencia Laboral: {experienciaLaboral}";
            labelEducacion.Text = $"Educación: {educacion}";
        }
    }
}