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

        // Validar los datos de inicio de sesión
        var user = DataRepository.GetUsers().FirstOrDefault(u => u.Username == username && u.Password == password);
        if (user != null)
        {
            // Inicio de sesión exitoso, redirigir al usuario a la siguiente página
            // Puedes reemplazar "HomePage" con el nombre de tu página principal
            Navigation.PushAsync(new ProductosPage());
        }
        else
        {
            // Mostrar un mensaje de error en caso de inicio de sesión fallido
            DisplayAlert("Error", "Nombre de usuario o contraseña incorrectos", "OK");
        }
    }
}