using System;
using Xamarin.Forms;

namespace DynamicForm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnEnviarClicked(object sender, EventArgs e)
        {
            var nombre = entryNombre.Text;
            var apellidos = entryApellidos.Text;
            var fechaNacimiento = datePickerFechaNacimiento.Date.ToString("d");
            var nacionalidad = pickerNacionalidad.SelectedItem?.ToString();

            var aptitudes = new System.Text.StringBuilder();
            foreach (CheckBox aptitud in stackAptitudes.Children)
            {
                if (aptitud.IsChecked)
                    aptitudes.AppendLine(aptitud.Content.ToString());
            }

            var habilidades = new System.Text.StringBuilder();
            foreach (CheckBox habilidad in stackHabilidades.Children)
            {
                if (habilidad.IsChecked)
                    habilidades.AppendLine(habilidad.Content.ToString());
            }

            var lenguajes = new System.Text.StringBuilder();
            foreach (CheckBox lenguaje in stackLenguajes.Children)
            {
                if (lenguaje.IsChecked)
                    lenguajes.AppendLine(lenguaje.Content.ToString());
            }

            var perfil = editorPerfil.Text;
            var experienciaLaboral = editorExperienciaLaboral.Text;
            var educacion = editorEducacion.Text;

            await Navigation.PushAsync(new CVPage(
                nombre, apellidos, fechaNacimiento, nacionalidad,
                aptitudes.ToString(), habilidades.ToString(), lenguajes.ToString(),
                perfil, experienciaLaboral, educacion));
        }
    }
}
