namespace portegaExamenP1.views;

public partial class vRegistro : ContentPage
{
    string usuario;
    public vRegistro(string usuario)
    {
        InitializeComponent();
        lblUsuario.Text = "Conectado como: " + usuario;
        this.usuario = usuario;
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        txtQuotaAmount.Text = "";
        int initialAmount = int.Parse(txtInitialAmount.Text);
        txtQuotaAmount.Text = calcularCuota(initialAmount).ToString();
    }

    private double calcularCuota(int amount)
    {
        int total = 3000;
        int resto = total - amount;
        int partialRest = resto / 3;
        double cuota = Convert.ToDouble(partialRest + (total * 0.05));
        return cuota;
    }


    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        int initialAmount = int.Parse(txtInitialAmount.Text);
        double cuota = calcularCuota(initialAmount);
        double totalCuota = cuota * 3;
        String date = dpDate.Date.ToString();
        String pais = pkCountry.Items[pkCountry.SelectedIndex].ToString();
        String ciudad = pkCity.Items[pkCity.SelectedIndex].ToString();
        double totalAmount = initialAmount + totalCuota;
        Navigation.PushAsync(new vResumen(this.usuario, txtName.Text, txtLastName.Text, date, pais, ciudad, initialAmount.ToString(), cuota.ToString(), totalAmount.ToString()));
    }
}