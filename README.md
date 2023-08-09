# Petshop Mobile
## ES NECESARIO LA EJECUCION DE LA API LOCAL PARA EL CORRECTO FUNCIONAMIENTO DEL CÓDIGO
Esta aplicación móvil está desarrollada utilizando .NET MAUI, un framework de interfaz de usuario multiplataforma de Microsoft. La aplicación se centra en la gestión de productos y clientes para una tienda de mascotas.
## Modelos
La aplicación define dos clases de modelos principales: Cliente y Producto. Estas clases se utilizan para representar la información de los clientes y productos respectivamente.
## Servicios API
La lógica de comunicación con la API se encuentra en los servicios definidos en el espacio de nombres PetshopMobileProgreso2.Services. Los servicios IServicioApiCli e IServicioApiPro definen las operaciones disponibles para gestionar clientes y productos a través de una API remota.
## Interfaz de Usuario
La interfaz de usuario se compone de múltiples páginas que se encuentran en el espacio de nombres PetshopMobileProgreso2.Pages. La página principal es MainPage, que muestra una lista de productos y clientes. La navegación entre las páginas se gestiona a través de la clase AppShell.
## Configuración y Ejecución
La clase App en el archivo App.xaml.cs es la clase de inicio de la aplicación. Define la página de inicio, que en este caso es LoginPage.

La clase AppShell en el archivo AppShell.xaml.cs define la estructura de la aplicación utilizando el componente Shell. Se muestra la página MainPage en el contenido principal.

El archivo MauiProgram.cs se utiliza para crear y configurar la instancia de la aplicación MAUI.
## Configuración del Entorno
Para ejecutar esta aplicación, asegúrese de tener instalado .NET MAUI en su entorno de desarrollo. Puede encontrar información sobre cómo configurar y ejecutar una aplicación .NET MAUI en la documentación oficial.
## Notas
Este README proporciona una descripción general de la estructura y los componentes clave de la aplicación. Asegúrese de revisar el código fuente para obtener más detalles sobre la implementación y el funcionamiento de la aplicación.
