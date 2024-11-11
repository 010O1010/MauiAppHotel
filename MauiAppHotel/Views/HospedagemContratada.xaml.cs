namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }

    // Adicionado um evento para o botão que leva à Página Sobre
    private void BtnSobre(object sender, EventArgs e)
    {
            Navigation.PushAsync(new Sobre());
    }
}