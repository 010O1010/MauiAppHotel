namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
    public Sobre()
    {
        InitializeComponent();
    }

    // Bot�o que retorna
    private void BtnVoltar(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}