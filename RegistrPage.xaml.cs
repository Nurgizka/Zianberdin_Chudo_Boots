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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zianberdin_Chudo_Boots
{
    /// <summary>
    /// Логика взаимодействия для RegistrPage.xaml
    /// </summary>
    public partial class RegistrPage : Page
    {
        public RegistrPage()
        {
            InitializeComponent();
        }
        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            var user = Zianberdin_Chudo_ObuvEntities.GetContext().Users
                .FirstOrDefault(u => u.UserLogin == LoginBox.Text.Trim());

            if (user == null)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }

            Manager.CurrentUser = user;
            Manager.MainFrame.Navigate(new ProductPage());
        }

        private void GuestBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.CurrentUser = null;
            Manager.MainFrame.Navigate(new ProductPage());
        }
    }
}
