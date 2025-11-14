using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class ResumoCadastro : ContentPage
{
	public ResumoCadastro(Evento evento)
	{
		InitializeComponent();
		BindingContext = evento;
	}
}