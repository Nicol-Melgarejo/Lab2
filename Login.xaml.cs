using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab02
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Menu menu = new Menu();
        //    menu.ShowDialog();
        //}

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username = "Nicol";
            string password = "1234";

            if (usernameTextBox.Text == username && passwordBox.Password == password)
            {
                
                MessageBox.Show("Inicio de sesión exitoso.", "¡Bienvenido!", MessageBoxButton.OK, MessageBoxImage.Information);



                Menu menu = new Menu();
                menu.ShowDialog();
            }
            else
            {
                
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Por favor, inténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
        