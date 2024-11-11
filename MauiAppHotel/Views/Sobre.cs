namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
    public Sobre()
    {
        InitializeComponent();
    }

    // Botão que retorna
    private void BtnVoltar(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}