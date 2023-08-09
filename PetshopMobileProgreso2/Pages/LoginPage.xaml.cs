namespace PetshopMobileProgreso2.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        // Validar los datos de inicio de sesi�n
        var user = DataRepository.GetUsers().FirstOrDefault(u => u.Username == username && u.Password == password);
        if (user != null)
        {
            // Inicio de sesi�n exitoso, redirigir al usuario a la siguiente p�gina
            // Puedes reemplazar "HomePage" con el nombre de tu p�gina principal
            Navigation.PushAsync(new ProductosPage());
        }
        else
        {
            // Mostrar un mensaje de error en caso de inicio de sesi�n fallido
            DisplayAlert("Error", "Nombre de usuario o contrase�a incorrectos", "OK");
        }
    }
}