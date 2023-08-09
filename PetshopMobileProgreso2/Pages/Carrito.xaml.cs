using System.Collections.ObjectModel;
using PetshopMobileProgreso2.Models;
using PetshopMobileProgreso2.Utils;

namespace PetshopMobileProgreso2.Pages;

public partial class Carrito : ContentPage
{
	public Carrito()
	{
		InitializeComponent();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        ListaGlobalProductos.ItemsSource = new ObservableCollection<Producto>(ListaGlobal.listaGlobalProductos);
    }

    public double Suma()
    {
        ListaGlobal.listaGlobalProductos = new List<Producto>();

        double sum = 0;
        foreach (Producto product in ListaGlobal.listaGlobalProductos)
        {
            sum = sum + product.Precio;
        }
        Console.WriteLine(sum.ToString());
        return sum;      
    }

    private void Redirect_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FacturaPage());
    }
}