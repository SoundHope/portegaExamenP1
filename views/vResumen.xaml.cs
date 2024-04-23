namespace portegaExamenP1.views;

public partial class vResumen : ContentPage
{
	public vResumen(string username, string name, string lastName, string date, string pais, string ciudad, string initialAmount, string cuota, string totalAmount )
	{
		InitializeComponent();
        lblUsuario.Text = "Conectado como: " + username;
        nombre.Text = name;
        apellido.Text = lastName;
        edad.Text = date;
        country.Text = pais;
        lblciudad.Text = ciudad;
        lblmontoInicial.Text = initialAmount;
        lblpagoMensual.Text = cuota;
        lblpagoTotal.Text = totalAmount;
    }

    private void btnSalir_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vLogin());
    }
}