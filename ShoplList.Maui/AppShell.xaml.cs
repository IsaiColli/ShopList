using ShoplList.Maui.Views;

namespace ShoplList.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Registrar las rutas de navegacion de las paginas de la aplicacion
            Routing.RegisterRoute(nameof(EditShopListItemPage), typeof(EditShopListItemPage));
        }
    }
}
