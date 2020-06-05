using Kalum2020v1.Models;
using Kalum2020v1.ModelsViews;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace Kalum2020v1.Views
{
    public partial class LoginView :MetroWindow
    {
        private LoginModelView _ModelView;
        public LoginView(MainViewModel mainViewModel)
        {
            InitializeComponent();
            _ModelView = new LoginModelView(mainViewModel);
            this.DataContext = _ModelView;
        }
    }
}