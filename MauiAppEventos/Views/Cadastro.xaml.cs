using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class Cadastro : ContentPage
{
    App PropriedadesApp;
    public Cadastro()
    {
        InitializeComponent();

    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        var evento = new Evento
        {
            Nome = nome.Text,
            Local = local.Text,
            NumeroParticipantes = (int)stp_participantes.Value,
            CustoPorParticipante = double.Parse(custo.Text),
            DataInicio = dtpk_inicio.Date == null ? DateTime.Today: dtpk_inicio.Date,
            DataTermino = dtpk_termino.Date == null ? DateTime.Today: dtpk_termino.Date,
        };

        // Navegar para a página de resumo passando o objeto
        await Navigation.PushAsync(new ResumoCadastro(evento));
    

    }
}
