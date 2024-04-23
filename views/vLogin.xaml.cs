using Microsoft.Maui.Controls;

namespace portegaExamenP1.views;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}

    private async void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string password = txtPassword.Text;
        if (validateCredentials(usuario, password))
        {
            await DisplayAlert("Bienvenido", usuario, "continuar");
            await Navigation.PushAsync(new vRegistro(usuario));
        }
        else
        {
            await DisplayAlert("Error", "Credenciales invalidas", "cerrar");
        }
        
    }

    private bool validateCredentials(string user, string password)
    {
        List<string> usuarios = new List<string> { "estudiante2024", "examen1", "NombreEstudiante" };
        List<string> passwords = new List<string> { "uisrael2024", "parcial1", "2024" };
        if (usuarios.Contains(user))
        {
            int userIndex = usuarios.IndexOf(user);
            if (passwords[userIndex] == password)
            {
                return true;
            }
        }
        return false;
    }

    private void btnAcercaDe_Clicked(object sender, EventArgs e)
    {

    }
}